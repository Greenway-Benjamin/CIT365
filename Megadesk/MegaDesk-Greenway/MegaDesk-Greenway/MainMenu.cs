using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Greenway
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void NewQuote_Click(object sender, EventArgs e)
        {
            AddQuote quoteForm = new AddQuote();
            quoteForm.Tag = this;
            quoteForm.Show();
            Hide();
        }

        private void ViewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show();
            Hide();
        }

        private void SearchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes search = new SearchQuotes();
            search.Tag = this;
            search.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
