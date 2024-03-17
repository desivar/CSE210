using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("Two Steps From Hell - Victory (Piano Version)",5297 );
        _video[0].AddComment("");

        _videos[1] = new Video("




How to Build a Hangman Game with Python", 28);
        _videos[1].AddComment("");
        _videos[1].AddComment("");
        _videos[1].AddComment("");
        
        _videos[2] = new Video("The ultimate WATERCOLOUR TUTORIAL | For beginners | Drawlikeasir", 448);
        _videos[2].AddComment("");
        _videos[2].AddComment("");
        _videos[2].AddComment("");

        _videos[3] = new Video("How to draw Anime "Basic Anatomy'' (Anime Drawing Tutorial for Beginners)", 10421);
        _videos[3].AddComment("");
        _videos[3].AddComment("");
        _videos[3].AddComment("");

        for(int i = 0; i <
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}