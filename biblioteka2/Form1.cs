using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka2
{
    

    public partial class Form1 : Form
    {
        private BindingList<Book> books = new BindingList<Book>();
        public Form1()
        {
            InitializeComponent();
            lstBooks.DataSource = books;
        }

        private void rbtnDark_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDark.Checked)
            {
                mainPanel.BackColor = Color.FromArgb(45, 45, 48);
                mainPanel.ForeColor = Color.White;
                btnAddBook.ForeColor = Color.Black;
                btnEditBook.ForeColor = Color.Black;

            }
        }

        private void rbtnLight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLight.Checked)
            {
                mainPanel.BackColor = Color.LightGray;
                mainPanel.ForeColor = Color.Black;
                btnAddBook.ForeColor = Color.Black;
                btnEditBook.ForeColor = Color.Black;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenre.Items.AddRange(new[] { "Fantasy", "Science Fiction", "Drama", "History", "Romance" });
            cmbGenre.SelectedIndex = 0;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Book book = new Book
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Genre = cmbGenre.SelectedItem.ToString(),
                    IsAvailable = chkAvailable.Checked
                };
                books.Add(book);
                lblStatus.Text = "Книга добавена успешно.";
                ClearForm();
            }
        }
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                var selectedBook = books[lstBooks.SelectedIndex];
                txtTitle.Text = selectedBook.Title;
                txtAuthor.Text = selectedBook.Author;
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0 && ValidateInput())
            {
                Book selected = (Book)lstBooks.SelectedItem;
                selected.Title = txtTitle.Text;
                selected.Author = txtAuthor.Text;
                selected.Genre = cmbGenre.SelectedItem.ToString();
                selected.IsAvailable = chkAvailable.Checked;

                lstBooks.Refresh(); 
                lblStatus.Text = "Книгата е обновена.";
            }
        }
       
        private void lstBooks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                Book book = (Book)lstBooks.SelectedItem;
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                cmbGenre.SelectedItem = book.Genre;
                chkAvailable.Checked = book.IsAvailable;
            }
        }

        private bool ValidateInput()
        {
            if (txtTitle.Text.Trim().Length == 0)
            {
                lblStatus.Text = "Моля, въведете заглавие.";
                return false;
            }

            if (txtAuthor.Text.Trim().Length == 0)
            {
                lblStatus.Text = "Моля, въведете автор.";
                return false;
            }

            if (cmbGenre.SelectedIndex == -1)
            {
                lblStatus.Text = "Моля, изберете жанр.";
                return false;
            }

            lblStatus.Text = "";
            return true;
        }

        private void ClearForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            cmbGenre.SelectedIndex = 0;
            chkAvailable.Checked = false;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                // Потвърждение преди изтриване
                var result = MessageBox.Show(
                    "Наистина ли искате да изтриете тази книга?",
                    "Потвърждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    books.RemoveAt(lstBooks.SelectedIndex);
                    lblStatus.Text = "Книгата е изтрита.";
                    ClearForm();
                }
            }
            else
            {
                lblStatus.Text = "Моля, изберете книга за изтриване.";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                // Запазваме избраната книга
                int index = lstBooks.SelectedIndex;

                // "Обновяваме" ListBox-а, като присвоим отново DataSource
                lstBooks.DataSource = null;
                lstBooks.DataSource = books;

                // Възстановяваме избора
                lstBooks.SelectedIndex = index;

                lblStatus.Text = "Данните са обновени.";
            }
            else
            {
                lblStatus.Text = "Моля, изберете книга за обновяване.";
            }
        }

    }
}
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Author} ({Genre}) {(IsAvailable ? "[✓]" : "[✗]")}";
        }
    }

