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

    public partial class Student : System.Windows.Forms.Form
    {
        static string stu_sid;
        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static string connectionStringLI = System.Configuration.ConfigurationManager.AppSettings["connectionStringLI"];
        static string connectionString_a = System.Configuration.ConfigurationManager.AppSettings["connectionString_a"];
        static string connectionString_s = System.Configuration.ConfigurationManager.AppSettings["connectionString_s"];
        static string connectionString_t = System.Configuration.ConfigurationManager.AppSettings["connectionString_t"];

        public Student()
        {
            InitializeComponent();
        }
        public Student(string id)
        {
            InitializeComponent();
            stu_sid = id;
            sid.Text = stu_sid;
            Display();
        }

        void Display()
        {
            SqlConnection con = new SqlConnection(connectionString_s);//创建-个数据库连接
            SqlCommand cmd = con.CreateCommand();//执行语句
            cmd.CommandText = "select * from db_students where sid = " + stu_sid;
            try
            {
                con.Open();//打开连接
                SqlDataReader reader = cmd.ExecuteReader();//只读形式形成数据流
                if (reader.Read())
                {
                    String stu_sname = reader.GetString(reader.GetOrdinal("sname"));
                    String stu_semail = reader.GetString(reader.GetOrdinal("semail"));
                    String stu_sgrade = reader.GetString(reader.GetOrdinal("sgrade"));
                    sname.Text = stu_sname;
                    semail.Text = stu_semail;
                    sgrade.Text = stu_sgrade;
                }
            }
            catch (SqlException e)//捕捉异常
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void GradeSearchButton_Click(object sender, EventArgs e)
        {
            studentScoreSearch childrenForm = new studentScoreSearch(stu_sid);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            changePassword childrenForm = new changePassword(stu_sid);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
