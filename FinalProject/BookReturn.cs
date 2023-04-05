using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBubReturn_Click(object sender, EventArgs e)
        {
            string bookid = tbBookIDRe.Text;
            BorrowList borrow = new BorrowList();
            foreach(BorrowList brl in Form1.Instance.borrowList)
            {
                if (bookid == brl.BookID)
                {
                    borrow = brl;
                }
            }

            Form1.Instance.borrowList.Remove(borrow);
            this.DialogResult = DialogResult.OK;
        }
    }
}
