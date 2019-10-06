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
    public partial class AddQuote : Form
    {
        
        const int MAX_WIDTH = 96;
        const int MIN_WIDTH = 24;
        const int MAX_DEPTH = 48;
        const int MIN_DEPTH = 12;
        const int MAX_DRAWERS = 7;

        enum DesktopMaterial
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }

        string[] rushDays = { "3", "5", "7", "14" };

        public AddQuote()
        {            
            InitializeComponent();
            surfaceMaterialBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            rushOrderBox.Items.AddRange(rushDays);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = (MainMenu)Tag;
            mainForm.Show();
            Close();
        }

        private void validatingWidth(object sender, CancelEventArgs e)
        {
            string errorMessage;
            int value;
            if(!int.TryParse(widthBox.Text, out value))
            {                
                errorMessage = "Width must be a whole number";
                this.errorProvider.SetError(label10, errorMessage);
                widthBox.Text = "";
            }
            else
            {
                value = int.Parse(widthBox.Text);
                if (value > MAX_WIDTH || value < MIN_WIDTH)
                {
                    errorMessage = $"Width should be between {MIN_WIDTH} and {MAX_WIDTH}";
                    this.errorProvider.SetError(label10, errorMessage);
                    widthBox.Text = "";
                }
                else
                {
                    this.errorProvider.Clear();
                }
            }
            
        }

        private void depthValidate(object sender, KeyPressEventArgs e)
        {
            string errorMessage;
            if (!char.IsDigit(e.KeyChar))
            {
                if(char.IsControl(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = true;
                    errorMessage = "Only enter numbers";
                    this.errorProvider1.SetError(label11, errorMessage);
                }
                
            }
            else
            {
                this.errorProvider1.Clear();
            }
            
            
        }

        private void validatingDepth(object sender, CancelEventArgs e)
        {
            string errorMessage;
            int value;

            if (!int.TryParse(depthBox.Text, out value))
            {
                errorMessage = "Depth must be a whole number";
                this.errorProvider1.SetError(label11, errorMessage);                
            }
            else
            {
                value = int.Parse(depthBox.Text);

                if (value > MAX_DEPTH || value < MIN_DEPTH)
                {
                    errorMessage = $"Depth should be between {MIN_DEPTH} and {MAX_DEPTH}";
                    this.errorProvider1.SetError(label11, errorMessage);
                }

                else
                {
                    this.errorProvider1.Clear();
                }
            }
            
        }

        private void validatingDrawers(object sender, CancelEventArgs e)
        {
            string errorMessage;
            int value;
            if (!int.TryParse(drawersBox.Text, out value))
            {
                errorMessage = "Drawers must be a whole number";
                this.errorProvider2.SetError(drawersBox, errorMessage);
                drawersBox.Text = "";
            }
            else
            {
                value = int.Parse(drawersBox.Text);
                if (value > MAX_DRAWERS || value < 0)
                {
                    errorMessage = $"Drawers should be between 0 and {MAX_DRAWERS}";
                    this.errorProvider2.SetError(drawersBox, errorMessage);
                    drawersBox.Text = "";
                }
                else
                {
                    this.errorProvider2.Clear();
                }
            }
        }

        private void validatingSurfaceMaterial(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if(!Enum.IsDefined(typeof(DesktopMaterial), surfaceMaterialBox.Text))
            {
                errorMessage = "Please select an item from the list";
                this.errorProvider3.SetError(surfaceMaterialBox, errorMessage);
                surfaceMaterialBox.Text = "";
            }
            else
            {
                this.errorProvider3.Clear();
            }
        }

        private void validatingRush(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!rushDays.Contains(rushOrderBox.Text))
            {
                errorMessage = "Please select an item from the list";
                this.errorProvider4.SetError(rushOrderBox, errorMessage);
                rushOrderBox.Text = "";
            }
            else
            {
                this.errorProvider4.Clear();
            }
        }

        private void CreateQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int depth = int.Parse(depthBox.Text);
                int width = int.Parse(widthBox.Text);
                int drawers = int.Parse(drawersBox.Text);
                int rushDays = int.Parse(rushOrderBox.Text);
                string material = surfaceMaterialBox.Text;
                string firstName = firstNameBox.Text;
                string lastName = lastNameBox.Text;
                Desk newDesk = new Desk(depth, width, drawers, material);
                DeskQuote newQuote = new DeskQuote(firstName, lastName, newDesk, rushDays);

                DisplayQuote display = new DisplayQuote(newQuote);
                display.Show();
                
            } catch
            {
                MessageBox.Show("An error occurred. Check inputs and try again.");
            }
        }
    }
}
