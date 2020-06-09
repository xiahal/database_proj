using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace database_project
{
    public partial class adminStudentManageAdd : Form
    {
        public adminStudentManageAdd()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string sid = studentNumBox.Text.Trim(); //获取Form2中文本框txt_ add_ sid的值,并去除结尾的空字符
            string sname = studentNameBox.Text.Trim();
            string semail = studentMailBox.Text.Trim();
            string sgrade = studentGradeBox.Text.Trim();
            string sql = "insert into STUDENTS values('" + sid + "','" + sname + "','" + semail + "','" + sgrade + "')";
            adminStudentManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
