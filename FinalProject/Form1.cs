using System.Text;
using System.Xml;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public List<BorrowList> borrowList = new List<BorrowList>();
        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.ShowDialog();
            if(information.DialogResult == DialogResult.OK)
            {
                borrowList.Add(information.getBorowList());
            }
            RefreshData();
        }
        public void RefreshData()
        {
            dataGridView1.Rows.Clear();
            foreach(BorrowList borrow in borrowList)
            {
                dataGridView1.Rows.Add(borrow.StudentName, borrow.StudentID, borrow.Major, borrow.Year, borrow.BookName, borrow.BookID, borrow.BookShelf, borrow.BorrowDate, borrow.ReturnDate);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Book";
            saveFile.Filter = "CSV|*.csv";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                SaveToCSV(saveFile.FileName);
            }
        }
        private void SaveToCSV(string filePath)
        {
            using (StreamWriter file = new StreamWriter(filePath, false, UTF8Encoding.UTF8))
            {
                foreach (BorrowList item in borrowList)
                {
                    file.WriteLine($"{item.StudentName}, {item.StudentID}, {item.Major}, {item.Year}, {item.BookName},{item.BookID},{item.BookShelf},{item.BorrowDate},{item.ReturnDate}");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "Teams";
            openFile.Filter = "CSV|*.csv";
            openFile.ShowDialog();
            using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    BorrowList item = new BorrowList
                    {
                        StudentName = data[0].Trim(),
                        StudentID = data[1].Trim(),
                        Major = data[2].Trim(),
                        Year = data[3].Trim(),
                        BookName = data[4].Trim(),
                        BookID = data[5].Trim(),
                        BookShelf = data[6].Trim(),
                        BorrowDate = data[7].Trim(),
                        ReturnDate = data[8].Trim()
                    };
                    borrowList.Add(item);
                }
            }
            RefreshData();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReturn returnbook = new BookReturn();
            returnbook.ShowDialog();
            if(returnbook.DialogResult == DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}