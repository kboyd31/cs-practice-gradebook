public class Statistics
{
    public double Average;
    public double Low;
    public double High;

    public Statistics()
    {
        this.Average = 0.0;
        this.Low = double.MinValue;
        this.High = double.MaxValue;
    }
}