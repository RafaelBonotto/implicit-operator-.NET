using System;

namespace ImplicitOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de um usuário
            var usuario = new Usuario
            {
                Id = 1,
                UsuarioNome = "Rafael",
                Senha = "senha1234",
                Ativo = true
            };

            // Cria uma instância do ViewModel
            // Recebe um usuário (Conversão implícita)
            UsuarioViewModel viewModel = usuario;

            Console.WriteLine("Implicit Operator Exemplo:");
            Console.WriteLine($"Id: {viewModel.IdUsuario}");
            Console.WriteLine($"Nome: {viewModel.UsuarioNome}");
        }
    }
}
