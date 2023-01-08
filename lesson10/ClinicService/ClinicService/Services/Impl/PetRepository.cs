using ClinicService.Models;
using System.Data;
using System.Data.SQLite;

namespace ClinicService.Services.Impl
{
    public class PetRepository : IPetRepository
    {
        private const string connectionString = "Data Source = clinic.db; Version = 3; Pooling = true; Max Pool Size = 100;";

        public int Create(Pet item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "INSERT INTO Pets(ClientId, Name, Birthday) VALUES(@ClientId, @Name, @Birthday)";
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public int Update(Pet item)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "UPDATE pets SET ClientId = @ClientId, Name = @Name, Birthday = @Birthday WHERE PetId=@PetId";
            command.Parameters.AddWithValue("@PetId", item.PetId);
            command.Parameters.AddWithValue("@ClientId", item.ClientId);
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Birthday", item.Birthday.Ticks);
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
            command.CommandText = "DELETE FROM Pets WHERE PetId=@PetId";
            command.Parameters.AddWithValue("@PetId", id);
            command.Prepare();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res;
        }

        public IList<Pet> GetAll()
        {
            List<Pet> list = new List<Pet>();
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Pets";
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Pet Pet = new Pet();
                Pet.PetId = reader.GetInt32(0);
                Pet.ClientId = reader.GetInt32(1);
                Pet.Name = reader.GetString(2);
                Pet.Birthday = new DateTime(reader.GetInt64(3));

                list.Add(Pet);
            }


        connection.Close();
            return list;
        }

        public Pet GetById(int id)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "SELECT * FROM Pets WHERE PetId=@PetId";
            command.Parameters.AddWithValue("@PetId", id);
            command.Prepare();
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read()) {
                Pet Pet = new Pet();
                Pet.PetId = reader.GetInt32(0);
                Pet.ClientId = reader.GetInt32(1);
                Pet.Name = reader.GetString(2);
                Pet.Birthday = new DateTime(reader.GetInt64(3));

                connection.Close();
                return Pet;
            }
            else
            {
                connection.Close();
                return null;
            }
        }


    }
}
