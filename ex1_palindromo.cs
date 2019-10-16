using System;
using System.Text;
using System.Linq;

namespace RCATeste
{
    public class Ex1
    {
        private static bool EhPalindromo(string str)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);  //registra provedor de encoding para acessar codificações
            //Remove acentuação da palavra
            byte[] bAcentoRemovido = Encoding.GetEncoding("windows-1251").GetBytes(str);
            string acentoRemovido = Encoding.ASCII.GetString(bAcentoRemovido);
            //Passando toda string para minúsculo para critério de comparação e deixar tudo igual
            string lowerString = acentoRemovido.ToLower();
            //Removendo espaços
            string semEspacos = lowerString.Replace(" ", "");
            //Removendo pontos
            string finalString = semEspacos.Replace(".", "");
            //Invertendo string para realizar comparação
            string reverseString = new string(finalString.Reverse().ToArray());
            Console.WriteLine(reverseString);
            //Compara a string final (toda minúscula, sem acentos e sem espaços) com a mesma só que invertida
            if (finalString == reverseString)
                return true;

            return false;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase ou palavra: ");
            string str = Console.ReadLine();
            if (EhPalindromo(str))
                Console.WriteLine(string.Format("A frase/palavra ({0}) é palíndromo!", str));
            else
                Console.WriteLine(string.Format("A frase/palavra ({0}) não é palíndromo!", str));
            Console.ReadKey();
        }
    }
}
