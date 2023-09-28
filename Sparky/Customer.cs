namespace Sparky
{
    public class Customer
    {
        public int Discount = 15;

        public string GreetMessage { get; set; }

        public string GreetCombineNames(string firstName, string LastName)
        {
            GreetMessage = $"Hello, {firstName} {LastName}";
            Discount = 20;
            return GreetMessage;
        }
    }
}