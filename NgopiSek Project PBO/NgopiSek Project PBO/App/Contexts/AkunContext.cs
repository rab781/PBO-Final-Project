using NgopiSek_Project_PBO.App.Core;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Project_PBO.App.Contexts
{
    internal class AkunContext : DatabaseWrapper
    {
        // ---------------------- Mencari akun yang terdaftar di data base ---------------
        // ------------------ Akun Admin dan Akun Kasir ----------------------------------
        public static bool Login(string username, string password, string table)
        {
            string query = $"select count(*) from {table} " + $"where username_{table} = @username and password_{table}=@password";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password),
            };

            openConnection();
            command.CommandText = query;
            command.Parameters.AddRange(parameters);
            int hasil = Convert.ToInt32(command.ExecuteScalar());   
            closeConnection();

            return hasil > 0;
        }
        // ----------------------- Digunakan untuk registrasi -------------------------------------
        // ------------------ Pengecekan username terdapat pada data base ----------------
        public static bool cekUsername(string username, string table)
        {
            string query = $"select count(*) from {table} " + $"where username_{table} = @username ";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@username", username),
            };

            openConnection();
            command.CommandText = query;
            command.Parameters.AddRange(parameters);
            int hasil = Convert.ToInt32(command.ExecuteScalar());
            closeConnection();

            return hasil > 0;
        }

        // ------------------- Pendaftaran Admin dan kasir-------------------
        public static bool Registrasi(string nama, string username, string password, string table)
        {
            string query = $"INSERT INTO {table} (nama_{table}, username_{table}, password_{table}) VALUES(@nama, @username, @password)";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@username", username),
                new NpgsqlParameter("@password", password),
            };

            openConnection();
            command.CommandText = query;
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
            closeConnection();

            return true;
        }
    }
}
