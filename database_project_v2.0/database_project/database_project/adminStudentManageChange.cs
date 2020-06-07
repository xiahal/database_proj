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
    public partial class adminStudentManageChange : Form
    {
        String oldsid;//修改前学号
        public adminStudentManageChange()
        {
            InitializeComponent();
        }
        public adminStudentManageChange(string sid, string sname, string semail, string sgrade)
        {
            InitializeComponent();
            studentNumBox.Text = sid;
            studentNameBox.Text = sname;
            studentMailBox.Text = semail;
            studentGradeBox.Text = sgrade;
            oldsid = sid.Trim();//获取修改前学号
        }

        //修改数据事件
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string newsid = studentNumBox.Text.Trim();
            string sname = studentNameBox.Text.Trim();
            string semail = studentMailBox.Text.Trim();
            string sgrade = studentGradeBox.Text.Trim();
            string sql = "update STUDENTS set sid='" + newsid + "',sname='" + sname + "',semail='" + semail + "',sgrade='" + sgrade + "' where sid='" + oldsid + "'";
            adminStudentManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
