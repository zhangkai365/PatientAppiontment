using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//include
using PatientAppointment.TestUnit;

namespace PatientAppointment.View
{
    public partial class Form_TestUnit : Form
    {
        public Form_TestUnit()
        {
            InitializeComponent();
        }

        private void Btn_PatientRecords_Create_Click(object sender, EventArgs e)
        {
            TestPatientRecords mnTestPatientRecords = new TestPatientRecords();
            mnTestPatientRecords.TestCreate();
        }

        private void Btn_PatientRecords_UpDate_Click(object sender, EventArgs e)
        {
            TestPatientRecords mnTestPatientRecords = new TestPatientRecords();
            mnTestPatientRecords.TestUpDate();
        }

        private void Btn_PatientRecords_Delete_Click(object sender, EventArgs e)
        {
            TestPatientRecords mnTestPatientRecords = new TestPatientRecords();
            mnTestPatientRecords.TestDelete();
        }

        private void Btn_PatientCheck_Create_Click(object sender, EventArgs e)
        {
            TestPatientCheck mnTestPatientCheck = new TestPatientCheck();
            mnTestPatientCheck.TestCreate();
        }



    }
}
