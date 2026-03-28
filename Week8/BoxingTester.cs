namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        // створили зміну a (value)
        int a = 10;
        
        // зробити боксинг
        object obj = a;
        
        // зробити анбоксинг
        int b = (int)obj;
        
        // вивели всі значення
        Console.WriteLine(a);
        Console.WriteLine(obj);
        Console.WriteLine(b);
    }
}