namespace Sparky
{
    public class Customer
    {
        public string GreetMessage { get; set; }

        public string GreetCombineNames(string firstName, string LastName)
        {
            GreetMessage = $"Hello, {firstName} {LastName}";
            return GreetMessage;
        }
    }
}