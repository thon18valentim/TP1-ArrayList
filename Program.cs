
using System.Collections;
using TP1___ArrayList;

ArrayList nomes = new() { "othonvv", "jsuianinha", "rechetag", "gutoNawate" };
ArrayList senhas = new() { "123", "1234", "12345", "123456" };

bool UsuarioExiste(string nome, string senha)
  => nomes.Any(nome) || senhas.Any(senha);

bool AutenticarUsuario(string nome, string senha)
{
  var nomeIndex = nomes.FindIndex(nome);
  var senhaIndex = senhas.FindIndex(senha);

  if (nomeIndex == -1 || senhaIndex == -1)
    return false;

  if (nomeIndex == senhaIndex)
    return true;

  return false;
}

var tentativas = 0;
do
{
  Console.Clear();

  Console.WriteLine("| Bem vindo ao sistema |");
  Console.WriteLine("(1) Logar");
  Console.WriteLine("(2) Cadastrar");
  Console.WriteLine("(3) Sair");
  _ = int.TryParse(Console.ReadLine(), out int opc);

  if (opc != 1 && opc != 2)
    break;

  if (opc == 1)
  {
    Console.Clear();

    Console.WriteLine("|| Login de usuario ||");
    Console.WriteLine("Nome de usuario:");
    var usuario = Console.ReadLine();
    Console.WriteLine("Senha do usuario:");
    var senha = Console.ReadLine();

    if (!AutenticarUsuario(usuario, senha))
    {
      tentativas++;

      Console.WriteLine("\nErro, usuario não encontrado!");

      if (tentativas > 3)
      {
        Console.WriteLine("\nVocê ultrapassou o limite de tentativas, o sistema será finalizado!");
        break;
      }

      Console.WriteLine("\n--- Clique qualquer botão para prosseguir ---");

      Console.ReadLine();
    }
    else
    {
      tentativas = 0;

      Console.WriteLine("\nUsuario autenticado com sucesso!");
      Console.WriteLine("\n--- Clique qualquer botão para prosseguir ---");

      Console.ReadLine();
    }

    continue;
  }

  Console.WriteLine("|| Cadastro de usuario ||");
  Console.WriteLine("Nome do usuario:");
  var usuario_cadastro = Console.ReadLine();
  Console.WriteLine("Senha do usuario:");
  var senha_cadastro = Console.ReadLine();

  if (UsuarioExiste(usuario_cadastro, senha_cadastro))
  {
    Console.WriteLine("\nErro, usuario ou senha invalidos!");
    Console.WriteLine("\n--- Clique qualquer botão para prosseguir ---");

    Console.ReadLine();
  }
  else
  {
    nomes.Add(usuario_cadastro);
    senhas.Add(senha_cadastro);

    Console.WriteLine("\nUsuario cadastrado com sucesso!");
    Console.WriteLine("\n--- Clique qualquer botão para prosseguir ---");

    Console.ReadLine();
  }

} while (true);

Console.WriteLine("\n-- Sistema Finalizado --");
