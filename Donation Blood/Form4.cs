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
using System.Data.SqlTypes;

namespace Donation_Blood
{
    public partial class form4 : Form
    {
      public  SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-44DAKMQ\SQLEXPRESS;DataBase=Bloooooood;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader dr;

        public form4()
        {
            InitializeComponent();
            // read Bloodtype
            try
            {
                cn.Open();
                cmd = new SqlCommand("Blooodtype", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["Bloodtype"]);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
        }
        //insert Data into Donation operation
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("updatedataaaaa", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bloodtype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Data", dateTimePicker1.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Done Successfuly", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cn.Close();
            }
            //return Quanity
            try
            {

                cn.Open();
                cmd = new SqlCommand("return_quantity", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bloodtype", comboBox1.SelectedItem.ToString());
                cmd.Parameters.Add("@q", SqlDbType.Int);
                cmd.Parameters["@q"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int check = Convert.ToInt32(cmd.Parameters["@q"].Value);
              //  MessageBox.Show(check.ToString());
              //  MessageBox.Show(comboBox1.SelectedItem.ToString());
                if (check == 0)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DeleteQuanity", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Bloodtype", comboBox1.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("We have our enough quanttity");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("error1");
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("Quantity", cn);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Bloodtype", comboBox1.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Successfully Donation");
                }
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
  




  
            
            
