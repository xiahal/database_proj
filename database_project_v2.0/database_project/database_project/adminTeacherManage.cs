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
    public partial class adminTeacherManage : Form
    {
        //从app. config配置文件中读取key-connectionString字段的value
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        static string connectionStringLI = System.Configuration.ConfigurationManager.AppSettings["connectionStringLI"];
        static string connectionString_a = System.Configuration.ConfigurationManager.AppSettings["connectionString_a"];
        static string connectionString_s = System.Configuration.ConfigurationManager.AppSettings["connectionString_s"];
        static string connectionString_t = System.Configuration.ConfigurationManager.AppSettings["connectionString_t"];

        public adminTeacherManage()
        {
            InitializeComponent();
        }

        //查询数据
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString_a);//创建-个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con); //创建DataSet和 SQL Server之间的桥接器,用于对数据库进行操作
            DataSet ds = new DataSet(); // 创建一个数据集
            try
            {
                con.Open(); // 打开连接。
                sda.Fill(ds, "teachers"); //往窗体里students表中填充数据集ds
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

        //增删改数据.
        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString_a); //创建一 个数据库连接
            SqlCommand cmd = new SqlCommand(sql, con); //创建- 个SqlCommand ,用于对数据库进行操作
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();//rows接受sq1执行后返回的行数
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose(); //对Sq1Command进行处理 ,回收
                con.Close(); //连接关闭
            }
        }

        //查询数据事件
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string tname = teacherNameBox.Text.Trim();
            string tid = teacherNumBox.Text.Trim();
            string tsalary = teacherSalaryBox.Text.Trim();
            
            this.studentDataGrid.DataSource = Query("select * from teachers where tid like '%" + tid + "%' and tname like '%" + tname + "%' and tsalary like '%" + tsalary + "%'").Tables["teachers"];

        }

        //删除数据事件
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int a = studentDataGrid.CurrentRow.Index; //获取当前选中行
            string tid = studentDataGrid.Rows[a].Cells[0].Value.ToString().Trim(); //获取该行的第0列数据
            //MessageBox. Show(sid);
            string sql = "delete from TEACHERS where tid='" + tid + "'";
            if (ExecuteSql(sql) > 0)
                MessageBox.Show("删除成功");
            else
                MessageBox.Show("删除失败");
        }

        //添加数据事件
        private void AddButton_Click(object sender, EventArgs e)
        {
            //弹出子窗体childrenForm(adminTeacherManageAdd)
            adminTeacherManageAdd childrenForm = new adminTeacherManageAdd();
            childrenForm.Owner = this;
            childrenForm.Show();
        }

        //修改数据事件
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //获取当前选中行(记录)             
            int a = studentDataGrid.CurrentRow.Index;
            //获取该行各列数据(各字段值)             
            string tid = studentDataGrid.Rows[a].Cells[0].Value.ToString().Trim();
            string tname = studentDataGrid.Rows[a].Cells[1].Value.ToString().Trim();
            string temail = studentDataGrid.Rows[a].Cells[2].Value.ToString().Trim();
            string tsalary = studentDataGrid.Rows[a].Cells[3].Value.ToString().Trim();
            //弹出子窗体Form_update(adminTeacherManageChange)，把上面四行获取的各字段值传入子窗体             
            adminTeacherManageChange subForm = new adminTeacherManageChange(tid, tname, temail, tsalary);
            subForm.Owner = this;
            subForm.Show();
        }
    }
}
