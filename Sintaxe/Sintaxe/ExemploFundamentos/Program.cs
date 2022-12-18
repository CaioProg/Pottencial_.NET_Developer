


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");


Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//    Console.WriteLine($"Posição N {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//    Console.WriteLine($"Posição N {contadorForeach} - {listaString[contadorForeach]}");
//    contadorForeach++;
// }









// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);

// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// Console.WriteLine("Percorrendo o Array com o FOR");

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//    Console.WriteLine($"Posição N {contador} - {arrayInteiros[contador]}");
// }







// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//       Console.WriteLine($"Posição N {contadorForeach} - {valor}");
//       contadorForeach++;
// }