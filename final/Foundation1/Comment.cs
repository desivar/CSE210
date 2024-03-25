//class comment/ just need to get the user who did the comment and te comment itself

public class Comment
{
    private string _userName;
    private string _comment;

    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comment = comment;

    }
    ////write code to get user name/get user comment
    public string GetUserName()
    {
        return _userName;
    }
    public string GetComment()
    {
        return _comment;
    }
}
