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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Kranthi\Documents\data.mdf;Integrated Security = True;");

           public Form2()
        {
          

            
              InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users values('"+textBox1.Text + " ','" +  textBox2.Text + " ','" + textBox3.Text + " ','" + dateTimePicker1.Text + " ','" + listBox1.Text + " ','" + textBox4.Text + " ',' "+ pictureBox1.Text+ " ')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saving is success");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update into users values('" + textBox1.Text + " ','" + textBox2.Text + " ','" + textBox3.Text + " ','" + dateTimePicker1.Text + " ','" + listBox1.Text + " ','" + textBox4.Text + " ','" +pictureBox1.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully updated");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {

                textBox5.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users values('" + textBox1.Text + " ','" + textBox2.Text + " ','" + textBox3.Text + " ','" + dateTimePicker1.Text + " ','" + listBox1.Text + " ','" + textBox4.Text + " ','" +pictureBox1+" ')";
            con.Close();
            

            MessageBox.Show("saved");
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}