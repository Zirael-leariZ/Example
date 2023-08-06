int min;
int max;

Console.WriteLine ("What's min: ");
min = int.Parse(Console.ReadLine());

Console.WriteLine ("What's max: ");
max = int.Parse(Console.ReadLine());

Random random = new Random();
int A = random.Next(min,max);
int B = random.Next(min,max);

Console.WriteLine("The min is: " + A);
Console.WriteLine("The max is : " + B);

Console.WriteLine ("A + B is: " + (A + B));

Console.ReadLine();