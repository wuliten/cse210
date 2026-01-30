using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "How Small Does Water Get?";
        video1._author = "The Slow Mo Guys";
        video1._length = 56;
        video1.AddComment(new Comment { _name = "@theslowmoguys", _text = "This entire short takes place in 0.19 of a second." });
        video1.AddComment(new Comment { _name = "@ashtonarrington698", _text = "I love how the last one just blasted off" });
        video1.AddComment(new Comment { _name = "@calebroush1484", _text = "This is legitimately one of the coolest things I have ever seen filmed" });

        Video video2 = new Video();
        video2._title = "Dragon Ball Z Abridged Episode 1";
        video2._author = "TeamFourStar";
        video2._length = 521;
        video2.AddComment(new Comment { _name = "@thedaleyintake7092", _text = "January 2 2026, I'm rewatching." });
        video2.AddComment(new Comment { _name = "@wolfpackattack", _text = "It funny how Krillin's Owned count starts and ends at Kame house." });
        video2.AddComment(new Comment { _name = "@LezbionestHere", _text = "The older this gets, the funnier the myspace jokes get"});

        Video video3 = new Video();
        video3._title = "Health potion logic";
        video3._author = "Viva La Dirt League";
        video3._length = 109;
        video3.AddComment(new Comment { _name = "@vg2448", _text = "8 hours later on the toilet... -500 HP." });
        video3.AddComment(new Comment { _name = "@maxgoose707", _text = "He just healed back the damage that done to his mouth" });
        video3.AddComment(new Comment { _name = "@yakisova7576", _text = "Rowan is like those main characters that got teleported to another world" });

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
