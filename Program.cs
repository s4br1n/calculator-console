class Calculator
{
    public static void Main()
    {
        int input1, input2, action;

        Console.Write("Enter the action to be performed\n");
        Console.Write("Press 1 for Addition\n");
        Console.Write("Press 2 for Substraction\n");
        Console.Write("Press 3 for Multiplication\n");
        Console.Write("Press 4 for Division\n\n");

        action = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter 1st input\n");
        input1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd input\n");
        input2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("The result is ");

        switch (action)
        {
            case 1:
                Console.Write(input1 + input2);
                break;

            case 2:
                Console.Write(input1 - input2);
                break;

            case 3:
                Console.Write(input1 * input2);
                break;

            case 4:
                {
                    Console.Write(input1 / input2);
                }
                break;
        }
        Console.Write("\n press any key");
        Console.ReadKey();
    }
}