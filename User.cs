using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

public class Use
{

    public static void Main() {

          public string connStr = "server=localhost;user=root;database=world;port=3306;password=******";
          public MySqlConnection conn = new MySqlConnection(connStr);
    }

    public static void getUser()
    {
        try
        {
            Console.WriteLine("Retreiving from Database!");
            conn.Open();

            string sql = "SELECT * FROM applicationDB.users WHERE username=''";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]+" -- "+rdr[1]);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }


    public static void saveUser()
    {
        try
        {
            Console.WriteLine("Saving to Database!");
            conn.Open();

            string sql = "INSERT INTO applicationDB.users (id,name, Email,username.mobile_number,occupation,address,gender,profile_photo_data) VALUES (101',"Hrithik", "hrith@gmail.com,"9633276543,"doctor","kukatpalli","male",null)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}