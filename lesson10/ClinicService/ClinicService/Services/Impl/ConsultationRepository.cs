﻿using ClinicService.Models;
using System.Data;
using System.Data.SQLite;

namespace ClinicService.Services.Impl
{
    public class ConsultationRepository : IConsultationRepository
    {
        private const string connectionString = "Data Source = clinic.db; Version = 3; Pooling = true; Max Pool Size = 100;";

        public int Create(Consultation item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "INSERT INTO Consultations(ClientId, PetId, ConsultationDate, Description) VALUES(@ClientId, @PetId, @ConsultationDate, @Description)";
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
            command.Parameters.AddWithValue("@Description", item.Description);

            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public int Update(Consultation item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE Consultations SET ClientId = @ClientId, PetId = @PetId, ConsultationDate = @ConsultationDate, Description = @Description WHERE ConsultationId=@ConsultationId";
            command.Parameters.AddWithValue("@ConsultationId", item.ConsultationId);
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ConsultationDate", item.ConsultationDate.Ticks);
            command.Parameters.AddWithValue("@Description", item.Description);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public int Delete(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "DELETE FROM Consultations WHERE ConsultationId=@ConsultationId";
            command.Parameters.AddWithValue("@ConsultationId", id);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public IList<Consultation> GetAll()
        {
            List<Consultation> list = new List<Consultation>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Consultations";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Consultation Consultation = new Consultation();
                Consultation.ConsultationId = reader.GetInt32(0);
                Consultation.ClientId = reader.GetInt32(1);
                Consultation.PetId = reader.GetInt32(2);
                Consultation.ConsultationDate = new DateTime(reader.GetInt64(3));
                Consultation.Description = reader.GetString(4);

                list.Add(Consultation);
            }

            connection.Close();
            return list;
        }

        public Consultation GetById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Consultations WHERE ConsultationId=@ConsultationId";
            command.Parameters.AddWithValue("@ConsultationId", id);
            command.Prepare();
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read()) {
                Consultation Consultation = new Consultation();
                Consultation.ConsultationId = reader.GetInt32(0);
                Consultation.ClientId = reader.GetInt32(1);
                Consultation.PetId = reader.GetInt32(2);
                Consultation.ConsultationDate = new DateTime(reader.GetInt64(3));
                Consultation.Description = reader.GetString(4);

                connection.Close();
                return Consultation;
            }
            else
            {
                connection.Close();
                return null;
            }
        }


    }
}
