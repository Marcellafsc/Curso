using System;

namespace Prestacoes
{
	class Program
	{
		/*
		 * 19/06/2020
		 * A loja Mamão com Açúcar está vendendo seus produtos em 5 prestações sem juros.
		 * O algoritmo recebe um valor de uma compra e mostra o valor das prestações.
		 * Versão: Beta
		 */

		static void Main(string[] args)
		{
			decimal valor, resultado;
			
			Console.WriteLine("Digite o total a pagar: ");
			valor = decimal.Parse(Console.ReadLine());

			resultado = valor / 5;

			Console.WriteLine($"O valor total a pagar é: {resultado}");
		}
	}
}
