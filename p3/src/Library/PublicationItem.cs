namespace Ucu.Poo.Defense
{
    public class PublicationItem
    {
        public Material Material { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int TotalIteam { get; set; }

        public PublicationItem(Material material, int quantity, int price)
        {
            this.Material = material;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalIteam = CalculateTotal();
        }
        /// <summary>
        /// I decided to create the Total of each item here because I considered that this is the expert of each item
        /// </summary>
        /// <returns>Total of each item</returns>
        public int CalculateTotal(){
            return this.Quantity * this.Price;
        }

    }
}