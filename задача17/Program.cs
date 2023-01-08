// 

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result
}

int getQuarterNumber(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y >0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter
}

int userX = getUserValue("Введите X");
int userY = getUserValue("Введите Y");
int quarter = getQuarterNumber(userX,userY);
if (userX != 0 && userY != o)
{
    int quarter = getQuarterNumber(userX, userY);
    Console.WriteLine($"Точка[{x}],{y}] находится в {quarter} четверти");
}