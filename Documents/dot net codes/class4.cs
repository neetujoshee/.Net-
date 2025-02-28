class TestPublisher
{
    //delegate declaration
    public delegate void TestDelegate();
    //event declaraion
    public event TestDelegate TestEvent;
    public void sampleActions();
    {
        Console.WriteLine("sample actions performed!");
        OnTestEvent();
    }
    //defining a method to raise a event
    Public void OnTestEvent )
}