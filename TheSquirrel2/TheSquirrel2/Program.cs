
int row = 0;
int col = 0;
int hazelNut = 0;

bool endOfGame = false;

int n = int.Parse(Console.ReadLine());
string[] tockens = Console.ReadLine().Split(", ").ToArray();

char[,] field = new char[n, n];



for (int i = 0; i < field.GetLength(0); i++)
{
    string sentence = Console.ReadLine();
    char[] comand = sentence.ToCharArray();

    for (int j = 0; j < field.GetLength(1); j++)
    {
        if (comand[j] == 's')
        {
            row = i;
            col = j;
        }
        field[i, j] = comand[j];
    }
}

   
    for (int k = 0; k < tockens.Length; k++)
    {
        string comand = tockens[k];
        field[row, col] = '*';

        if (comand == "left")
        {
            col--;
        }
        else if (comand == "right")
        {
            col++;
        }

        else if (comand == "up")
        {
            row--;
        }
        else if (comand == "down")
        {
            row++;
        }


        if (row >= n || row < 0 || col >= n || col < 0)
        {
            Console.WriteLine("The squirrel is out of the field.");
            endOfGame = true;
            break;
        }

        else if (field[row, col] == '*')
        {
            continue;
        }

        else if (field[row, col] == 'h')
        {
            hazelNut++;
            field[row, col] = '*';

            if (hazelNut == 3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
                field[row, col] = 's';

                endOfGame = true;
                break;

            }
        }

        else if (field[row, col] == 't')
        {
            Console.WriteLine($"Unfortunately, the squirrel stepped on a trap...");
        field[row, col] = '*';
        endOfGame = true;
            break;
        }


    }
if (!endOfGame)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
Console.WriteLine($"Hazelnuts collected: {hazelNut}");


