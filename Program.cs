using System;
using System.Diagnostics;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;
 
    public SayaTubeUser(string username)
    {
        Debug.Assert(username.Length <= 100, "Nama username memiliki panjang maksimal 100 karakter");
        Debug.Assert(username != null, "Nama username tidak berupa null.");
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();

    }
    public int GetTotalVideoPlayCount()
    {
        int hasil = 0;
        Debug.Assert(uploadedVideos[i].GetPlayCount() <= int.MaxValue, "Video yang ditambahkan punya playCount yang kurang dari bilangan integer maksimum")
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            hasil += uploadedVideos[i].GetPlayCount();
        }
        return hasil;
     
    }
    public void addVideo(SayaTubeVideo tube)
    {
        Debug.Assert(tube != null, "Video yang ditambahkan tidak berupa null.");
        try
        {
            checked
            {
                uploadedVideos.Add(tube);
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error! code yang di tambahkan tidak boleh ksong");
        }
    }
    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User : " + this.Username);
        for (int i = 0; i < 8; i++)
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
        Debug.Assert(title != null, "Judul Tidak boleh kosong");
        Debug.Assert(judulvideo.Length <= 200, "Panjang maksimal Video maksimal 200 karakter");
        Debug.Assert(playCount > 0, "Input play count tidak berupa bilangan negatif.");
        this.title = judulvideo;
        this.playCount = 0;
        this.id = rand.Next(10000, 99999);
    }
    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count <= 25000000, "Input penambahan play count maksimal 25.000.000 per panggilan method-nya");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error,playcount melebihi batas maksimum");
            this.playCount = int.MaxValue;
        }
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

        try
        {
            SayaTubeUser user = new SayaTubeUser("Sadul");
            SayaTubeVideo video = new SayaTubeVideo("Power Ranger");

            for (int i = 0; i < 10; i++)
            {
                user.addVideo(video = new SayaTubeVideo("Utramen"));
                user.addVideo(video = new SayaTubeVideo("Boiboiboy"));
                user.addVideo(video = new SayaTubeVideo("Upin - ipin"));
                user.addVideo(video = new SayaTubeVideo("Pada Zaman Dahulu"));
            }

        }

      
             
    }
}
