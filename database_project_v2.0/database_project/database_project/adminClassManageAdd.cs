﻿using System;
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
    public partial class adminClassManageAdd : Form
    {
        public adminClassManageAdd()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string cid = classNumBox.Text.Trim(); //获取adminClassManageAdd中文本框cid的值,并去除结尾的空字符
            string cname = classNameBox.Text.Trim();
            string tid = teacherBox.Text.Trim();
            string sql = "insert into costea values('" + cid + "','" + tid +  "')";
            adminClassManage.ExecuteSql(sql);
            this.Close();
        }
    }
}
