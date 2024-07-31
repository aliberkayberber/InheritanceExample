namespace OOP
{
    public class Ogrenci : BaseKisi
    {
        public string studentNo{get; set;}

        public void Hello()
        {
            BaseKisi.Introduce(name,surname);
            System.Console.WriteLine("Ogrenci numaram: " + studentNo);
        }
    }
}
