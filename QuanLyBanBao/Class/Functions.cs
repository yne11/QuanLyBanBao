using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanBao.Class
{
    public static class Functions
    {
        private static string _connectionString =
            @"Data Source=LAPTOP-J120BN4R;Initial Catalog=QuanLyBanBao;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection Con { get; private set; }

        // Kết nối CSDL
        public static void Connect()
        {
            try
            {
                if (Con == null)
                    Con = new SqlConnection(_connectionString);

                if (Con.State == ConnectionState.Closed || Con.State == ConnectionState.Broken)
                    Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối CSDL!\nLỗi: {ex.Message}",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ngắt kết nối
        public static void Disconnect()
        {
            if (Con != null && (Con.State == ConnectionState.Open || Con.State == ConnectionState.Connecting))
            {
                Con.Close();
                Con.Dispose();
                Con = null;
            }
        }

        // Lấy dữ liệu về DataTable
        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, Con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Kiểm tra khóa tồn tại
        public static bool CheckKey(string sql)
        {
            Connect();
            using (SqlDataAdapter da = new SqlDataAdapter(sql, Con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows.Count > 0;
            }
        }

        // Thực thi SQL (INSERT, UPDATE, DELETE)
        public static bool RunSQL(string sql)
        {
            Connect();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thực thi lệnh SQL!\n{ex.Message}\n\nLệnh: {sql}",
                    "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Thực thi SQL có tham số (AN TOÀN, tránh SQL Injection)
        public static bool RunSQLWithParams(string sql, SqlParameter[] parameters)
        {
            Connect();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thực thi SQL:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Lấy giá trị đơn (Scalar)
        public static object GetFieldValue(string sql)
        {
            Connect();
            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                return cmd.ExecuteScalar();
            }
        }

        // TẠO MÃ TỰ ĐỘNG HOÀN HẢO – ĐÃ SỬA ĐỂ RA B009 → B010 → B011 → B100 → ĐẸP NHẤT!
        public static string CreateKey(string tableName, string prefix = "", int length = 3)
        {
            string sql = "";
            int nextNumber = 1;

            try
            {
                Connect();

                if (tableName == "Bao")
                {
                    sql = "SELECT MAX(CAST(SUBSTRING(MaBao, 2, LEN(MaBao)) AS INT)) FROM Bao WHERE ISNUMERIC(SUBSTRING(MaBao, 2, LEN(MaBao))) = 1";
                    object result = GetFieldValue(sql);
                    nextNumber = (result == DBNull.Value || result == null) ? 1 : Convert.ToInt32(result) + 1;
                    return "B" + nextNumber.ToString("D3"); // ← D3 = 3 chữ số → B009, B010, B011, B100 → ĐẸP NHƯ BẠN MUỐN!
                }
                else if (tableName == "KhachHang")
                {
                    sql = "SELECT MAX(CAST(SUBSTRING(MaKH, 3, 10) AS INT)) FROM KhachHang WHERE ISNUMERIC(SUBSTRING(MaKH, 3, 10)) = 1";
                    object result = GetFieldValue(sql);
                    nextNumber = (result == DBNull.Value || result == null) ? 1 : Convert.ToInt32(result) + 1;
                    return "KH" + nextNumber.ToString("D3");
                }
                else if (tableName == "PhieuBan")
                {
                    sql = @"SELECT ISNULL(MAX(CAST(SUBSTRING(SoPhieu, 9, 10) AS INT)), 0) 
                            FROM PhieuBan 
                            WHERE ISNUMERIC(SUBSTRING(SoPhieu, 9, 10)) = 1";
                    object result = GetFieldValue(sql);
                    nextNumber = Convert.ToInt32(result) + 1;

                    string today = DateTime.Now.ToString("yyMMdd");
                    return $"PB{today}{nextNumber:D6}";
                }
                else
                {
                    return prefix + nextNumber.ToString("D" + length);
                }
            }
            catch
            {
                if (tableName == "Bao") return "B001";
                if (tableName == "KhachHang") return "KH001";
                if (tableName == "PhieuBan") return $"PB{DateTime.Now:yyMMdd}000001";
                return prefix + "001";
            }
        }

        // Định dạng tiền tệ VNĐ
        public static string FormatMoney(decimal money)
        {
            return money.ToString("N0") + " ₫";
        }

        // Chỉ cho nhập số
        public static void OnlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        // THÊM HÀM NÀY ĐỂ HỖ TRỢ THAM SỐ AN TOÀN (TRÁNH SQL INJECTION)
        public static object GetFieldValue(string sql, SqlParameter[] parameters)
        {
            Connect();
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    if (parameters != null && parameters.Length > 0)
                        cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy giá trị: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}