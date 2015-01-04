using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Project Include
using PatientAppiontment.Common;

namespace PatientAppiontment.View
{
    public partial class ExamDisplay : Form
    {
        /// <summary>
        /// 视窗的显示模式
        /// </summary>
        private ViewType _viewType = ViewType.Initial;

        public ExamDisplay(ViewType mnViewType)
        {
            InitializeComponent();
            _viewType = mnViewType; 
        }

        private void btn_Confrom_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
 
            }
        }

        /// <summary>
        /// 检查输入
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            return true;
        }

        /// <summary>
        /// 窗体加载时候的初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamDisplay_Load(object sender, EventArgs e)
        {

        }


    }
}
