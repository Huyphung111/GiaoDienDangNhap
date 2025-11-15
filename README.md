# 🐾 HỆ THỐNG QUẢN LÝ PET SHOP

## 📌 THÔNG TIN DỰ ÁN
- **Tên dự án:** Hệ thống Quản lý Cửa hàng Thú cưng (Pet Shop Management System)
- **Ngôn ngữ:** C# - Windows Forms Application
- **Database:** Microsoft SQL Server
- **Framework:** .NET Framework
- **Namespace:** `GiaoDienDangNhap`

---

## 🎯 MÔ TẢ DỰ ÁN
Hệ thống quản lý toàn diện cho cửa hàng thú cưng, bao gồm:
- ✅ Quản lý thú cưng và sản phẩm phụ kiện
- ✅ Quản lý đơn hàng và hóa đơn
- ✅ Quản lý dịch vụ (tắm, cắt tỉa, khám...)
- ✅ Quản lý khách hàng và nhà cung cấp
- ✅ Báo cáo thống kê doanh thu
- ✅ Hệ thống phân quyền người dùng

---

## 🗄️ CƠ SỞ DỮ LIỆU

### Database: `QUANLY_PETSHOP_V3`

#### 📊 Danh sách các bảng (14 bảng):

| STT | Tên Bảng | Chức năng |
|-----|----------|-----------|
| 1 | `PhanQuyen` | Quản lý phân quyền (Admin, Khách hàng) |
| 2 | `NguoiDung` | Thông tin tài khoản người dùng |
| 3 | `LoaiThuCung` | Danh mục loại thú cưng |
| 4 | `ThuCung` | Thông tin thú cưng (tên, giá, số lượng...) |
| 5 | `KhachHang` | Thông tin khách hàng |
| 6 | `DonHang` | Quản lý đơn hàng |
| 7 | `NhaCungCap` | Thông tin nhà cung cấp |
| 8 | `SanPhamPhuKien` | Sản phẩm phụ kiện cho thú cưng |
| 9 | `ChiTietDonHang` | Chi tiết các mặt hàng trong đơn |
| 10 | `DichVu` | Danh sách dịch vụ |
| 11 | `PhieuDichVu` | Phiếu đặt dịch vụ |
| 12 | `HoaDon` | Hóa đơn thanh toán |
| 13 | `ChiTietHoaDon` | Chi tiết hóa đơn |
| 14 | `BaoCaoThongKe` | Báo cáo thống kê doanh thu |

#### 🔐 Tài khoản mặc định:
```
👤 Username: admin
🔑 Password: admin123
📋 Quyền hạn: Admin (MaPhanQuyen = 1)
```

#### ⚙️ Connection String:
```csharp
Data Source=HUYNE;
Initial Catalog=QUANLY_PETSHOP_V3;
Integrated Security=True;
TrustServerCertificate=True
```

---

## 🖥️ CÁC FORM TRONG ỨNG DỤNG

### 1. **Form1 - Đăng nhập** ✅
**Chức năng:**
- Đăng nhập bằng tài khoản và mật khẩu
- Xác thực từ database SQL Server
- Phân quyền Admin/Khách hàng
- Checkbox hiển thị/ẩn mật khẩu
- Chuyển đến form đăng ký
- Chuyển đến form đổi mật khẩu

**Validation:**
- Kiểm tra tài khoản không được để trống
- Kiểm tra mật khẩu không được để trống
- Xác thực tài khoản/mật khẩu từ database
- Kiểm tra trạng thái tài khoản (TrangThai = 1)

**Controls chính:**
- `textBox1`: Tên đăng nhập
- `textBox2`: Mật khẩu
- `button1`: Nút Đăng nhập
- `btn_taotaikhoang`: Nút Tạo tài khoản
- `btn_doimatkhau`: Nút Đổi mật khẩu
- `check_hienmatkhau`: Checkbox hiển thị mật khẩu

---

### 2. **Form2 - Đăng ký tài khoản** ✅
**Chức năng:**
- Tạo tài khoản mới cho khách hàng
- Kiểm tra tài khoản đã tồn tại
- Kiểm tra email hợp lệ và không trùng
- Tự động tạo record KhachHang
- Mặc định MaPhanQuyen = 2 (Khách hàng)

