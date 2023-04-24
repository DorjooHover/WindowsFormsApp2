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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public string com;
        private String Com
        {
            get { return com; }
            set { com = value;}
        }
        public Form2(string com)
        {
            InitializeComponent();
            this.com = com;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RSK8I6S;Initial Catalog=SWE331_midterms2;Integrated Security=True");
            DataTable dt = new DataTable();
            DataSet sd = new DataSet();
            SqlCommand sc = new SqlCommand("getData", conn);
            SqlDataAdapter sda = new SqlDataAdapter(sc);
            sc.CommandType = CommandType.StoredProcedure;
            conn.Open();


            dt.Load(sc.ExecuteReader());
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {

                    profession.Items.Add(row[0]);
                    if (!program.Items.Contains(row[1]))
                    {
                        program.Items.Add(row[1]);
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RSK8I6S;Initial Catalog=SWE331_midterms2;Integrated Security=True");
           
            if (this.com == "add")
            {
                SqlCommand sc = new SqlCommand("addStudent", conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.AddWithValue("@lastname" , lastname.Text);
                sc.Parameters.AddWithValue("@firstname" , firstname.Text);
                sc.Parameters.AddWithValue("@pr" , 18);
                sc.Parameters.AddWithValue("@pg" ,  8);
                sc.Parameters.AddWithValue("@code" , code.Text);
                sc.Parameters.AddWithValue("@note" , note.Text);

               

                conn.Open();

                sc.ExecuteNonQuery();
                conn.Close();
            }
            if(this.com == "set")
            {
                SqlCommand sc = new SqlCommand("setStudent", conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sc.CommandType = CommandType.StoredProcedure;
                sc.Parameters.AddWithValue("@lastname", lastname.Text);
                sc.Parameters.AddWithValue("@firstname", firstname.Text);
                sc.Parameters.AddWithValue("@pr", 18);
                sc.Parameters.AddWithValue("@pg", 8);
                sc.Parameters.AddWithValue("@code", code.Text);
                sc.Parameters.AddWithValue("@note", note.Text);

                conn.Open();

                sc.ExecuteReader();
                conn.Close();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
