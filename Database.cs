using Npgsql;

public class Database {
    public Database(User user) {

    }

    public static void DropTable(string tableName) {
        var cs = "Host=localhost;Username=postgres;Password=elcanion;Database=testdb";

        using var con = new NpgsqlConnection(cs);
        con.Open();

        using var cmd = new NpgsqlCommand();
        cmd.Connection = con;

        cmd.CommandText = $"DROP TABLE IF EXISTS {tableName}";
        cmd.ExecuteNonQuery();
    }

    public static void CreateUsersTable() {
        var cs = "Host=localhost;Username=postgres;Password=elcanion;Database=testdb";

        using var con = new NpgsqlConnection(cs);
        con.Open();

        using var cmd = new NpgsqlCommand();
        cmd.Connection = con;
        
        cmd.CommandText = @"CREATE TABLE users(id SERIAL PRIMARY KEY, 
    name VARCHAR(255), email VARCHAR(255), yearofbirth INT, age INT)";
        cmd.ExecuteNonQuery();
    }

    public static async void InsertUserIntoTable(User user) {

        var cs = "Host=localhost;Username=postgres;Password=elcanion;Database=testdb";

        using var con = new NpgsqlConnection(cs);
        con.Open();

        using var cmd = new NpgsqlCommand();
        cmd.Connection = con;

        cmd.CommandText = $"INSERT INTO users(name, yearofbirth, age, email) VALUES(@name, @yearOfBirth, @age, @email)";
        await using (cmd) {
            cmd.Parameters.AddWithValue("name", user.Name);
            cmd.Parameters.AddWithValue("yearOfBirth", user.YearOfBirth);
            cmd.Parameters.AddWithValue("age", user.Age);
            cmd.Parameters.AddWithValue("email", user.Email);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}