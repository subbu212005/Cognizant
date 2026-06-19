using System;

interface IMediaPlayer
{
    void Play();
}

class Mp3Player : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing MP3 File");
    }
}

class Program
{
    static void Main()
    {
        IMediaPlayer player=new Mp3Player();
        player.Play();
    }
}
