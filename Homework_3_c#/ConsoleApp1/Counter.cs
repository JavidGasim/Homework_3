namespace ConsoleApp1;

internal class Counter
{
    public int min { get; set; }
    public int max { get; set; }
    public int currentData { get; set; }

    public Counter()
    {

    }

    public Counter(int min, int max, int currentData)
    {
        this.min = min;
        this.max = max;
        this.currentData = currentData;
    }

    public void increment()
    {
        if (currentData<max)
        {
            currentData++;

            Console.WriteLine("Current Data: " + currentData);
        }

        else
        {
            Console.WriteLine("Current Data is Maximum");
        }
    }

    public void decrement()
    {

        if (currentData > min)
        {
            currentData--;

            Console.WriteLine("Current Data: " + currentData);
        }

        else
        {
            Console.WriteLine("Current Data is Minimum");
        }

    }
}
