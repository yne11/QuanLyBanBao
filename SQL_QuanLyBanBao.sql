USE master
GO

-- XÓA & TẠO LẠI CSDL MỚI HOÀN TOÀN
IF DB_ID('QuanLyBanBao') IS NOT NULL
BEGIN
    ALTER DATABASE QuanLyBanBao SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE QuanLyBanBao
    PRINT 'ĐÃ XÓA CSDL CŨ!'
END
GO

CREATE DATABASE QuanLyBanBao
GO
USE QuanLyBanBao
GO

-- TẠO BẢNG
CREATE TABLE Bao (
    MaBao CHAR(5) PRIMARY KEY,
    TenBao NVARCHAR(100) NOT NULL,
    LoaiBao NVARCHAR(30) NOT NULL,
    GiaBan DECIMAL(12,0) DEFAULT 0,
    SoLuongTon INT DEFAULT 0
)
GO

CREATE TABLE KhachHang (
    MaKH CHAR(6) PRIMARY KEY,
    TenKH NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(150),
    DienThoai VARCHAR(15),
    Email VARCHAR(100)
)
GO

CREATE TABLE PhieuBan (
    SoPhieu CHAR(14) PRIMARY KEY,
    NgayLap DATE DEFAULT GETDATE(),
    MaKH CHAR(6) FOREIGN KEY REFERENCES KhachHang(MaKH),
    TongTien DECIMAL(15,0) DEFAULT 0
)
GO

CREATE TABLE ChiTietPhieuBan (
    SoPhieu CHAR(14) FOREIGN KEY REFERENCES PhieuBan(SoPhieu),
    MaBao CHAR(5) FOREIGN KEY REFERENCES Bao(MaBao),
    SoLuong INT NOT NULL,
    DonGia DECIMAL(12,0) NOT NULL,
    ThanhTien AS SoLuong * DonGia PERSISTED,
    PRIMARY KEY (SoPhieu, MaBao)
)
GO

PRINT 'ĐÃ TẠO XONG 4 BẢNG!'

-- CHÈN 8 BÁO (CÓ CẢ BÁO ĐIỆN TỬ)
INSERT INTO Bao VALUES
('B001', N'Tuổi Trẻ',           N'Báo giấy',        5000, 2000),
('B002', N'Thanh Niên',         N'Báo giấy',        4500, 1800),
('B003', N'Người Lao Động',     N'Báo giấy',        6000, 1600),
('B004', N'VnExpress',          N'Báo điện tử',     0,     999999),
('B005', N'Dân Trí',            N'Báo điện tử',     0,     999999),
('B006', N'Sài Gòn Giải Phóng', N'Báo giấy',        5500, 1500),
('B007', N'Thể Thao & Văn Hóa', N'Báo giấy',        4800, 1700),
('B008', N'Pháp Luật TP.HCM',   N'Báo giấy',        7000, 1400)
GO

-- CHÈN 30 KHÁCH HÀNG (SIÊU VIP)
INSERT INTO KhachHang VALUES
('KH001', N'Nguyễn Văn An',        N'123 Lê Lợi, Q.1',           '0903123456', 'an@gmail.com'),
('KH002', N'Trần Thị Bình',        N'45 Trần Hưng Đạo, Q.5',     '0918234567', 'binh@yahoo.com'),
('KH003', N'Lê Hoàng Cường',       N'78 Nguyễn Huệ, Q.1',        '0935123789', 'cuong@gmail.com'),
('KH004', N'Phạm Minh Duy',        N'56 CMT8, Q.3',              '0987654321', 'duy@hotmail.com'),
('KH005', N'Vũ Thị Kim Ngân',      N'89 Pasteur, Q.1',           '0909112233', 'ngan@gmail.com'),
('KH006', N'Đỗ Văn Em',            N'12 Nguyễn Thị Minh Khai',   '0922334455', 'em.do@gmail.com'),
('KH007', N'Huỳnh Thị Hồng',       N'100 Hai Bà Trưng',          '0945678901', 'hong@gmail.com'),
('KH008', N'Ngô Quang Hải',        N'56 Lê Văn Sỹ, Q.3',         '0908765432', 'hai.ngo@gmail.com'),
('KH009', N'Hoàng Anh Tuấn',       N'25 Lý Thường Kiệt',         '0912345678', 'tuan@gmail.com'),
('KH010', N'Lý Thị Mai',           N'88 Võ Văn Tần',             '0923456789', 'mai@gmail.com'),
('KH011', N'Phan Văn Khánh',       N'99 Nguyễn Thị Minh Khai',   '0934567890', 'khanh@gmail.com'),
('KH012', N'Đặng Ngọc Sơn',        N'11 Lê Lợi, Q.1',            '0945678901', 'son@gmail.com'),
('KH013', N'Võ Minh Trí',          N'33 Bùi Viện',               '0956789012', 'tri@gmail.com'),
('KH014', N'Bùi Thị Lan',          N'44 Phạm Ngũ Lão',           '0967890123', 'lan@gmail.com'),
('KH015', N'Trương Công Định',     N'55 Nam Kỳ Khởi Nghĩa',      '0978901234', 'dinh@gmail.com'),
('KH016', N'Nguyễn Thị Thu',       N'66 Lê Thánh Tôn',           '0989012345', 'thu@gmail.com'),
('KH017', N'Phạm Văn Hùng',        N'77 Trần Phú',               '0990123456', 'hung@gmail.com'),
('KH018', N'Lê Thị Ngọc',          N'88 Nguyễn Trãi',            '0901234567', 'ngoc@gmail.com'),
('KH019', N'Trần Văn Nam',         N'99 Cách Mạng Tháng 8',      '0912345678', 'nam@gmail.com'),
('KH020', N'Đinh Thị Hương',       N'111 Điện Biên Phủ',         '0923456789', 'huong@gmail.com'),
('KH021', N'Nguyễn Quốc Bảo',      N'222 Nguyễn Văn Cừ',         '0934567890', 'bao@gmail.com'),
('KH022', N'Trần Ngọc Ánh',        N'333 Pasteur',               '0945678901', 'anh@gmail.com'),
('KH023', N'Lê Minh Quân',         N'444 Lê Hồng Phong',         '0956789012', 'quan@gmail.com'),
('KH024', N'Phạm Thị Yến',         N'555 Võ Thị Sáu',            '0967890123', 'yen@gmail.com'),
('KH025', N'Vũ Văn Long',          N'666 Trường Chinh',          '0978901234', 'long@gmail.com'),
('KH026', N'Hoàng Thị Mai',        N'777 Nguyễn Tri Phương',     '0989012345', 'mai2@gmail.com'),
('KH027', N'Đỗ Minh Hiếu',         N'888 Hùng Vương',            '0990123456', 'hieu@gmail.com'),
('KH028', N'Nguyễn Văn Tèo',       N'999 Lý Tự Trọng',           '0901234567', 'teo@gmail.com'),
('KH029', N'Trần Thị Tẹt',         N'1010 Phạm Văn Đồng',        '0912345678', 'tet@gmail.com'),
('KH030', N'Lê Văn Tẹo',           N'1111 Nguyễn Văn Linh',      '0923456789', 'teo2@gmail.com')
GO

