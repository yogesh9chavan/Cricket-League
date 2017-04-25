using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionstring;
        OracleConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionstring = "Data Source=XE;Persist Security Info=True;User ID=system;Password=yogesh;";
            conn = new OracleConnection(connectionstring);
            conn.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OracleCommand cmd = new OracleCommand("insert into player values(" + id.Text + ",'" + name.Text + "'," + matches.Text + ",'" 
            //    + team.Text + "','" + speciality.Text + "'," + age.Text + ",'" + nationality.Text + "'," + mom.Text + ")",conn);
            //cmd.ExecuteNonQuery();

            OracleDataAdapter da = new OracleDataAdapter("SELECT * FROM points_table", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //dataGridView2.DataSource = dt;
        }

    }
}
