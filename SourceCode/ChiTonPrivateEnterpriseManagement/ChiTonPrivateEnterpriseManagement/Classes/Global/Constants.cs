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
        public const string MANAGE_MENU_VN = "QUẢN LÝ MENU";
        public const string MANAGE_ROLE_VN = "QUẢN LÝ CHỨC VỤ";
        public const string MANAGE_RIGHT_VN = "QUẢN LÝ QUYỀN";
        public const string MANAGE_USER_VN = "QUẢN LÝ NHÂN VIÊN";
        public const string MANAGE_CONSTRUCTION_INFO_VN = "QUẢN LÝ CÔNG TRÌNH";
        public const string MANAGE_ESTIMATE_INFO_VN = "QUẢN LÝ DỰ TOÁN";
        
        // Child Menus VN
        public const string MANAGE_MENU_INFO_VN = "Xem Toàn Bộ Thông Tin Menu";
        public const string MANAGE_ROLE_INFO_VN = "Xem Toàn Bộ Thông Tin Chức Vụ";
        public const string MANAGE_RIGHT_INFO_VN = "Xem Toàn Bộ Thông Tin Quyền";
        public const string MANAGE_USER_INFO_VN = "Xem Toàn Bộ Thông Tin Nhân Viên";

        // Parent Manus EN
        public const string MANAGE_MENU_EN = "MANAGE_MENU";
        public const string MANAGE_ROLE_EN = "MANAGE_ROLE";
        public const string MANAGE_RIGHT_EN = "MANAGE_RIGHT";
        public const string MANAGE_USER_EN = "MANAGE_USER";

        // Child Menus EN
        public const string MANAGE_MENU_INFO_EN = "MANAGE_MENU_INFO";
        public const string MANAGE_ROLE_INFO_EN = "MANAGE_ROLE_INFO";
        public const string MANAGE_RIGHT_INFO_EN = "MANAGE_RIGHT_INFO";
        public const string MANAGE_USER_INFO_EN = "MANAGE_USER_INFO";

        public const string ROLE_ADMIN = "admin";
        public const string ROLE_MANAGER = "manager";
        public const string ROLE_CHIEF_ACCOUNTANT = "chief accountant";
        public const string ROLE_ACCOUNTANT = "accountant";

        //Encrypt key 
        public const string Encryptkey = "!@CTEM@ADS2o1o@!";

        public const string MENU_PARENT_DISPLAYMEMBER = "MenuName";
        public const string MENU_PARENT_VALUEMEMBER = "MenuID";

        public const string ROLE_DISPLAYMEMBER = "RoleName";
        public const string ROLE_VALUEMEMBER = "RoleID";

        public const string RIGHT_DISPLAYMEMBER = "RightName";
        public const string RIGHT_VALUEMEMBER = "RightID";

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
    }
}
