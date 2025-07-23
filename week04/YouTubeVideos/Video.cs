using System;
using System.Collections.Generic;
public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public Video(string title, string author, int length)
    {
        SetTitle(title);
        SetAuthor(author);
        SetLength(length);
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public List<Comment> GetAllComments()
    {
        return new List<Comment>(_comments);
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Tilte: {GetTitle()}");
        Console.WriteLine($"Author: {GetAuthor()}");
        Console.WriteLine($"Length in seconds: {GetLength()}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in GetAllComments())
        {
            Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
        }
        Console.WriteLine();

    }

}