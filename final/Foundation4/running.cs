class Running : Activity
{
    private double _distance; // mile単位

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // 速度 = (距離 / 分) * 60 = マイル/時
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        // pace = min / distance = min/mile
        return GetMinutes() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}