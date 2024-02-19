using System.ComponentModel.DataAnnotations;

namespace FunWithMusic
{
    internal class Program
    {
        enum Genre
        {
            Classical,
            Pop,
            HipHop,
            Rock,
            Jazz
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }

            public void SetTitle(string title)
            {
                Title = title;
            }

            public void SetLength(string length)
            {
                Length = length;
            }

            public string Display()
            {
                return "Title: " + Title +
                    "\nArtist: " + Artist +
                    "\nAlbum: " + Album +
                    "\nLength: " + Length +
                    "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string title = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string artist = Console.ReadLine();
            Console.WriteLine("What album is it on?");
            string album = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            string length = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("C - Classical\nP - Pop\nH - Hip Hop\nR - Rock\nJ - Jazz");
            Genre? genre;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'C':
                case 'c':
                    genre = Genre.Classical;
                    break;
                case 'P':
                case 'p':
                    genre = Genre.Pop;
                    break;
                case 'H':
                case 'h':
                    genre = Genre.HipHop;
                    break;
                case 'R':
                case 'r':
                    genre = Genre.Rock;
                    break;
                case 'J':
                case 'j':
                    genre = Genre.Jazz;
                    break;
                default:
                    genre = null;
                    break;
            }

            Music music = new Music(title, artist, album, length, genre.GetValueOrDefault());
            Music moreMusic = music;
            Console.WriteLine("What is the next song on the album?");
            moreMusic.SetTitle(Console.ReadLine());
            Console.WriteLine("What is the length of the song?");
            moreMusic.SetLength(Console.ReadLine());

            Console.WriteLine($"{music.Display()}");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}
