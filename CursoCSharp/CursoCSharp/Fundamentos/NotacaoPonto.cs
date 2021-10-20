using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World")
                .Replace("word!", " Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("TEste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);


        }
    }
}
