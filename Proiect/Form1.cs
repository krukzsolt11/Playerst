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

namespace Proiect
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panellogin.Visible = true;
            panelregister.Visible = false;
            panelmanagefields.Visible = false;
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panellogin_Paint(object sender, PaintEventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krukz\Desktop\Facultate\II\Proiect\Proiect\Users.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            panelmanagefields.Visible = false;  
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krukz\Desktop\Facultate\II\Proiect\Proiect\Users.mdf;Integrated Security=True");
            cn.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(passwordlogin.Text != string.Empty || usernamelogin.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + usernamelogin.Text + "' and password='" + passwordlogin.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    dr.Close();
                    panellogin.Visible = false;
                    panelregister.Visible = false;
                    panelmanagefields.Visible = true;  
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelregister.Visible = false;
            panellogin.Visible = true;
            panelmanagefields.Visible = false;
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            panellogin.Visible = false;
            panelregister.Visible = true;
            panelmanagefields.Visible = false;
        }

        private void panelregister_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(confirmpassword.Text != string.Empty || passwordregister.Text != string.Empty || usernameregister.Text != string.Empty)
            {
                if(passwordregister.Text == confirmpassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + usernameregister.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values (@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", usernameregister.Text);
                        cmd.Parameters.AddWithValue("password", passwordregister.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registermenu_Click(object sender, EventArgs e)
        {
            panellogin.Visible = false;
            panelregister.Visible = true;  
            panelmanagefields.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
