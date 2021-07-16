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
    public partial class Form3 : Form
    {
      public  SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-44DAKMQ\SQLEXPRESS;DataBase=Bloooooood;Integrated Security=true;");
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }
        //Delete
        /*private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                cmd = new SqlCommand("check_", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id_.Text);
                che = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cn.Close();
            }
            if (che == 1)
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand("Delete_", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id_.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                { MessageBox.Show(ex.Message, "Error"); }
                finally { cn.Close(); }
            }
            else
            {
                MessageBox.Show("Invaild Id", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
        //insert into Donation Operation
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("DonationOOperation", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bloodtype", Blood1.Text);
                cmd.Parameters.AddWithValue("@Quanity", Quanity.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done successfuly", "information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


