using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk___Pescador
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var ViewQuotes = new ViewAllQuotes(this);
            ViewQuotes.Show();
            this.Hide();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var AddQuote = new AddQuote(this);
            AddQuote.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var SearchQuotes = new SearchQuotes(this);
            SearchQuotes.Show();
            this.Hide();
        }
    }
}
