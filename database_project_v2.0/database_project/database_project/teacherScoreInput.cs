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
    public partial class teacherScoreInput : System.Windows.Forms.Form
    {
        static string tid;

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static string connectionStringLI = System.Configuration.ConfigurationManager.AppSettings["connectionStringLI"];
        static string connectionString_a = System.Configuration.ConfigurationManager.AppSettings["connectionString_a"];
        static string connectionString_s = System.Configuration.ConfigurationManager.AppSettings["connectionString_s"];
        static string connectionString_t = System.Configuration.ConfigurationManager.AppSettings["connectionString_t"];

        public teacherScoreInput()
        {
            InitializeComponent();
        }

        public teacherScoreInput(string id)
        {
            InitializeComponent();
            tid = id;
            int rows = 0;
            string sql_getcid = "select cid from db_choices,db_teachers where db_teachers.tid=db_choices.tid and db_teachers.tid = '" + tid + "'";
            SqlConnection con_getcid = new SqlConnection(connectionString_t);    //创建一个数据库连接
            SqlCommand cmd_getcid = new SqlCommand(sql_getcid, con_getcid);                      //创建SqlCommand用于对数据库进行操作
            try
            {
                con_getcid.Open();
                rows = cmd_getcid.ExecuteNonQuery();        //rows接受sql执行后返回的行数                
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);             
            }
            finally
            {
                cmd_getcid.Dispose();
                con_getcid.Close();
            }

            if (rows != 0)
            {
                SqlDataAdapter sda_getcid = new SqlDataAdapter(sql_getcid, con_getcid);          //创建DataSet和SQL Server之间的桥接器，用于对数据库进行操作
                DataSet ds = new DataSet();                                 //创建一个数据集
                try
                {
                    con_getcid.Open();                 //打开连接
                    sda_getcid.Fill(ds, "teachers");                    
                }
                catch (SqlException e_getcid)
                {
                    MessageBox.Show(e_getcid.Message);     //抛出异常                 
                }
                finally
                {
                    sda_getcid.Dispose();      //sda处理，以便空间回收
                    con_getcid.Close();        //连接关闭
                }
                this.classIdBox.DataSource = ds.Tables["teachers"];
                classIdBox.DisplayMember = "cid";
            }
        }
        

        private void confirmInput_Click(object sender, EventArgs e)
        {
            string ipt_cid = classIdBox.Text;
            string ipt_sid = studentIdBox.Text;
            string ipt_score = studentScoreBox.Text;

            if (ipt_cid == "")
            {
                MessageBox.Show("error: please enter courseID!");
            }
            if (ipt_sid == "")
            {
                MessageBox.Show("error: please enter studentID!");
            }
            if (ipt_score == "")
            {
                MessageBox.Show("error: please enter score!");
            }
            else
            {
                string sql_upd = "insert into choices VALUES(  '" + ipt_sid + "','" + tid + "' ,'" + ipt_cid + "'," + ipt_score + ")";
                SqlConnection con_upd = new SqlConnection(connectionString_t);    //创建一个数据库连接
                SqlCommand cmd_upd = new SqlCommand(sql_upd, con_upd);                      //创建SqlCommand用于对数据库进行操作
                try
                {
                    con_upd.Open();
                    int rows = cmd_upd.ExecuteNonQuery();        //rows接受sql执行后返回的行数
                    if (rows != 0)
                    {
                        MessageBox.Show("insert SUCCESS!");
                        classIdBox.Text = "";
                        studentIdBox.Text = "";
                        studentScoreBox.Text = "";
                        lastClassIdBox.Text = ipt_cid;
                        lastStudentIdBox.Text = ipt_sid;
                        lastStudentScoreBox.Text = ipt_score;
                    }
                    else
                    {
                        MessageBox.Show("insert FAILURE!");
                        classIdBox.Text = "";
                        studentIdBox.Text = "";
                        studentScoreBox.Text = "";
                    }
                }
                catch (SqlException e_upd)
                {
                    MessageBox.Show(e_upd.Message);
                }
                finally
                {
                    cmd_upd.Dispose();
                    con_upd.Close();
                }
            }
        }
    }
}
