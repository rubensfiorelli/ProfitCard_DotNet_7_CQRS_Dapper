namespace ProfitCard.Domain.ValueObjects
{
    public record DeliveryAdress
    {
        public DeliveryAdress(short number,
                              string street,
                              string complement,
                              string city,
                              string state,
                              string zipCode,
                              string country)
        {
            Number = number;
            Street = street;
            Complement = complement;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
        }

        public short Number { get; private init; }
        public string Street { get; private init; }
        public string Complement { get; private init; }
        public string City { get; private init; }
        public string State { get; private init; }
        public string ZipCode { get; private init; }
        public string Country { get; private init; }

    }
}
