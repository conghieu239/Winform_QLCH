CREATE DATABASE QLCH2
GO
USE QLCH2
GO
-- Bảng Đăng Nhập
CREATE TABLE DangNhap (
  TenDangNhap NVARCHAR(50) PRIMARY KEY ,
  MatKhau NVARCHAR(50) NOT NULL
  )

  DROP TABLE DangNhap
-- Bảng Nhân Viên
CREATE TABLE Nhan_Vien (
  MaNhanVien INT PRIMARY KEY,
  HoTen NVARCHAR(100) NOT NULL,
  TenDangNhap NVARCHAR(50) NOT NULL,
  MatKhau NVARCHAR(50) NOT NULL,
  VaiTro NVARCHAR(50)
);

-- Bảng Hàng Hóa
CREATE TABLE Hang_Hoa (
  MaHangHoa INT PRIMARY KEY,
  TenHangHoa NVARCHAR(100) NOT NULL,
  DonGia DECIMAL(10,2) NOT NULL,
  SoLuongTonKho INT NOT NULL
);


-- Bảng Khách Hàng
CREATE TABLE Khach_Hang (
  MaKhachHang INT PRIMARY KEY,
  HoTen NVARCHAR(100) NOT NULL,
  Email NVARCHAR(100) NOT NULL,
  SoDienThoai NVARCHAR(20) NOT NULL
);

-- Bảng Hóa Đơn
CREATE TABLE Hoa_Don (
  MaHoaDon INT PRIMARY KEY,
  MaKhachHang INT NOT NULL,
  MaNhanVien INT NOT NULL,
  NgayTao DATETIME NOT NULL,
  IDMaGiamGia NVARCHAR (20) ,
  TongTien DECIMAL(10,2) NOT NULL
);

-- Bảng Chi Tiết Hóa Đơn
CREATE TABLE Chi_Tiet_Hoa_Don (
  MaChiTietHoaDon INT PRIMARY KEY,
  MaHoaDon INT NOT NULL,
  MaHangHoa INT NOT NULL,
  SoLuong INT NOT NULL,
);

-- Bảng Đặt Hàng
CREATE TABLE Dat_Hang (
  MaDatHang INT PRIMARY KEY,
  MaKhachHang INT NOT NULL,
  MaNhanVien INT NOT NULL,
  NgayDat DATETIME NOT NULL,
  TrangThai NVARCHAR(50) NOT NULL
);
-- Bảng Mã Giảm Giá
CREATE TABLE Ma_Giam_Gia
(
  IDMaGiamGia NVARCHAR(20) PRIMARY KEY,
  TenMaGiamGia NVARCHAR (100) NOT NULL,
  NgayBatDau datetime NOT NULL,
  NgayKetThuc datetime NOT NULL,
  SoTienGiam Decimal(10,2) NOT NULL,
  Mota NVARCHAR (100) NOT NULL
) ;
-- Bảng quy định
CREATE TABLE Quy_Dinh
(
  MaQuyDinh INT PRIMARY KEY,
  TenQuyDinh NVARCHAR (100) NOT NULL,
  Mota NVARCHAR (100) NOT NULL
  ) ;

-- Tạo khóa ngoại
-- Tạo ràng buộc duy nhất
ALTER TABLE Nhan_Vien ADD CONSTRAINT nhanvien_duynhat UNIQUE (TenDangNhap);

-- Bảng Hóa Đơn
ALTER TABLE Hoa_Don
ADD CONSTRAINT FK_Hoa_Don_Khach_Hang
FOREIGN KEY (MaKhachHang) REFERENCES Khach_Hang (MaKhachHang);
ALTER TABLE Hoa_Don
ADD CONSTRAINT FK_Hoa_Don_Nhan_Vien
FOREIGN KEY (MaNhanVien) REFERENCES Nhan_Vien (MaNhanVien);
ALTER TABLE Hoa_Don
ADD CONSTRAINT FK_Hoa_Don_Ma_Giam_Gia
FOREIGN KEY (IDMaGiamGia) REFERENCES Ma_Giam_Gia (IDMaGiamGia);

