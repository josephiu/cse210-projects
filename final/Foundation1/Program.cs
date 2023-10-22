using System;

class Program
{
    static void Main(string[] args)
     {
        var videos = new List<Video>();




        // first video and 3 comments

        var comment1 = new Comment();
        comment1._commenter = "takker";
        comment1._text = "Your Video is the best";

        var comment2 = new Comment();
        comment2._commenter = "tmaks";
        comment2._text = " madppooo";

        var comment3 = new Comment();
        comment3._commenter = "Ken";
        comment3._text = " Love it";

       
        var video1 = new Video();
        video1._author = "Mathew";
        video1._length = 21245;
        video1._tittle = "God is Great";

        video1.comments.Add(comment1);
        video1.comments.Add(comment2);
        video1.comments.Add(comment3);    




         // Second video and 3 comments

        var talker1 = new Comment();
        talker1._commenter = "Sam";
        talker1._text = "I dont like the Video";

        var talker2 = new Comment();
        talker2._commenter = "Marthins";
        talker2._text = " God Bless you";

        var talker3 = new Comment();
        talker3._commenter = "Linux";
        talker3._text = " supper Video";
        
        var video2 = new Video();
        video2._author = "James";
        video2._length = 8000;
        video2._tittle = "Talk2Me";
        video2.comments.Add(talker1);
        video2.comments.Add(talker2);
        video2.comments.Add(talker3);

        // Third video and 3 comments

        var makeup1 = new Comment();
        makeup1._commenter = "Jinp";
        makeup1._text = "Master Class";

        var makeup2 = new Comment();
        makeup2._commenter = "Mercy";
        makeup2._text = " Please Visit The Temple";

        var makeup3 = new Comment();
        makeup3._commenter = "Kwame";
        makeup3._text = " woooow";
        
        var video3 = new Video();
        video3._author = "Lucky";
        video3._length = 9566;
        video3._tittle = "Talk2Me";
        
        video3.comments.Add(makeup1);
        video3.comments.Add(makeup2);
        video3.comments.Add(makeup3);

        // Fourth video and 3 comments

        var online1 = new Comment();
        online1._commenter = "Alma";
        online1._text = "I want the link to this video";

        var online2 = new Comment();
        online2._commenter = "Emeka";
        online2._text = " call me";

        var online3 = new Comment();
        online3._commenter = "Jude";
        online3._text = " check the lyrics";
        
        var video4 = new Video();
        video4._author = "James";
        video4._length = 2500;
        video4._tittle = "Troll";

        video4.comments.Add(online1);
        video4.comments.Add(online2);
        video4.comments.Add(online3);


        // all the 4 videos into the List of videos
        
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);



        
//iterating through the video list and printing out each objects
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
     }

       






}