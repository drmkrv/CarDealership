using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Order
    {
        // Функция получения списка марок автомобилей
        public List<string> Brand()
        {
            SqlDataReader Brands;
            List<string> result = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT BrandName from [Brand]", conn);
                Brands = cmd.ExecuteReader();
                if (Brands.HasRows)
                {
                    while (Brands.Read())
                    {
                        result.Add(Convert.ToString(Brands.GetString(0)));
                    }
                    conn.Close();
                    return result;
                }
                else {
                    conn.Close();
                    return null; 
                }

            }
        }
        // Функция получения списка моделей автомобилей выбранной марки
        public List<string> Model(string Brand)
        {
            SqlDataReader Models;
            int IDBrand;
            List<string> result = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmdIDBrand = new SqlCommand($"SELECT ID_Brand from [Brand] WHERE BrandName = '{Brand}'", conn);
                IDBrand = (int)cmdIDBrand.ExecuteScalar();
                SqlCommand cmdModel = new SqlCommand($"SELECT ModelName from [Model] WHERE Brand = '{IDBrand}'", conn);
                Models = cmdModel.ExecuteReader();
                if (Models.HasRows)
                {
                    while (Models.Read())
                    {
                        result.Add(Convert.ToString(Models.GetString(0)));
                    }
                    conn.Close();
                    return result;
                }
                else
                {
                    conn.Close();
                    return null;
                }

            }
        }
        // Функция получения списка цветов кузова
        public List<string> Color()
        {
            SqlDataReader Colors;
            List<string> result = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ColorName from [Color]", conn);
                Colors = cmd.ExecuteReader();
                if (Colors.HasRows)
                {
                    while (Colors.Read())
                    {
                        result.Add(Convert.ToString(Colors.GetString(0)));
                    }
                    conn.Close();
                    return result;
                }
                else
                {
                    conn.Close() ;
                    return null;
                }

            }
        }
        // Функция получения списка цветов салона
        public List<string> ColorInterior()
        {
            SqlDataReader ColorsInterior;
            List<string> result = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ColorInterior from [ColorInterior]", conn);
                ColorsInterior = cmd.ExecuteReader();
                if (ColorsInterior.HasRows)
                {
                    while (ColorsInterior.Read())
                    {
                        result.Add(Convert.ToString(ColorsInterior.GetString(0)));
                    }
                    conn.Close();
                    return result;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
        }
        // Функция получения ID марки по названию
        public int GetBrand(string brandName)
        {
            int IDBrand;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID_Brand FROM [Brand] WHERE BrandName = '{brandName}'", conn);
                IDBrand = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            return IDBrand;
        }
        // Функция получения ID модели по названию
        public int GetModel(string modelName)
        {
            int IDModel;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID_Model FROM [Model] WHERE ModelName = '{modelName}'", conn);
                IDModel = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            return IDModel;
        }
        // Функция получения ID цвета кузова по названию
        public int GetColor(string colorName)
        {
            int IDColor;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID_Color FROM [Color] WHERE ColorName = '{colorName}'", conn);
                IDColor = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            return IDColor;
        }
        // Функция получения ID цвета салона по названию
        public int GetColorInterior(string colorInteriorName)
        {
            int IDColorInterior;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ID_ColorInterior from [ColorInterior] WHERE ColorInterior = '{colorInteriorName}'", conn);
                IDColorInterior = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            return IDColorInterior;
        }
        // Функция получения стоимости автомобиля по модели
        public int GetCost(string modelName)
        {
            int cost;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Cost FROM [Model] WHERE ModelName = '{modelName}'", conn);
                cost = (int)cmd.ExecuteScalar();
                conn.Close();
            }
            return cost;
        }
        // Функция создания заказа в БД.
        public void NewOrder(int brand, int model, int color, int colorInterior, int conditioner, int powerwindows, int cost, int client)
        {
            Console.WriteLine(brand);
            Console.WriteLine(model);
            Console.WriteLine(color);
            Console.WriteLine(colorInterior);
            Console.WriteLine(conditioner);
            Console.WriteLine(powerwindows);
            Console.WriteLine(cost);
            Console.WriteLine(client);
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO [Car] (Brand, Model, Color, ColorInterior, Conditioner, PowerWindows, Cost, Photo, Status, Client) VALUES ('{brand}','{model}','{color}','{colorInterior}','{conditioner}','{powerwindows}','{cost}', '{"-"}', '{"Заказ"}','{client}')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Заказ оформлен!", "Внимание!", MessageBoxButtons.OK);
        }
    }
}