-- Bảng Chi Tiết Hóa Đơn
ALTER TABLE Chi_Tiet_Hoa_Don
ADD CONSTRAINT FK_Chi_Tiet_Hoa_Don_Hoa_Don
FOREIGN KEY (MaHoaDon) REFERENCES Hoa_Don (MaHoaDon);
ALTER TABLE Chi_Tiet_Hoa_Don
ADD CONSTRAINT FK_Chi_Tiet_Hoa_Don_Hang_Hoa
FOREIGN KEY (MaHangHoa) REFERENCES Hang_Hoa (MaHangHoa);

-- Bảng Đặt Hàng
ALTER TABLE Dat_Hang
ADD CONSTRAINT FK_Dat_Hang_Khach_Hang
FOREIGN KEY (MaKhachHang) REFERENCES Khach_Hang (MaKhachHang);
ALTER TABLE Dat_Hang
ADD CONSTRAINT FK_Dat_Hang_Nhan_Vien
FOREIGN KEY (MaNhanVien) REFERENCES Nhan_Vien (MaNhanVien);
-- Chèn dữ liệu cho bảng Nhan_Vien
INSERT INTO Nhan_Vien (MaNhanVien, HoTen, TenDangNhap, MatKhau, VaiTro)
VALUES
  (1, N'Nguyễn Văn A', N'nvana', N'password1', N'Quản lý'),
  (2, N'Nguyễn Thị B', N'ntb', N'password2', N'Nhân viên'),
  (3, N'Trần Văn C', N'tvc', N'password3', N'Nhân viên'),
  (4, N'Lê Thị D', N'ltd', N'password4', N'Nhân viên'),
  (5, N'Hoàng Văn E', N'hve', N'password5', N'Nhân viên');
  SELECT * FROM Quy_Dinh
-- Chèn dữ liệu cho bảng Hang_Hoa
INSERT INTO Hang_Hoa (MaHangHoa, TenHangHoa, DonGia, SoLuongTonKho)
VALUES
  (1, N'Bánh mì',  10000, 50),
  (2, N'Nước ngọt Coca-Cola',  15000, 30),
  (3, N'Bát đũa inox',  25000, 20),
  (4, N'Dầu gội Sunsilk',  35000, 40),
  (5, N'Trà chanh',  50000, 15),
  (6, N'Sữa tươi Vinamilk',  12000, 25),
  (7, N'Bánh quy gói nhỏ',  8000, 40),
  (8, N'Bia Heineken lon 330ml',  25000, 30),
  (9, N'Túi ni-lông đựng rác',  5000, 50),
  (10, N'Găng tay vải',  15000, 15),
  (11, N'Cà phê phin đen',  18000, 20),
  (12, N'Son môi hồng',  30000, 35),
  (13, N'Ổ cắm điện 3 chấu',  20000, 10),
  (14, N'Túi nilon đựng thức ăn',  6000, 45),
  (15, N'Sữa rữa mặt',  28000, 18),
  (16, N'Bàn chải đánh răng', 7000, 55),
  (17, N'Bóng đèn LED',  45000, 22),
  (18, N'Áo mưa dày',  40000, 12),
  (19, N'Khăn giấy lau bàn',  10000, 28),
  (20, N'Găng tay cao su',  8000, 60);

