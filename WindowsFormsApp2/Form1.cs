using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RSK8I6S;Initial Catalog=SWE331_midterms2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataSet sd = new DataSet();
            conn.Open();
            sda.SelectCommand = new SqlCommand("" +
                "select Student_code as 'Оюутны код', s.First_name as 'Овог', s.Last_name as 'Нэр', pg.Program_name as 'Хөтөлбөр', pf.Profession_name as 'мэргэжил',  s.Note as 'тайлбар' from Students s\r\ninner join Professions pf on pf.Profession_id =  s.Profession_id\r\ninner join Programs pg on pg.Program_id = s.Program_id", conn);
            sda.Fill(dt);
            conn.Close();
            if(dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("set");
            f2.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("add");
            f2.ShowDialog();
        }
    }
}
