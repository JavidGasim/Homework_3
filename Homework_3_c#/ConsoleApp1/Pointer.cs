namespace ConsoleApp1;

internal class Pointer
{
    public int x { get; set; }
    public int y { get; set; }

    public Pointer()
    {

    }

    public Pointer(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void showData()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
    }
}
