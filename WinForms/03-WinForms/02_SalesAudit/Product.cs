using System;
using System.Globalization;

namespace SalesAudit
{
    public class Product
    {
        private decimal _price;

        public string Name { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public decimal PriceInDecimal { get => _price; }

        public string Price
        {
            get => _price.ToString();
            set
            {
                if (decimal.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out _price))
                    if (_price >= 0)
                        return;

                throw new Exception("Price is not available!");
            }
        }

        public override string ToString()
        {
            return $"{Name} Feature: {Feature} Description: {Description}";
        }
    }
}
