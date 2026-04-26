using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using RIVEROSCRUZ_PATITASFELICES.Models;

namespace RIVEROSCRUZ_PATITASFELICES.Controllers
{
    public class AgendamientoController
    {
        private SqlConnection GetConnection()
        {
            // Si no conecta, cambiar a: "Server=.\\SQLEXPRESS;Database=PatitasFelicesDB;Integrated Security=True;"
            return new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=PatitasFelicesDB;Integrated Security=True;");
        }

        private void Validar(Agendamiento a)
        {
            if (string.IsNullOrEmpty(a.NombreDueno) || string.IsNullOrEmpty(a.Telefono) ||
                string.IsNullOrEmpty(a.Correo) || string.IsNullOrEmpty(a.NombreMascota) ||
                string.IsNullOrEmpty(a.TipoMascota) || string.IsNullOrEmpty(a.MotivoConsulta))
                throw new ArgumentException("Todos los campos son obligatorios");

            if (a.FechaAtencion < DateTime.Today)
                throw new ArgumentException("La fecha no puede ser anterior a hoy");

            if (!a.Telefono.All(char.IsDigit))
                throw new ArgumentException("El telefono solo debe contener numeros");

            if (!a.Correo.Contains("@") || !a.Correo.Contains("."))
                throw new ArgumentException("El correo no es valido");

            if (a.EdadMascota <= 0)
                throw new ArgumentException("La edad debe ser mayor a cero");
        }

        public List<Agendamiento> GetAll()
        {
            List<Agendamiento> lista = new List<Agendamiento>();
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Agendamientos";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Agendamiento a = new Agendamiento();
                            a.IdAgendamiento = reader.GetInt32(0);
                            a.NombreDueno = reader.GetString(1);
                            a.Telefono = reader.GetString(2);
                            a.Correo = reader.GetString(3);
                            a.NombreMascota = reader.GetString(4);
                            a.TipoMascota = reader.GetString(5);
                            a.EdadMascota = reader.GetInt32(6);
                            a.FechaAtencion = reader.GetDateTime(7);
                            a.HoraAtencion = (TimeSpan)reader["HoraAtencion"];
                            a.MotivoConsulta = reader.GetString(9);
                            a.Estado = reader.GetString(10);
                            lista.Add(a);
                        }
                    }
                }
            }
            return lista;
        }

        public List<Agendamiento> GetByEstado(string estado)
        {
            List<Agendamiento> lista = new List<Agendamiento>();
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM Agendamientos WHERE Estado = @estado";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Agendamiento a = new Agendamiento();
                            a.IdAgendamiento = reader.GetInt32(0);
                            a.NombreDueno = reader.GetString(1);
                            a.Telefono = reader.GetString(2);
                            a.Correo = reader.GetString(3);
                            a.NombreMascota = reader.GetString(4);
                            a.TipoMascota = reader.GetString(5);
                            a.EdadMascota = reader.GetInt32(6);
                            a.FechaAtencion = reader.GetDateTime(7);
                            a.HoraAtencion = (TimeSpan)reader["HoraAtencion"];
                            a.MotivoConsulta = reader.GetString(9);
                            a.Estado = reader.GetString(10);
                            lista.Add(a);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Agendamiento a)
        {
            Validar(a);
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string sql = "INSERT INTO Agendamientos (NombreDueno, Telefono, Correo, NombreMascota, TipoMascota, EdadMascota, FechaAtencion, HoraAtencion, MotivoConsulta, Estado) " +
                             "VALUES (@NombreDueno, @Telefono, @Correo, @NombreMascota, @TipoMascota, @EdadMascota, @FechaAtencion, @HoraAtencion, @MotivoConsulta, @Estado)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NombreDueno", a.NombreDueno);
                    cmd.Parameters.AddWithValue("@Telefono", a.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", a.Correo);
                    cmd.Parameters.AddWithValue("@NombreMascota", a.NombreMascota);
                    cmd.Parameters.AddWithValue("@TipoMascota", a.TipoMascota);
                    cmd.Parameters.AddWithValue("@EdadMascota", a.EdadMascota);
                    cmd.Parameters.AddWithValue("@FechaAtencion", a.FechaAtencion);
                    cmd.Parameters.AddWithValue("@HoraAtencion", a.HoraAtencion);
                    cmd.Parameters.AddWithValue("@MotivoConsulta", a.MotivoConsulta);
                    cmd.Parameters.AddWithValue("@Estado", a.Estado);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Actualizar(Agendamiento a)
        {
            Validar(a);
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string sql = "UPDATE Agendamientos SET NombreDueno=@NombreDueno, Telefono=@Telefono, Correo=@Correo, " +
                             "NombreMascota=@NombreMascota, TipoMascota=@TipoMascota, EdadMascota=@EdadMascota, " +
                             "FechaAtencion=@FechaAtencion, HoraAtencion=@HoraAtencion, MotivoConsulta=@MotivoConsulta, " +
                             "Estado=@Estado WHERE IdAgendamiento=@IdAgendamiento";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NombreDueno", a.NombreDueno);
                    cmd.Parameters.AddWithValue("@Telefono", a.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", a.Correo);
                    cmd.Parameters.AddWithValue("@NombreMascota", a.NombreMascota);
                    cmd.Parameters.AddWithValue("@TipoMascota", a.TipoMascota);
                    cmd.Parameters.AddWithValue("@EdadMascota", a.EdadMascota);
                    cmd.Parameters.AddWithValue("@FechaAtencion", a.FechaAtencion);
                    cmd.Parameters.AddWithValue("@HoraAtencion", a.HoraAtencion);
                    cmd.Parameters.AddWithValue("@MotivoConsulta", a.MotivoConsulta);
                    cmd.Parameters.AddWithValue("@Estado", a.Estado);
                    cmd.Parameters.AddWithValue("@IdAgendamiento", a.IdAgendamiento);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string sql = "DELETE FROM Agendamientos WHERE IdAgendamiento = @id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
