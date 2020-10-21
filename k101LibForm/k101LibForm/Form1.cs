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
using k101LibForm.Models;

namespace k101LibForm
{
    public partial class Form1 : Form
    {
        BOOKDBEntities db = new BOOKDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        public void BookFillData()
        {
            dtgBook.DataSource = db.Books.Select(x => new {
                x.Name,
                x.PublishDate,
                x.Amount,
                AuthorName = x.Author.Name
            }).ToList();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string BookName = txtBook.Text;
            decimal count = nmCount.Value;
            DateTime pbDate = dtgPublish.Value;
            string authName = cmbAuthors.Text;
            if (BookName != string.Empty && authName!=string.Empty)
            {
                lblError.Visible = false;
                int authId = db.Authors.First(x=>x.Name==authName).ID;
                Book bk = new Book();
                bk.Name = BookName;
                bk.Amount = (int)count;
                bk.PublishDate = pbDate;
                bk.AuthorId = authId;
                db.Books.Add(bk);
                db.SaveChanges();
                MessageBox.Show("Kitab elave edildi");
                BookFillData();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Kitab adini qeyd edin!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbAuthors.Items.AddRange(db.Authors.Select(x => x.Name).ToArray());
            BookFillData();
        }
    }
}






//using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conLib))
//{
//    string comQuery = "Select Name From Authors";
//    con.Open();
//    SqlCommand com = new SqlCommand(comQuery, con);
//    var res = com.ExecuteReader();
//    while (res.Read())
//    {
//        cmbAuthors.Items.Add(res["Name"].ToString());
//    }
//}


//using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conLib))
//{
//    con.Open();
//    string comAuthCom = $"Select ID From Authors Where Name='{authName}'";
//    SqlCommand authcom = new SqlCommand(comAuthCom, con);
//    var authres = authcom.ExecuteReader();
//    while (authres.Read())
//    {
//        authId = Convert.ToInt32(authres["ID"]);
//    }
//}
//using (SqlConnection con = new SqlConnection(Properties.Settings.Default.conLib))
//{
//    con.Open();
//    string comString = string.Format($"Insert into Books Values('{BookName}','{pbDate}',{authId},{count},NULL)");
//    SqlCommand com = new SqlCommand(comString, con);
//    int res = com.ExecuteNonQuery();
//    if (res >= 1)
//    {
//        MessageBox.Show("Kitab elave edildi");
//        txtBook.Text = "";
//        nmCount.Value = 1;
//        dtgPublish.Value = DateTime.Now;
//    }
//}