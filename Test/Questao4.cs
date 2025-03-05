namespace Test;

public class Questao4
{
	private double CalculaFaturamentoMensal(Dictionary<string, double> faturamentoPorEstado)
	{
		double faturamentoTotal = 0;
		foreach (double valor in faturamentoPorEstado.Values)
			faturamentoTotal += valor;

		return faturamentoTotal;
	}

	private void ImprimePercentualRepresentacaoDeCadaEstadoNoFaturamento(double faturamentoTotal, Dictionary<string, double> faturamento)
	{
		foreach(KeyValuePair<string, double> estado in faturamento)
		{
			double percentual = (estado.Value / faturamentoTotal) * 100;
			Console.WriteLine($"Estado: {estado.Key}: {percentual:F2}%");
		}
	}

	public void ImprimePercentualRepresentacaoVendasDeCadaEstado(Dictionary<string, double> faturamento)
	{
		if (faturamento.Count == 0)
			return;
		double faturamentoTotal = CalculaFaturamentoMensal(faturamento);
		ImprimePercentualRepresentacaoDeCadaEstadoNoFaturamento(faturamentoTotal, faturamento);
	}
}
