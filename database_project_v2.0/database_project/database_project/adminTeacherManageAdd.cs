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
    public partial class adminTeacherManageAdd : Form
    {
        public adminTeacherManageAdd()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string newtid = teacherNumBox.Text.Trim();
            string newtname = teacherNameBox.Text.Trim();
            string newtemail = teacherMailBox.Text.Trim();
            string newtsalary = teacherSalaryBox.Text.Trim();
            string sql = "insert into TEACHERS values('" + newtid + "','" + newtname + "','" + newtemail + "','" + newtsalary + "')";
            adminTeacherManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
