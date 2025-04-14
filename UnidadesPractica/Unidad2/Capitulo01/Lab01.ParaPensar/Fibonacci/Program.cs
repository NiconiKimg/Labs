int total = 0;

int num1 = 0;
int num2 = 1;

int limite = int.Parse(Console.ReadLine());

for(int i = 0; i < limite; i++)
{

    total = num1 + num2;
    Console.WriteLine($"{num2} + {num1} = {total}");
    num1 = num2;
    num2 = total;
}

