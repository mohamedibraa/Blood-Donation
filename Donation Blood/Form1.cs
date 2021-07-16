using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Donation_Blood
{
    public partial class Form1 : Form
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-44DAKMQ\SQLEXPRESS;DataBase=Bloooooood;Integrated Security=true;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        //login 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text == "")
                {
                    MessageBox.Show("please enter username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (Password.Text == " ")
                {
                    MessageBox.Show("please enter password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cn.Open();
                    cmd = new SqlCommand("loooogin", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username",Username.Text);
                    cmd.Parameters.AddWithValue("@password",Password.Text);
                    int check = Convert.ToInt32(cmd.ExecuteScalar());

                    if (check == 1)
                    {
                        this.Hide();
                        new form4().ShowDialog();
                        // hospital As Admin
                    }
                    else if(check==2)
                    {
                        this.Hide(); new Form3().ShowDialog();
                        //Donar As admin
                    }
                    
                    else
                        MessageBox.Show("Invalid username & password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cn.Close();
            }

        }
        //sign up
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
