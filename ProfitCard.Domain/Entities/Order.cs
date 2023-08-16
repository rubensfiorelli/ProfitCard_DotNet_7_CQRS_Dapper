using ProfitCard.Domain.Common;
using ProfitCard.Domain.ValueObjects;

namespace ProfitCard.Domain.Entities
{
    public sealed class Order : BaseEntity
    {
        public Order(Guid clientId, string description, double serviceFee, DeliveryAdress deliveryAddress) : base()
        {

            ClientId = clientId;
            OrderNumber = GenerateOrderNumber();
            CardNumber = GenerateCardNumber();
            Description = description;
            ServiceFee = serviceFee;
            DeliveryAddress = deliveryAddress;
            IsDeleted = false;


            Products = new List<OrderItems>();
        }

        public Guid ClientId { get; private set; }
        public string OrderNumber { get; private set; }
        public string CardNumber { get; private set; }
        public string Description { get; private set; }
        public double ServiceFee { get; private set; }
        public bool IsDeleted { get; private set; }
        public DeliveryAdress DeliveryAddress { get; private set; }
        public double TotalPrice { get; private set; }
        public List<OrderItems> Products { get; private set; }


        public void SetupProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                var productPrice = product.FixedPriceCard + product.BenfitValue + (ServiceFee * product.BenfitValue);
                TotalPrice += productPrice;

                Products.Add(new OrderItems(product.Title, productPrice));
            }
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        private static string GenerateCardNumber()
        {
            var rand = new Random();

            var bytes = new byte[12];

            rand.NextBytes(bytes);

            for (var i = 0; i < bytes.Length; i++)
            {
                _ = bytes[i];
            }

            var result = new byte[12];

            return result.ToString();
        }

        private static string GenerateOrderNumber()
        {
            const string chars = "AKGIPY";
            const string numbers = "2348091";

            var code = new char[6];
            var random = new Random();

            for (var i = 0; i < 2; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 0; i < 4; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new string(code);
        }
    }
}
