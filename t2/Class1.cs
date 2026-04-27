using System;
using System.Security.Cryptography;

public partial class Test
{
	private int Mid;
    private int Final;

    public void SetGrade(int Mid,int Final)
    {
        if(ValidGrade(Mid, Final))
        {
            this.Mid = Mid;
            this.Final = Final;
        }
    }

    public double GetAvg()
    {
        return (Mid + Final) / 2.0;
    }
}

public partial class Test
{
    private bool ValidGrade(int Mid, int Final)
    {
        return (Mid >= 0 && Mid <= 100 && Final >= 0 && Final <= 100);
    }
}