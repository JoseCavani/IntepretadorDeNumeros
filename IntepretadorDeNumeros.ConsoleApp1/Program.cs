using System;

namespace IntepretadorDeNumeros.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declaracão de variaveis
            string entrada = @"
     __  __      __  __  __  __  __  __ 
   | __| __||__||__ |__    ||__||__||  |
   ||__  __|   | __||__|   ||__| __||__|

    ";
            int contador = 0;
            System.IO.StringReader leitorDeCodigos = new System.IO.StringReader(entrada);
            string[] linhas = new string[4];
            linhas[0] = leitorDeCodigos.ReadLine();
            linhas[1] = leitorDeCodigos.ReadLine();
            linhas[2] = leitorDeCodigos.ReadLine();
            linhas[3] = leitorDeCodigos.ReadLine();
            string linhaParaLer = "";





            /* idea antiga
            //char[] charParaLer1 = new char[4]; 
            //char[] charParaLer2 = new char[4];
            //char[] charParaLer3 = new char[4];
            */
            #endregion



            #region codigo para ver o que as linhas estao recebendo habilitar para desbugar
            Console.WriteLine(linhas[1]);
            Console.WriteLine(linhas[2]);
            Console.WriteLine(linhas[3]);
            Console.WriteLine();
        #endregion


        #region codigo para dividir colocar os numeros em uma so linha (isso faz um simbolo unico para cada numero) 
        checkagem:

            linhaParaLer = linhas[1].Substring(contador, 4) + linhas[2].Substring(contador, 4) + linhas[3].Substring(contador, 4);


            //idea antiga
            //charParaLer1 = linhas[1].Substring(contador, 4);
            //charParaLer2 = linhas[2].Substring(contador, 4);
            //charParaLer3 = linhas[3].Substring(contador, 4);
            contador += 4;
            // leia os 4 posições para frente de cada linha depois marque essa posição com o cotador
            //dai faça novamente depois com o novo valor do contador

            #endregion


            #region codigo para ver o que os charParaLer estao lendo habilitar para desbugar
            //codigo para ver o que os charParaLer estao lendo
            //Console.WriteLine(linhaParaLer);








            //idea antiga
            //foreach (var item in charParaLer1)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //foreach (var item in charParaLer2)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //foreach (var item in charParaLer3)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            #endregion

            #region codigo que ve qual numero é

            switch (linhaParaLer)
            {
                case "       |   |":
                    Console.Write(1);
                    break;
                case " __  __||__ ":
                    Console.Write(2);
                    break;
                case " __  __| __|":
                    Console.Write(3);
                    break;
                case "    |__|   |":
                    Console.Write(4);
                    break;
                case " __ |__  __|":
                    Console.Write(5);
                    break;
                case " __ |__ |__|":
                    Console.Write(6);
                    break;
                case " __    |   |":
                    Console.Write(7);
                    break;
                case " __ |__||__|":
                    Console.Write(8);
                    break;
                case " __ |__| __|":
                    Console.Write(9);
                    break;
                case " __ |  ||__|":
                    Console.Write(0);
                    break;
            }

          

            // idea antiga
            //if (charParaLer2[0] == ' ' && charParaLer1[1] == ' ' && charParaLer2[3] == '|' && charParaLer3[3] == '|')
            //    Console.Write(1);




            //else if (charParaLer1[1] == '_' && charParaLer1[2] == '_' && charParaLer2[1] == '_' && charParaLer2[0] == ' ' && charParaLer2[2] == '_' && charParaLer2[3] == '|' && charParaLer3[0] == '|' && charParaLer3[1] == '_' && charParaLer3[2] == '_')
            //    Console.Write(2);




            //else if (charParaLer1[0] == ' ' && charParaLer1[1] == '_' && charParaLer1[2] == '_' && charParaLer1[3] == ' ' && charParaLer2[0] == ' ' && charParaLer2[1] == '_' && charParaLer2[2] == '_' && charParaLer2[3] == '|' && charParaLer3[0] == ' ' && charParaLer3[1] == '_' && charParaLer3[2] == '_' && charParaLer3[3] == '|')
            //    Console.Write(3);




            //else if (charParaLer2[0] == '|' && charParaLer2[1] == '_' && charParaLer2[2] == '_' && charParaLer2[3] == '|' && charParaLer3[2] == ' ')
            //    Console.Write(4);



            //else if (charParaLer1[2] == '_' && charParaLer1[3] == ' ' && charParaLer2[2] == '_' && charParaLer2[3] == ' ' && charParaLer2[1] == '_' && charParaLer3[3] == '|' && charParaLer3[1] == '_' && charParaLer3[0] == ' ')
            //    Console.Write(5);

            //else if (charParaLer1[2] == '_' && charParaLer1[3] == ' ' && charParaLer2[2] == '_' && charParaLer2[3] == ' ' && charParaLer2[1] == '_' && charParaLer3[3] == '|' && charParaLer3[1] == '_')
            //    Console.Write(6);




            //else if (charParaLer2[0] == ' ' && charParaLer2[1] == ' ' && charParaLer1[1] == '_' && charParaLer1[2] == '_' && charParaLer3[3] == '|' && charParaLer2[3] == '|')
            //    Console.Write(7);


            //else if (charParaLer2[0] == '|' && charParaLer2[1] == '_' && charParaLer2[2] == '_' && charParaLer2[3] == '|' && charParaLer1[1] == '_' && charParaLer1[2] == '_' && charParaLer3[0] == '|' && charParaLer3[1] == '_' && charParaLer3[2] == '_' && charParaLer3[3] == '|')
            //    Console.Write(8);


            //else if (charParaLer2[0] == '|' && charParaLer2[1] == '_' && charParaLer2[2] == '_' && charParaLer2[3] == '|' && charParaLer1[1] == '_' && charParaLer1[2] == '_' && charParaLer3[0] == ' ' && charParaLer3[1] == '_' && charParaLer3[2] == '_' && charParaLer3[3] == '|')
            //    Console.Write(9);
            //else
            //    Console.Write(0);

            //  Console.WriteLine(); // habilitar se estiver debugando

            if ((contador) < linhas[1].Length) // termino os numeros? senão vai pra cima denovo
                goto checkagem;
            #endregion

            Console.ReadKey();

        }
    }
}