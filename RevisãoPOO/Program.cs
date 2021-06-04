using System;
using System.Collections.Generic;
using System.Linq;

namespace RevisãoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o programa(1-4)");
            var app = Console.ReadLine();

            switch (app)
            {
                case "1":
                    Console.WriteLine("Para criar uma pessoa digite 'C' e aperte enter...");
                    var opcao = Console.ReadLine();
                    List<Pessoa> pessoas = new List<Pessoa>();

                    while (!opcao.Equals("S"))
                    {
                        if (opcao.Equals("C"))
                        {
                            Console.WriteLine("\nDigite o nome da pessoa: ");
                            var nome = Console.ReadLine();
                            Console.WriteLine("Digite a data de nascimento: ");
                            var dataNascimento = Console.ReadLine();
                            Console.WriteLine("Digite a altura:");
                            var altura = Console.ReadLine();

                            var pessoa = new Pessoa(nome, DateTime.Parse(dataNascimento), decimal.Parse(altura));
                            pessoas.Add(pessoa);

                            Console.WriteLine("Pessoa criada com sucesso! Para criar mais digite 'C'. Para ver a lista aperte 'L'.");
                            opcao = Console.ReadLine();
                        }
                        else if (opcao.Equals("L"))
                        {
                            foreach (Pessoa pessoa in pessoas)
                            {
                                Console.WriteLine(pessoa.DadosPessoa());
                            }

                            Console.WriteLine("\nPara criar mais aperte 'C'. Para sair aperte 'S'. Ou digite o nome da pessoa para mais informações.");
                            opcao = Console.ReadLine();
                            while (!opcao.Equals("S") && !opcao.Equals("C") && !opcao.Equals("L"))
                            {
                                var _pessoa = pessoas.FirstOrDefault(n => n.Nome == opcao);
                                if (_pessoa != null)
                                {
                                    Console.WriteLine(_pessoa.DadosPessoa());
                                    Console.WriteLine(_pessoa.CalcularIdade());
                                    Console.WriteLine("\nPara criar mais aperte 'C'. Para sair aperte 'S'. Ou digite o nome da pessoa para mais informações.");
                                    opcao = Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Pessoa não encontrada. Para sair aperte 'S'. Para criar aperte 'C'. Para ver a lista aperte 'L'");
                                    opcao = Console.ReadLine();
                                }
                            }
                        }
                    }
                    break;

                case "2":
                    var agenda = new Agenda();

                    Console.WriteLine("Digite o nome da pessoa: ");
                    var Nome = Console.ReadLine();
                    Console.WriteLine("Digite a idade: ");
                    var Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura: ");
                    var Altura = float.Parse(Console.ReadLine());
                    agenda.armazenaPessoas(Nome, Idade, Altura);

                    agenda.imprimeAgenda();

                    Console.WriteLine("Busque uma pessoa pelo número na agenda: ");
                    agenda.imprimePessoa(int.Parse(Console.ReadLine()));

                    Console.WriteLine("Busque a posição da pessoa pelo nome: ");
                    var index = agenda.buscaPessoa(Console.ReadLine());
                    Console.WriteLine($"Posição --> {index}");

                    Console.WriteLine("Remova uma pessoa da agenda: ");
                    agenda.removePessoas(Console.ReadLine());
                    break;

                case "3":
                    Console.WriteLine("Elevador\n");
                    Console.WriteLine("Digite a capacidade total de pessoas no elevador: ");
                    var capacidadeTotal = Console.ReadLine();
                    Console.WriteLine("Digite o total de andares do prédio: ");
                    var totalAndares = Console.ReadLine();
                    var elevador = new Elevador();
                    elevador.Inicializa(int.Parse(capacidadeTotal), int.Parse(totalAndares));

                    Console.WriteLine("Elevador pronto. Digite o comando desejado:\nSobe\nDesce\nEntra\nSai\n\nPara sair digite 'S'...");
                    var comando = Console.ReadLine();
                    while (!comando.Equals("S"))
                    {
                        switch (comando)
                        {
                            case "Sobe":
                                bool resposta;
                                Console.WriteLine("Quantos andares subir?");
                                var andares = Console.ReadLine();
                                resposta = elevador.Sobe(int.Parse(andares));
                                if (resposta)
                                {
                                    Console.WriteLine($"O elevador subiu {andares} andares.");
                                }
                                else
                                {
                                    Console.WriteLine($"O elevador não pode subir {andares} andares.");
                                }

                                Console.WriteLine("Comando desejado: ");
                                comando = Console.ReadLine();
                                break;

                            case "Desce":
                                Console.WriteLine("Quantos andares descer?");
                                andares = Console.ReadLine();
                                resposta = elevador.Desce(int.Parse(andares));
                                if (resposta)
                                {
                                    Console.WriteLine($"O elevador desceu {andares} andares.");
                                }
                                else
                                {
                                    Console.WriteLine($"O elevador não pode descer {andares} andares.");
                                }

                                Console.WriteLine("Comando desejado: ");
                                comando = Console.ReadLine();
                                break;

                            case "Entra":
                                Console.WriteLine("Quantos pessoas entrar?");
                                var pessoasEntrando = Console.ReadLine();
                                resposta = elevador.Entra(int.Parse(pessoasEntrando));
                                if (resposta)
                                {
                                    Console.WriteLine($"No elevador entraram {pessoasEntrando} pessoas.");
                                }
                                else
                                {
                                    Console.WriteLine($"No elevador não podem entrar {pessoasEntrando} pessoas.");
                                }

                                Console.WriteLine("Comando desejado: ");
                                comando = Console.ReadLine();
                                break;

                            case "Sai":
                                Console.WriteLine("Quantos pessoas devem sair?");
                                pessoasEntrando = Console.ReadLine();
                                resposta = elevador.Sai(int.Parse(pessoasEntrando));
                                if (resposta)
                                {
                                    Console.WriteLine($"No elevador sairam {pessoasEntrando} pessoas.");
                                }
                                else
                                {
                                    Console.WriteLine($"No elevador não podem sair {pessoasEntrando} pessoas.");
                                }

                                Console.WriteLine("Comando desejado: ");
                                comando = Console.ReadLine();
                                break;

                            default:
                                Console.WriteLine("Comando não reconhecido. Tente novamente...\n\n");
                                Console.WriteLine("Comando desejado: ");
                                comando = Console.ReadLine();
                                break;
                        }
                    }
                    break;

                case "4":
                    var controleRemoto = new ControleRemoto();
                    var botao = "Ligar";
                    Console.WriteLine("Comandos...\n> -- Trocar canal para frente\n< -- Trocar canal para trás\n+ -- Aumentar volume\n- -- Diminuir volume\n\nOu digite o nome do canal desejado...");
                    while (!botao.Equals("Desligar"))
                    {
                        botao = Console.ReadLine();
                        if (botao.Equals(">"))
                        {
                            controleRemoto.TrocarCanal(trocar: true);
                        }
                        else if (botao.Equals("<"))
                        {
                            controleRemoto.TrocarCanal(trocar: false);
                        }
                        else if (botao.Equals("+"))
                        {
                            controleRemoto.AumentarVolume();
                        }
                        else if (botao.Equals("-"))
                        {
                            controleRemoto.DiminuirVolume();
                        }
                        else if (botao.Equals("."))
                        {
                            Console.Clear();
                            Console.WriteLine("Comandos...\n> -- Trocar canal para frente\n< -- Trocar canal para trás\n+ -- Aumentar volume\n- -- Diminuir volume\n\nOu digite o nome do canal desejado...");
                            controleRemoto.Consultar();
                        }else if(botao.Equals("0") || botao.Equals("1") || botao.Equals("2") || botao.Equals("3") || botao.Equals("4") || botao.Equals("5") || botao.Equals("6") || botao.Equals("7") || botao.Equals("8") || botao.Equals("9"))
                        {
                            controleRemoto.TrocarCanal(i: int.Parse(botao));
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Encerrando o programa...");
                    break;
            }  
        }
    }
}
