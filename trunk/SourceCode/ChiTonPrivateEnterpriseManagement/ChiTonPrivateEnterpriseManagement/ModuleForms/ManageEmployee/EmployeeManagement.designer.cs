namespace ChiTonPrivateEnterpriseManagement.ModuleForms.ManageEmployee
{
    partial class EmployeeManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.slcMain = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.dgvEmployee = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.totalDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdEmp = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dgvCons = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonDataGridViewCheckBoxColumn1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdCons = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rightDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).BeginInit();
            this.slcMain.Panel1.SuspendLayout();
            this.slcMain.Panel2.SuspendLayout();
            this.slcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // slcMain
            // 
            this.slcMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.slcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slcMain.Location = new System.Drawing.Point(0, 0);
            this.slcMain.Name = "slcMain";
            this.slcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // slcMain.Panel1
            // 
            this.slcMain.Panel1.Controls.Add(this.dgvEmployee);
            this.slcMain.Panel1.Controls.Add(this.hdEmp);
            // 
            // slcMain.Panel2
            // 
            this.slcMain.Panel2.Controls.Add(this.dgvCons);
            this.slcMain.Panel2.Controls.Add(this.hdCons);
            this.slcMain.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.slcMain.Size = new System.Drawing.Size(660, 460);
            this.slcMain.SplitterDistance = 220;
            this.slcMain.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Username,
            this.Fullname,
            this.Position,
            this.totalDebt,
            this.PhoneNumber,
            this.Address,
            this.Email,
            this.CMND,
            this.DOB,
            this.Note});
            this.dgvEmployee.DataSource = this.employerDTOBindingSource;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 28);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(660, 192);
            this.dgvEmployee.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvEmployee.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvEmployee.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(135)))), ((int)(((byte)(173)))));
            this.dgvEmployee.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.dgvEmployee.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.dgvEmployee.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dgvEmployee.StateCommon.HeaderColumn.Border.Rounding = 3;
            this.dgvEmployee.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvEmployee.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployee.TabIndex = 4;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            this.dgvEmployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_RowHeaderMouseClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FalseValue = null;
            this.Column1.HeaderText = "";
            this.Column1.IndeterminateValue = null;
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = null;
            this.Column1.Width = 25;
            // 
            // totalDebt
            // 
            this.totalDebt.DataPropertyName = "totalDebt";
            this.totalDebt.HeaderText = "Tổng Nợ";
            this.totalDebt.Name = "totalDebt";
            // 
            // hdEmp
            // 
            this.hdEmp.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnAdd});
            this.hdEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdEmp.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdEmp.Location = new System.Drawing.Point(0, 0);
            this.hdEmp.Name = "hdEmp";
            this.hdEmp.Size = new System.Drawing.Size(660, 28);
            this.hdEmp.TabIndex = 5;
            this.hdEmp.Values.Description = "";
            this.hdEmp.Values.Heading = "Danh Sách Nhân Viên";
            this.hdEmp.Values.Image = ((System.Drawing.Image)(resources.GetObject("hdEmp.Values.Image")));
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.btnAdd.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.btnAdd.Text = "Tạo Mới";
            this.btnAdd.ToolTipBody = "Tạo Mới Nhân Viên";
            this.btnAdd.ToolTipTitle = "Tạo Mới Nhân Viên";
            this.btnAdd.UniqueName = "D44CAFED5FD84D0D2B826697A3BBC6A2";
            // 
            // dgvCons
            // 
            this.dgvCons.AutoGenerateColumns = false;
            this.dgvCons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kryptonDataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvCons.DataSource = this.employerDTOBindingSource;
            this.dgvCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCons.Location = new System.Drawing.Point(0, 28);
            this.dgvCons.Name = "dgvCons";
            this.dgvCons.RowHeadersWidth = 25;
            this.dgvCons.Size = new System.Drawing.Size(660, 207);
            this.dgvCons.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvCons.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvCons.TabIndex = 6;
            // 
            // kryptonDataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.kryptonDataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.kryptonDataGridViewCheckBoxColumn1.FalseValue = null;
            this.kryptonDataGridViewCheckBoxColumn1.HeaderText = "";
            this.kryptonDataGridViewCheckBoxColumn1.IndeterminateValue = null;
            this.kryptonDataGridViewCheckBoxColumn1.Name = "kryptonDataGridViewCheckBoxColumn1";
            this.kryptonDataGridViewCheckBoxColumn1.TrueValue = null;
            this.kryptonDataGridViewCheckBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "totalDebt";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng Nợ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // hdCons
            // 
            this.hdCons.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.hdCons.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdCons.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.hdCons.Location = new System.Drawing.Point(0, 0);
            this.hdCons.Name = "hdCons";
            this.hdCons.Size = new System.Drawing.Size(660, 28);
            this.hdCons.TabIndex = 7;
            this.hdCons.Values.Description = "";
            this.hdCons.Values.Heading = "Danh Sách Nhân Viên";
            this.hdCons.Values.Image = ((System.Drawing.Image)(resources.GetObject("hdCons.Values.Image")));
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this.buttonSpecAny1.Image = global::ChiTonPrivateEnterpriseManagement.Properties.Resources.add;
            this.buttonSpecAny1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.FormClose;
            this.buttonSpecAny1.Text = "Tạo Mới";
            this.buttonSpecAny1.ToolTipBody = "Tạo Mới Nhân Viên";
            this.buttonSpecAny1.ToolTipTitle = "Tạo Mới Nhân Viên";
            this.buttonSpecAny1.UniqueName = "D44CAFED5FD84D0D2B826697A3BBC6A2";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tên Đăng Nhập";
            this.Username.Name = "Username";
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Tên";
            this.Fullname.Name = "Fullname";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Chức Vụ";
            this.Position.Name = "Position";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Số ĐT";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "Ngày Sinh";
            this.DOB.Name = "DOB";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            // 
            // employerDTOBindingSource
            // 
            this.employerDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.EmployerDTO);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Đăng Nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fullname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Chức Vụ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số ĐT";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn8.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ngày Sinh";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // roleDTOBindingSource
            // 
            this.roleDTOBindingSource.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RoleDTO);
            // 
            // rightDTOBindingSource1
            // 
            this.rightDTOBindingSource1.DataSource = typeof(ChiTonPrivateEnterpriseManagement.Classes.DTO.RightDTO);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.Controls.Add(this.slcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmployeeManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Border.Color1 = System.Drawing.Color.Khaki;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 4;
            this.StateCommon.Border.Width = 3;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Khaki;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassSimpleFull;
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Border.Rounding = 4;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateCommon.Header.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tag = "";
            this.Text = "Quản Lý Nhân Viên";
            this.TextExtra = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            this.slcMain.Panel1.ResumeLayout(false);
            this.slcMain.Panel1.PerformLayout();
            this.slcMain.Panel2.ResumeLayout(false);
            this.slcMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slcMain)).EndInit();
            this.slcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDTOBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.BindingSource rightDTOBindingSource1;
        private System.Windows.Forms.BindingSource roleDTOBindingSource;
        private System.Windows.Forms.BindingSource employerDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer slcMain;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEmployee;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdEmp;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvCons;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn kryptonDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader hdCons;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
    }
}

