using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanly01
{
    partial class Quanly
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
            btThoat = new Button();
            btDangXuat = new Button();
            dgvEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            label5 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbMalop = new ComboBox();
            tbPhone = new TextBox();
            pbEmployeeImage = new PictureBox();
            btSelectImage = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            tbEmail = new TextBox();
            label9 = new Label();
            cbNganhhoc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).BeginInit();
            SuspendLayout();
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.MediumSpringGreen;
            btThoat.Location = new Point(879, 501);
            btThoat.Margin = new Padding(3, 4, 3, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(110, 40);
            btThoat.TabIndex = 0;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // btDangXuat
            // 
            btDangXuat.BackColor = Color.DeepSkyBlue;
            btDangXuat.Location = new Point(1057, 0);
            btDangXuat.Margin = new Padding(3, 4, 3, 4);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(122, 44);
            btDangXuat.TabIndex = 1;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = false;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(12, 48);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(1222, 194);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 277);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã sv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 332);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên sv ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 387);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(73, 274);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Name = "tbId";
            tbId.Size = new Size(166, 27);
            tbId.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(73, 325);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(260, 27);
            tbName.TabIndex = 8;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Checked;
            ckGender.Location = new Point(14, 433);
            ckGender.Margin = new Padding(3, 4, 3, 4);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(63, 24);
            ckGender.TabIndex = 9;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.BackColor = Color.CornflowerBlue;
            btAddNew.Location = new Point(293, 501);
            btAddNew.Margin = new Padding(3, 4, 3, 4);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(104, 40);
            btAddNew.TabIndex = 10;
            btAddNew.UseVisualStyleBackColor = false;
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.DeepSkyBlue;
            btEdit.Location = new Point(494, 501);
            btEdit.Margin = new Padding(3, 4, 3, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(104, 40);
            btEdit.TabIndex = 11;
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.Red;
            btDelete.Location = new Point(681, 501);
            btDelete.Margin = new Padding(3, 4, 3, 4);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(104, 40);
            btDelete.TabIndex = 12;
            btDelete.UseVisualStyleBackColor = false;
            btDelete.Click += btDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(532, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 35);
            label5.TabIndex = 13;
            label5.Text = "Quản Lý Sinh Viên";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(517, 270);
            tbAddress.Margin = new Padding(3, 4, 3, 4);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(268, 27);
            tbAddress.TabIndex = 14;
            tbAddress.TextChanged += tbAddress_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 332);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 17;
            label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(879, 277);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 18;
            label7.Text = "Mã lớp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(404, 274);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 19;
            label8.Text = "Địa chỉ";
            // 
            // cbMalop
            // 
            cbMalop.FormattingEnabled = true;
            cbMalop.Items.AddRange(new object[] { "CCQ2211A", "CCQ2211B", "CCQ2211C", "CCQ2211D", "CCQ2211E", "CCQ2211F", "CCQ2211G", "CCQ2211H", "CCQ2211I", "CCQ2211J", "CCQ2211K", "CCQ2211L", "CCQ2211M", "CCQ2211N", "CCQ2211LA" });
            cbMalop.Location = new Point(980, 274);
            cbMalop.Margin = new Padding(3, 4, 3, 4);
            cbMalop.Name = "cbMalop";
            cbMalop.Size = new Size(167, 28);
            cbMalop.TabIndex = 20;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(517, 325);
            tbPhone.Margin = new Padding(3, 4, 3, 4);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(183, 27);
            tbPhone.TabIndex = 21;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // pbEmployeeImage
            // 
            pbEmployeeImage.Location = new Point(1069, 373);
            pbEmployeeImage.Margin = new Padding(3, 4, 3, 4);
            pbEmployeeImage.Name = "pbEmployeeImage";
            pbEmployeeImage.Size = new Size(125, 168);
            pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployeeImage.TabIndex = 22;
            pbEmployeeImage.TabStop = false;
            // 
            // btSelectImage
            // 
            btSelectImage.Location = new Point(880, 385);
            btSelectImage.Margin = new Padding(3, 4, 3, 4);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(109, 33);
            btSelectImage.TabIndex = 23;
            btSelectImage.Text = "Chọn ảnh...";
            btSelectImage.UseVisualStyleBackColor = true;
            btSelectImage.Click += btSelectImage_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(73, 378);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 27);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 385);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 25;
            label4.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(517, 387);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(219, 27);
            tbEmail.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(879, 328);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 27;
            label9.Text = "Ngành học";
            // 
            // cbNganhhoc
            // 
            cbNganhhoc.FormattingEnabled = true;
            cbNganhhoc.Items.AddRange(new object[] { "Công Nghệ Thông Tin ", "Quản Trị Kinh Doanh", "Công Nghệ Thực Phẩm ", "Ngôn Ngữ Anh ", "Công Nghệ Ôtô" });
            cbNganhhoc.Location = new Point(980, 324);
            cbNganhhoc.Name = "cbNganhhoc";
            cbNganhhoc.Size = new Size(254, 28);
            cbNganhhoc.TabIndex = 29;
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1248, 554);
            Controls.Add(cbNganhhoc);
            Controls.Add(label9);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btSelectImage);
            Controls.Add(pbEmployeeImage);
            Controls.Add(tbPhone);
            Controls.Add(cbMalop);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbAddress);
            Controls.Add(label5);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Controls.Add(btDangXuat);
            Controls.Add(btThoat);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Quanly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quanly";
            FormClosed += Quanly_FormClosed;
            Load += Quanly_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btThoat;
        private Button btDangXuat;
        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btEdit;
        private Button btDelete;
        private Label label5;
        private TextBox tbAddress;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbMalop;
        private TextBox tbPhone;
        private PictureBox pbEmployeeImage;
        private Button btSelectImage;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox tbEmail;
        private Label label9;
        private Label label10;
        private ComboBox cbNganhhoc;
    }
}