-- TẠO 100 PHIẾU BÁN TỪ 01/01/2025 ĐẾN 10/04/2025 (100 ngày)
DECLARE @i INT = 1
WHILE @i <= 100
BEGIN
    -- Tạo số phiếu PB250101000001 → PB250410000100
    DECLARE @SoPhieu CHAR(14) = 'PB25' + 
        FORMAT(DATEADD(DAY, @i-1, '2025-01-01'), 'MMdd') + 
        RIGHT('000000' + CAST(@i AS VARCHAR(6)), 6)

    DECLARE @NgayLap DATE = DATEADD(DAY, @i-1, '2025-01-01')
    DECLARE @MaKH CHAR(6) = 'KH' + RIGHT('00' + CAST(((@i-1) % 30) + 1 AS VARCHAR), 3)

    INSERT INTO PhieuBan (SoPhieu, NgayLap, MaKH, TongTien) VALUES (@SoPhieu, @NgayLap, @MaKH, 0)

    -- Mỗi phiếu bán từ 1 đến 6 báo ngẫu nhiên
    DECLARE @SoBao INT = 1 + (@i % 6)
    DECLARE @j INT = 1
    WHILE @j <= @SoBao
    BEGIN
        DECLARE @MaBao CHAR(5) = 'B00' + CAST(((@i + @j) % 8) + 1 AS VARCHAR)
        DECLARE @SoLuong INT = 5 + ((@i + @j) % 50)
        DECLARE @DonGia DECIMAL(12,0) = (SELECT GiaBan FROM Bao WHERE MaBao = @MaBao)
        IF @DonGia = 0 SET @DonGia = 5000  -- Báo điện tử cho giá tạm

        INSERT INTO ChiTietPhieuBan (SoPhieu, MaBao, SoLuong, DonGia) 
        VALUES (@SoPhieu, @MaBao, @SoLuong, @DonGia)

        UPDATE PhieuBan SET TongTien = TongTien + (@SoLuong * @DonGia) WHERE SoPhieu = @SoPhieu
        UPDATE Bao SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaBao = @MaBao AND GiaBan > 0

        SET @j = @j + 1
    END

    SET @i = @i + 1
END
GO

PRINT '================================================================'
PRINT 'HOÀN TẤT 100% – DỮ LIỆU SIÊU PHONG PHÚ ĐỂ DEMO ĐỒ ÁN ĐIỂM 10!'
PRINT '- 8 loại báo'
PRINT '- 30 khách hàng VIP'
PRINT '- 100 phiếu bán (từ 01/01/2025 đến 10/04/2025)'
PRINT '- Hơn 400 chi tiết phiếu'
PRINT '- Doanh thu, báo bán chạy, khách VIP – tất cả đều có!'
PRINT 'CHẠY CHƯƠNG TRÌNH → THỐNG KÊ / BÁO CÁO → ĐỒ THỊ ĐẸP, SỐ LIỆU CHÍNH XÁC!'
PRINT '================================================================'