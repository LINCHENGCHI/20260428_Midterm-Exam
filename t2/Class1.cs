using system;

public partial class Test
{
    int Mid, Final;

    public void SetGrade(int Mid, int Final)
    {
        if (ValidGrade(Mid, Final))
        {
            this.Mid = Mid;
            this.Final = Final;
        }
    }

    public double GetAvg() => (Mid + Final) / 2.0;
}

public partial class Test
{
    bool ValidGrade(int Mid, int Final)
        => Mid >= 0 && Mid <= 100 && Final >= 0 && Final <= 100;
}