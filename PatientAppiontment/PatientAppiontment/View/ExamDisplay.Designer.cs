namespace PatientAppointment.View
{
    partial class ExamDisplay
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
            this.lab_PatientArchiveCode = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_Confrom = new System.Windows.Forms.Button();
            this.cmb_PatientDoctor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PatientBedNum = new System.Windows.Forms.TextBox();
            this.cmb_PatientFloor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_PatientSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PatientAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PatientName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_PatientArchiveCode);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btn_Confrom);
            this.groupBox1.Controls.Add(this.cmb_PatientDoctor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_PatientBedNum);
            this.groupBox1.Controls.Add(this.cmb_PatientFloor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_PatientSex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PatientAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_PatientName);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // lab_PatientArchiveCode
            // 
            this.lab_PatientArchiveCode.AutoSize = true;
            this.lab_PatientArchiveCode.Location = new System.Drawing.Point(89, 27);
            this.lab_PatientArchiveCode.Name = "lab_PatientArchiveCode";
            this.lab_PatientArchiveCode.Size = new System.Drawing.Size(11, 12);
            this.lab_PatientArchiveCode.TabIndex = 16;
            this.lab_PatientArchiveCode.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 15;
            this.label17.Text = "患者序号：";
            // 
            // btn_Confrom
            // 
            this.btn_Confrom.Location = new System.Drawing.Point(540, 63);
            this.btn_Confrom.Name = "btn_Confrom";
            this.btn_Confrom.Size = new System.Drawing.Size(70, 61);
            this.btn_Confrom.TabIndex = 14;
            this.btn_Confrom.Text = "确定";
            this.btn_Confrom.UseVisualStyleBackColor = true;
            this.btn_Confrom.Click += new System.EventHandler(this.btn_Confrom_Click);
            // 
            // cmb_PatientDoctor
            // 
            this.cmb_PatientDoctor.FormattingEnabled = true;
            this.cmb_PatientDoctor.Location = new System.Drawing.Point(428, 104);
            this.cmb_PatientDoctor.Name = "cmb_PatientDoctor";
            this.cmb_PatientDoctor.Size = new System.Drawing.Size(91, 20);
            this.cmb_PatientDoctor.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "送诊医师：";
            // 
            // txt_PatientBedNum
            // 
            this.txt_PatientBedNum.Location = new System.Drawing.Point(253, 104);
            this.txt_PatientBedNum.Name = "txt_PatientBedNum";
            this.txt_PatientBedNum.Size = new System.Drawing.Size(73, 21);
            this.txt_PatientBedNum.TabIndex = 10;
            // 
            // cmb_PatientFloor
            // 
            this.cmb_PatientFloor.FormattingEnabled = true;
            this.cmb_PatientFloor.Items.AddRange(new object[] {
            "5A",
            "5B",
            "6A",
            "6B",
            "7A",
            "7B",
            "8A",
            "8B",
            "9A",
            "9B",
            "10A",
            "10B",
            "11A",
            "ICU",
            "12A",
            "12B"});
            this.cmb_PatientFloor.Location = new System.Drawing.Point(70, 104);
            this.cmb_PatientFloor.Name = "cmb_PatientFloor";
            this.cmb_PatientFloor.Size = new System.Drawing.Size(94, 20);
            this.cmb_PatientFloor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "床号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "楼层：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "岁";
            // 
            // cmb_PatientSex
            // 
            this.cmb_PatientSex.FormattingEnabled = true;
            this.cmb_PatientSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb_PatientSex.Location = new System.Drawing.Point(253, 63);
            this.cmb_PatientSex.Name = "cmb_PatientSex";
            this.cmb_PatientSex.Size = new System.Drawing.Size(73, 20);
            this.cmb_PatientSex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "年龄：";
            // 
            // txt_PatientAge
            // 
            this.txt_PatientAge.Location = new System.Drawing.Point(415, 63);
            this.txt_PatientAge.Name = "txt_PatientAge";
            this.txt_PatientAge.Size = new System.Drawing.Size(81, 21);
            this.txt_PatientAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // txt_PatientName
            // 
            this.txt_PatientName.Location = new System.Drawing.Point(70, 63);
            this.txt_PatientName.Name = "txt_PatientName";
            this.txt_PatientName.Size = new System.Drawing.Size(94, 21);
            this.txt_PatientName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已预约的检查项目";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(619, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // ExamDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExamDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "检查项目";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_PatientDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PatientBedNum;
        private System.Windows.Forms.ComboBox cmb_PatientFloor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_PatientSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PatientAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PatientName;
        private System.Windows.Forms.Button btn_Confrom;
        private System.Windows.Forms.Label lab_PatientArchiveCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}