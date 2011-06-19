using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChiTonPrivateEnterpriseManagement.Classes.DTO;
using ChiTonPrivateEnterpriseManagement.Classes.Global;
using ComponentFactory.Krypton.Toolkit;

namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    public partial class Profiles : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        private EmployerDTO employerDTO;
        public Profiles()
        {
            InitializeComponent();
        }

        public Profiles(EmployerDTO _employerDTO)
        {
            InitializeComponent();
            employerDTO = _employerDTO;
            SetInitData();
        }

        private void SetInitData()
        {
            txtUsername.Text = employerDTO.Username;
            txtFullname.Text = employerDTO.Fullname;
            txtAddress.Text = employerDTO.Address;
            txtTotalDebt.Text = employerDTO.totalDebt.ToString();
            txtEmail.Text = employerDTO.Email;
            txtPhoneNumber.Text = employerDTO.PhoneNumber;
            txtCMND.Text = employerDTO.CMND;
            dtpDOB.Value = employerDTO.DOB;
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            
        }
    }
}