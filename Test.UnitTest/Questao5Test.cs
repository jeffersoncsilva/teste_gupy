using FluentAssertions;
using System.ComponentModel;

namespace Test.UnitTest;

public class Questao5Test
{

	[Fact]
	public void Quando_PassadoUmaStringQualquer_DeveRetornarStringInvertida()
	{
		var q5 = new Questao5();

		var entrada = "hello";
		var resultadoEsperado = "olleh";

		var resultado = q5.InverteCaracteresStringSimples(entrada);

		resultado.Should().Be(resultadoEsperado);
	}

	[Fact]
	public void Quando_PassadoStringVazia_Entao_DeveRetornarStringVazia()
	{
		var q5 = new Questao5();
		var entrada = "";

		var resultado = q5.InverteCaracteresStringSimples(entrada);

		resultado.Should().Be("");
	}

	[Fact]
	public void Quando_PassadoStringNula_DeveRetornarStringVazia()
	{
		var q5 = new Questao5();
		string? entrada = null;
		var resultado = q5.InverteCaracteresStringSimples(entrada);
		resultado.Should().Be("");
	}
}