-- Chèn dữ liệu cho bảng Khach_Hang
INSERT INTO Khach_Hang (MaKhachHang, HoTen, Email, SoDienThoai)
VALUES
  (1, N'Nguyễn Văn Khách', N'nvk@example.com', N'0123456789'),
  (2, N'Trần Thị Khách Hàng', N'ttkh@example.com', N'0987654321'),
  (3, N'Lê Văn A', N'lva@example.com', N'0369876543'),
  (4, N'Phạm Thị B', N'ptb@example.com', N'0765432987'),
  (5, N'Huỳnh Văn C', N'hvc@example.com', N'0923456712'),
  (6, N'Phan Văn Khách', N'pvk@example.com', N'0345678912'),
  (7, N'Tran Văn Khách Hàng', N'tvkh@example.com', N'0765432890'),
  (8, N'Lý Văn A', N'lva@example.com', N'0923786451'),
  (9, N'Mai Thị B', N'mtb@example.com', N'0654321897'),
  (10, N'Đỗ Văn C', N'dvc@example.com', N'0987651234'),
  (11, N'Nguyễn Thị D', N'ntd@example.com', N'0321897645'),
  (12, N'Lê Văn E', N'lve@example.com', N'0765432890'),
  (13, N'Hoàng Thị F', N'htf@example.com', N'0345678912'),
  (14, N'Trần Văn G', N'tvg@example.com', N'0923786451'),
  (15, N'Phạm Thị H', N'pth@example.com', N'0654321897'),
  (16, N'Nguyễn Văn I', N'nvi@example.com', N'0987651234'),
  (17, N'Lý Thị K', N'ltk@example.com', N'0321897645'),
  (18, N'Trần Văn L', N'tvl@example.com', N'0765432890'),
  (19, N'Mai Thị M', N'mtm@example.com', N'0345678912'),
  (20, N'Đỗ Văn N', N'dvn@example.com', N'0923786451');

-- Chèn dữ liệu vào bảng Ma_Giam_Gia
INSERT INTO Ma_Giam_Gia (IDMaGiamGia, TenMaGiamGia, NgayBatDau, NgayKetThuc, SoTienGiam, Mota)
VALUES
(N'MG001', N'Giảm giá 10,000 VND', '2023-01-01 08:00:00', '2023-04-30 23:59:59', 10000.00, N'Giảm giá 10,000 VND cho mọi đơn hàng'),
(N'MG002', N'Giảm giá 20,000 VND', '2023-02-01 00:00:00', '2023-03-28 23:59:59', 20000.00, N'Áp dụng cho sản phẩm mới'),
(N'MG003', N'Giảm giá 15,000 VND', '2023-05-01 00:00:00', '2023-07-31 23:59:59', 15000.00, N'Khuyến mãi hấp dẫn'),
(N'MG004', N'Giảm giá 25,000 VND', '2023-04-01 00:00:00', '2023-09-30 23:59:59', 25000.00, N'Chương trình đặc biệt'),
(N'MG005', N'Giảm giá 30,000 VND', '2023-09-01 00:00:00', '2023-12-31 23:59:59', 30000.00, N'Ưu đãi cuối năm');
-- Chèn dữ liệu cho bảng Hoa_Don
INSERT INTO Hoa_Don (MaHoaDon, MaKhachHang, MaNhanVien, NgayTao,IDMaGiamGia , TongTien)
VALUES
  (1, 1, 1, '2023-12-01 08:00:00',N'MG001', 321000.00),
   (3, 3, 3, '2023-04-20 10:45:00',N'MG001', 357000.00),
     (7, 7, 2, '2023-07-05 11:30:00',N'MG001', 207000.00),
	   (17, 17, 2, '2023-05-28 11:00:00',N'MG001', 354000.00),
	   (21, 1, 1, '2023-11-21 14:30:00',N'MG003', 210000.00),
	     (24, 4, 4, '2023-06-20 16:55:00',N'MG003', 360000.00),
		  (29, 9, 4, '2023-11-23 15:05:00', N'MG003',1110000.00),
		    (57, 17, 2, '2023-10-19 17:15:00',N'MG001', 230000.00),
			  (59, 19, 4, '2023-06-01 15:05:00', N'MG001' ,490000.00);
