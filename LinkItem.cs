
    public class LinkItem
    {
    public string Subject { get; set; }
    public string LinkURL { get; set; }
    public bool Viewed { get; set; } = false;

    public LinkItem(string subject, string linkURL, bool viewed)
    {
        Subject = subject;
        LinkURL = linkURL;
        Viewed = viewed;
    }
}

