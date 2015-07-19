namespace PatientAppointment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_NewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DataBaseManagement_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ConnectionStringSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DataBaseManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddNewExam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "显示选定日期所有预约病人";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_NewAppointment,
            this.Menu_DataBaseManagement_Top,
            this.测试ToolStripMenuItem,
            this.Menu_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_NewAppointment
            // 
            this.Menu_NewAppointment.Name = "Menu_NewAppointment";
            this.Menu_NewAppointment.Size = new System.Drawing.Size(80, 21);
            this.Menu_NewAppointment.Text = "预约新病人";
            // 
            // Menu_DataBaseManagement_Top
            // 
            this.Menu_DataBaseManagement_Top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ConnectionStringSetting,
            this.Menu_DataBaseManagement});
            this.Menu_DataBaseManagement_Top.Name = "Menu_DataBaseManagement_Top";
            this.Menu_DataBaseManagement_Top.Size = new System.Drawing.Size(140, 21);
            this.Menu_DataBaseManagement_Top.Text = "数据库管理及连接设置";
            // 
            // Menu_ConnectionStringSetting
            // 
            this.Menu_ConnectionStringSetting.Name = "Menu_ConnectionStringSetting";
            this.Menu_ConnectionStringSetting.Size = new System.Drawing.Size(160, 22);
            this.Menu_ConnectionStringSetting.Text = "数据库连接设置";
            this.Menu_ConnectionStringSetting.Click += new System.EventHandler(this.Menu_ConnectionSetting_Click);
            // 
            // Menu_DataBaseManagement
            // 
            this.Menu_DataBaseManagement.Name = "Menu_DataBaseManagement";
            this.Menu_DataBaseManagement.Size = new System.Drawing.Size(160, 22);
            this.Menu_DataBaseManagement.Text = "数据库管理";
            this.Menu_DataBaseManagement.Click += new System.EventHandler(this.Menu_DataBaseManagement_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(44, 21);
            this.Menu_Exit.Text = "退出";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddNewExam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 559);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预约患者列表";
            // 
            // btn_AddNewExam
            // 
            this.btn_AddNewExam.Location = new System.Drawing.Point(568, 18);
            this.btn_AddNewExam.Name = "btn_AddNewExam";
            this.btn_AddNewExam.Size = new System.Drawing.Size(103, 28);
            this.btn_AddNewExam.TabIndex = 9;
            this.btn_AddNewExam.Text = "新增检查";
            this.btn_AddNewExam.UseVisualStyleBackColor = true;
            this.btn_AddNewExam.Click += new System.EventHandler(this.btn_AddNewExam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(668, 446);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超声预约";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_NewAppointment;
        private System.Windows.Forms.ToolStripMenuItem Menu_DataBaseManagement_Top;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddNewExam;
        private System.Windows.Forms.ToolStripMenuItem Menu_ConnectionStringSetting;
        private System.Windows.Forms.ToolStripMenuItem Menu_DataBaseManagement;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
    }
}

