/*
 1- Faça um programa que leia dez numeros inteiros e imprima os seguintes itens: 
	A) somente os valores pares
	B) somente os valores impares
	C) somente a primeira e a ultima posicao
 */

Console.WriteLine("=====Numeros pares e impares=====");

int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];
int qntPares = 0, qntImpares = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o numero({i}): ");
	numeros[i] = int.Parse(Console.ReadLine());
}


for(int i = 0;i < 10; i++)
{
	if (numeros[i] % 2 == 0)
	{
		pares[qntPares++] = numeros[i];
	}
	else
	{
		impares[qntImpares++] = numeros[i];
	}
}
Console.WriteLine("=============================");

if(qntPares > 0)
{
    Console.WriteLine("Valores pares:");

	for(int i  = 0; i < qntPares; i++)
	{
		Console.Write($"{pares[i]} ");
    }
}

Console.WriteLine("\n=============================");

if (qntImpares > 0)
{
    Console.WriteLine("Valores impares:");

    for (int i = 0; i < qntImpares; i++)
    {
        Console.Write($"{impares[i]} ");
    }
}

Console.WriteLine("\n=============================");

Console.WriteLine($"Primeira posicao: {numeros[0]}");
Console.WriteLine($"Ultima posicao: {numeros[9]}");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
