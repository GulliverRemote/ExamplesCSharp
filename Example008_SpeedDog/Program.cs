double v1dr = new Random().Next(1, 6),
       v2dr = new Random().Next(1, 6),
       smezh = new Random().Next(5, 50),
       vDog = new Random().Next(1, 7),
       t = 0;
int count = 0;
bool friend = false;

Console.WriteLine($"Скорость 1 друга = {v1dr}");
Console.WriteLine($"Скорость 2 друга = {v2dr}");
Console.WriteLine($"Скорость собаки = {vDog}");
Console.WriteLine($"Расстояние между друзьями = {smezh}");


if (vDog <= v1dr)
{
    Console.WriteLine("Собака слишком медленная чтобы бегать между друзьями");
    Environment.Exit(0);
}
else if (vDog < v2dr)
{
    Console.WriteLine("Собака добежит до 2 друга и не догонит его");
    Environment.Exit(0);
}
else if (vDog == v2dr)
{
    Console.WriteLine("Собака добежит до 2 друга и побежит на равне с ним");
    Environment.Exit(0);
}
else
{
    while (smezh >= 3)
    {
        if (friend == false)
        {
            t = smezh / (vDog + v2dr);
            friend = true;
        }
        else
        {
            t = smezh / (vDog + v1dr);
            friend = false;
        }
        smezh = (v1dr + v2dr) * t;
        smezh = Math.Round(smezh, 4);
        Console.WriteLine(smezh);
        count++;
    }

    Console.WriteLine($"Собака пробежала {count} раз");
}