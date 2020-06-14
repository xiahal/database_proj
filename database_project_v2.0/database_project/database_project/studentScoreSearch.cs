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
    public partial class studentScoreSearch : Form
    {
        static string sid;

        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static string connectionStringLI = System.Configuration.ConfigurationManager.AppSettings["connectionStringLI"];
        static string connectionString_a = System.Configuration.ConfigurationManager.AppSettings["connectionString_a"];
        static string connectionString_s = System.Configuration.ConfigurationManager.AppSettings["connectionString_s"];
        static string connectionString_t = System.Configuration.ConfigurationManager.AppSettings["connectionString_t"];

        public studentScoreSearch()
        {
            InitializeComponent();
        }

        public studentScoreSearch(string id)
        {
            InitializeComponent();
            sid = id;
            string[] TermBoxSrc =
            new[]{ "1", "2", "3" ,"4","all"};
            this.TermBox.DataSource = TermBoxSrc;
            //Display();
        }

        //查询数据
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString_s);//创建-个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con); //创建DataSet和 SQL Server之间的桥接器,用于对数据库进行操作
            DataSet ds = new DataSet(); // 创建一个数据集
            try
            {
                con.Open(); // 打开连接。
                sda.Fill(ds, "students"); //往窗体里students表中填充数据集ds
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message); // 抛出异常
            }
            finally
            {
                sda.Dispose(); //sda处理 ,以便空间回收
                con.Close(); //连接关闭
            }
        }

        public string setGPA(float score)
        {
            string gpa_0;
            if (score >= 90)
                gpa_0 = "4.0";
            else if (score >= 85)
                gpa_0 = "3.7";
            else if (score >= 81)
                gpa_0 = "3.3";
            else if (score >= 78)
                gpa_0 = "3.0";
            else if (score >= 75)
                gpa_0 = "2.7";
            else if (score >= 72)
                gpa_0 = "2.3";
            else if (score >= 68)
                gpa_0 = "2.0";
            else if (score >= 64)
                gpa_0 = "1.7";
            else if (score >= 60)
                gpa_0 = "1.0";
            else
                gpa_0 = "0";
            return gpa_0;
        }

        void Display()
        {
            
        }

        private void CourseAndScoreQuery_Click(object sender, EventArgs e)
        {
            string cterm = TermBox.Text.Trim();
            string scoreAgv;
            float score;
            string gpa;
            int classNum;
            int scoreSum = 0;
            int i;
            try
            {
                if (cterm == "all" | cterm == "")
                {
                    this.dataGridView1.DataSource = Query("execute sp_StudentQuery_all'" + sid + "'").Tables["students"];

                    classNum = this.dataGridView1.RowCount - 1;
                    for (i = 0; i < this.dataGridView1.RowCount - 1; i++)
                    {
                        if (this.dataGridView1.Rows[i].Cells[4].Value.ToString() == "")
                        {
                            classNum--;
                        }
                        else
                        {
                            scoreSum = scoreSum + int.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString().Trim());
                        }

                    }
                    score = (float)scoreSum / (float)classNum;
                    scoreAgv = (score).ToString().Trim();
                    gpa = setGPA(score).ToString().Trim();

                    classNumberBox.Text = classNum.ToString();
                    averageScoreBox.Text = scoreAgv;
                    GPABox.Text = gpa;
                }
                else if (cterm == "1" | cterm == "2" | cterm == "3" | cterm == "4")
                {
                    this.dataGridView1.DataSource = Query("execute sp_StudentQuery'" + sid + "','" + cterm + "'").Tables["students"];

                    classNum = this.dataGridView1.RowCount - 1;
                    for (i = 0; i < this.dataGridView1.RowCount - 1; i++)
                    {
                        if (this.dataGridView1.Rows[i].Cells[4].Value.ToString() == "")
                        {
                            classNum--;
                        }
                        else
                        {
                            scoreSum = scoreSum + int.Parse(this.dataGridView1.Rows[i].Cells[4].Value.ToString().Trim());
                        }

                    }
                    score = (float)scoreSum / (float)classNum;
                    scoreAgv = (score).ToString().Trim();
                    gpa = setGPA(score).ToString().Trim();

                    classNumberBox.Text = classNum.ToString();
                    averageScoreBox.Text = scoreAgv;
                    GPABox.Text = gpa;
                }
                else
                {
                    MessageBox.Show("None term message!");
                    TermBox.Text = "";
                }
            }


            catch (Exception exce)
            {
                throw new Exception(exce.Message);
            }

        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
