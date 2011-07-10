using System;
using System.Collections.Generic;
using System.Text;

namespace ChiTonPrivateEnterpriseManagement.Classes.Global
{
    class Constants
    {
        public static int WIDTH_MENU_HIDE = 30;
        public static int WIDTH_MENU_SHOW = 200;

        // Parent Menus VN
        public const string MANAGE_MENU = "QUẢN LÝ MENU";
        public const string MANAGE_ROLE = "QUẢN LÝ CHỨC VỤ";
        public const string MANAGE_RIGHT = "QUẢN LÝ QUYỀN";
        public const string MANAGE_USER = "QUẢN LÝ NHÂN VIÊN";
        public const string MANAGE_CONSTRUCTION = "QUẢN LÝ CÔNG TRÌNH";
        public const string MANAGE_ESTIMATE_ACCOUNT = "QUẢN LÝ DỰ TOÁN QUYẾT TOÁN TIẾN ĐỘ";
        public const string MANAGE_WAREHOUSE = "QUẢN LÝ KHO";
        public const string MANAGE_DEBT = "QUẢN LÝ CÔNG NỢ";
        public const string MANAGE_MATERIAL = "QUẢN LÝ VẬT TƯ VẬT LIỆU";
        public const string MANAGE_SYSTEM = "QUẢN LÝ HỆ THỐNG";
        
        // Child Menus    
        public const string MANAGE_EMPLOYEE_SALARY = "Quản Lý Lương";
        public const string MANAGE_EMPLOYEE_ADVANCE = "Quản Lý Tiền Ứng";
        public const string RESET_PASSWORD = "Làm Mới Password";

        public const string MANAGE_SUBCONTRACTORS = "Quản Lý Nhà Thầu Phụ";
        public const string MANAGE_WORKER = "Quản Lý Công Nhân";

        public const string MANAGE_ESTIMATE = "Quản Lý Dự Toán";
        public const string MANAGE_ACCOUNT = "Quản Lý Quyết Toán";
        public const string MANAGE_PROCESS = "Quản Lý Tiến Độ";

        public const string MANAGE_MAIN_WAREHOUSE = "Quản Lý Kho Chính";
        public const string MANAGE_CONSTRUCTION_WAREHOUSE = "Quản Lý Kho Công Trình";
        public const string MANAGE_STOCK = "Lịch Xuất Kho";

        public const string MANAGE_COMPARE_DEBT = "Lịch Đọ Sổ";

        // Role
        public const string ROLE_SUPPER_ADMIN = "Supper Admin";
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_MANAGER = "Manager";
        public const string ROLE_CHIEF_ACCOUNTANT = "Chief Accountant";
        public const string ROLE_ACCOUNTANT = "Accountant";
        public const string ROLE_CASHIER = "Cashier";

        //Encrypt key 
        public const string Encryptkey = "!@CTEM@ADS2o1o@!";
        public const string DEFAULT_PASSWORD = "123456";

        public const string MENU_PARENT_DISPLAYMEMBER = "MenuName";
        public const string MENU_PARENT_VALUEMEMBER = "MenuID";

        public const string ROLE_DISPLAYMEMBER = "RoleName";
        public const string ROLE_VALUEMEMBER = "RoleID";

        public const string RIGHT_DISPLAYMEMBER = "RightName";
        public const string RIGHT_VALUEMEMBER = "RightID";

        public const string EMPLOYEE_DISPLAYMEMBER = "Display";
        public const string EMPLOYEE_VALUEMEMBER = "employeeID";

        public const string CONSTRUCTION_DISPLAYMEMBER = "ConstructionName";
        public const string CONSTRUCTION_VALUEMEMBER = "ConstructionID";

        public const string WAREHOUSE_DISPLAYMEMBER = "WarehouseName";
        public const string WAREHOUSE_VALUEMEMBER = "WarehouseID";

        public const string DEBT_DISPLAYMEMBER = "DebtName";
        public const string DEBT_VALUEMEMBER = "DebtID";

        public const string MATERIAL_DISPLAYMEMBER = "MaterialName";
        public const string MATERIAL_VALUEMEMBER = "MaterialID";

        public const string VALIDATE_USERNAME_PASSWORD = "Chưa Nhập Đầy Đủ Nhập Tên Đăng Nhập và Mật Khẩu";
        public const string VALIDATE_USERNAME = "Tên Đăng Nhập không được để trống";
        public const string VALIDATE_PASSWORD = "Mật Khẩu không được để trống";
        public const string INVALID_USERNAME_PASSWORD = "Tên Đăng Nhập hoặc Mất Khẩu Bị Sai";
        public const string CONFIRM = "Thông Báo";
        public const string EMPTY_TEXT = "";

        public const string PASSWORD_DATABASE = "rXheHWP2/EFNOQJiHMHyGA==";
        public const string USERNAME_MANAGE_DB = "CTEM-DB";

        public const string ACTIVE = "Hoạt Động";
        public const string INACTIVE = "Ngừng Hoạt Động";

        public const int ISACTIVE_TRUE = 1;
        public const int ISACTIVE_FALSE = 0;

        public const string PAY = "Đã Thanh Toán";
        public const string NOTPAY = "Chưa Thanh Toán";

        public const string HORISONTAL_TOP = "horisontaltop";
        public const string HORISONTAL_BOT = "horisontalbot";
        public const string VERTICAL_LEFT = "verticalleft";
        public const string VERTICAL_RIGHT = "verticalright";
        public const string HORISONTAL_TOP_CUSTOM = "horisontaltopcustom";
        public const string HORISONTAL_BOT_CUSTOM = "horisontalbotcustom";
        public const string VERTICAL_LEFT_CUSTOM = "verticalleftcustom";
        public const string VERTICAL_RIGHT_CUSTOM = "verticalrightcustom";
        public const string CENTER = "center";

        public const string INVALIDATE_VALUE = "Giá Trị Bạn Vừa Nhập Không Hợp Lệ";

        public const string TO_CONSTRUCTION_WAREHOUSE = "Kho Công Trình";
        public const string TO_MAIN_WAREHOUSE = "Kho Chính";

        public const string CONSTRUCTION_WAREHOUSE = "Kho Công Trình";
        public const string MAIN_WAREHOUSE = "Kho Chính";

        public const string CREATE_NEW_EMPLOYEE = "Create New Employee";

        public const string NOT_PERMISSION = "Bạn Không Có Quyền Cho Chức Năng Này";

        public const string EMPLOYEE = "Employee";

        public const string NUMBER = "number";

        public const string ZERO_NUMBER = "0";

        public const string NOT_EXIST_MATERIAL = "Vật tư này chưa tồn tại\n Bạn có muốn thêm mới?";
        public const string NOT_EXIST_MATERIAL_EST = "Vật tư này chưa tồn tại trong dự toán\n Bạn có muốn thêm mới?";
    }
}
