

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;



Console.WriteLine("Percorrendo o Array com o FOR");

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
   Console.WriteLine($"Posição N {contador} - {arrayInteiros[contador]}");
}


Console.WriteLine("Percorrendo o Array com o FOREACH");

int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
      Console.WriteLine($"Posição N {contadorForeach} - {valor}");
      contadorForeach++;
}