INSERT INTO Hoa_Don (MaHoaDon, MaKhachHang, MaNhanVien, NgayTao , TongTien)
VALUES
  (2, 2, 2, '2023-06-15 14:30:00', 354000.00),
  (4, 4, 4, '2023-09-03 12:20:00', 306000.00),
  (5, 5, 5, '2023-11-10 16:55:00', 338000.00),
  (6, 6, 1, '2023-02-28 09:10:00', 134000.00),

  (8, 8, 3, '2023-10-12 17:15:00', 420000.00),
  (9, 9, 4, '2023-03-18 13:40:00', 355000.00),
  (10, 10, 5, '2023-08-25 15:05:00', 116000.00),
  (11, 11, 1, '2023-05-08 18:30:00', 129000.00),
  (12, 12, 2, '2023-01-16 08:00:00', 376000.00),
  (13, 13, 3, '2023-07-29 10:25:00', 333000.00),
  (14, 14, 4, '2023-09-22 12:50:00', 200000.00),
  (15, 15, 5, '2023-02-03 16:15:00', 283000.00),
  (16, 16, 1, '2023-11-15 09:40:00', 286000.00),

  (18, 18, 3, '2023-04-02 14:25:00', 275000.00),
  (19, 19, 4, '2023-10-09 16:50:00', 289000.00),
  (20, 20, 5, '2023-08-14 08:00:00', 112000.00),

  (22, 2, 2, '2023-09-26 10:45:00', 560000.00),
  (23, 3, 3, '2023-01-09 12:20:00', 250000.00),

  (25, 5, 5, '2023-04-27 09:10:00', 250000.00),
  (26, 6, 1, '2023-08-05 11:30:00', 600000.00),
  (27, 7, 2, '2023-12-11 17:15:00', 300000.00),
  (28, 8, 3, '2023-03-16 13:40:00', 500000.00),

  (30, 10, 5, '2023-07-10 18:30:00', 40000.00),
  (31, 11, 1, '2023-09-17 08:00:00', 150000.00),
  (32, 12, 2, '2023-02-25 10:25:00', 350000.00),
  (33, 13, 3, '2023-05-04 12:50:00', 140000.00),
  (34, 14, 4, '2023-08-11 16:15:00', 25000.00),
  (35, 15, 5, '2023-12-18 09:40:00', 250000.00),
  (36, 16, 1, '2023-10-31 11:00:00', 270000.00),
  (37, 17, 2, '2023-01-14 14:25:00', 240000.00),
  (38, 18, 3, '2023-04-21 16:50:00', 60000.00),
  (39, 19, 4, '2023-06-26 08:00:00', 500000.00),
  (40, 20, 5, '2023-03-05 14:30:00', 40000.00),
  (41, 1, 1, '2023-01-20 10:45:00', 225000.00),
  (42, 2, 2, '2023-11-27 12:20:00', 560000.00),
  (43, 3, 3, '2023-09-03 16:55:00', 250000.00),
  (44, 4, 4, '2023-04-10 09:10:00', 375000.00),
  (45, 5, 5, '2023-08-17 11:30:00', 250000.00),
  (46, 6, 1, '2023-12-24 17:15:00', 600000.00),
  (47, 7, 2, '2023-07-01 13:40:00', 300000.00),
  (48, 8, 3, '2023-10-08 15:05:00', 500000.00),
  (49, 9, 4, '2023-05-15 18:30:00', 1125000.00),
  (50, 10, 5, '2023-11-22 08:00:00', 40000.00),
  (51, 11, 1, '2023-09-02 14:30:00', 150000.00),
  (52, 12, 2, '2023-01-17 10:45:00', 350000.00),
  (53, 13, 3, '2023-06-24 12:20:00', 140000.00),
  (54, 14, 4, '2023-03-31 16:55:00', 25000.00),
  (55, 15, 5, '2023-08-07 09:10:00', 250000.00),
  (56, 16, 1, '2023-12-14 11:30:00', 270000.00),

  (58, 18, 3, '2023-04-26 13:40:00', 60000.00),

  (60, 20, 5, '2023-03-08 18:30:00', 40000.00);



