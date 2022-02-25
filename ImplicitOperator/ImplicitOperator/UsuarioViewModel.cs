namespace ImplicitOperator
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(int idUsuario, string usuarioNome)
        {
            UsuarioNome = usuarioNome;
            IdUsuario = idUsuario;
        }
        public int IdUsuario { get; }
        public string UsuarioNome { get; }

        /// <summary>
        /// Método responsável por receber um objeto Usuario 
        /// e converter para um UsuarioViewModel, ocultando as demais propriedades
        /// </summary>
        /// <param name="usuario"></param>
        /// 
        public static implicit operator UsuarioViewModel(Usuario usuario)
            => new (usuario.Id, usuario.UsuarioNome);
    }
}
