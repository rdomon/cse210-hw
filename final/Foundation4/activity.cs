class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // アクセサメソッド
    protected string GetDate()
    {
        // change format of date to "03 Nov 2022" 
        DateTime date = DateTime.Parse(_date);
        return date.ToString("dd MMM yyyy");
    }

    protected double GetMinutes()
    {
        return _minutes;
    }


    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    // get summary
    public virtual string GetSummary()
    {
        return $"{GetDate()} Unknown Activity ({_minutes} min)";
    }
}