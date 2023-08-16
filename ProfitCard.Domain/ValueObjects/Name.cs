namespace ProfitCard.Domain.ValueObjects
{
    public record Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private init; }
        public string LastName { get; private init; }
    }
}
