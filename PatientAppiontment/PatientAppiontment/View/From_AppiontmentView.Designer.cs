namespace PatientAppointment.View
{
    partial class From_AppiontmentView
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
            this.btn_NewPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewPatient
            // 
            this.btn_NewPatient.Location = new System.Drawing.Point(482, 28);
            this.btn_NewPatient.Name = "btn_NewPatient";
            this.btn_NewPatient.Size = new System.Drawing.Size(117, 26);
            this.btn_NewPatient.TabIndex = 0;
            this.btn_NewPatient.Text = "增加新被检者";
            this.btn_NewPatient.UseVisualStyleBackColor = true;
            // 
            // From_AppiontmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 561);
            this.Controls.Add(this.btn_NewPatient);
            this.Name = "From_AppiontmentView";
            this.Text = "From_AppiontmentView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewPatient;
    }
}