public class Comments
{
    private string _userName;
    private string _comment;
    public Comments(string userName,string comment)

    {
        _userName=userName;
        _comment=comment;
    }

    //obtain inf

    public string GetUserName()
    {
        return _userName;
        
    }
    public string  GetComment()
    {
        return _comment;
    }
}
