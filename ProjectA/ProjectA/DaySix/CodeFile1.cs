public delegate void MethodHandlerA();//functional pointer
public delegate int MethodHandlerB(int x,int y);
public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("Calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x+","+y);
        return x * y;
    }
    public int Divide(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x / y;
    }
    public String GetModel()
    {
        return "X500";
    }
}
public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask); //also can be written as mc.DoTask
        MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add); // also can be written as mc.Add
        MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply); //also can be writtem as mc.Multiply
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine(addResult);
        int multiplyResult = methodHandlerTwo(20, 5);
        Console.WriteLine(multiplyResult);

    }
    public static void TestTwo()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Multiply;// multi-cast delegate
        methodHandlerB(100,50);
        Console.WriteLine();
        
    }
}