-- Chèn dữ liệu cho bảng Chi_Tiet_Hoa_Don
INSERT INTO Chi_Tiet_Hoa_Don (MaChiTietHoaDon, MaHoaDon, MaHangHoa, SoLuong)
VALUES
  (1, 1, 1, 2),
  (2, 1, 2, 3),
  (3, 2, 3, 1),
  (4, 3, 4, 2),
  (5, 4, 5, 3),
  (6, 6, 6, 3),
  (7, 7, 7, 2),
  (8, 8, 8, 4),
  (9, 9, 9, 5),
  (10, 10, 10, 1),
  (11, 11, 11, 3),
  (12, 12, 12, 2),
  (13, 13, 13, 4),
  (14, 14, 14, 5),
  (15, 15, 15, 2),
  (16, 16, 16, 3),
  (17, 17, 17, 4),
  (18, 18, 18, 1),
  (19, 19, 19, 2),
  (20, 20, 20, 3),
  (21, 6, 14, 3),
  (22, 12, 8, 4),
  (23, 19, 10, 2),
  (24, 8, 18, 3),
  (25, 3, 3, 5),
  (26, 11, 6, 1),
  (27, 5, 16, 4),
  (28, 20, 11, 2),
  (29, 1, 9, 5),
  (30, 10, 7, 3),
  (31, 14, 4, 1),
  (32, 17, 12, 2),
  (33, 16, 17, 3),
  (34, 2, 5, 4),
  (35, 15, 15, 2),
  (36, 7, 13, 4),
  (37, 18, 2, 5),
  (38, 13, 19, 3),
  (39, 9, 1, 1),
  (40, 4, 20, 2),
  (41, 15, 14, 1),
  (42, 19, 11, 3),
  (43, 16, 2, 4),
  (44, 8, 18, 2),
  (45, 7, 9, 5),
  (46, 20, 16, 3),
  (47, 3, 7, 4),
  (48, 14, 12, 1),
  (49, 5, 5, 2),
  (50, 10, 20, 4),
  (51, 1, 4, 3),
  (52, 6, 13, 2),
  (53, 9, 19, 1),
  (54, 18, 1, 5),
  (55, 11, 6, 3),
  (56, 13, 16, 4),
  (57, 12, 15, 2),
  (58, 2, 8, 1),
  (59, 4, 14, 5),
  (60, 17, 20, 3),
  (61, 19, 18, 4),
  (62, 8, 10, 2),
  (63, 3, 1, 1),
  (64, 9, 17, 3),
  (65, 13, 4, 5),
  (66, 10, 9, 1),
  (67, 2, 19, 2),
  (68, 20, 7, 3),
  (69, 1, 15, 4),
  (70, 6, 13, 1),
  (71, 16, 3, 2),
  (72, 7, 10, 4),
  (73, 15, 2, 5),
  (74, 5, 18, 3),
  (75, 11, 16, 1),
  (76, 4, 8, 2),
  (77, 18, 1, 4),
  (78, 14, 11, 5),
  (79, 3, 12, 3),
  (80, 9, 5, 2),
  (81, 14, 10, 1),
  (82, 2, 15, 3),
  (83, 11, 9, 4),
  (84, 18, 4, 2),
  (85, 9, 8, 3),
  (86, 3, 7, 5),
  (87, 16, 13, 1),
  (88, 6, 19, 2),
  (89, 12, 18, 4),
  (90, 8, 11, 5),
  (91, 17, 5, 2),
  (92, 5, 12, 3),
  (93, 20, 16, 1),
  (94, 13, 1, 2),
  (95, 1, 14, 4),
  (96, 10, 20, 5),
  (97, 7, 6, 3),
  (98, 19, 3, 1),
  (99, 15, 17, 2),
  (100, 4, 2, 4),
