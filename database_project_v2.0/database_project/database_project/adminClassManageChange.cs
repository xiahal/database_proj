using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace database_project
{
    public partial class adminClassManageChange : Form
    {
        String oldcid;//修改课程号
        String oldtid;
        public adminClassManageChange()
        {
            InitializeComponent();
        }
        public adminClassManageChange(string cid, string cname, string tid)
        {
            InitializeComponent();
            classNumBox.Text = cid;
            teacherBox.Text = tid;
            classNameBox.Text = cname;

            oldcid = cid.Trim();//获取修改前学号
            oldtid = tid.Trim();
        }

        //修改数据事件
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string newcid = classNumBox.Text.Trim();
            string newtid = teacherBox.Text.Trim();
            string sql = "update costea set cid='" + newcid + "',tid='" + newtid + "' where cid='" + oldcid + "' and tid='" + oldtid + "'";
            adminClassManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
