
using System.Collections.Generic;
namespace dvdCollection.Models{
    public class FilmTitlesProducers
    {
    public int ProducerID {get; set;}
    public int FilmTitleID {get; set;}

    public Producers Producer {get; set;}
    public FilmTitles FilmTitle {get; set;}

    
    }

}
