using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Video1
        Video video1 = new Video("Proper ways to pray", "Muhire", 1200.98);
        Comments comment1 = new Comments("Mboi", "Wow! this is great!");
        Comments comment2 = new Comments("Ernest", "Asante sana");
        Comments comment3 = new Comments("Alice", "Mubarikiwe kaka!\n");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // Video2
        Video video2 = new Video("Impanvu", "Israel Mbonyi", 1234.45);
        Comments comment10 = new Comments("Mutama", "Imana Ishimwe kuko yatuyaye ubwakabiri");
        Comments comment20 = new Comments("@Stance32", "Great Vocals");
        Comments comment30 = new Comments("Fred", "Hashimwe Yesu Iteka ryose\n");
        video2.AddComment(comment10);
        video2.AddComment(comment20);
        video2.AddComment(comment30);

        // Video3
        Video video3 = new Video("Let Your Hair Down", "MAGIC", 300.00);
        Comments comment100 = new Comments("Mike", "Who's still here in 2026?");
        Comments comment200 = new Comments("@Konko89", "Great Vocals");
        Comments comment300 = new Comments("Profasq", "I love the Guitars");
        Comments comment400 = new Comments("Sarah", "Flavourful drums");
        video3.AddComment(comment100);
        video3.AddComment(comment200);
        video3.AddComment(comment300);
        video3.AddComment(comment400);

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}