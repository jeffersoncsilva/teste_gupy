using FluentAssertions;
using Xunit;

namespace Test.UnitTest;

public class Questao2Test
{
	[Theory]
	[InlineData(144)]
	[InlineData(233)]
	[InlineData(377)]
	[InlineData(610)]
	[InlineData(987)]
	public void Quando_NumeroPercenteASequenciaDeFibonacci_QuandoUsadoMetodoDeComplexidadeExponencial_DeveSerImprimidoMensagemNoConsole(int numero)
	{
		Questao2 questao2 = new();
		var resultado = questao2.VerificaSeNumeroESequenciaDeFibonacci(numero);
		resultado.Should().Contain($"O número {numero} pertence à sequência de Fibonnacci");
	}


	[Theory]
	[InlineData(102)]
	[InlineData(150)]
	[InlineData(205)]
	[InlineData(318)]
	[InlineData(500)]
	public void Quando_NumeroNaoPertenceASequenciaDeFibonacci_QuandoUsadoMetodoDeComplexidadeExponencial_DeveSerRetornadoMensagemIndicandoQueNaoPertence(int numero)
	{
		Questao2 questao2 = new();
		var resultado = questao2.VerificaSeNumeroESequenciaDeFibonacci(numero);
		resultado.Should().Contain($"O número {numero} não pertence à sequência de Fibonnacci:");
	}

	[Theory]
	[InlineData(144)]
	[InlineData(233)]
	[InlineData(377)]
	[InlineData(610)]
	[InlineData(987)]
	public void Quando_NumeroPercenteASequenciaDeFibonacci_QuandoUsadoMetodoDeComplexidadeLogaritimica_DeveSerImprimidoMensagemNoConsole(int numero)
	{
		Questao2 questao2 = new();
		var resultado = questao2.VerificaSeNumeroESequenciaDeFibonacci(numero);
		resultado.Should().Contain($"O número {numero} pertence à sequência de Fibonnacci");
	}


	[Theory]
	[InlineData(102)]
	[InlineData(150)]
	[InlineData(205)]
	[InlineData(318)]
	[InlineData(500)]
	public void Quando_NumeroNaoPertenceASequenciaDeFibonacci_QuandoUsadoMetodoDeComplexidadeLogaritimica_DeveSerRetornadoMensagemIndicandoQueNaoPertence(int numero)
	{
		Questao2 questao2 = new();
		var resultado = questao2.VerificaSeNumeroESequenciaDeFibonacci(numero);
		resultado.Should().Contain($"O número {numero} não pertence à sequência de Fibonnacci:");
	}
}
