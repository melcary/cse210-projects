using System;
using System.Runtime.CompilerServices;

public class MathAssigment : Assigment
{
    private string _textBookSection;
    private string _problems;

    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public MathAssigment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}