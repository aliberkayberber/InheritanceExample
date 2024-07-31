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

    public class Ogrenci : BaseKisi
    {
        public string studentNo{get; set;}

        public void Hello()
        {
            BaseKisi.Introduce(name,surname);
            System.Console.WriteLine("Ogrenci numaram: " + studentNo);
        }
    }

    public class Ogretmen : BaseKisi
    {
        public string salary{get; set;}

        public void Meet()
        {
            BaseKisi.Introduce(name,surname);
            System.Console.WriteLine("Maasım: " + salary);
        }
    }
    
}