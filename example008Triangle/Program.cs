//Console.SetCursorPosition(symbols; string);
//Console.Write("depicting form");

Console.Clear();

int windowWidth = 160;
int windowHeight = 70;

Console.WindowWidth = windowWidth;
Console.WindowHeight = windowHeight;
Console.BufferWidth = windowWidth;
Console.BufferHeight = windowHeight;

int xa = 75, ya = 0,
    xb = 0, yb = 50,
    xc = 150, yc = 50;

Console.SetCursorPosition(xa, ya);
Console.Write("+");

Console.SetCursorPosition(xb, yb);
Console.Write("+");

Console.SetCursorPosition(xc, yc);
Console.Write("+");


//int x = (xa + xb + xc) / 3, y = (ya + yb + yc) / 3;

int x = (60), y = (20);
//Console.SetCursorPosition (x, y);
Console.Write ("+");

int count = 0;

while (count < 100000) 
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

        if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

        if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}