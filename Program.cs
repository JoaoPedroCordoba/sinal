int n;

Console.WriteLine("Digite um numero:");
n = Convert.ToInt32(Console.ReadLine());

bool n2;

n2 = (n == 0);

if (n2)
{
    Console.WriteLine("zero");
}
else  if (n < 0){
        Console.WriteLine("negativo");
    }
    else{
        Console.WriteLine("positivo");
    }
