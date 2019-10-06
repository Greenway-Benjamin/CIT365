using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Greenway
{
    public class DeskQuote
    {
        public string firstName, lastName;
        public Desk desk;
        public int rushDays;
        public int price;
        public const int BASE_PRICE = 200;
        public const int PRICE_PER_SQ_IN = 1;
        public const int DRAWER_PRICE = 50;

        public DeskQuote(string firstName, string lastName, Desk desk, int rushDays)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.desk = desk;
            this.rushDays = rushDays;
            this.price = getQuotePrice();
        }

        private int getQuotePrice()
        {
            int total;
            int surfaceArea = desk.getSurfaceArea();
            int rushPrice = getRushPrice(surfaceArea, rushDays);
            int surfaceMaterialCost = getSurfaceMaterialCost(desk.SurfaceMaterial);

            total = BASE_PRICE + surfaceArea * PRICE_PER_SQ_IN + desk.Drawers * DRAWER_PRICE + surfaceMaterialCost + rushPrice;

            return total;
        }

        public int getRushPrice(int area, int days)
        {
            int rushPrice;

            switch (days)
            {
                case 3:

                    if (area > 2000)
                    {
                        rushPrice = 80;
                    }
                    else if (area > 1000) 
                    {
                        rushPrice = 70;
                    } else
                    {
                        rushPrice = 60;
                    }

                    break;

                case 5:

                    if (area > 2000)
                    {
                        rushPrice = 60;
                    }
                    else if (area > 1000)
                    {
                        rushPrice = 50;
                    }
                    else
                    {
                        rushPrice = 40;
                    }

                    break;

                case 7:

                    if (area > 2000)
                    {
                        rushPrice = 40;
                    }
                    else if (area > 1000)
                    {
                        rushPrice = 35;
                    }
                    else
                    {
                        rushPrice = 30;
                    }

                    break;

                default:

                    rushPrice = 0;

                    break;
            }

            return rushPrice;
        }

        public int getSurfaceMaterialCost(string material)
        {
            int cost = 0;
            switch (material)
            {
                case "Oak":

                    cost = 200;

                    break;

                case "Laminate":

                    cost = 100;

                    break;

                case "Pine":

                    cost = 50;

                    break;

                case "Rosewood":

                    cost = 300;

                    break;

                case "Veneer":

                    cost = 125;

                    break;
            }

            return cost;
        }
    }
}
