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
using System.Configuration;

namespace DatabaseView
{
    public partial class Form1 : Form
    {
        string Connecting = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\DatabaseView\DatabaseView\Database1.mdf;Integrated Security=True";
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset() {
            da = new SqlDataAdapter("SELECT * FROM Student", Connecting);
            ds = new DataSet();
            da.Fill(ds);
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'database1DataSet.Student' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.studentTableAdapter.Fill(this.database1DataSet.Student);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
