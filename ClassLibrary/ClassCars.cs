using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class Cars
    {
        // Функция изменения статуса автомобиля, имеющегося в наличии, на "Продано".
        public void SoldCar(int Client, string IDCar)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Car SET Status = '{"Продано"}', Client = '{Client}' WHERE ID_Car='{IDCar}'", conn);
                cmd.ExecuteScalar();
                conn.Close();
            }
        }
        // Функция получения марки автомобиля по его ID.
        public string GetBrand(string IDBrand)
        {
            string brand;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT BrandName from [Brand] WHERE ID_Brand='{IDBrand}'", conn);
                brand = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            return brand;
        }
        // Функция получения модели автомобиля по его ID.
        public string GetModel(string IDModel)
        {
            string model;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ModelName from [Model] WHERE ID_Model='{IDModel}'", conn);
                model = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            return model;
        }
        // Функция получения цвета кузова по его ID.
        public string GetColor(string IDColor)
        {
            string color;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ColorName from [Color] WHERE ID_Color='{IDColor}'", conn);
                color = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            return color;
        }
        // Функция получения цвета салона по его ID.
        public string GetColorInterior(string IDColorInterior)
        {
            string colorinterior;
            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = CarDealership; Integrated Security = True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT ColorInterior from [ColorInterior] WHERE ID_ColorInterior='{IDColorInterior}'", conn);
                colorinterior = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            return colorinterior;
        }
    }
}
