class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 距離（マイル） = ラップ数 * 50 / 1000 * 0.62
        return _laps * 50.0 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        // 速度 = (距離 / 分) * 60 = マイル/時
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        // ペース = 分 / 距離 = 分/マイル
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile, Laps: {_laps}";
    }
}