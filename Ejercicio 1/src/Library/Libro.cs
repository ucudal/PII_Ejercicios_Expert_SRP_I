using System;

namespace SRP
{
    public class Book
    {
/* Para que Book tenga un poco más de sentido y cumpla con el principio SRP, debería "partir por la mitad" este código. 
Pondré, por una parte, lo relacionado al libro en sí (Título, autor y código) y en la otra parte pondré lo que viene 
siendo su ubicación. */
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        /*public string LibrarySector { get ; set; } //Esto irá en Localizacion.
        public string LibraryShelve { get ; set; }*/   

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

      /*  public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }*/

        

    } 
}

