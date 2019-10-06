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
    public partial class DisplayQuote : Form
    {
        DeskQuote quote;
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            this.quote = quote;
            buildQuote();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void buildQuote()
        {
            firstNameLabel.Text = quote.firstName;
            lastNameLabel.Text = quote.lastName;
            basePriceLabel.Text = $"${DeskQuote.BASE_PRICE}";
            areaLabel.Text = $"{quote.desk.getSurfaceArea()} square inches for ${quote.desk.getSurfaceArea() * DeskQuote.PRICE_PER_SQ_IN}";
            drawersLabel.Text = $"{quote.desk.Drawers} x $50 = ${quote.desk.Drawers * DeskQuote.DRAWER_PRICE}";
            materialLabel.Text = $"{quote.desk.SurfaceMaterial} at ${quote.getSurfaceMaterialCost(quote.desk.SurfaceMaterial)}";
            rushLabel.Text = $"{quote.rushDays} for an extra ${quote.getRushPrice(quote.desk.getSurfaceArea(), quote.rushDays)}";
            totalLabel.Text = $"${quote.price}";
        }
    }
}