(101, 21, 2, 3),
(102, 22, 15, 4),
(103, 23, 8, 2),
(104, 24, 10, 5),
(105, 25, 5, 1),
(106, 26, 18, 3),
(107, 27, 12, 2),
(108, 28, 3, 4),
(109, 29, 17, 5),
(110, 30, 7, 1),
(111, 31, 19, 3),
(112, 32, 4, 2),
(113, 33, 16, 4),
(114, 34, 9, 1),
(115, 35, 1, 5),
(116, 36, 11, 3),
(117, 37, 6, 4),
(118, 38, 14, 2),
(119, 39, 13, 5),
(120, 40, 20, 1),
(121, 21, 2, 3),
(122, 22, 15, 4),
(123, 23, 8, 2),
(124, 24, 10, 5),
(125, 25, 5, 1),
(126, 26, 18, 3),
(127, 27, 12, 2),
(128, 28, 3, 4),
(129, 29, 17, 5),
(130, 30, 7, 1),
(131, 31, 19, 3),
(132, 32, 4, 2),
(133, 33, 16, 4),
(134, 34, 9, 1),
(135, 35, 1, 5),
(136, 36, 11, 3),
(137, 37, 6, 4),
(138, 38, 14, 2),
(139, 39, 13, 5),
(140, 40, 20, 1),
(141, 21, 2, 3),
(142, 22, 15, 4),
(143, 23, 8, 2),
(144, 24, 10, 5),
(145, 25, 5, 1),
(146, 26, 18, 3),
(147, 27, 12, 2),
(148, 28, 3, 4),
(149, 29, 17, 5),
(150, 30, 7, 1),
(151, 31, 19, 3),
(152, 32, 4, 2),
(153, 33, 16, 4),
(154, 34, 9, 1),
(155, 35, 1, 5),
(156, 36, 11, 3),
(157, 37, 6, 4),
(158, 38, 14, 2),
(159, 39, 13, 5),
(160, 40, 20, 1),
(161, 21, 2, 3),
(162, 22, 15, 4),
(163, 23, 8, 2),
(164, 24, 10, 5),
(165, 25, 5, 1),
(166, 26, 18, 3),
(167, 27, 12, 2),
(168, 28, 3, 4),
(169, 29, 17, 5),
(170, 30, 7, 1),
(171, 31, 19, 3),
(172, 32, 4, 2),
(173, 33, 16, 4),
(174, 34, 9, 1),
(175, 35, 1, 5),
(176, 36, 11, 3),
(177, 37, 6, 4),
(178, 38, 14, 2),
(179, 39, 13, 5),
(180, 40, 20, 1),
(181, 21, 2, 3),
(182, 22, 15, 4),
(183, 23, 8, 2),
(184, 24, 10, 5),
(185, 25, 5, 1),
(186, 26, 18, 3),
(187, 27, 12, 2),
(188, 28, 3, 4),
(189, 29, 17, 5),
(190, 30, 7, 1),
(191, 31, 19, 3),
(192, 32, 4, 2),
(193, 33, 16, 4),
(194, 34, 9, 1),
(195, 35, 1, 5),
(196, 36, 11, 3),
(197, 37, 6, 4),
(198, 38, 14, 2),
(199, 39, 13, 5),
(200, 40, 20, 1),
(201, 41, 2, 3),
(202, 42, 15, 4),
(203, 43, 8, 2),
(204, 44, 10, 5),
(205, 45, 5, 1),
(206, 46, 18, 3),
(207, 47, 12, 2),
(208, 48, 3, 4),
(209, 49, 17, 5),
(210, 50, 7, 1),
(211, 51, 19, 3),
(212, 52, 4, 2),
(213, 53, 16, 4),
(214, 54, 9, 1),
(215, 55, 1, 5),
(216, 56, 11, 3),
(217, 57, 6, 4),
(218, 58, 14, 2),
(219, 59, 13, 5),
(220, 60, 20, 1),
(221, 41, 2, 3),
(222, 42, 15, 4),
(223, 43, 8, 2),
(224, 44, 10, 5),
(225, 45, 5, 1),
(226, 46, 18, 3),
(227, 47, 12, 2),
(228, 48, 3, 4),
(229, 49, 17, 5),
(230, 50, 7, 1),
(231, 51, 19, 3),
(232, 52, 4, 2),
(233, 53, 16, 4),
(234, 54, 9, 1),
(235, 55, 1, 5),
(236, 56, 11, 3),
(237, 57, 6, 4),
(238, 58, 14, 2),
(239, 59, 13, 5),
(240, 60, 20, 1),
(241, 41, 2, 3),
(242, 42, 15, 4),
(243, 43, 8, 2),
(244, 44, 10, 5),
(245, 45, 5, 1),
(246, 46, 18, 3),
(247, 47, 12, 2),
(248, 48, 3, 4),
(249, 49, 17, 5),
(250, 50, 7, 1),
(251, 51, 19, 3),
(252, 52, 4, 2),
(253, 53, 16, 4),
(254, 54, 9, 1),
(255, 55, 1, 5),
(256, 56, 11, 3),
(257, 57, 6, 4),
(258, 58, 14, 2),
(259, 59, 13, 5),
(260, 60, 20, 1),
(261, 41, 2, 3),
(262, 42, 15, 4),
(263, 43, 8, 2),
(264, 44, 10, 5),
(265, 45, 5, 1),
(266, 46, 18, 3),
(267, 47, 12, 2),
(268, 48, 3, 4),
(269, 49, 17, 5),
(270, 50, 7, 1),
(271, 51, 19, 3),
(272, 52, 4, 2),
(273, 53, 16, 4),
(274, 54, 9, 1),
(275, 55, 1, 5),
(276, 56, 11, 3),
(277, 57, 6, 4),
(278, 58, 14, 2),
(279, 59, 13, 5),
(280, 60, 20, 1),
(281, 41, 2, 3),
(282, 42, 15, 4),
(283, 43, 8, 2),
(284, 44, 10, 5),
(285, 45, 5, 1),
(286, 46, 18, 3),
(287, 47, 12, 2),
(288, 48, 3, 4),
(289, 49, 17, 5),
(290, 50, 7, 1),
(291, 51, 19, 3),
(292, 52, 4, 2),
(293, 53, 16, 4),
(294, 54, 9, 1),
(295, 55, 1, 5),
(296, 56, 11, 3),
(297, 57, 6, 4),
(298, 58, 14, 2),
(299, 59, 13, 5),
(300, 60, 20, 1);


