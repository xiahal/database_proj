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
    public partial class adminClassManageAdd : Form
    {
        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static string connectionStringLI = System.Configuration.ConfigurationManager.AppSettings["connectionStringLI"];
        static string connectionString_a = System.Configuration.ConfigurationManager.AppSettings["connectionString_a"];
        static string connectionString_s = System.Configuration.ConfigurationManager.AppSettings["connectionString_s"];
        static string connectionString_t = System.Configuration.ConfigurationManager.AppSettings["connectionString_t"];

        bool check1 = false;
        bool check2 = false;
        public adminClassManageAdd()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(check1 &&check2)
            {
                check1 = false;
                check2 = false;
                string cid = classNumBox.Text.Trim(); //获取adminClassManageAdd中文本框cid的值,并去除结尾的空字符

                string tid = teaNumBox.Text.Trim();
                string sql = "insert into costea values('" + cid + "','" + tid + "')";


                SqlConnection con = new SqlConnection(connectionString_a); //创建一 个数据库连接
                SqlCommand cmd = new SqlCommand(sql, con); //创建- 个SqlCommand ,用于对数据库进行操作
                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();//rows接受sq1执行后返回的行数
                }
                catch (SqlException e_add)
                {
                    throw new Exception(e_add.Message);
                }
                finally
                {
                    cmd.Dispose(); //对Sq1Command进行处理 ,回收
                    con.Close(); //连接关闭
                }
                MessageBox.Show("insert SUCCESS!");

                this.Close();
            }
            else
            {
                MessageBox.Show("please check CORRECT message!");
                check1 = false;
                check2 = false;
            }
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            string cname = classNameBox.Text.Trim();
            string tname = teacherBox.Text.Trim();
            string cid = classNumBox.Text.Trim(); //获取adminClassManageAdd中文本框cid的值,并去除结尾的空字符

            string tid = teaNumBox.Text.Trim();
            SqlConnection con = new SqlConnection(connectionString_a);//创建一个数据库连接
            SqlCommand cmd1 = con.CreateCommand();
            SqlCommand cmd2 = con.CreateCommand();
            string sql1 = "select cname from courses where cid='" + cid + "'";
            string sql2 = "select tname from teachers where tid='" + tid + "'";
            cmd1.CommandText = sql1;
            cmd2.CommandText = sql2;
            try
            {
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    string getcname = reader.GetString(reader.GetOrdinal("cname"));
                    classNameBox.Text = getcname.ToString().Trim();
                    check1 = true;
                }
                else
                    MessageBox.Show("WRONG course name!");
            }
            catch (SqlException e_add)
            {
                throw new Exception(e_add.Message);
            }
            finally
            {
                cmd1.Dispose(); //对Sq1Command进行处理 ,回收
                con.Close(); //连接关闭
            }
            try
            {
                con.Open();
                SqlDataReader reader = cmd2.ExecuteReader();
                if (reader.Read())
                {
                    string gettname = reader.GetString(reader.GetOrdinal("tname"));
                    teacherBox.Text = gettname.ToString().Trim();
                    check2 = true;
                }
                else
                    MessageBox.Show("WRONG teacher name!");
            }
            catch (SqlException e_add)
            {
                throw new Exception(e_add.Message);
            }
            finally
            {
                cmd2.Dispose();
                con.Close(); //连接关闭
            }


        }
    }
}
