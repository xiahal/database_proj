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
    public partial class changePassword : Form
    {
        static string id;

        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        
        public changePassword()
        {
            InitializeComponent();
        }

        public changePassword(string idnum)
        {
            InitializeComponent();
            id = idnum;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool act = false;
            string oglpwd = originalPasswordBox.Text.Trim();
            string nwpwd = newPasswardBox.Text.Trim();
            string cfmpwd = confirmPasswordBox.Text.Trim();

            SqlConnection con_slc = new SqlConnection(connectionString);//创建一个数据库连接
            string sql_slc = "select * from users where uid=" + id + " and upasswd=" + oglpwd;
            SqlCommand cmd_slc = new SqlCommand(sql_slc, con_slc);//创建一个SqlCommand，用于对数据库进行操作  

            try
            {
                con_slc.Open();
                SqlDataReader reader = cmd_slc.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("your ORIGINAL password is incorrect! Try AGAIN.");
                    originalPasswordBox.Text = "";
                    newPasswardBox.Text = "";
                    confirmPasswordBox.Text = "";
                }
                else
                {
                    if (nwpwd == "")
                    {
                        MessageBox.Show("error: NEW password is NULL!");
                        confirmPasswordBox.Text = "";
                    }
                    else if (cfmpwd == "")
                    {
                        MessageBox.Show("error: enter CONFIRM password again!");
                    }
                    else if (string.Compare(nwpwd, cfmpwd) != 0)
                    {
                        MessageBox.Show("error: the two passwords do NOT match!");
                        newPasswardBox.Text = "";
                        confirmPasswordBox.Text = "";
                    }
                    else act = true;
                }
                if (act)
                {
                    string sql_upd = "update users set upasswd = '" + nwpwd + "' where uid = " + id;
                    SqlConnection con_upd = new SqlConnection(connectionString);//创建一个数据库连接
                    SqlCommand cmd_upd = new SqlCommand(sql_upd, con_upd);//创建一个SqlCommand，用于对数据库进行操作

                    try
                    {
                        con_upd.Open();
                        int rows = cmd_upd.ExecuteNonQuery();//rows接受sql执行后返回的行数
                        if (rows == 0)
                            MessageBox.Show("change password FAILURE!");
                        else
                            MessageBox.Show("change password SUCCESS!");
                    }
                    catch (SqlException e1)
                    {
                        MessageBox.Show(e1.Message + "\nchange password failed.");
                        throw new Exception(e1.Message);
                    }
                    finally
                    {
                        cmd_upd.Dispose();//对SqlCommand进行处理，回收
                        con_upd.Close();//连接关闭
                    }
                    this.Close();
                }
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                cmd_slc.Dispose();//cmd处理，以便空间回收
                con_slc.Close();//连接关闭
            }
        }

        private void Conceal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
