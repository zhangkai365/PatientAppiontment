namespace PatientAppointment.View
{
    partial class Form_DataBaseManagement
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
            this.btn_CreateDataBase_Appointment = new System.Windows.Forms.Button();
            this.btn_IsDataBaseExist_Appointment = new System.Windows.Forms.Button();
            this.lab_DataBaseStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_CreateDataBase_Appointment);
            this.groupBox1.Controls.Add(this.btn_IsDataBaseExist_Appointment);
            this.groupBox1.Controls.Add(this.lab_DataBaseStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库管理";
            // 
            // btn_CreateDataBase_Appointment
            // 
            this.btn_CreateDataBase_Appointment.Location = new System.Drawing.Point(147, 157);
            this.btn_CreateDataBase_Appointment.Name = "btn_CreateDataBase_Appointment";
            this.btn_CreateDataBase_Appointment.Size = new System.Drawing.Size(171, 45);
            this.btn_CreateDataBase_Appointment.TabIndex = 3;
            this.btn_CreateDataBase_Appointment.Text = "创建Appointment数据库";
            this.btn_CreateDataBase_Appointment.UseVisualStyleBackColor = true;
            this.btn_CreateDataBase_Appointment.Click += new System.EventHandler(this.btn_CreateDataBase_Appointment_Click);
            // 
            // btn_IsDataBaseExist_Appointment
            // 
            this.btn_IsDataBaseExist_Appointment.Location = new System.Drawing.Point(147, 86);
            this.btn_IsDataBaseExist_Appointment.Name = "btn_IsDataBaseExist_Appointment";
            this.btn_IsDataBaseExist_Appointment.Size = new System.Drawing.Size(171, 45);
            this.btn_IsDataBaseExist_Appointment.TabIndex = 2;
            this.btn_IsDataBaseExist_Appointment.Text = "检测Appointment数据库状态";
            this.btn_IsDataBaseExist_Appointment.UseVisualStyleBackColor = true;
            this.btn_IsDataBaseExist_Appointment.Click += new System.EventHandler(this.btn_IsDataBaseExist_Appointment_Click);
            // 
            // lab_DataBaseStatus
            // 
            this.lab_DataBaseStatus.AutoSize = true;
            this.lab_DataBaseStatus.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_DataBaseStatus.Location = new System.Drawing.Point(197, 28);
            this.lab_DataBaseStatus.Name = "lab_DataBaseStatus";
            this.lab_DataBaseStatus.Size = new System.Drawing.Size(142, 19);
            this.lab_DataBaseStatus.TabIndex = 1;
            this.lab_DataBaseStatus.Text = "数据库状态未知";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "\'预约\'数据库：";
            // 
            // Form_DataBaseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 265);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_DataBaseManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库管理";
            this.Load += new System.EventHandler(this.Form_DataBaseManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CreateDataBase_Appointment;
        private System.Windows.Forms.Button btn_IsDataBaseExist_Appointment;
        private System.Windows.Forms.Label lab_DataBaseStatus;
        private System.Windows.Forms.Label label1;
    }
}