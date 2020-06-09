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
    public partial class adminScManageChange : Form
    {
        String oldsid;//修改前学号
        String oldcid;
        public adminScManageChange()
        {
            InitializeComponent();
        }

        public adminScManageChange(string sid, string cid, string cscore)
        {
            InitializeComponent();
            studentNumBox.Text = sid;
            classNumBox.Text = cid;
            gradeBox.Text = cscore;
            oldsid = sid.Trim();//获取修改前学号
            oldcid = cid.Trim();
        }

        //修改数据事件
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string newsid = studentNumBox.Text.Trim();
            string newcid = classNumBox.Text.Trim();
            string newcscore = gradeBox.Text.Trim();
            string sql = "update choices set sid='" + newsid + "',cid='" + newcid + "',score='" + newcscore + "' where sid='" + oldsid + "' and cid='" + oldcid + "'";
            adminScManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
