namespace OOP
{
    public class BaseKisi
    {
        public string name{get; set;}
        public string surname{get; set;}

        public static void Introduce(string name , string surname)
        {
            System.Console.WriteLine($"Merhaba, ismim {name} {surname}.");
        }
    }
}