**Validation:**
- Tên tài khoản: Không trống, tối thiểu 3 ký tự, không trùng
- Mật khẩu: Không trống, tối thiểu 6 ký tự
- Nhập lại mật khẩu: Phải khớp với mật khẩu
- Email: Không trống, định dạng hợp lệ, không trùng

**Controls chính:**
- `textBox1`: Tên tài khoản
- `textBox2`: Mật khẩu
- `textBox3`: Nhập lại mật khẩu
- `txt_email`: Email
- `button1`: Nút Tạo tài khoản
- `btnCancel`: Nút Hủy

**Label lỗi:**
- `txt_tdn`: Tên tài khoản đã tồn tại
- `txt_matkhauitnhat6kitu`: Mật khẩu ít nhất 6 ký tự
- `label5`: Mật khẩu nhập lại không khớp
- `txt_emailkhongphuhop`: Email không hợp lệ

---

### 3. **DoiMatKhau - Đổi mật khẩu** ✅
**Chức năng:**
- Đổi mật khẩu cho tài khoản đã có
- Xác thực tài khoản và mật khẩu hiện tại
- Kiểm tra mật khẩu mới không trùng mật khẩu cũ
- Cập nhật mật khẩu vào database
- Checkbox hiển thị/ẩn mật khẩu cho cả 3 trường

**Validation:**
- Tài khoản: Không trống, phải tồn tại
- Mật khẩu hiện tại: Không trống, phải đúng
- Mật khẩu mới: Không trống, tối thiểu 6 ký tự, không trùng mật khẩu cũ
- Nhập lại mật khẩu: Phải khớp với mật khẩu mới

**Controls chính:**
- `txt_taikhoan`: Tên tài khoản
- `txt_matkhauhientai`: Mật khẩu hiện tại
- `txt_nhapmatkhaumoi`: Mật khẩu mới
- `txt_nhaplai`: Nhập lại mật khẩu mới
- `btn_doimatkhau`: Nút Đổi mật khẩu
- `ck_hien`: Checkbox hiển thị mật khẩu

**Label lỗi:**
- `txt_taikhoangkhonghople`: Tài khoản không hợp lệ
- `txt_matkhaunhapsai`: Mật khẩu nhập sai
- `matkhauitnhat6kitu`: Mật khẩu ít nhất 6 ký tự
- `matkhaunhaplaikhongdung`: Mật khẩu nhập lại không đúng

---

### 4. **GiaoDien - Form chính** 🚧
**Chức năng:**
- Form chính sau khi đăng nhập thành công
- Hiển thị menu và các chức năng quản lý
- *Đang phát triển...*

---

## 🔧 CÀI ĐẶT VÀ CHẠY DỰ ÁN

### Yêu cầu hệ thống:
- ✅ Visual Studio 2019 trở lên
- ✅ .NET Framework 4.7.2 trở lên
- ✅ SQL Server 2017 trở lên
- ✅ SQL Server Management Studio (SSMS)

### Các bước cài đặt:

#### 1. Cài đặt Database
```sql
-- Chạy script SQL để tạo database
-- File: Database_Script.sql
-- Tạo database QUANLY_PETSHOP_V3 và các bảng
```

#### 2. Cấu hình Connection String
Mở các file sau và cập nhật Connection String:
- `Form1.cs`
- `Form2.cs`
- `DoiMatKhau.cs`

```csharp
// Thay đổi theo cấu hình SQL Server của bạn
private string connectionString = @"Data Source=TÊN_MÁY_BẠN;
                                   Initial Catalog=QUANLY_PETSHOP_V3;
                                   Integrated Security=True;
                                   TrustServerCertificate=True";
```

#### 3. Build và Run
```
1. Mở Solution trong Visual Studio
2. Build Solution (Ctrl + Shift + B)
3. Run (F5)
```

---

## 📝 HƯỚNG DẪN SỬ DỤNG

### Đăng nhập lần đầu:
1. Chạy ứng dụng
2. Đăng nhập bằng tài khoản admin:
   - Username: `admin`
   - Password: `admin123`
3. Hoặc tạo tài khoản mới bằng nút "Tạo tài khoản"

### Tạo tài khoản mới:
1. Click nút "Tạo tài khoản" ở form đăng nhập
2. Nhập đầy đủ thông tin:
   - Tên tài khoản (tối thiểu 3 ký tự)
   - Mật khẩu (tối thiểu 6 ký tự)
   - Nhập lại mật khẩu
   - Email hợp lệ
