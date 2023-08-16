using ProfitCard.Domain.Common;
using ProfitCard.Domain.ValueObjects;

namespace ProfitCard.Domain.Entities
{
    public sealed class Client : BaseEntity
    {
        public Client(Name name,
                      string email,
                      string company,
                      DateTime issue,
                      DateTime validate,
                      double value,
                      DeliveryAdress deliveryAdress,
                      Guid productId) : base()
        {
            Name = name;
            Email = email;
            Company = company;
            Issue = issue;
            Validate = validate;
            Value = value;
            DeliveryAdress = deliveryAdress;
            IsDeleted = false;
            ProductId = productId;
        }

        public Name Name { get; private set; }
        public string Email { get; private set; }
        public string Company { get; private set; }
        public DateTime Issue { get; private set; }
        public DateTime Validate { get; private set; }
        public double Value { get; private set; }
        public DeliveryAdress DeliveryAdress { get; private set; }
        public bool IsDeleted { get; private set; }
        public Guid ProductId { get; private set; }
        public Product? Product { get; set; }


        public void Delete()
        {
            IsDeleted = true;
        }

        public void SetClient(Name newName,
            string newEmail,
            string newCompany,
            DateTime newValidate,
            double newValue,
            DeliveryAdress newDeliveryAdress)
        {
            Name = newName;
            Email = newEmail;
            Company = newCompany;
            Issue = newValidate;
            Value = newValue;
            DeliveryAdress = newDeliveryAdress;

        }

    }


}
