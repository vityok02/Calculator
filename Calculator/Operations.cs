namespace Calculator;

class Calculate
{
    public void DoOperation()
    {
        string operation = GetOperation();
        switch (operation)
        {
            case "+":
                Console.WriteLine(operation);
                break;
        }
    }
    public static string GetValueFromConsole()
    {
        string operation = Console.ReadLine();
        return operation;
    }

    public static string GetOperation()
    {
        string operation = Console.ReadLine();
        return operation;
    }
}