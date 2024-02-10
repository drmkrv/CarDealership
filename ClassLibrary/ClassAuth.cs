using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Auth
    {
        // Функция проверки корректности ввода логина и пароля
        public object LogInFunc(string login, string password)
        {
            object IDclient;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID_Client from [Client] WHERE Login='{login}' AND Password='{password}'", conn);
                IDclient = (object)cmd.ExecuteScalar();
            }
            return IDclient;
        }
    }
}
