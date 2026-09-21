namespace AreaCircumference;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            String property;
            String shape;

            try
            {
                Console.Write("Calculate: (Area - A/Circumference - C)");
                property = Console.ReadLine();
                int a, b, c, h, r;
                switch (property)
                {
                    case "A":
                        Console.Write("Choose a geometrical shape: (Square - S/Rectangle - R/Triangle - T/Circle - C)");
                        shape = Console.ReadLine();
                        switch (shape)
                        {
                            
                            case "S":
                                Console.Write("Enter the length of its side: (integer)");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine(squareArea(a));
                                break;
                            case "R":
                                Console.Write("Enter the length of its side a: (integer)");
                                a = int.Parse(Console.ReadLine());

                                Console.Write("Enter the length of its side b: (integer)");
                                b = int.Parse(Console.ReadLine());

                                Console.WriteLine(rectangleArea(a, b));
                                break;
                            case "T":
                                Console.Write("Enter the length of its side a: (integer)");
                                a = int.Parse(Console.ReadLine());

                                Console.Write("Enter the length of its height h: (integer)");
                                h = int.Parse(Console.ReadLine());

                                Console.WriteLine(triangleArea(a, h));
                                break;
                            case "C":
                                Console.Write("Enter the length of its radius r: (integer)");
                                r = int.Parse(Console.ReadLine());

                                Console.WriteLine(circleArea(r));
                                break;
                            default:
                                continue;
                        }
                        break;
                    case "C":
                        Console.Write("Choose a geometrical shape: (Square - S/Rectangle - R/Triangle - T/Circle - C)");
                        shape = Console.ReadLine();
                        switch (shape)
                        {
                            
                            case "S":
                                Console.Write("Enter the length of its side: (integer)");
                                a = int.Parse(Console.ReadLine());

                                Console.WriteLine(squareCircumference(a));
                                break;
                            case "R":
                                Console.Write("Enter the length of its side a: (integer)");
                                a = int.Parse(Console.ReadLine());

                                Console.Write("Enter the length of its side b: (integer)");
                                b = int.Parse(Console.ReadLine());

                                Console.WriteLine(rectangleCircumference(a, b));
                                break;
                            case "T":
                                Console.Write("Enter the length of its side a: (integer)");
                                a = int.Parse(Console.ReadLine());

                                Console.Write("Enter the length of its side b: (integer)");
                                b = int.Parse(Console.ReadLine());

                                Console.Write("Enter the length of its side c: (integer)");
                                c = int.Parse(Console.ReadLine());

                                Console.WriteLine(triangleCircumference(a, b, c));
                                break;
                            case "C":
                                Console.Write("Enter the length of its radius r: (integer)");
                                r = int.Parse(Console.ReadLine());

                                Console.WriteLine(circleCircumference(r));
                                break;
                            default:
                                continue;
                        }
                        break;
                    default:
                        continue;
                }

                
            }
            catch
            {
                continue;
            }
            
        }
    }

    static double squareArea(int a)
    {
        return a * a;
    }
    static double squareCircumference(int a)
    {
        return 4 * a;
    }

    static double rectangleArea(int a, int b)
    {
        return a * b;
    }
    
    static double rectangleCircumference(int a, int b)
    {
        return 2 * (a + b);
    }

    static double triangleArea(int a, int h)
    {
        return a * h /2;
    }

    static double triangleCircumference(int a, int b, int c)
    {
        return a + b + c;
    }

    static double circleArea(int r)
    {
        return Math.PI * r * r;
    }

    static double circleCircumference(int r)
    {
        return 2 * Math.PI * r;
    }
}

