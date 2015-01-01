using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using PatientAppiontment.Data;

namespace PatientAppiontment.View
{
    public partial class Form_DataBaseManagement : Form
    {
        public Form_DataBaseManagement()
        {
            InitializeComponent();
        }

        private void btn_IsDataBaseExist_Appiontment_Click(object sender, EventArgs e)
        {
            CreateDataBase mnCreateDataBase = new CreateDataBase();
            if (mnCreateDataBase.IsDataBaseExsit())
            {
                lab_DataBaseStatus.Text = @"存在";
            }
        }

        private void Form_DataBaseManagement_Load(object sender, EventArgs e)
        {
            btn_CreateDataBase_Appiontment.Enabled = false;
        }
    }
}
