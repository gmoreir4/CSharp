using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notbook gamer";
            string modelo = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " 
                + modelo + " custa " + preco + "." );
            Console.WriteLine("O {0} da marca {1} custa {2}.",
                nome, modelo, preco);
            Console.WriteLine($"A marca {modelo} é legal!");            
            Console.WriteLine($"1 + 1 = {1 + 1 }");
            


        }
    }
}