3. Click "Tạo tài khoản"
4. Đăng nhập bằng tài khoản vừa tạo

### Đổi mật khẩu:
1. Click nút "Đổi mật khẩu" ở form đăng nhập
2. Nhập thông tin:
   - Tên tài khoản
   - Mật khẩu hiện tại
   - Mật khẩu mới (tối thiểu 6 ký tự, không trùng mật khẩu cũ)
   - Nhập lại mật khẩu mới
3. Click "Đổi mật khẩu"
4. Đăng nhập lại với mật khẩu mới

---

## 🔐 BẢO MẬT

**Lưu ý quan trọng:**
- ⚠️ Mật khẩu hiện đang lưu dạng **plain text** trong database
- ⚠️ Khuyến nghị: Sử dụng **hash** (BCrypt, SHA256) cho môi trường production
- ⚠️ Sử dụng **Stored Procedures** thay vì query trực tiếp để tránh SQL Injection
- ⚠️ Implement **Session Management** và **Token Authentication**

---

## 🛠️ CÔNG NGHỆ SỬ DỤNG

| Công nghệ | Mục đích |
|-----------|----------|
| **C# Windows Forms** | Giao diện người dùng |
| **ADO.NET** | Kết nối và thao tác database |
| **SQL Server** | Lưu trữ dữ liệu |
| **SqlConnection** | Kết nối database |
| **SqlCommand** | Thực thi câu lệnh SQL |
| **SqlDataReader** | Đọc dữ liệu |

---

## 📋 TÍNH NĂNG ĐÃ HOÀN THÀNH

- ✅ Đăng nhập với xác thực database
- ✅ Đăng ký tài khoản mới
- ✅ Đổi mật khẩu
- ✅ Phân quyền người dùng (Admin/Khách hàng)
- ✅ Validation đầy đủ cho các form
- ✅ Hiển thị/ẩn mật khẩu
- ✅ Kiểm tra email hợp lệ
- ✅ Kiểm tra tài khoản/email trùng lặp
- ✅ Thiết kế database chuẩn hóa

---

## 🚀 TÍNH NĂNG ĐANG PHÁT TRIỂN

- 🔄 Form quản lý thú cưng
- 🔄 Form quản lý sản phẩm phụ kiện
- 🔄 Form quản lý đơn hàng
- 🔄 Form quản lý dịch vụ
- 🔄 Form báo cáo thống kê
- 🔄 Form quản lý khách hàng
- 🔄 Form quản lý nhà cung cấp

---

## 📞 LIÊN HỆ & HỖ TRỢ

- 📧 Email: admin@petshop.com
- 🌐 Website: (đang cập nhật)

---

## 📜 GIẤY PHÉP

Dự án này được phát triển cho mục đích học tập và nghiên cứu.

---

## 👥 ĐÓNG GÓP

Mọi đóng góp đều được hoan nghênh! Vui lòng:
1. Fork dự án
2. Tạo branch mới (`git checkout -b feature/TinhNangMoi`)
3. Commit thay đổi (`git commit -m 'Thêm tính năng mới'`)
4. Push lên branch (`git push origin feature/TinhNangMoi`)
5. Tạo Pull Request

---

## 📝 LƯU Ý KHI SỬ DỤNG CODE

### Các tên control cần đúng:

**Form1 (Đăng nhập):**
- textBox1, textBox2
- txt_tdn, txt_matkhau
- button1, btn_taotaikhoang, btn_doimatkhau
- check_hienmatkhau

**Form2 (Đăng ký):**
- textBox1, textBox2, textBox3, txt_email
- txt_tdn, label5, txt_matkhauitnhat6kitu, txt_emailkhongphuhop
- button1, btnCancel

**DoiMatKhau (Đổi mật khẩu):**
- txt_taikhoan, txt_matkhauhientai, txt_nhapmatkhaumoi, txt_nhaplai
- txt_taikhoangkhonghople, txt_matkhaunhapsai, matkhauitnhat6kitu, matkhaunhaplaikhongdung
- btn_doimatkhau, ck_hien

---

## 🎓 HỌC LIỆU THAM KHẢO

- C# Windows Forms Documentation
- ADO.NET Tutorial
- SQL Server Best Practices
- Database Design Principles

---

**Phát triển bởi:** Huy Phùng
**Năm phát triển:** 2024  
**Phiên bản:** 3.0

---

*README này được cập nhật lần cuối: 15/11/2025*
