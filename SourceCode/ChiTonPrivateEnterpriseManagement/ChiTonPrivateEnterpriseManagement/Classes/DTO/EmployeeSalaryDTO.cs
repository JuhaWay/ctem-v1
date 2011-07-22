using System;

/// <summary>
/// Entity for table Employer
/// </summary>

namespace ChiTonPrivateEnterpriseManagement.Classes.DTO
{
    public class EmployeeSalaryDTO
    {
        public long EmployeeSalaryID { get; set; }
        public long EmployeeID { get; set; }
        public string Month { get; set; }
        public long Salary { get; set; }
        public long Salarypc { get; set; }
        public long TotalAllowance { get; set; }
        public long DebtPay { get; set; }
        public long Debt1 { get; set; }
        public long Debt2 { get; set; }
        public long TotalAdvanceSalary { get; set; }
        public long ActualIncome { get; set; }
        public DateTime DateReceive { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public bool IsPay { get; set; }        

        public string MonthFormat { get; set; }
        public string SalaryFormat { get; set; }
        public string SalarypcFormat { get; set; }
        public string TotalAllowanceFormat { get; set; }
        public string DebtPayFormat { get; set; }
        public string Debt1Format { get; set; }
        public string Debt2Format { get; set; }
        public string TotalAdvanceSalaryFormat { get; set; }
        public string ActualIncomeFormat { get; set; }
        public string DateReceiveFormat {get;set;}
                

        public EmployeeSalaryDTO()
        {
            Username = "";
            Fullname = "";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(EmployeeSalaryDTO)) return false;
            return Equals((EmployeeSalaryDTO)obj);
        }


        public bool Equals(EmployerDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Username, Username); //Equals(other.UsernameFullname, UsernameFullname) &&  && Equals(other.Password, Password) && Equals(other.Fullname, Fullname) && Equals(other.Address, Address) && Equals(other.Email, Email) && Equals(other.Note, Note) && other.RoleId == RoleId && Equals(other.CMND, CMND) && Equals(other.Passport, Passport) && Equals(other.BankAccount, BankAccount) && Equals(other.Job, Job) && other.IsActive.Equals(IsActive) && Equals(other.MobilePhone, MobilePhone) && Equals(other.HomePhone, HomePhone) && other.CreatedDate.Equals(CreatedDate) && other.LastUpdated.Equals(LastUpdated) && Equals(other.CreatedBy, CreatedBy) && Equals(other.UpdatedBy, UpdatedBy) && Equals(other.UserType, UserType) && Equals(other.LocationName, LocationName) && Equals(other.Namespace, Namespace);
        }

        public static bool operator ==(EmployeeSalaryDTO left, EmployeeSalaryDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmployeeSalaryDTO left, EmployeeSalaryDTO right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
