using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Video firstVideo = CreateVideo();
        Video secondVideo = CreateVideo();
        Video thirdVideo = CreateVideo();
        Video fourthVideo = CreateVideo();

        List<Video> track = new List<Video>();

        track.Add(firstVideo);
        track.Add(secondVideo);
        track.Add(thirdVideo);
        track.Add(fourthVideo);

        for(int i = 0; track.Count > i; i++){
            Console.WriteLine("Author: "+track[i]._author);
            Console.WriteLine("Title: "+track[i]._title);
            Console.WriteLine("Length(Seconds): "+track[i]._length);
            Console.WriteLine("Comments: "+track[i].CommentAmount());
            for(int c = 0; track[i]._discussion.Count > c ; c++)
            {
                Console.WriteLine("\n"+track[i]._discussion[c]._name);
                Console.WriteLine(track[i]._discussion[c]._text+"\n");
            }
        }

    }

    static Video CreateVideo()//added for simpilicty
    {
        List<Comment> commentPage = new List<Comment>();

        List<string> userName = 
        ["Emílie Viviana Pittman", 
        "Donata So-yul Sepúlveda",
        "Marie Roy Rowntree",
        "Rabbie Lan Vrabcová",
        "Alcides Indrani Hristova",
        "Lenny Cher Sheppard",
        "Alvena Rosamund Kerry",
        "Spock",
        "Picard",
        "khan",
        "Sheela"];
        //this is so that I can clearly note that both lists are the same length of elements

        List<string> userText = 
        ["Guys, does your blog has application? Would love to follow your updates via my phone.",
        "I used to love hunting, now I hate it, to kill a living creature for fun and entertainment is just wrong.",
        "My wallet is empty, my attitude is gone, but at least I have cool new Dota skins, LOL.",
        "Why 9GAG forbids image comments in some cases? I’m upset : (",
        "We all wait for one thing in Dota and it is Greeviling, so many years have passed since the last event... Any chance to see new one guys?",
        "Who is your favorite singer? Come on guys, list some names, let's find people with the same taste in the music.",
        "You need to pay attention to small details, sure one small episode alone is not a big deal, but if such episodes are more than ten, things start to look not so good!",
        "Wash your hands before dinner, don't let bad bacterias to harm your immune system.",
        "You are true friend, I will share your post on my social media accounts, hope it will be helpful for you.",
        "Can anyone help me with file recovery? I accidentally formatted my flash drive, all my pictures are gone T_T",
        "I love to have deep conversation with people, a meaningful and interesting conversation with a cup of tea."];
        // ditto of above

        List<string> authorTitle = 
        ["Unlock the Power of Your Own Homelab: DIY Guide to Building an Epic Home Server!",
        "Unlock Your Home Lab Potential: 10 Game-Changing Tips You NEED to Know!",
        "Transform Your Tech Skills: Ultimate Beginner's Guide to Building a Powerful Homelab!",
        "10 Cleaning Hacks That Will CHANGE Your Life: Transform Messy Spaces Instantly!",
        "Epic Clean-Up Challenge! Watch This Mess Transform in Just 30 Minutes!",
        "Revolutionize Your Clean Routine! Top 10 Game-Changing Cleaning Tools You NEED!",
        "Transform Your Cleaning Routine: The Ultimate Guide to Must-Have Cleaning Equipment!",
        "Transform Your Home: 10 Must-Have Cleaning Equipment Hacks You Never Knew Existed!",
        "Top 10 Unbelievable Gaming Secrets You've Never Heard Of!",
        "EXCLUSIVE: 5 Groundbreaking Gaming News Updates You Can't Miss! 🚀 | What's Next in Gaming?",
        "🚨 GAMING NEWS UNLEASHED! 🚀 The Hottest Releases, Shocking Leaks, and Must-Know Updates of 2023!"];
        // again of the above

        Random rnd = new Random();
        int seed = rnd.Next(3,5);
        for(int c = 0; seed > c; c++)
        {
            int characterSeed = rnd.Next(0,11);
            Comment userThought = new Comment(userName[characterSeed],userText[characterSeed]);
            commentPage.Add(userThought);
        }
        int authorSeed = rnd.Next(0,11);
        Video frame = new Video(commentPage,userName[authorSeed],authorTitle[authorSeed],rnd.Next(0,1200));

        return frame;
    }
}