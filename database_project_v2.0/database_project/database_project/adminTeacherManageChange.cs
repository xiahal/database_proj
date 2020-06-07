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
    public partial class adminTeacherManageChange : Form
    {
        String oldtid;//修改前工号
        public adminTeacherManageChange()
        {
            InitializeComponent();
        }

        public adminTeacherManageChange(string tid, string tname, string temail, string tsalary)
        {
            InitializeComponent();
            teacherNumBox.Text = tid;
            teacherNameBox.Text = tname;
            teacherMailBox.Text = temail;
            teacherSalaryBox.Text = tsalary;
            oldtid = tid.Trim();//获取修改前学号
        }

        //修改数据事件
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string newtid = teacherNumBox.Text.Trim();
            string newtname = teacherNameBox.Text.Trim();
            string newtemail = teacherMailBox.Text.Trim();
            string newtsalary = teacherSalaryBox.Text.Trim();
            string sql = "update teachers set tid='" + newtid + "',tname='" + newtname + "',temail='" + newtemail + "',tsalary='" + newtsalary + "' where tid='" + oldtid + "'";
            adminTeacherManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
