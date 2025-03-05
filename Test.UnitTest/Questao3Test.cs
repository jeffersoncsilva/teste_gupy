using FluentAssertions;
using System.Globalization;

namespace Test.UnitTest;

public class Questao3Test
{
	[Fact]
	public void Quando_FaturamentoTemTamanhoZero_EntaoNaoDeveSerExibidoNadaNaTela()
	{
		var faturamento = new List<double>();

		var q3 = new Questao3();
		using (var consoleOutput = new StringWriter())
		{
			Console.SetOut(consoleOutput);

			q3.RealizaOperacoesFaturamento(faturamento.ToArray());
			var output = consoleOutput.ToString();

			output.Should().BeEmpty();
		}
	}

	[Fact]
	public void Quando_FaturamentoTemTamanhoUnico_Entao_DeveSerExibidoValoresIguaisNaTela()
	{
		double[] faturamento = [1200.0];
		var q3 = new Questao3();
		using (var consoleOutput = new StringWriter())
		{
			Console.SetOut(consoleOutput);

			q3.RealizaOperacoesFaturamento(faturamento.ToArray());
			var output = consoleOutput.ToString();

			output.Should().Contain($"O menor faturamento diário foi de: {faturamento[0].ToString("C", new CultureInfo("pt-BR"))}");
			output.Should().Contain($"O maior faturamento diário foi de: {faturamento[0].ToString("C", new CultureInfo("pt-BR"))}");
			output.Should().Contain($"A quantidade de dias acima da média foi de: {0} dia(s).");
		}

	}

	[Fact]
	public void Quando_FaturamentoTemTamanhoDeDoisMasSaoIguais_Entao_DeveSerExibidoValoresIguaisNaTela()
	{
		double[] faturamento = [1200.0, 1200.0];
		var q3 = new Questao3();
		using (var consoleOutput = new StringWriter())
		{
			Console.SetOut(consoleOutput);

			q3.RealizaOperacoesFaturamento(faturamento.ToArray());
			var output = consoleOutput.ToString();

			output.Should().Contain($"O menor faturamento diário foi de: {faturamento[0].ToString("C", new CultureInfo("pt-BR"))}");
			output.Should().Contain($"O maior faturamento diário foi de: {faturamento[0].ToString("C", new CultureInfo("pt-BR"))}");
			output.Should().Contain($"A quantidade de dias acima da média foi de: {0} dia(s).");
		}
	}

	[Fact]
	public void Quando_FaturamentoTemTamanhoVariado_Entao_DeveSerExibidosMenorValorMaiorValorEQuantidadeDeDiasAcima()
	{
		double[] faturamento = [1200.0, 1100.0, 999.99, 1333.0, 2059.12, 879.45];
		var q3 = new Questao3();
		using (var consoleOutput = new StringWriter())
		{
			Console.SetOut(consoleOutput);

			q3.RealizaOperacoesFaturamento(faturamento.ToArray());
			var output = consoleOutput.ToString();

			output.Should().Contain($"O menor faturamento diário foi de: {faturamento[5].ToString("C", new CultureInfo("pt-BR"))}");
			output.Should().Contain($"O maior faturamento diário foi de: {faturamento[4].ToString("C", new CultureInfo("pt-BR"))}");
			output.Should().Contain($"A quantidade de dias acima da média foi de: {4} dia(s).");
		}
	}
}
