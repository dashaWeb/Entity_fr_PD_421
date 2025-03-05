using System.Data.SqlClient;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //Connection String - містить всю інформацію для підключення до сервера 
        // SQL Server
        // -- Windows Authentication -- 
        // "Data Source=server_name;Initial Catalog=db_name;Integrated Security=True"
        // -- Server Authentication -- 
        // "Data Source=server_name;Initial Catalog=db_name;Integrated Security=False;User ID=login;Password=password"
        string conn = @"Data Source = (localdb)\ProjectModels; 
                        Initial Catalog = UniversityPD_421;
                        Integrated Security = True; Connect Timeout = 2";
        //defaul  Connect Timeout = 30
        SqlConnection connection = new SqlConnection(conn);
        connection.Open();
        Console.WriteLine("Connected");


        //string cmdText = @"insert into Teachers
        //values('Alex','2005/03/15','+38052-458-78-96')";

        //SqlCommand command = new SqlCommand(cmdText, connection);
        //// ExecuteNonQuery - викoнує команду, яка не повертає результату (insert delete, update), але метод повертає кількість рядків, які були задіяні в команді
        //int row = command.ExecuteNonQuery();
        //Console.WriteLine($"{row} rows affected");


        // ExecuteScalar - виконує команду, яка повертає одне значення
        //string cmdText = @"select AVG(AverageMark) from Students";
        //SqlCommand command = new SqlCommand(cmdText, connection);
        //var res = (double)command.ExecuteScalar();
        //Console.WriteLine($"Result avg price :: {Math.Round(res,2)}");

        //ExecuteReader - виконує команду select та повертає результат у вигляді DbDataReader
        string cmdText = "select* from Students;";
        SqlCommand command = new SqlCommand(cmdText, connection);
        SqlDataReader reader = command.ExecuteReader();

        //Console.OutputEncoding = Encoding.UTF8;
        //// відображається назва всіх колонок
        for (int i = 0; i < reader.FieldCount; i++) // FieldCount - кількість стовпців у таблиці
        {
            if(i == 0 || i == 5 || i == 6 || i == 7 || i == 8)
                Console.Write($"{reader.GetName(i),15}");
            else if (i == 3)
                Console.Write($"{reader.GetName(i),30}");
            else
                Console.Write($"{reader.GetName(i),25}");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 200));
        // відображаємо всі значення кожного рядка
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (i == 0 || i == 5 || i == 6 || i == 7 || i == 8)
                    Console.Write($"{reader[i],15}");
                else if (i == 3)
                    Console.Write($"{reader[i],30}");
                else
                    Console.Write($"{reader[i],25}");
               
            }
            Console.WriteLine();
        }
        connection.Close();
    }
}