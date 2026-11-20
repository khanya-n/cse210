using System;

class Program
{
    static void Main(string[] args)
    {
        Video albumsVideo = new Video("My Top 10 Albums of All Time", "Michael", 1032);
        Video challengeVideo = new Video("Pokemon Nuzlocke Challenge (GONE WRONG)", "Andre", 1256);
        Video vlogVideo = new Video("My First Day In London", "Devi", 974);

        albumsVideo.AddComment(new Comment("Ian", "Some crazy picks here. HUge respect, though."));
        albumsVideo.AddComment(new Comment("Thando", "Loved #4. It really takes me back to my high school days."));
        albumsVideo.AddComment(new Comment("Brad", "Looks like I've got some new albums to check out."));

        challengeVideo.AddComment(new Comment("Lebo", "Don't feel too bad. You sure did better than I ever could."));
        challengeVideo.AddComment(new Comment("Stephen", "I kinda feel bad about laughing at that last battle but BRUH"));
        challengeVideo.AddComment(new Comment("Alex", "That last battle was insane. So close, yet so far."));

        vlogVideo.AddComment(new Comment("Ollie", "Great. Now I wanna go there even more now."));
        vlogVideo.AddComment(new Comment("Ray", "You should try some chicken tikka masala. It's probably the one British dish I actually enjoy lol."));
        vlogVideo.AddComment(new Comment("Dani", "I always forget that England isn't always so grey."));

        albumsVideo.DisplayVideo();
        challengeVideo.DisplayVideo();
        vlogVideo.DisplayVideo();
    }
}