using System;
// a C# program that simulates an extraction of fake comments from a fake video in YouTube
  //strings
class Program
{
     static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("EasyTutorials", "How to Play Two Steps from Hell", 330);
        _videos[0].AddComment("Charles", "thanks a lot!");
        _videos[0].AddComment("Aramys", "Well done!");
        _videos[0].AddComment("Mity", "finally a version for begginners");

        _videos[1] = new Video("How to Draw Birds", "Easy tutorial", 980);
        _videos[1].AddComment("anyf","Easy technique");
        _videos[1].AddComment("Mark5","This was a great first class!");
        _videos[1].AddComment("Eny","thank you so much for sharing.That's helpful!!");
        
        _videos[2] = new Video("Wolkenfrei", "Du bist meine Insel", 750);
        _videos[2].AddComment("Myday", "Impossible to stop listening");
        _videos[2].AddComment("Luna", "You got a beautifull voice and the song is the perfect definition of love!");
        _videos[2].AddComment("Gerny9", "Great music, beautiful voice!!! Everything is very harmonious! I enjoyed the song!!! ");

        _videos[3] = new Video("Responsive Web Site", "HTML,CSS,JavaScript", 3200);
        _videos[3].AddComment("cameron", "Great work. Can I know how much time did you spend to do it?");
        _videos[3].AddComment("luis16", "I like the color palette");
        _videos[3].AddComment("lu34", "i like this result");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}
