using System;

namespace trabalho_lpe_2sem
{
    class Program
    {
        static void Main(string[] args)
        {
           String Texto = String.Empty;
            String Tipo;
            Console.WriteLine("\n\nTema: Descarte Consciente - Criptografia em Base64");
            Console.WriteLine("Digite o texto a ser Criptografado:  ");
            Texto = Console.ReadLine();
            Texto = Criptografar(Texto);

            Console.WriteLine("Texto Criptografado: {0} ", Texto);
            //Ação criada para gerar uma escolha entre Sim ou Não para Descriptografar o texto.
            Console.WriteLine("Deseja Descriptografar seu Texto? Sim ou Não:");
            Tipo = Console.ReadLine();
            //condição 
            if (Tipo.Equals("Sim"))
            {
                Console.WriteLine(Descriptografar(Texto));

            }
            if (Tipo.Equals("Não"))
            {
                Console.WriteLine("Obrigado por Utilizar a Aplicação :)");

            }
            Console.ReadLine();
        }

        public static String Criptografar(String valor)
        {//String para Criptografar o texto.
            String chaveCripto;
            Byte[] cript = System.Text.ASCIIEncoding.ASCII.GetBytes(valor);
            chaveCripto = Convert.ToBase64String(cript);
            return chaveCripto;

        }
        public static String Descriptografar(String valor)
        {//String para Descriptografar.
            String chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);
            return chaveCripto;
        }
    }
}