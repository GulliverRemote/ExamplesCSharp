double v1dr = new Random().Next(1, 6),
       v2dr = new Random().Next(1, 6),
       smezh = new Random().Next(5, 50),
       
       t = 0;
int count = 0;
bool friend = false;

int max = (int)v1dr;

if (max < v2dr)
    max = (int)v2dr;
double vDog = new Random().Next(max, 7);


Console.WriteLine($"Скорость 1 друга = {v1dr}");
Console.WriteLine($"Скорость 2 друга = {v2dr}");
Console.WriteLine($"Скорость собаки = {vDog}");
Console.WriteLine($"Расстояние между друзьями = {smezh}");


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