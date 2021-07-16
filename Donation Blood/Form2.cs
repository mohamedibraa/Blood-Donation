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
    public partial class Form2 : Form
    {
      public  SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-44DAKMQ\SQLEXPRESS;DataBase=Bloooooood;Integrated Security=true;");
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //insert data
        private void button1_Click(object sender, EventArgs e)
        {
            if (combo.SelectedItem == "Donar")
            {
                if (d_name.Text == "")
                    MessageBox.Show("Plese enter Your name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (d_username.Text == "")
                    MessageBox.Show("Plese enter Your Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (d_password.Text == "")
                    MessageBox.Show("Plese enter Your Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (d_phone.Text == "")
                    MessageBox.Show("Plese enter Your Phone", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (d_email.Text == "")
                    MessageBox.Show("Plese enter Your Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (d_address.Text == "")
                    MessageBox.Show("Plese enter Your Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (d_gender.Text == "")
                    MessageBox.Show("Plese enter Your Gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (bloodtype.Text == "")
                    MessageBox.Show("Plese enter Your BloodType", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand("Insertdoonar", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@D_name", d_name.Text);
                        cmd.Parameters.AddWithValue("@username", d_username.Text);
                        cmd.Parameters.AddWithValue("@password", d_password.Text);
                        cmd.Parameters.AddWithValue("@phone", d_phone.Text);
                        cmd.Parameters.AddWithValue("@Email", d_email.Text);
                        cmd.Parameters.AddWithValue("@Address", d_address.Text);
                        cmd.Parameters.AddWithValue("@Gender", d_gender.Text);
                        cmd.Parameters.AddWithValue("@Bloodtype", bloodtype.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Done Successfuly", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        cn.Close();
                    }
                    this.Hide();
                    new Form1().ShowDialog();
                }
            }
            else if (combo.SelectedItem == "Hospital")
            {
                if (h_name.Text == "")
                    MessageBox.Show("Plese enter Your name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (h_username.Text == "")
                    MessageBox.Show("Plese enter Your Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (h_pass.Text == "")
                    MessageBox.Show("Plese enter Your Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (h_address.Text == "")
                    MessageBox.Show("Plese enter Your Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (Email_.Text == "")
                    MessageBox.Show("Plese enter Your Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (phone_.Text == "")
                    MessageBox.Show("Plese enter Your Phone ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    try
                    {

                        cn.Open();
                        cmd = new SqlCommand("insertHoospital", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@H_name", h_name.Text);
                        cmd.Parameters.AddWithValue("@username", h_username.Text);
                        cmd.Parameters.AddWithValue("@password", h_pass.Text);
                        cmd.Parameters.AddWithValue("@H_address", h_address.Text);
                        cmd.Parameters.AddWithValue("@Email", Email_.Text);
                        cmd.Parameters.AddWithValue("@phone", phone_.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Done Successfuly", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "error");
                    }
                    finally
                    {
                        cn.Close();
                    }
                    this.Hide();
                    new Form1().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("please select item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (combo.SelectedItem == "Donar")
            {
                this.panel2.Hide();
                this.panel1.Show();
            }
            else if(combo.SelectedItem == "Hospital")
            {
                this.panel1.Hide();
                this.panel2.Show();
            }
            else
            {
                MessageBox.Show("please select item", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 
