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
    
    public partial class Login : System.Windows.Forms.Form
    {
        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void StudentLoginButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text.Trim() == "")
                MessageBox.Show("please enter ID!");
            if (passwordBox.Text.Trim() == "")
                MessageBox.Show("please enter password!");
            else
            {
                string id = idBox.Text.Trim();
                string pwd = passwordBox.Text.Trim();
                string sql;
                SqlConnection con = new SqlConnection(connectionString);//创建-个数据库连接
                if (id[0] != '1')
                {
                    MessageBox.Show("Your ID is invalid! Try AGAIN.");
                    passwordBox.Text = "";
                    idBox.Text = "";
                }
                else
                {
                    sql = "select * from users where uid = " + id + " and upasswd = " + pwd + " and ugroup = 1";

                    SqlCommand cmd = new SqlCommand(sql, con); //执行语句
                    try
                    {
                        con.Open();//打开连接
                        SqlDataReader reader = cmd.ExecuteReader();//只读形式形成数据流
                        if (!reader.Read())//数据为空
                        {
                            MessageBox.Show("Your ID is unknown or your PASSWORD is incorrect! Try AGAIN.");
                            passwordBox.Text = "";
                            idBox.Text = "";
                        }
                        else
                        {
                                Admin childrenForm = new Admin();
                                childrenForm.Owner = this;
                                childrenForm.Show();
                        }
                    }
                    catch (SqlException e1)//抛出异常
                    {
                        MessageBox.Show(e1.Message);
                    }
                    finally
                    {
                        cmd.Dispose();//cmd处理 以便空间回收
                        con.Close();//连接关闭
                    }
                }
            }
        }

        private void TeacherLoginButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text.Trim() == "")
                MessageBox.Show("please enter ID!");
            if (passwordBox.Text.Trim() == "")
                MessageBox.Show("please enter password!");
            else
            {
                string id = idBox.Text.Trim();
                string pwd = passwordBox.Text.Trim();
                string sql;
                SqlConnection con = new SqlConnection(connectionString);//创建-个数据库连接
                if (id[0] != '2')
                {
                    MessageBox.Show("Your ID is invalid! Try AGAIN.");
                    passwordBox.Text = "";
                    idBox.Text = "";
                }
                else
                {
                    sql = "select * from users where uid = " + id + " and upasswd = " + pwd + " and ugroup = 2";

                    SqlCommand cmd = new SqlCommand(sql, con); //执行语句
                    try
                    {
                        con.Open();//打开连接
                        SqlDataReader reader = cmd.ExecuteReader();//只读形式形成数据流
                        if (!reader.Read())//数据为空
                        {
                            MessageBox.Show("Your ID is unknown or your PASSWORD is incorrect! Try AGAIN.");
                            passwordBox.Text = "";
                            idBox.Text = "";
                        }
                        else
                        {
                                Teacher childrenForm = new Teacher();
                                childrenForm.Owner = this;
                                childrenForm.Show();                            
                        }
                    }
                    catch (SqlException e1)//抛出异常
                    {
                        MessageBox.Show(e1.Message);
                    }
                    finally
                    {
                        cmd.Dispose();//cmd处理 以便空间回收
                        con.Close();//连接关闭
                    }
                }
            }
        }

        private void ManagerLoginButton_Click(object sender, EventArgs e)
        {


            if (idBox.Text.Trim() == "")
                MessageBox.Show("please enter ID!");
            if (passwordBox.Text.Trim() == "")
                MessageBox.Show("please enter password!");
            else
            {
                string id = idBox.Text.Trim();
                string pwd = passwordBox.Text.Trim();
                string sql;
                SqlConnection con = new SqlConnection(connectionString);//创建-个数据库连接
                if (id[0] != '3')
                {
                    MessageBox.Show("Your ID is invalid! Try AGAIN.");
                    passwordBox.Text = "";
                    idBox.Text = "";
                }
                else
                {
                    sql = "select * from users where uid = " + id + " and upasswd = " + pwd + " and ugroup = 3";

                    SqlCommand cmd = new SqlCommand(sql, con); //执行语句
                    try
                    {
                        con.Open();//打开连接
                        SqlDataReader reader = cmd.ExecuteReader();//只读形式形成数据流
                        if (!reader.Read())//数据为空
                        {
                            MessageBox.Show("Your ID is unknown or your PASSWORD is incorrect! Try AGAIN.");
                            passwordBox.Text = "";
                            idBox.Text = "";
                        }
                        else
                        {
                                Student childrenForm = new Student();
                                childrenForm.Owner = this;
                                childrenForm.Show();                            
                        }
                    }
                    catch (SqlException e1)//抛出异常
                    {
                        MessageBox.Show(e1.Message);
                    }
                    finally
                    {
                        cmd.Dispose();//cmd处理 以便空间回收
                        con.Close();//连接关闭
                    }
                }
            }
        }
    }
}
