using ProfitCard.Application.Output.Output.Results;
using ProfitCard.Domain.Entities;

namespace ProfitCard.Application.Output.Output.ViewModel
{
    public record ClientViewModel
    {
        public ClientViewModel(Guid id, string fullName,
                               string email,
                               string company,
                               DateTime issue,
                               DateTime validate,
                               double value,
                               string fullAddress,
                               bool isDeleted,
                               Guid productId)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Company = company;
            Issue = issue;
            Validate = validate;
            Value = value;
            FullAddress = fullAddress;
            IsDeleted = isDeleted;
            ProductId = productId;
        }

        public Guid Id { get; private init; }
        public string FullName { get; private init; }
        public string Email { get; private init; }
        public string Company { get; private init; }
        public DateTime Issue { get; private init; }
        public DateTime Validate { get; private init; }
        public double Value { get; private init; }
        public string FullAddress { get; private init; }
        public bool IsDeleted { get; private init; }
        public Guid ProductId { get; private init; }
        public Result? Result { get; set; }



        public static ClientViewModel FromEntity(Client client)
        {
            var address = client.DeliveryAdress;
            var name = client.Name;


            return new ClientViewModel(client.Id,
                $"{name.FirstName}, {name.LastName}",
                client.Email,
                client.Company,
                client.Issue,
                client.Validate,
                client.Value,
                $"{address.Number}, {address.Street}, {address.Complement}, {address.City}, {address.State}, {address.ZipCode}, {address.Country}",
                client.IsDeleted,
                client.ProductId);
        }
    }
}