-- Chèn dữ liệu cho bảng Dat_Hang
INSERT INTO Dat_Hang (MaDatHang, MaKhachHang, MaNhanVien, NgayDat, TrangThai)
VALUES
  (1, 1, 1, '2023-12-01 08:00:00', N'Đã xác nhận'),
  (2, 2, 1, '2023-12-02 09:30:00', N'Chờ xử lý'),
  (3, 3, 2, '2023-12-03 10:15:00', N'Đang giao'),
  (4, 4, 3, '2023-12-04 11:45:00', N'Đã giao'),
  (5, 5, 3, '2023-12-05 13:20:00', N'Đã hủy'),
  (6, 6, 1, '2023-12-06 08:00:00', N'Đã xác nhận'),
  (7, 7, 2, '2023-12-07 09:30:00', N'Chờ xử lý'),
  (8, 8, 3, '2023-12-08 10:15:00', N'Đang giao'),
  (9, 9, 4, '2023-12-09 11:45:00', N'Đã giao'),
  (10, 10, 5, '2023-12-10 13:20:00', N'Đã hủy'),
  (11, 11, 1, '2023-12-11 08:00:00', N'Đã xác nhận'),
  (12, 12, 2, '2023-12-12 09:30:00', N'Chờ xử lý'),
  (13, 13, 3, '2023-12-13 10:15:00', N'Đang giao'),
  (14, 14, 4, '2023-12-14 11:45:00', N'Đã giao'),
  (15, 15, 5, '2023-12-15 13:20:00', N'Đã hủy'),
  (16, 16, 1, '2023-12-16 08:00:00', N'Đã xác nhận'),
  (17, 17, 2, '2023-12-17 09:30:00', N'Chờ xử lý'),
  (18, 18, 3, '2023-12-18 10:15:00', N'Đang giao'),
  (19, 19, 4, '2023-12-19 11:45:00', N'Đã giao'),
  (20, 20, 5, '2023-12-20 13:20:00', N'Đã hủy');

