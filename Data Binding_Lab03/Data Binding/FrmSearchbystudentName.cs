using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Binding
{
    public partial class FrmSearchbystudentName : Form
    {
        public FrmSearchbystudentName()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\File năm 3 kì 2\Lập trình web nâng cao (1)\Bài tập web ngày 15_3\STUDENT_MANAGEMENT.mdf"";Integrated Security=True;Connect Timeout=30";
        // Đối tượng kết nối
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void FrmSearchbystudentName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet1.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet1.STUDENT);

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"select * from student where name like '%{txtStudentName.Text}%'", strCon);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
