namespace CaesarCypher;

class Program
{
    public static int key = 5;
    static void Main(string[] args)
    {
        Console.Write("Zadejte zprávu k šifrování: ");
        String message = Console.ReadLine();

        String messageCypher = CypherMessage(message);

        Console.WriteLine("Zašifrovaná zpráva:");
        Console.WriteLine(messageCypher);
    }

    static String CypherMessage(String message)
    {
        String output = "";
        foreach(char character in message)
        {
            if (character == 35)
            {
                output += character;
                continue;
            }
            else if(character <65 || character >90)
            {
                continue;
            }

            int codedChar = character - 'A';
            codedChar += key;
            codedChar = codedChar % 26;
            codedChar = codedChar + 'A';

            output += (char) codedChar;
        }
        return output;  
    }
}
