using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment_Movie
{
    public class Movie
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int YearOfRelease { get; set; }
        public string Genre { get; set; }

        public Movie() { }
        public Movie(string name, int id, int year, string genre)
        {
            Name = name;
            Id = id;
            YearOfRelease = year;
            Genre = genre;
        }

        public void Display()
        {
            Console.WriteLine($"\nName: {Name}\nId: {Id}\nYear Of Release: {YearOfRelease}\nGenre: {Genre}");
        }
    }
}
