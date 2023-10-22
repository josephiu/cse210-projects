using System.Security.Cryptography.X509Certificates;

class Video
{
    public string _tittle;
    public string _author;
    public double _length;

    public List<Comment> comments = new List<Comment>();
   

    
    public int GetNumberOfComments()
    {
        return comments.Count;
    }



    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_tittle}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (seconds): {_length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine($"{comment._commenter}: {comment._text}");
        }
        Console.WriteLine();    


    }

}

   
      