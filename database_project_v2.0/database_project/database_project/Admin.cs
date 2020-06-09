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
    public partial class Admin : Form
    {
        static string adm_id;
        static string adm_name;
        static string adm_email;
        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = ConfigurationManager.AppSettings["connectionString"];

        public Admin()
        {
            InitializeComponent();
        }

        //初始化管理员登录信息
        public Admin(string id)
        {
            InitializeComponent();
            adm_id = id;
            aid.Text = adm_id;
            Display();
        }

        void Display()
        {
            SqlConnection con = new SqlConnection(connectionString);//创建一个数据库连接
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from admins where aid= '" + adm_id + "'";
            // SqlDataAdapter sda = new SqlDataAdapter(sql, con);//创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();//创建一个数据集（数据缓存）
            try
            {
                con.Open();//打开连接
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    adm_name = reader.GetString(reader.GetOrdinal("aname"));
                    adm_email = reader.GetString(reader.GetOrdinal("aemail"));
                    aname.Text = adm_name;
                    aemail.Text = adm_email;
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

        private void ClassManageButton_Click(object sender, EventArgs e)
        {
            adminClassManage childrenForm = new adminClassManage();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void TeacherManageButton_Click(object sender, EventArgs e)
        {
            adminTeacherManage childrenForm = new adminTeacherManage();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ChooseManageButton_Click(object sender, EventArgs e)
        {
            adminScManage childrenForm = new adminScManage();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void StudentManageButton_Click(object sender, EventArgs e)
        {
            adminStudentManage childrenForm = new adminStudentManage();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            changePassword childrenForm = new changePassword(adm_id);
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
