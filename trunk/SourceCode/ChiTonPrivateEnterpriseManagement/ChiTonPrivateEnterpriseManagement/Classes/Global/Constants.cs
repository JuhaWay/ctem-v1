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
        public const string MANAGE_USER = "Quản Lý Nhân Viên";
        public const string MANAGE_CONSTRUCTION = "Quản Lý Công Trình";
        public const string MANAGE_WAREHOUSE = "Quản Lý Kho";
        public const string MANAGE_DEBT = "Quản Lý Công Nợ";
        public const string MANAGE_LEDGER = "Quản Lý Sổ Cái";
        
        // Child Menus    
        public const string MANAGE_EMPLOYEE_SALARY = "Quản Lý Lương";
        public const string MANAGE_EMPLOYEE_ADVANCE = "Quản Lý Tiền Ứng";        

        public const string MANAGE_SUBCONTRACTORS = "Quản Lý Nhà Thầu Phụ";
        public const string MANAGE_WORKER = "Quản Lý Công Nhân";
        public const string MANAGE_ESTIMATE = "Quản Lý Dự Toán";
        public const string MANAGE_ACCOUNT = "Quản Lý Mua Hàng";
        public const string MANAGE_PROCESS = "Quản Lý Tiến Độ";

        public const string MANAGE_STOCK = "Lịch Xuất Kho";
        public const string MANAGE_VEHICLE = "Quản Lý Phương Tiện";
        public const string MANAGE_MATERIAL = "Quản Lý Vật Tư Vật Liệu";
        public const string DAILY_VEHICLE = "Quản Lý Tình Hình Phương Tiện";

        public const string MANAGE_COMPARE_DEBT = "Lịch Đọ Sổ";

        public const string MANAGE_MENU = "Quản Lý Menu";
        public const string MANAGE_ROLE = "Quản Lý Chức Vụ";
        public const string MANAGE_RIGHT = "Quản Lý Quyền";
        public const string RESET_PASSWORD = "Làm Mới Password";

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

        public const string CONSTRUCTION_WAREHOUSE = "Kho Công Trình";
        public const string MAIN_WAREHOUSE = "Kho Chính";

        public const string CREATE_NEW_EMPLOYEE = "Create New Employee";

        public const string CREATE_NEW_CONSTRUCTION = "Create New Construction";

        public const string NOT_PERMISSION = "Bạn Không Có Quyền Cho Chức Năng Này";

        public const string NUMBER = "number";

        public const string ZERO_NUMBER = "0";

        public const string NOT_EXIST_MATERIAL = "Vật tư này chưa tồn tại\n Bạn có muốn thêm mới?";
        public const string NOT_EXIST_MATERIAL_EST = "Vật tư này chưa tồn tại trong dự toán\n Bạn có muốn thêm mới?";

        

        public const int MIN_HEIGHT_HEADER_GROUP = 26;
        public const int MAX_HEIGHT_HG_CONS = 180;
        public const int MAX_HEIGHT_HG_EMP = 120;
        public const int MAX_HEIGHT_HG_WH = 180;
        public const int MAX_HEIGHT_HG_DEBT = 100;
        public const int MAX_HEIGHT_HG_LEDGER = 100;
        public const int MAX_HEIGHT_HG_SYSTEM = 160;


        public const string CHILD_FORM = "Child Form";

        public const string DIALOG_FORM = "Dialog Form";

        public const string CONFIRM_DELETE = "Bạn có chắc chắn muốn xóa?";

        public const string DELETE_SUCESS = "Đã xáo thành công";

        public const string ERROR = "Đã có lỗi xảy ra";

        public const string CONFIRM_DELETEALL = "Bạn có chắc chắn muốn xóa tất cả?";

        public const string UPDATE_SUCCESS = "Đã lưu đổi thành công";

        public const string ANNOUNCE = "Thông báo";

        public const string THOUSAND = " 000";

        public const string ERROR_EMPTY_TEXT = "Vui lòng điền vào các ô có gạch đỏ";

        public const string ERROR_LENTH_PHONENUMBER = "Độ dài số điện thoại không chính xác";

        public const string ERROR_FORMAT_PHONENUMBER = "Số điện thoại nhập không chính xác";

        public const string ALERT_ERROR = "Thông Báo Lỗi";

        public const string CREATE_SUCCESS = " Đã tạo thành công\n Bạn có muốn tiếp tục tạo?";

        public const string INVALID_DATE = "Các Ngày Nhập Vào Không Hợp Lệ";


        public const string DATETIME_FORMAT_SHORTDATE_SHORTTIME = "dd/MM/yyyy HH:mm:ss";

        public const string DATETIME_FORMAT_SHORTDATE = "dd/MM/yyyy";

        public const string INPUT_NUMBER = "Chỉ Nhập Số Vào";

        public const string EMPLOYEE_SEARCH = "Employee Search";
        public const string TO_PLACE = "To Place";
        public const string STATUS = "Status";        
        public const string CONSTRUCTION = "CONSTRUCTION";
        public const string EMPLOYEE = "EMPLOYEE";
        public const string WAREHOUSE = "WAREHOUSE";
        public const string MATERIAL = "Material";
        public const string DEBT = "DEBT";
        public const string LEDGER = "LEDGER";
        public const string SYSTEM = "SYSTEM";
        public const string ALL = "Tất Cả";
        public const string STATUS_SEARCH = "Status Search";
        public const string DEBT_SEARCH = "Debt Search";
        public const string IS_PAY = "Is Pay";

        public const string USER = "User";

        public const string ERROR_EXIST_ITEM = " Dữ Liệu Vừa Nhập Đã Tồn Tại\n Bạn Nên Sửa Hoặc Xóa Nó";

        public const string WAREHOUSE_TYPE = "Warehouse Type";

        public const string WAREHOUSE_SEARCH = "Warehouse Search";

        public const string WAREHOUSE_TYPE_SEARCH = "Warehouse Type Search";

        public const string ROLE = "ROLE";

        public const string ERROR_INPUT_NUMBER = "Chỉ Được Nhập Số";

        public const string ROLE_SEARCH = "ROLE SEARCH";

        public const string SPLIP_MONEY = " ";

        public const string ACCOUNT_SEARCH = "Account Search";

        public const string CONSTRUCTION_SEARCH = "Construction Search";

        public const string MATERIAL_SEARCH = "Material Search";

        public const string VERHICLE = "Verhicle";

        public const string DRIVER = "Driver";

        public const string DRIVER_ROLE = "Tài Xế";

        public const string PASS_NOT_MATCH = "Mật Khẩu Bạn Vừa Nhập Không Đúng";

        public const string NOT_CONFIRM_PASS = "Mật Khẩu Bạn Vừa Nhập Không Khớp Với Mật Khẩu Trên";

        public const string ERROR_DATE = "Ngày Vừa Chọn Không Hợp Lệ";

        public const string INPUT_NUMBER_ONLY = "Chỉ Được Nhập Số";
    }
}
