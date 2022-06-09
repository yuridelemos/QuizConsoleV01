namespace QuizConsoleV01
{
    class Quiz
    {
        private bool imprimirTela;
        private bool fimDeJogo;
        private int contadorErros;

        public Quiz()
        {
            imprimirTela = false;
            fimDeJogo = false;
            contadorErros = 0;
        }
        public void IniciarJogo()
        {
            while (!fimDeJogo)
            {
                if (!imprimirTela)
                {
                    imprimirTela = true;
                    ImprimirTela();
                }
                if (contadorErros != 3)
                    Pergunta();
            }
        }

        private void Pergunta()
        {
            string[] bancoDePerguntas = new string[]
            {
                "Quem foi o capitão da seleção brasileira na copa do mundo de 2018?",
                "O maior divisor comum de 25 e 48 é",
                "Qual novela do sbt teve a atriz Irene Ravache como protagonista?"
            };
            string[,] bancoDeRespostas = new string[,]{
                {"Marcelo","Paulinho","Thiago Silva","Neymar","D"},
                {"9", "6", "1", "8", "C"},
                {"Pícara Sonhadora","Fascinação","Razão de Viver", "Chiquititas", "C"}
            };

            Random random = new Random();
            int numeroAleatorio = random.Next(0, bancoDePerguntas.Length);
            Console.WriteLine(bancoDePerguntas[numeroAleatorio]);
            Console.WriteLine("A- " +
                bancoDeRespostas[numeroAleatorio, 0] + "\nB- " +
                bancoDeRespostas[numeroAleatorio, 1] + "\nC- " +
                bancoDeRespostas[numeroAleatorio, 2] + "\nD- " +
                bancoDeRespostas[numeroAleatorio, 3] + "\n");

            string resposta = Console.ReadLine().ToUpper();
            if (resposta == bancoDeRespostas[numeroAleatorio, 4])
            {
                Console.WriteLine("CERTA RESPOSTA");
            }
            else
            {
                contadorErros++;
                Console.WriteLine("Errow");
            }

        }

        private void ImprimirTela()
        {
            Console.WriteLine("QUIZ MELHOR DO MELHOR DO BRASIL");
            Console.WriteLine("Perguntas das mais variadas e três chances de errar");
            Console.WriteLine("Aperter 1 - Para iniciar e 0 - Para sair");
            int escolha = int.Parse(Console.ReadLine());
            EscolhaUsuario(escolha);
        }

        private void EscolhaUsuario(int escolha)
        {
            switch (escolha)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    IniciarJogo();
                    break;
                default:
                    Console.WriteLine("Digito inválido!");
                    break;

            }
        }
    }

}
