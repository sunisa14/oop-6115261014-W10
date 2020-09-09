using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  oop_6115261014_w10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fTitle = txtTitle.Text;
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string name = txtName.Text;
            string page = txtPage.Text;
            string Publisher = txtPublisher.Text;
            string date = txtDate.Text;
            string rank = txtRank.Text;
            string weight = txtWeight.Text;
            Result R = new Result(title,fname,lname);
            Wijai W = new  Wijai(name, page, Publisher, date, rank, weight);
            lblShowData.Text =  + R.ResultTitle + " " + R.ResultFName +  + R.ResultLname +  + W.WijaiName + 
                + W.WijaiPage +  + W.WijaiPublisher +  + W.WijaiDate +
                 + W.WijaiRank +  + W.WijaiWeight;




        }
    }
}
