using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video(
            "How I Built a To-Do App in 24 Hours with 0 Sleep",
            "CodeRush",
            726
        );

        video1.AddComment(new Comment("devDan", "Sleep is for the garbage collector."));
        video1.AddComment(new Comment("sleepyScript", "I tried this and accidentally built a calculator."));
        video1.AddComment(new Comment("byteQueen", "Respect. I need 24 hours just to choose a font."));
        video1.AddComment(new Comment("nullPointer", "At 2:38 you reinvented React. Impressive."));

        Video video2 = new Video(
            "I Let AI Refactor My 10-Year-Old Codebase",
            "SyntaxSurge",
            840
        );

        video2.AddComment(new Comment("aiOverlord", "I for one welcome our robotic overlords."));
        video2.AddComment(new Comment("legacyLarry", "Bold move. Mine just deleted `main()` and left."));
        video2.AddComment(new Comment("refactorFan", "Honestly, looks cleaner than my fresh code."));
        video2.AddComment(new Comment("techTina", "You forgot to version control it before. Ouch."));

        Video video3 = new Video(
            "CSS: Centering Divs Without Crying",
            "FrontendFairy",
            402
        );

        video3.AddComment(new Comment("gridGuy", "I’ve never felt more seen."));
        video3.AddComment(new Comment("floatRegret", "Flashbacks to 2009... not cool."));
        video3.AddComment(new Comment("boxModelBoss", "Should be required viewing in bootcamps."));
        video3.AddComment(new Comment("zeroMargin", "Still confused but at least I’m not alone."));

        List<Video> videos = new List<Video> {
            video1,
            video2,
            video3
        };

        Console.Clear();

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}