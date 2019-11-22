using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var albums = new List<Album>
            {
                new Album {Id = 1,Title = "Kill em all", ReleaseYear = 1983},
                new Album {Id = 2,Title = "Ride The Lightning", ReleaseYear = 1984},
                new Album {Id = 3,Title = "Master of Pupets", ReleaseYear = 1986},
                new Album {Id = 4,Title = "And Justice For All", ReleaseYear = 1988 },
                new Album {Id = 5,Title = "Black Album", ReleaseYear = 1991 }
            };

            var SortedAlbums = albums.Where(x => x.ReleaseYear > 1985).OrderBy(x => x.Title).ToList();

            foreach (var album in albums)
            {
                Console.WriteLine(album.Title);
            }
        }
    }
}
