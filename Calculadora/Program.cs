using System;

namespace Calculadora
{
	class Program
	{
		/*
		 * Faça um algoritmo que receba dois números e ao final mostre a soma, subtração, multiplicação e a divisão dos números lidos.
		 * 19/06/2020
		 */

		static void Main(string[] args)
		{
			int numeroEntrada1, numeroEntrada2, resultadoSoma, resultadoSubtracao, resultadoMultiplicacao, resultadoDivisao;
			
			Console.WriteLine("Digite o primeiro número: ");
			numeroEntrada1 = int.Parse(Console.ReadLine());

			Console.Write("Digite o segundo número: ");
			numeroEntrada2 = int.Parse(Console.ReadLine());

			resultadoSoma = numeroEntrada1 + numeroEntrada2;
			resultadoSubtracao = numeroEntrada1 - numeroEntrada2;
			resultadoMultiplicacao = numeroEntrada1 * numeroEntrada2;
			resultadoDivisao = numeroEntrada1 / numeroEntrada2;

			Console.WriteLine($"Resultado da soma: {resultadoSoma}");
			Console.WriteLine($"Resultado da subtração: {resultadoSubtracao}");
			Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");
			Console.WriteLine($"Resultado da divisão: {resultadoDivisao}");
		}
	}
}
