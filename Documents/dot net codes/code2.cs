class ExceptionEx 
{
    int x, y;
    public ExceptionEx(int a, int b)
    {
        x = a;
        y = b;
    }
    public void divide()
    {
        Console.WriteLine("result of division:"+(x/y));
    }
}
class ExceptionTest
{
    public static void Main(string[] args)
    {
        ExceptionEx E = new ExceptionEx(10,0);
    }
}