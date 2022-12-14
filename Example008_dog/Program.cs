// See https://aka.ms/new-console-template for more information

//Console.Clear();

int count = 0;
double distance = 10000;
int speadF1 = 1; int speadF2 = 20; int speadDog = 5;
int friend = 2;
double time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (speadDog + speadF1);
        friend = 2;
    }
    else
     {
        time = distance / (speadDog + speadF2);
        friend = 1;

    }
    distance = distance - time * (speadF1 + speadF2);
    count++;
}

Console.Write("Dog runs " + count + " times");