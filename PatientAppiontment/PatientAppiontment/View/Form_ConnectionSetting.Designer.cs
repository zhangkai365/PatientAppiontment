namespace PatientAppiontment.View
{
    partial class Form_ConnectionSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_DataBaseSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SaveAndTest = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_RestDefault = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_InitialCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DataSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_DataBaseSelect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_SaveAndTest);
            this.groupBox1.Controls.Add(this.btn_Return);
            this.groupBox1.Controls.Add(this.btn_RestDefault);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_UserID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_InitialCatalog);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_DataSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接";
            // 
            // cmb_DataBaseSelect
            // 
            this.cmb_DataBaseSelect.FormattingEnabled = true;
            this.cmb_DataBaseSelect.Location = new System.Drawing.Point(185, 35);
            this.cmb_DataBaseSelect.Name = "cmb_DataBaseSelect";
            this.cmb_DataBaseSelect.Size = new System.Drawing.Size(179, 20);
            this.cmb_DataBaseSelect.TabIndex = 12;
            this.cmb_DataBaseSelect.SelectedIndexChanged += new System.EventHandler(this.cmb_DataBaseSelect_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "选择要设置的数据库连接：";
            // 
            // btn_SaveAndTest
            // 
            this.btn_SaveAndTest.Location = new System.Drawing.Point(149, 245);
            this.btn_SaveAndTest.Name = "btn_SaveAndTest";
            this.btn_SaveAndTest.Size = new System.Drawing.Size(97, 29);
            this.btn_SaveAndTest.TabIndex = 10;
            this.btn_SaveAndTest.Text = "保存并测试";
            this.btn_SaveAndTest.UseVisualStyleBackColor = true;
            this.btn_SaveAndTest.Click += new System.EventHandler(this.btn_SaveAndTest_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(268, 245);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(97, 29);
            this.btn_Return.TabIndex = 9;
            this.btn_Return.Text = "返回";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_RestDefault
            // 
            this.btn_RestDefault.Location = new System.Drawing.Point(32, 245);
            this.btn_RestDefault.Name = "btn_RestDefault";
            this.btn_RestDefault.Size = new System.Drawing.Size(97, 29);
            this.btn_RestDefault.TabIndex = 8;
            this.btn_RestDefault.Text = "恢复默认连接";
            this.btn_RestDefault.UseVisualStyleBackColor = true;
            this.btn_RestDefault.Click += new System.EventHandler(this.btn_ResetDefalut_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(112, 193);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(253, 21);
            this.txt_Password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "密码：";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(113, 152);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(253, 21);
            this.txt_UserID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名：";
            // 
            // txt_InitialCatalog
            // 
            this.txt_InitialCatalog.Location = new System.Drawing.Point(112, 111);
            this.txt_InitialCatalog.Name = "txt_InitialCatalog";
            this.txt_InitialCatalog.Size = new System.Drawing.Size(252, 21);
            this.txt_InitialCatalog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库名称：";
            // 
            // txt_DataSource
            // 
            this.txt_DataSource.Location = new System.Drawing.Point(113, 70);
            this.txt_DataSource.Name = "txt_DataSource";
            this.txt_DataSource.Size = new System.Drawing.Size(252, 21);
            this.txt_DataSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库IP：";
            // 
            // Form_ConnectionSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 309);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ConnectionSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接设置";
            this.Load += new System.EventHandler(this.Form_ConnectionSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_RestDefault;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_InitialCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DataSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveAndTest;
        private System.Windows.Forms.ComboBox cmb_DataBaseSelect;
        private System.Windows.Forms.Label label5;
    }
}