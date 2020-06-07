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
    public partial class Teacher : System.Windows.Forms.Form
    {
        static string tch_tid;
        string tch_tname;
        string tch_temail;
        int tch_tsalary;

        //从app.config配置文件读取key=connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Teacher()
        {
            InitializeComponent();
        }
        public Teacher(string uid)
        {
            InitializeComponent();
            tch_tid = uid;
                    tid.Text = tch_tid;
            Display();
        }

        void Display()
        {
            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from teachers where tid= " + tch_tid;
            try
            {
                con.Open();//打开连接
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tch_tname = reader.GetString(reader.GetOrdinal("tname"));
                    tch_temail = reader.GetString(reader.GetOrdinal("temail"));
                    tch_tsalary = reader.GetInt32(reader.GetOrdinal("tsalary"));
                    tname.Text = tch_tname;
                    temail.Text = tch_temail;
                    tsalary.Text = tch_tsalary.ToString();

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);//抛出异常
            }
            finally
            {
                cmd.Dispose();//sda处理，以便空间回收
                con.Close();//连接关闭
            }

        }

        private void gradeInput_Click(object sender, EventArgs e)
        {
            teacherScoreInput childrenForm = new teacherScoreInput(tch_tid);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void studentSearch_Click(object sender, EventArgs e)
        {
            teacherStudentSearch childrenForm = new teacherStudentSearch();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            changePassword childrenForm = new changePassword(tch_tid);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
