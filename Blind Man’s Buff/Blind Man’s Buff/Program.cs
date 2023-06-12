int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
string[,] filed = new string[n[0], n[1]];

int rols = -1;
int cols = -1;
int moves = 0;
int touchetOpponents = 0;

for (int rol = 0; rol < filed.GetLength(0); rol++)
{
    string[] line = Console.ReadLine().Split().ToArray();

    for (int col = 0; col < filed.GetLength(1); col++)
    {
        filed[rol, col] = line[col];
        if (line[col] == "B")
        {
            rols = rol;
            cols = col;
            filed[rol, col] = "-";
        }
       
    }
}

;

string comand = string.Empty;

while ((comand = Console.ReadLine()) != "Finish")
{

    if (comand == "up")
    {
        if (!IsInFiled(rols - 1, cols) || filed[rols - 1, cols] == "O")
        { 
            continue;
        }
        rols--;

    }

    else if (comand == "down")
    {

        if (!IsInFiled(rols + 1, cols ) || filed[rols + 1, cols] == "O")
        {
            
            continue;
        }
        rols++;
    }

    else if (comand == "right")
    {
        if (!IsInFiled(rols, cols + 1) || filed[rols, cols + 1] == "O")
        {
            
            continue;
        }
        cols++;

    }
    else if (comand == "left")
    {
        if (!IsInFiled(rols, cols - 1) || filed[rols, cols - 1] == "O")
        {
            
            continue;
        }
        cols--;
    }

    moves++;
    if (filed[rols, cols] == "P")
    {
        filed[rols, cols] = "-";
        touchetOpponents++;

        if (touchetOpponents == 3) { break; }

    }

}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchetOpponents} Moves made: {moves}");





bool IsInFiled(int row, int col)

{
    if (row >= n[0] || row < 0 || col >= n[1] || col < 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}