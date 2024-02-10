using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Reg
    {
        // Функция проверки существования клиента.
        public bool GetClientExistence(string login_client, string phone, string email)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Login from [Client] WHERE Login = '{login_client}' OR Phone = '{phone}' OR Email = '{email}'", conn);
                string log = (string)cmd.ExecuteScalar();
                conn.Close();
                if (log == null) return true;
                else return false;
            }
        }
        // Функция добавления клиента в БД.
        public void InsertClient(string surname, string name, string last_name, string phone, string email, string login, string password1)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Client] (Surname, Name, LastName, Phone, Email, Login, Password) VALUES ('{surname}', '{name}', '{last_name}', '{phone}', '{email}', '{login}', '{password1}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
