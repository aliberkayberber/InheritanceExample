namespace OOP
{

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
