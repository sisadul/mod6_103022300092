using System;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;
 
    public SayaTubeUser(string username)
    {
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();

    }
    public int GetTotalVideoPlayCount()
    {
        int hasil = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            hasil += uploadedVideos[i].GetPlayCount();
        }
        return hasil;
     
    }
    public void addVideo(SayaTubeVideo tube)
    {
        uploadedVideos.Add(tube);
    }
    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User : " + this.Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            this.uploadedVideos[i].PrintVideoDetails();
        }
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string judulvideo)
    {
        Random rand = new Random();
        this.title = judulvideo;
        this.id = rand.Next(10000,99999);
        this.playCount = 0;
    }
    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }
    public int GetPlayCount()
    {
        return this.playCount;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("Id Video: " + this.id);
        Console.WriteLine("Judul Video: " + this.title);
        Console.WriteLine("Jumlah diputar: " + this.playCount);
    }
}

class Program
{ 
    public static void Main(string[] args)
    {

        SayaTubeUser user = new SayaTubeUser("Sadul");
        SayaTubeVideo video = new SayaTubeVideo("Power Ranger");
        user.addVideo(video = new SayaTubeVideo("Utramen"));
        user.addVideo(video = new SayaTubeVideo("Boiboiboy"));
        user.addVideo(video = new SayaTubeVideo("Upin - ipin"));
        user.addVideo(video = new SayaTubeVideo("Pada Zaman Dahulu"));
        video.IncreasePlayCount(1);
        user.PrintAllVideoPlayCount();
        video.PrintVideoDetails();
             
    }
}
