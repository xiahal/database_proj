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

        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

        public studentScoreSearch()
        {
            InitializeComponent();
        }

        public studentScoreSearch(string id)
        {
            InitializeComponent();
            sid = id;
            Display();
        }

        //查询数据
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);//创建-个数据库连接
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

        void Display()
        {
            string scoreAgv;
            int classNum;
            int scoreSum = 0;
            int i;

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
            scoreAgv = ((float)scoreSum / (float)classNum).ToString().Trim();

            classNumberBox.Text = classNum.ToString();
            averageScoreBox.Text = scoreAgv;

        }

    }
}
