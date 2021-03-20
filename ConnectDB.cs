using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HomeWork2
{
    public class ConnectDB
    {
        #region 查詢無人機資料表的Method
        public static DataTable ReadDroneDetail()
        {
            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM Drone_Detail;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@NumberCol", "2");

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine(
                    //        "\t{0}\t{1}\t{2}",
                    //        dr["ID"],
                    //        dr["Birthday"],
                    //        dr["Name"]
                    //    );
                    //}

                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

                //finally
                //{
                //    connection.Close();
                //}
            }
        }
        #endregion


        #region 新增無人機資料的Method
        public static DataTable InsertIntoDroneDetail(int Sid, string DroneName, string Manufacturer, string WeightLoad, string Status, string StopReason, string Operator)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"INSERT INTO Drone_Detail
                                        (DroneDetail_ID, DroneName, Manufacturer, WeightLoad, Status, StopReason, operator)
                                    VALUES
                                        (@DroneDetail_ID, @DroneName, @Manufacturer, @WeightLoad, @Status, @StopReason, @operator)";



            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@DroneDetail_ID", Sid);
                command.Parameters.AddWithValue("@DroneName", DroneName);
                command.Parameters.AddWithValue("@Manufacturer", Manufacturer);
                command.Parameters.AddWithValue("@WeightLoad", WeightLoad);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@StopReason", StopReason);
                command.Parameters.AddWithValue("@operator", Operator);


                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    //受影響的資料筆數(沒有使用)
                    //int totalChangRows = command.ExecuteNonQuery();
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    return dt;
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }

            }
        }
        #endregion


        #region 刪除無人機資料的Method
        public static DataTable DelectDroneDetail(int ID)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"DELETE FROM Drone_Detail WHERE DroneDetail_ID = @ID";
            //DELETE FROM TestTable_1 WHERE ID


            

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@ID", ID);



                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    //受影響的資料筆數(沒有使用)
                    //int totalChangRows = command.ExecuteNonQuery();
                    //HttpContext.Current.Response.Write("Total chang" + totalChangRows + " Rows.");
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    return dt;
                }
                catch (Exception ex)
                {
                    //HttpContext.Current.Response.Write(ex);
                    //Console.WriteLine(ex);
                    return null;
                }

            }
        }
        #endregion


        #region 修改無人機資料表的Method
        public static DataTable UpDateDroneDetail(int Sid, string DroneName, string Manufacturer, string WeightLoad, string Status, string StopReason, string Operator)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";


            //使用的SQL語法
            string queryString = $@"UPDATE Drone_Detail SET DroneName=@DroneName, Manufacturer=@Manufacturer, WeightLoad=@WeightLoad, Status=@Status, StopReason=@StopReason, operator=@operator WHERE DroneDetail_ID=@DroneDetail_ID";


        

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@DroneDetail_ID", Sid);
                command.Parameters.AddWithValue("@DroneName", DroneName);
                command.Parameters.AddWithValue("@Manufacturer", Manufacturer);
                command.Parameters.AddWithValue("@WeightLoad", WeightLoad);
                command.Parameters.AddWithValue("@Status", Status);
                command.Parameters.AddWithValue("@StopReason", StopReason);
                command.Parameters.AddWithValue("@operator", Operator);


                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);


                    //受影響的資料筆數(沒有使用)
                    //int totalChangRows = command.ExecuteNonQuery();
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");


                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                    return null;
                }

            }
        }
        #endregion


        #region 查詢單筆無人機資料表的Method
        public static DataTable ReadSingleDroneDetail(int ID)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM Drone_Detail WHERE DroneDetail_ID=@ID;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);

                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine(
                    //        "\t{0}\t{1}\t{2}",
                    //        dr["ID"],
                    //        dr["Birthday"],
                    //        dr["Name"]
                    //    );
                    //}

                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

                //finally
                //{
                //    connection.Close();
                //}
            }
        }
        #endregion


        #region 查詢電池資料表的Method
        public static DataTable ReadDroneBattery()
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM Drone_Battery;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@NumberCol", "2");

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);

                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine(
                    //        "\t{0}\t{1}\t{2}",
                    //        dr["ID"],
                    //        dr["Birthday"],
                    //        dr["Name"]
                    //    );
                    //}


                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

                //finally
                //{
                //    connection.Close();
                //}
            }
        }
        #endregion


        #region 新增電池資料的Method
        public static DataTable InsertIntoDroneBattery(int Sid, string BatteryName, string Stutas, string StopReason)
        {
            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"INSERT INTO Drone_Battery
                                        (sid, battery_Name, status, stopReason)
                                    VALUES
                                        (@sid, @battery_Name, @status, @stopReason)";


           

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@sid", Sid);
                command.Parameters.AddWithValue("@battery_Name", BatteryName);
                command.Parameters.AddWithValue("@status", Stutas);
                command.Parameters.AddWithValue("@stopReason", StopReason);



                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);

                    //受影響的資料筆數(沒有使用)
                    //int totalChangRows = command.ExecuteNonQuery();
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    return dt;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    HttpContext.Current.Response.Write(ex);

                    return null;
                }

            }
        }
        #endregion


        #region 刪除電池資料的Method
        public static DataTable DelectBattery(int ID)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"DELETE FROM Drone_Battery WHERE sid = @ID";
            //DELETE FROM TestTable_1 WHERE ID

           

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@ID", ID);



                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);

                    //受影響的資料筆數(沒有使用)
                    int totalChangRows = command.ExecuteNonQuery();
                    //HttpContext.Current.Response.Write("Total chang" + totalChangRows + " Rows.");
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    return dt;

                   
                }
                catch (Exception ex)
                {
                    //HttpContext.Current.Response.Write(ex);
                    //Console.WriteLine(ex);

                    return null;
                }

            }
        }
        #endregion


        #region 修改電池資料表的Method
        public static DataTable UpDateBattery(int Sid, string BatteryName, string Status, string StopReason)
        {
            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"UPDATE Drone_Battery SET battery_Name=@battery_Name, status=@status, stopReason=@stopReason WHERE sid=@sid";

 

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@sid", Sid);
                command.Parameters.AddWithValue("@battery_Name", BatteryName);
                command.Parameters.AddWithValue("@status", Status);
                command.Parameters.AddWithValue("@stopReason", StopReason);
                


                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);

                    //受影響的資料筆數(沒有使用)
                    //int totalChangRows = command.ExecuteNonQuery();
                    //Console.WriteLine("Total chang" + totalChangRows + " Rows.");

                    return dt;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    HttpContext.Current.Response.Write(ex);

                    return null;
                }

            }
        }
        #endregion


        #region 查詢單筆電池資料表的Method
        public static DataTable ReadSingleBattery(int sid)
        {
            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Drone; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM Drone_Battery WHERE sid=@ID;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);

                //將值丟進相對應的位子
                command.Parameters.AddWithValue("@ID", sid);

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    Console.WriteLine(
                    //        "\t{0}\t{1}\t{2}",
                    //        dr["ID"],
                    //        dr["Birthday"],
                    //        dr["Name"]
                    //    );
                    //}

                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

                //finally
                //{
                //    connection.Close();
                //}
            }
        }
        #endregion
    }
}