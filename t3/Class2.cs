using System;

public class Test
{
	private int Mid;
    private int Final;

    public Test(int Mid, int Final)
    {
        this.Mid = Mid;

        this.Final = Final;
    }

    public int NewMid
    {
        get { return Mid; }
    }

    public int NewFinal
    {
        get { return Final; }
        set { Final = value; }
    }
}
