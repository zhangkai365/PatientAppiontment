namespace PatientAppointment.View
{
    partial class Form_TestUnit
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
            this.Btn_PatientRecords_Delete = new System.Windows.Forms.Button();
            this.Btn_PatientRecords_UpDate = new System.Windows.Forms.Button();
            this.Btn_PatientRecords_Create = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_PatientCheck_Delete = new System.Windows.Forms.Button();
            this.Btn_PatientCheck_Update = new System.Windows.Forms.Button();
            this.Btn_PatientCheck_Create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_PatientRecords_Delete);
            this.groupBox1.Controls.Add(this.Btn_PatientRecords_UpDate);
            this.groupBox1.Controls.Add(this.Btn_PatientRecords_Create);
            this.groupBox1.Location = new System.Drawing.Point(47, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test-PatientRecords";
            // 
            // Btn_PatientRecords_Delete
            // 
            this.Btn_PatientRecords_Delete.Location = new System.Drawing.Point(310, 25);
            this.Btn_PatientRecords_Delete.Name = "Btn_PatientRecords_Delete";
            this.Btn_PatientRecords_Delete.Size = new System.Drawing.Size(80, 27);
            this.Btn_PatientRecords_Delete.TabIndex = 2;
            this.Btn_PatientRecords_Delete.Text = "Delete";
            this.Btn_PatientRecords_Delete.UseVisualStyleBackColor = true;
            this.Btn_PatientRecords_Delete.Click += new System.EventHandler(this.Btn_PatientRecords_Delete_Click);
            // 
            // Btn_PatientRecords_UpDate
            // 
            this.Btn_PatientRecords_UpDate.Location = new System.Drawing.Point(168, 25);
            this.Btn_PatientRecords_UpDate.Name = "Btn_PatientRecords_UpDate";
            this.Btn_PatientRecords_UpDate.Size = new System.Drawing.Size(80, 27);
            this.Btn_PatientRecords_UpDate.TabIndex = 1;
            this.Btn_PatientRecords_UpDate.Text = "UpDate";
            this.Btn_PatientRecords_UpDate.UseVisualStyleBackColor = true;
            this.Btn_PatientRecords_UpDate.Click += new System.EventHandler(this.Btn_PatientRecords_UpDate_Click);
            // 
            // Btn_PatientRecords_Create
            // 
            this.Btn_PatientRecords_Create.Location = new System.Drawing.Point(26, 25);
            this.Btn_PatientRecords_Create.Name = "Btn_PatientRecords_Create";
            this.Btn_PatientRecords_Create.Size = new System.Drawing.Size(80, 27);
            this.Btn_PatientRecords_Create.TabIndex = 0;
            this.Btn_PatientRecords_Create.Text = "Create";
            this.Btn_PatientRecords_Create.UseVisualStyleBackColor = true;
            this.Btn_PatientRecords_Create.Click += new System.EventHandler(this.Btn_PatientRecords_Create_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_PatientCheck_Delete);
            this.groupBox2.Controls.Add(this.Btn_PatientCheck_Update);
            this.groupBox2.Controls.Add(this.Btn_PatientCheck_Create);
            this.groupBox2.Location = new System.Drawing.Point(51, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test-PatientCheck";
            // 
            // Btn_PatientCheck_Delete
            // 
            this.Btn_PatientCheck_Delete.Location = new System.Drawing.Point(300, 32);
            this.Btn_PatientCheck_Delete.Name = "Btn_PatientCheck_Delete";
            this.Btn_PatientCheck_Delete.Size = new System.Drawing.Size(73, 29);
            this.Btn_PatientCheck_Delete.TabIndex = 2;
            this.Btn_PatientCheck_Delete.Text = "Delete";
            this.Btn_PatientCheck_Delete.UseVisualStyleBackColor = true;
            // 
            // Btn_PatientCheck_Update
            // 
            this.Btn_PatientCheck_Update.Location = new System.Drawing.Point(161, 32);
            this.Btn_PatientCheck_Update.Name = "Btn_PatientCheck_Update";
            this.Btn_PatientCheck_Update.Size = new System.Drawing.Size(73, 29);
            this.Btn_PatientCheck_Update.TabIndex = 1;
            this.Btn_PatientCheck_Update.Text = "Update";
            this.Btn_PatientCheck_Update.UseVisualStyleBackColor = true;
            // 
            // Btn_PatientCheck_Create
            // 
            this.Btn_PatientCheck_Create.Location = new System.Drawing.Point(22, 32);
            this.Btn_PatientCheck_Create.Name = "Btn_PatientCheck_Create";
            this.Btn_PatientCheck_Create.Size = new System.Drawing.Size(73, 29);
            this.Btn_PatientCheck_Create.TabIndex = 0;
            this.Btn_PatientCheck_Create.Text = "Create";
            this.Btn_PatientCheck_Create.UseVisualStyleBackColor = true;
            this.Btn_PatientCheck_Create.Click += new System.EventHandler(this.Btn_PatientCheck_Create_Click);
            // 
            // Form_TestUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_TestUnit";
            this.Text = "Form_TestUnit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_PatientRecords_Delete;
        private System.Windows.Forms.Button Btn_PatientRecords_UpDate;
        private System.Windows.Forms.Button Btn_PatientRecords_Create;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_PatientCheck_Delete;
        private System.Windows.Forms.Button Btn_PatientCheck_Update;
        private System.Windows.Forms.Button Btn_PatientCheck_Create;
    }
}