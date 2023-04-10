Console.WriteLine("Insira uma palavra: ");
string palavra = Console.ReadLine().ToUpper();

string palavraInvertida = string.Empty;

//separar os caracteres da palavra do fim para o começo
for (int i = palavra.Length - 1; i >= 0; i--)
{
    //concatenar os caracteres
    palavraInvertida += palavra[i];
}

Console.WriteLine("A palavra digitada foi " + palavra + " e ao contrário ela fica " + palavraInvertida + ".");

Console.ReadLine();