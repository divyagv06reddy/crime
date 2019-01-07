using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Kranthi\Documents\data.mdf;Integrated Security = True;");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users1 values('" + textBox1.Text + " ','" + textBox2.Text + " ','" +radioButton1.Text + " ','" + textBox3.Text + " ')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saving is success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Close();
        
    }
    }
}
