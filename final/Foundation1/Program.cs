

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class video
{
    
    private string_author;
    private string_title;
    private int_legth;
    private List<Comments>_comments;
    public video(string author, string title,int lenght)
    {
    _author=author;
    _ttle=title;
    lenght=lenght;
    _comments=newList<Comment>();

    }
    public void AddComent(string author, string comment)

{
comment new Comment=new Comment(author,comment);
_comments.Add(newComment);
}
public void DisplayVideoInfo()

{
    Console.WriteLine("\n--VideoInfo--");
    Console.WriteLine($"Title:{_title}");
    Console.WriteLine($"Author:{_author}");
    Console.WriteLine($"length in seconds:{_length}");
    Console.WriteLine($"Lenght in HH:MM:SS:{GetLenghtInHHMMSS()}");
    Console.WriteLine($"How many comments:{GetCommentsCount()}");
} 
public void DisplayVideoComments()
{
    Console.WriteLine("\n--Comments--");
    foreach(Comment comment in_comments)

{
    Console.WriteLine($"{comment.etUserName()}\n{Comment.GetComment()}");
}
}
public string GetLenghtInHHMMSS()
{
TimeSpan time=TimeSpan.FromSeconds(_lenght); 
return time.ToString(@"hh\:mm\:ss");
}
}
//obtain inf
public string: GetAuthor()
{
    return _author;
}
public string:GetTitle()
{
    return _title

}
public interface: GetLenght()
{
    return _lenght()
}
public int GetCommentsCount()
{ 
    return  _comments.count()
}
}