INSERT INTO Quy_Dinh (MaQuyDinh, TenQuyDinh, Mota)
VALUES
(1, N'Phạt việc đi trễ', N'Áp dụng mức phạt 50,000 VND cho nhân viên đi trễ không đúng thời gian quy định.'),
(2, N'Phạt không đeo đồng hồ chấm công', N'Áp dụng mức phạt 30,000 VND cho nhân viên không đeo đồng hồ chấm công đúng cách.'),
(3, N'Phạt việc nghỉ không thông báo', N'Áp dụng mức phạt 100,000 VND cho nhân viên nghỉ làm mà không thông báo trước.'),
(4, N'Phạt việc sử dụng điện thoại trong giờ làm việc', N'Áp dụng mức phạt 80,000 VND cho nhân viên sử dụng điện thoại cá nhân trong giờ làm việc.'),
(5, N'Phạt việc làm mất tài sản công ty', N'Áp dụng mức phạt 150,000 VND cho nhân viên gây mất mát hoặc hỏng hóc tài sản của công ty.'),
(6, N'Phạt việc tiết lộ thông tin mật', N'Áp dụng mức phạt 200,000 VND cho nhân viên tiết lộ thông tin mật của công ty.'),
(7, N'Phạt việc không tuân thủ quy tắc an toàn', N'Áp dụng mức phạt 120,000 VND cho nhân viên không tuân thủ các quy tắc an toàn làm việc.'),
(8, N'Phạt việc làm việc không chấp nhận được', N'Áp dụng mức phạt 250,000 VND cho nhân viên làm việc không chấp nhận được.'),
(9, N'Phạt việc sử dụng chất kích thích trong công ty', N'Áp dụng mức phạt 500,000 VND cho nhân viên sử dụng chất kích thích trong công ty.'),
(10, N'Phạt việc không duy trì vệ sinh cá nhân', N'Áp dụng mức phạt 300,000 VND cho nhân viên không duy trì vệ sinh cá nhân đúng cách.');

  
--Tính tổng tiền của mỗi hóa đơn
SELECT
    CHD.MaHoaDon,
    SUM(CHD.SoLuong * HH.DonGia) AS TongTien
FROM
    Chi_Tiet_Hoa_Don CHD
JOIN
    Hang_Hoa HH ON CHD.MaHangHoa = HH.MaHangHoa
GROUP BY
    CHD.MaHoaDon;
-- Tính doanh thu theo tháng
	SELECT
  YEAR(NgayTao) AS Nam,
  MONTH(NgayTao) AS Thang,
  SUM(TongTien) AS DoanhThu
FROM
  Hoa_Don
GROUP BY
  YEAR(NgayTao),
  MONTH(NgayTao)
ORDER BY
  Nam ASC,
  Thang ASC;
-- Lấy tên khách hàng,nhân viên tương ứng
  SELECT
  Hoa_Don.MaHoaDon,
  Khach_Hang.HoTen As HoTenKH,
  Nhan_Vien.HoTen As HoTenNV,
  Hoa_Don.NgayTao,
  Hoa_Don.TongTien
  FROM
  Hoa_Don
INNER JOIN Khach_Hang ON Hoa_Don.MaKhachHang = Khach_Hang.MaKhachHang
INNER JOIN Nhan_Vien ON Hoa_Don.MaNhanVien = Nhan_Vien.MaNhanVien;
--Lấy chi tiết của từng mã hóa đơn

  SELECT 
  MaHoaDon,
  TenHangHoa,
  SoLuong,
  DonGia,
  TongTien,
  CASE WHEN ROW_NUMBER() OVER (PARTITION BY MaHoaDon ORDER BY (SELECT NULL)) = 1 THEN TongHoaDon END AS TongHoaDon
FROM (
  SELECT 
    CTHD.MaHoaDon,
    HH.TenHangHoa,
    CTHD.SoLuong,
    HH.DonGia,
    CTHD.SoLuong * HH.DonGia AS TongTien,
    SUM(CTHD.SoLuong * HH.DonGia) OVER (PARTITION BY CTHD.MaHoaDon) AS TongHoaDon
  FROM 
    Chi_Tiet_Hoa_Don CTHD
    JOIN Hang_Hoa HH ON CTHD.MaHangHoa = HH.MaHangHoa
  WHERE 
    CTHD.MaHoaDon = 1
) AS Subquery;
-- Lấy hóa đơn có áp dụng mã giảm giá
SELECT 
  HD.MaHoaDon,
  KH.HoTen AS TenKhachHang,
  NV.HoTen AS TenNhanVien,
  HD.NgayTao,
  MG.TenMaGiamGia,
  HD.TongTien
FROM 
  Hoa_Don HD
  JOIN Khach_Hang KH ON HD.MaKhachHang = KH.MaKhachHang
  JOIN Nhan_Vien NV ON HD.MaNhanVien = NV.MaNhanVien
  LEFT JOIN Ma_Giam_Gia MG ON HD.IDMaGiamGia = MG.IDMaGiamGia







