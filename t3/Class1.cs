using System;

public class Student
{
    private string Name;
    private Test Score;
    private static int Count = 0;

    public Student(string n, int m, int f)
    {
        Name = n;
        Score = new Test(m, f);
        Count++;
    }

    public string GetStudentInfo()
    {
        string str = "";
        str = "\n第"+ Count + "位學生";
        str += "\n學生姓名:" + "Name";
        str += "\n學生期中考試:" + Score.NewMid;
        str += "\n學生期末考試:" + Score.NewFinal;
        return str;
    }
}
