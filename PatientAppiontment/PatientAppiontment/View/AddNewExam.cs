using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientAppiontment.View
{
    public partial class AddNewExam : Form
    {
        public AddNewExam()
        {
            InitializeComponent();
        }

        private void btn_Confrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
