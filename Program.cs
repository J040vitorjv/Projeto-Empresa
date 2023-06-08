using Programa_empresa.Classes.Enums;
using descricao.Tipo;

namespace cadastro_empresa
{
    public class Program
    {

        static void Main(string[] args)
        {
            var lista = new List<Cadastro>();

            /*
             for (int i = 1; i < 50; i++)
            {
                lista.Add(new Cadastro
                {
                    CadastroId = i,
                    Funcao = Funcoes.Ferramentaria,
                    Nome = $"joao",
                });

            }

            var funcionario1 = lista.FirstOrDefault();

            if (funcionario1.Funcao == Funcoes.Marketing)
            {

            }

            Console.ReadLine();
            */
            // Quantidade de especializações
            int nEspecializacoes = 9;
            Console.WriteLine("Quantidade de especializações: " + nEspecializacoes);

            // Quantidade de funcionários por setor
            int nFuncionariosSetor1 = 3;
            int nFuncionariosSetor2 = 6;
            Console.WriteLine("Quantidade de funcionários no setor 1: " + nFuncionariosSetor1);
            Console.WriteLine("Quantidade de funcionários no setor 2: " + nFuncionariosSetor2);

            // Média de tempo no setor
            double mediaTempoSetor1 = 6;
            double mediaTempoSetor2 = 10;
            Console.WriteLine("Média de tempo no setor 1: " + mediaTempoSetor1);
            Console.WriteLine("Média de tempo no setor 2: " + mediaTempoSetor2);

            // Cadastro de funcionário por setor
            var nomeFuncionarioSetor1;
            var nomeFuncionarioSetor2;
            Console.WriteLine("Digite o nome do funcionário a ser cadastrado no setor 1: ");
        }
    }
}