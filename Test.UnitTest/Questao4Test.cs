using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Moq;

namespace Test.UnitTest
{
	public class Questao4Test
	{
		[Fact]
		public void Quando_ChamadoMetodoDeImprimirPercentual_Should_ImprimirPercentuaisDosEstadosCorretamente()
		{
			var faturamento = new Dictionary<string, double>
			{
				{ "SP", 50 },
				{ "RJ", 50 }
			};

			var questao4 = new Questao4();
			using (var consoleOutput = new StringWriter())
			{
				Console.SetOut(consoleOutput);
				questao4.ImprimePercentualRepresentacaoVendasDeCadaEstado(faturamento);
				var output = consoleOutput.ToString();

				output.Should().Contain("Estado: SP: 50,00%");
				output.Should().Contain("Estado: RJ: 50,00%");
			}
		}

		[Fact]
		public void Quando_ChamadoMetodoDeImprimirPercentual_Com_FaturamentoEVazio_Entao_NaoDeveImprimirNada()
		{
			var faturamento = new Dictionary<string, double>();
			var questao4 = new Questao4();
			using (var saidaConsole = new StringWriter())
			{
				Console.SetOut(saidaConsole);
				questao4.ImprimePercentualRepresentacaoVendasDeCadaEstado(faturamento);
				var saida = saidaConsole.ToString();
				saida.Should().BeEmpty();
			}
		}

		[Fact]
		public void Quando_ChamadoMetodoDeImprimirPercentual_Com_DadosPreenchidosCorretamente_Entao_DeveImprimriCorretamente()
		{
			var faturamento = new Dictionary<string, double>
			{
				{"SP", 67836.43},
				{"RJ", 36678.66},
				{"MG", 29229.88},
				{"ES", 27165.48},
				{"Outros", 19849.53}
			};

			var questao = new Questao4();

			using (var saidaConsole = new StringWriter())
			{
				Console.SetOut(saidaConsole);
				questao.ImprimePercentualRepresentacaoVendasDeCadaEstado(faturamento);

				// Assert
				var saida = saidaConsole.ToString();
				saida.Should().Contain("Estado: SP: 37,53%");
				saida.Should().Contain("Estado: RJ: 20,29%");
				saida.Should().Contain("Estado: MG: 16,17%");
				saida.Should().Contain("Estado: ES: 15,03%");
				saida.Should().Contain("Estado: Outros: 10,98%");
			}

			
		}
	}
}