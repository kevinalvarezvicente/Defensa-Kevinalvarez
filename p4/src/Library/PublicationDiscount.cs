using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount: IPublicationItem
    {
        private int amount;

        public double Total
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = Convert.ToInt32(value);
            }
        }

        public PublicationDiscount(int amount)
        {
            this.Total = amount;
        }
    }
}