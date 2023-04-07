

double height, ideaWeight;
char genre;
Console.Write("Enter your Height: ");
height = double.Parse(Console.ReadLine());

Console.WriteLine("\nEnter your Genre ('M' or 'W'): ");
genre = char.Parse(Console.ReadLine());


if(genre == 'm' || genre == 'M')
{
    ideaWeight = (72.7 * height) - 58;
    Console.WriteLine("Your ideal weight is: "+ ideaWeight.ToString("F1"));
}
else if(genre == 'w' || genre == 'W')
{
    ideaWeight = (62.1 * height) - 44.7;
    Console.WriteLine();
    Console.WriteLine("Your ideal weight is: " + ideaWeight.ToString("F1"));
}
