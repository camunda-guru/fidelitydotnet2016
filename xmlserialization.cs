using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
[Serializable()]
public class Movie
 {
   [XmlAttribute("MovieName")]
   public string Title
   { get; set; }
 
 [XmlElement("MovieRating")]
   public float Rating
   { get; set; }
 
  [XmlElement("MovieReleaseDate")]
   public DateTime ReleaseDate
   { get; set; }
 }
class test
{
static public void SerializeToXML(List<Movie> movies)
 {
   XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>));
   TextWriter textWriter = new StreamWriter(@"movie.xml");
   serializer.Serialize(textWriter, movies);
   textWriter.Close();
 }
static void Main(string[] args)
 {
   Movie movie = new Movie();
   movie.Title = "Starship Troopers";
   movie.ReleaseDate = DateTime.Parse("11/7/1997");
   movie.Rating = 6.9f;
 
  Movie movie2 = new Movie();
   movie2.Title = "Ace Ventura: When Nature Calls";
   movie2.ReleaseDate = DateTime.Parse("11/10/1995");
   movie2.Rating = 5.4f;
 
  List<Movie> movies = new List<Movie>() { movie, movie2 };
 
  SerializeToXML(movies);
 List<Movie> retmov = DeserializeFromXML();
foreach(Movie x in retmov)
{
   Console.WriteLine(x.Title);

}
 }
 
 
static List<Movie> DeserializeFromXML()
 {
    XmlSerializer deserializer = new XmlSerializer(typeof(List<Movie>));
    TextReader textReader = new StreamReader(@"movie.xml");
    List<Movie> movies; 
   movies = (List<Movie>)deserializer.Deserialize(textReader);
    textReader.Close();
 
   return movies;
 }
}