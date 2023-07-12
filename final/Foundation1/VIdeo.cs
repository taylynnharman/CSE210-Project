//Store title, author, and length (in seconds) of the video. Each video also has responsibility to store a list of comments, and should have a method to return the number of comments. 
class Video {
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    public List<Comment> Comments { get; set; }

    public Video()
    {
        Comments = new List<Comment>();
    }

    public int NumComments()
    {
        return Comments.Count;
    }
}