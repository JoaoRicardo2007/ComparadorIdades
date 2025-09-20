namespace Course
{
     public class Saida
    {
        Produto p1, p2;

        public Saida()
        {
            p1 = new Produto();
            p2 = new Produto();

            Console.WriteLine("Insira o nome da Pessoa1");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da Pessoa1");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome da Pessoa2");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Insira a idade da Pessoa2");
            p2.Idade = int.Parse(Console.ReadLine());  
        }
        public string CompararIdades()
        {
            if (p1.Idade > p2.Idade)
            {
                return ($"{p1.Nome} tem {p1.Idade}, logo, é mais velha que {p2.Nome}, que tem apenas {p2.Idade} anos.");
            }
            else if (p2.Idade > p1.Idade)
            {
                return ($"{p2.Nome} tem {p2.Idade}, logo, é mais velha que {p1.Nome}, que tem apenas {p1.Idade} anos.");
            }
            else
            {
                return ($"{p1.Nome} e {p2.Nome} tem a mesma idade, {p1.Idade}");
            }
        }
    }
}
