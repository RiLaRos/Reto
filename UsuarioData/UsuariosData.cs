using System.Data;
using System.Data.SqlClient;
using UsuarioModelo;

namespace UsuarioData
{
    public class UsuariosData
    {
        public bool AgregarUsuario(UsuarioModel usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Reto;Trusted_Connection=True;"))
                {
                    using (SqlCommand command = new SqlCommand("USP_INSERT_USUARIO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                        command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                        command.Parameters.AddWithValue("@Edad", usuario.Edad);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarUsuario(UsuarioModel usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Reto;Trusted_Connection=True;"))
                {
                    using (SqlCommand command = new SqlCommand("USP_UPDATE_USUARIO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UsuarioId", usuario.Id);
                        command.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                        command.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                        command.Parameters.AddWithValue("@Edad", usuario.Edad);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarUsuario(int usuarioId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Reto;Trusted_Connection=True;"))
                {
                    using (SqlCommand command = new SqlCommand("USP_DELETE_USUARIO", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UsuarioModel> ListarUsuarios()
        {
            return new List<UsuarioModel>();
        }
    }
}
