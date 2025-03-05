using System.Globalization;

namespace Test;

class Questao3
{
	private void ImprimeMenorFaturamentoDiario(double[] faturamentoDiario)
	{
		var menor = faturamentoDiario.Min();
		Console.WriteLine($"O menor faturamento diário foi de: {menor.ToString("C", new CultureInfo("pt-BR"))}");
	}

	private void ImprimeMaiorFaturamentoDiario(double[] faturamentoDiario)
	{
		var maior = faturamentoDiario.Max();
		Console.WriteLine($"O maior faturamento diário foi de: {maior.ToString("C", new CultureInfo("pt-BR"))}");
	}

	private double CalculaMediaFaturamentoMensal(double[] faturamento)
	{
		return faturamento.Sum() / faturamento.Length;
	}

	private void ImprimeDiasComFaturamentoMaiorQueAMedia(double media, double[] faturamento)
	{
		int diasAcimaDamedia = 0;
		for(int i = 0; i < faturamento.Length; i++)
		{
			if (media > faturamento[i])
				diasAcimaDamedia++;
		}

		Console.WriteLine($"A quantidade de dias acima da média foi de: {diasAcimaDamedia} dia(s).");
	}

	public void RealizaOperacoesFaturamento(double[] faturamento)
	{
		ImprimeMenorFaturamentoDiario(faturamento);
		ImprimeMaiorFaturamentoDiario(faturamento);
		var media = CalculaMediaFaturamentoMensal(faturamento);
		ImprimeDiasComFaturamentoMaiorQueAMedia(media, faturamento);
	}
}
