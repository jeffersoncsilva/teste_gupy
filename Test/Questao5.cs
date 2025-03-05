using System.Text;

namespace Test;

class Questao5
{
	// Maneira mais simples usar o .revert
	public string InverteCaracteresString(string? str)
	{
		return str?.Reverse().ToString() ?? string.Empty;
	}

	// Maneira a mão simplista
	public string InverteCaracteresStringSimples(string? str)
	{
		var builder = new StringBuilder();
		foreach(var caractere in (str?.Reverse() ?? ""))
		{
			builder.Append(caractere);
		}
		return builder.ToString();
	}

	// Outra maneira seria
	public string InverteCaracteresStringSimples2(string? str)
	{
		if (string.IsNullOrWhiteSpace(str))
			return string.Empty;

		var size = str.Length;
		char[] caracteres = new char[size];

		for(int i = 0; i < size; i++)
		{
			caracteres[size - 1 - i] = str[i];
		}

		return new string(caracteres);
	}
}
