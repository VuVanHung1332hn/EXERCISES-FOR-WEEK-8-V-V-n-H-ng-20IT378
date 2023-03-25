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
    public partial class ListofStudentsbyClass : Form
    {
        public ListofStudentsbyClass()
        {
            InitializeComponent();
        }
       //string conn = global::ListofStudentsbyClass.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
       // DataSet ds = null;
       // SqlDataAdapter adapter = null;
        //string str;

        private void btnView_Click(object sender, EventArgs e)
        {
            //str = $"Select * from  Student where ClassID= '{cboClassID.Text}'";
            //adapter = new SqlDataAdapter(str,conn);
           // ds = new DataSet();
            //adapter.Fill(ds);
           // dataGridView1.DataSource = ds.Tables[0];
        }

        private void ListofStudentsbyClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.CLASS);

        }

        
    }
}
