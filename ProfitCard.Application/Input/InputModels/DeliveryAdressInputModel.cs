using ProfitCard.Domain.ValueObjects;

namespace ProfitCard.Application.Input.InputModels
{
    public class DeliveryAdressInputModel
    {
        public short Number { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public DeliveryAdress ToValueObject()
            => new DeliveryAdress(Number, Street, Complement, City, State, ZipCode, Country);
    }
}