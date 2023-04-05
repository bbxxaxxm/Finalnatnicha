using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BorrowList
    {
        private string studentname;
        private string studentid;
        private string major;
        private string year;
        private string bookname;
        private string bookid;
        private string bookshelf;
        private string borrowdate;
        private string returndate;

        public string StudentName
        {
            get { return studentname; }
            set { studentname = value; }
        }

        public string StudentID
        {
            get { return studentid; }
            set { studentid = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }

        public string BookID
        {
            get { return bookid; }
            set { bookid = value; }
        }

        public string BookShelf
        {
            get { return bookshelf; }
            set { bookshelf = value; }
        }

        public string BorrowDate
        {
            get { return borrowdate; }
            set { borrowdate = value; }
        }

        public string ReturnDate
        {
            get { return returndate; }
            set { returndate = value; }
        }
    }
}
