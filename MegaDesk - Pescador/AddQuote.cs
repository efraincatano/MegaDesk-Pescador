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
    public partial class AddQuote : Form
    {
        private MainMenu _mainMenu;
        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void newQuoteTitle_Click(object sender, EventArgs e)
        {

        }

        private void costumerNameText_Click(object sender, EventArgs e)
        {

        }
        private void surfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenu.Show();
        }
    }
}
