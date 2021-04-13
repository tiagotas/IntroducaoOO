using System;

namespace IntroducaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *         GLOSSÁRIO
             *         
             *   Orientação a Objetos
             * 
             * 1) "Orientação a Objetos" => Paradigma (Jeito) de Linguagem de Programação
             * 2) "Objeto" => Apresentação de alguma coisa do mundo físico (ex: Casa Pronta)
             * 3) "Classe" => Especificação de como o "Objeto" será (ex: Planta da Casa)
             *      - "Atributo/Propriedade" => Características da classe (características que o Objeto terá. Ex da casa: cor, qnt quartos, qnt banheiros)
             *      - "Métodos" => Ações da classe (ações que o objeto terá. Ex da casa: morar, alugar, vender, comprar (verbos) )
             * 5) "Método Construtor" => É chamado quando o "Objeto" é criado a partir da "Classe". Tem o mesmo nome da classe.
             * 6) Como criar um objeto:   Classe c = new Classe();   /   Professor p = new Professor();
             */ 

            Console.WriteLine("Criando objeto da pessoa");


            Aluno p1 = new Aluno("Caio");
            p1.Idade = 16;
            p1.Respirar();
            p1.Comer("Lasanha");
            p1.Andar();
            p1.Estudar("Desenvolvimento de Software");


            Aluno p2 = new Aluno("Ana Clara");
            p2.Respirar();
            //p2.Comer("Pizza");
            //p2.Andar();
            p2.Estudar("Desenvolvimento de Software");


            Professor p3 = new Professor("Charlinho");
            p3.Respirar();
            p3.Andar();
            p3.Comer("Batata");
            p3.Ensinar("Desenvolvimento de Software");



            //p1.Nome = "Tiago";

            Console.WriteLine("");
            Console.WriteLine("o aluno que está em p1 é {0} e tem {1} anos.", p1.Nome, p1.Idade);
            Console.WriteLine("o aluno que está em p2 é {0}", p2.Nome);
            Console.WriteLine("o professor que está em p3 é {0}", p3.Nome);





            Console.ReadKey();
        }
    }
}
