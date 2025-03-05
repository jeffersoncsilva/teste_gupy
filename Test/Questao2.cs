namespace Test;

public class Questao2
{
	// 1º Forma - Simples, porém complexidade Linear.
	public string VerificaSeNumeroESequenciaDeFibonacci(int numero)
	{
		int a = 0;
		int b = 1;
		List<int> seq = [a, b];
		while(b <= numero)
		{
			if (b == numero)
				return $"O número {numero} pertence à sequência de Fibonnacci: {string.Join(", ", seq)}";

			int temp = b;
			b = a + b;
			a = temp;
			seq.Add(b);
		}

		return $"O número {numero} não pertence à sequência de Fibonnacci: {string.Join(", ", seq)}";
	}

	// Outra forma - um pouco mais complexa, porém complexidade logarítmica
	public bool VerificaSeNumeroPertenceAFibonnaci(long numero)
	{
		return VerificaSeNumeroEQuadradoPerfeito(5 * (numero * numero + 4)) ||
			VerificaSeNumeroEQuadradoPerfeito(5 * (numero * numero - 4));
	}

	private bool VerificaSeNumeroEQuadradoPerfeito(long numero)
	{
		if (numero < 0)
			return false;
		long raiz = (long)Math.Sqrt(numero);
		return raiz * raiz == numero;
	}

}
