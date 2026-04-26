using System;
using System.Data.SqlClient;
using RIVEROSCRUZ_PATITASFELICES.Models;

namespace RIVEROSCRUZ_PATITASFELICES.Controllers
{
    public class UsuarioController
    {
        private SqlConnection GetConnection()
        {
            // Si no conecta, cambiar a: "Server=.\\SQLEXPRESS;Database=PatitasFelicesDB;Integrated Security=True;"
            return new SqlConnection("Server=localhost;Database=PatitasFelicesDB;Integrated Security=True;");
        }

        public Usuario ValidarLogin(string nombreUsuario, string clave)
        {
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(clave))
                throw new ArgumentException("Ingrese usuario y contrasena");

            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string sql = "SELECT IdUsuario, NombreUsuario, Clave, Rol FROM Usuarios WHERE NombreUsuario = @user AND Clave = @clave";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", nombreUsuario);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario();
                            usuario.IdUsuario = reader.GetInt32(0);
                            usuario.NombreUsuario = reader.GetString(1);
                            usuario.Clave = reader.GetString(2);
                            usuario.Rol = reader.GetString(3);
                            return usuario;
                        }
                        else
                        {
                            throw new ArgumentException("Usuario o contrasena incorrectos");
                        }
                    }
                }
            }
        }
    }
}
