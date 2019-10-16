using System;
using System.Collections.Generic;
using System.Text;

namespace RCATeste
{
    public class Ex2
    {
        private static List<string> palavras = new List<string>();

        private static void ChecarPalavras()
        {
            int qtdDeA = 0;
            int qtdPalavrasMinTresA = 0;
            int qtdPalavrasComMaisQuatroLetras = 0;
            //Percorre cada palavra em cada índice da lista de palavras
            Console.WriteLine("---------------------------------");
            Console.WriteLine("As palavras digitadas foram: ");
            foreach(string s in palavras)
            {
                Console.WriteLine(s);
                //Percorre cada caractere de cada palavra individualmente
                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] == 'a')
                    {
                        ++qtdDeA;
                        if(qtdDeA >= 3)
                        {
                            //A) incrementa cada vez que tiver no mínimo 3 a's na palavra
                            ++qtdPalavrasMinTresA; 
                            break; 
                        }
                    }
                }
                
                //B) Caso a palavra em questão contenha mais de 4 letras
                if (s.Length > 4)
                    ++qtdPalavrasComMaisQuatroLetras;


            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine(string.Format("A quantidade de palavras que possuem no mínimo 3 vezes a ocorrência da letra (a) são: {0}", qtdPalavrasMinTresA));
            Console.WriteLine(string.Format("A quantidade de palavras que contém mais de 4 letras são: {0}", qtdPalavrasComMaisQuatroLetras));
            Console.WriteLine("---------------------------------");
            //C) Ordenar a lista de palavras por ordem alfabética
            palavras.Sort();
            Console.WriteLine("As palavras em ordem alfabética: ");
            foreach(string s in palavras)
                Console.WriteLine(s);
        }

        private static void Main()
        {
            int i = 0;
            Console.WriteLine("Digite a quantidade de palavras a ser analisada: ");
            string qtdPalavras = Console.ReadLine();
            while(i < Convert.ToInt32(qtdPalavras))
            {
                string palavra = Console.ReadLine();
                palavras.Add(palavra);
                ++i;
            }
            ChecarPalavras();
            Console.ReadKey();
        }
    }
}
