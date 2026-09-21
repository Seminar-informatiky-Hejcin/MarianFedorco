namespace NumberStatistics;

class Program
{
    static void Main(string[] args)
    {
        Numbers numbers;
        Console.Write("Enter your numbers in the format 1,2,3,4: ");
        try
        {
            numbers = new Numbers(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("The numbers were given in the wrong format!");
            return;
        }

        while (true)
        {
            Console.Write("Which statistic would you like to see: (View numbers-V / View sum-S / View average-A / View number of numbers-N / View max-MA / View min-MI)");
            switch (Console.ReadLine())
            {
                case "V":
                    numbers.printNumbers();
                    break;
                case "S":
                    numbers.printNumbersSum();
                    break;
                case "A":
                    numbers.printNumbersAverage();
                    break;
                case "N":
                    numbers.printNumbersLength();
                    break;
                case "MA":
                    numbers.printNumbersMax();
                    break;
                case "MI":
                    numbers.printNumbersMin();
                    break;
                default:
                    continue;
            }
        }

    }
}

class Numbers
{
    private int[] numbers;
    public Numbers(string input)
    {
        String[] numbersStrings = input.Split(",");
        this.numbers = new int[numbersStrings.Length];
        for (int i = 0; i < numbersStrings.Length; i ++)
        {
            this.numbers[i] = int.Parse(numbersStrings[i]);
        }
    }

    public void printNumbers()
    {
        Console.WriteLine("Your numbers:");
        for (int i = 0; i < this.numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            Console.Write(" ");
        }
        Console.Write("\n");
    }

    public void printNumbersSum()
    {
        int sum = 0;
        for (int i = 0; i < this.numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Sum of your numbers:");
        Console.WriteLine(sum);
    }

    public void printNumbersAverage()
    {
        int sum = 0;
        for (int i = 0; i < this.numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Average of your numbers:");
        Console.WriteLine((double) sum/this.numbers.Length);
    }

    public void printNumbersLength()
    {
        Console.WriteLine("Number of you numbers:");
        Console.WriteLine(this.numbers.Length);
    }

    public void printNumbersMax()
    {
        int max = numbers[0];
        for (int i = 0; i < this.numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("The biggest number in your set is:");
        Console.WriteLine(max);
    }

    public void printNumbersMin()
    {
        int min = numbers[0];
        for (int i = 0; i < this.numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine("The smallest number in your set is:");
        Console.WriteLine(min);
    }
}