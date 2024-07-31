namespace OOP
{

    public class Ogretmen : BaseKisi
    {
        public string salary{get; set;}

        public void Meet()
        {
            BaseKisi.Introduce(name,surname); // basekisi sınıfındaki metoru çağırıdım. Metotlar metot çağırabilir
            System.Console.WriteLine("Maasım: " + salary);
        }
    }
    
}
