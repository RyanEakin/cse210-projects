using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _discussion = new List<Comment>(); //changed it to discussion due to its specificity

    //didn't add a blank Video class due to it not being necessary
    public Video(List<Comment> discussion, string author, string title, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _discussion = discussion;
    }

    public int CommentAmount() 
    //changed this to no argument due to the member variable being in the same class
    {   
        int amountComments =_discussion.Count;
        return amountComments;
    }
    // didn't need the Display class after all, so I cut it out of the program.
}