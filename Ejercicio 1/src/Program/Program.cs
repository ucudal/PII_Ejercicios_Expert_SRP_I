using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            ShelveBook loc1 = new ShelveBook("A", "7");
            ShelveBook loc2 = new ShelveBook("B", "3");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            loc1.Agr(book1); //Agrego el libro a la localización loc1
            //Para esto último tomé un video de YouTube para tomar un poco de referencia en este último paso
            //Lo adjunto aquí https://www.youtube.com/watch?v=0obdeYYhxAg

        }
    }
}