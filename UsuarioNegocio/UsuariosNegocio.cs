using UsuarioData;
using UsuarioModelo;

namespace UsuarioNegocio
{
    public class UsuariosNegocio
    {
        public bool AgregarUsuario(UsuarioModel usuario)
        {
            var usuarioData = new UsuariosData();
            return usuarioData.AgregarUsuario(usuario);
        }
    }
}
