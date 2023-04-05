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
    public partial class Information : Form
    {
        BorrowList borrow;
        public Information()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            BorrowList borrowlist = new BorrowList();
            borrowlist.StudentName = tbName.Text;
            borrowlist.StudentID = tbID.Text;
            borrowlist.Major = tbMajor.Text;
            borrowlist.Year = tbYearClass.Text;
            borrowlist.BookName = tbBookName.Text;
            borrowlist.BookID = tbBookID.Text;
            borrowlist.BookShelf = tbBookShelf.Text;
            borrowlist.BorrowDate = dateTimeBorrow.Text;
            borrowlist.ReturnDate = dateTimeReturn.Text;
            borrow = borrowlist;
            this.DialogResult = DialogResult.OK;
        }
        public BorrowList getBorowList()
        {
            return borrow;
        }
    }
}
