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
    public partial class teacherStudentSearch : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static string connectionStringLI = System.Configuration.ConfigurationManager.AppSettings["connectionStringLI"];
        static string connectionString_a = System.Configuration.ConfigurationManager.AppSettings["connectionString_a"];
        static string connectionString_s = System.Configuration.ConfigurationManager.AppSettings["connectionString_s"];
        static string connectionString_t = System.Configuration.ConfigurationManager.AppSettings["connectionString_t"];

        public teacherStudentSearch()
        {
            InitializeComponent();
        }

        public static DataSet Query(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString_t);//创建一个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);//创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
            DataSet ds = new DataSet();//创建一个数据集（数据缓存）
            try
            {
                con.Open();//打开连接
                sda.Fill(ds, "choices");//把数据源表students执行SQL命令sql的改动同步到数据缓存ds
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);//抛出异常
            }
            finally
            {
                sda.Dispose();//sda处理，以便空间回收
                con.Close();//连接关闭
            }
        }

        private void StudentSearchButton_Click(object sender, EventArgs e)
        {
            string sid = this.studentIdBox.Text;
            string cid = this.classIdBox.Text;
            if (sid.Length != 0 && cid.Length != 0)
            {
                //调用存储过程
                this.dataGridView.DataSource = Query("execute sp_TeacherQuery_with_cid_sid_all '" + sid + "','" + cid + "'").Tables["choices"];
            
                SqlConnection con = new SqlConnection(connectionString_t);//创建一个数据库连接
                SqlCommand cmd = con.CreateCommand();
                //调用存储过程
                string sql = "execute sp_TeacherQuery_with_cid_sid'" + sid + "','" + cid + "'";
                cmd.CommandText = sql;
                try
                {
                    con.Open();//打开连接
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string choicenum = reader.GetString(reader.GetOrdinal("choicenum"));
                        string avgscore = reader.GetString(reader.GetOrdinal("avgscore"));
                        classNumberBox.Text = choicenum;
                        averageScoreBox.Text = avgscore;
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);//抛出异常
                }
                finally
                {
                    cmd.Dispose();//sda处理，以便空间回收
                    con.Close();//连接关闭
                }
            }
            else if (sid.Length == 0 && cid.Length != 0)
            {
                this.dataGridView.DataSource = Query("execute sp_TeacherQuery_with_cid_all '" + cid + "'").Tables["choices"];

                SqlConnection con = new SqlConnection(connectionString_t);//创建一个数据库连接
                SqlCommand cmd = con.CreateCommand();
                string sql = "execute sp_TeacherQuery_with_cid '" + cid + "'";
                cmd.CommandText = sql;
                try
                {
                    con.Open();//打开连接
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string choicenum = reader.GetString(reader.GetOrdinal("choicenum"));
                        string avgscore = reader.GetString(reader.GetOrdinal("avgscore"));
                        classNumberBox.Text = choicenum;
                        averageScoreBox.Text = avgscore;
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);//抛出异常
                }
                finally
                {
                    cmd.Dispose();//sda处理，以便空间回收
                    con.Close();//连接关闭
                }
            }
            else if (sid.Length != 0 && cid.Length == 0)
            {
                this.dataGridView.DataSource = Query("execute sp_TeacherQuery_with_sid_all '" + sid + "'").Tables["choices"];

                SqlConnection con = new SqlConnection(connectionString_t);//创建一个数据库连接
                SqlCommand cmd = con.CreateCommand();
                string sql = "execute sp_TeacherQuery_with_sid '" + sid + "'";
                cmd.CommandText = sql;
                try
                {
                    con.Open();//打开连接
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string choicenum = reader.GetString(reader.GetOrdinal("choicenum"));
                        string avgscore = reader.GetString(reader.GetOrdinal("avgscore"));
                        classNumberBox.Text = choicenum;
                        averageScoreBox.Text = avgscore;
                    }
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.Message);//抛出异常
                }
                finally
                {
                    cmd.Dispose();//sda处理，以便空间回收
                    con.Close();//连接关闭
                }
            }
            else if (sid.Length == 0 && cid.Length == 0)
            {
                MessageBox.Show("enter courseID or studentID!", "warning");

            }

        }
    }
}
