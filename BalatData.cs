﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLeayrs
{
    public class BalatData
    {

        public static DataTable GetAllBalat()
        {
            DataTable dt = new DataTable();

            using(SqlConnection conn = new SqlConnection( DataSetting.Connaction_string))
            {
                string query = "exec sp_AllBalats";
                using(SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
            return dt;
        }

		public static DataTable GetAllBalatInMakzan(int MakzanID)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string query = @"exec sp_GetAllMakzanBalats @MakzanID ";
				using (SqlCommand command = new SqlCommand(query, conn))
				{
                    command.Parameters.AddWithValue("@MakzanID", MakzanID);
					try
					{
						conn.Open();

						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.HasRows)
								dt.Load(reader);
						}
					}
					catch (Exception ex)
					{

					}
				}
			}
			return dt;
		}

		public static bool GetBalataInfo(int BalataID,ref int MakzanID,ref int BalataTypeID,ref int MadeInID,ref string Code,ref float M_In_B,ref decimal Salary, ref int MakasID,ref string PicturePath)
        {
            bool found = false;
      
            using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string Qury = @"exec sp_GetBalata @BalatID ";

                using(SqlCommand command =new SqlCommand(Qury, conn))
                {
                    command.Parameters.AddWithValue("@BalatID", BalataID);
                    

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MakzanID = (int)reader["MakzanID"];
                                BalataTypeID = (int)reader["TypeID"];
                                MadeInID = (int)reader["MadeInID"];
                                Code = (string)reader["Code"];
                                M_In_B = Convert.ToSingle(reader["M_in_B"]);
                                Salary = (decimal)reader["Salary"];
                                MakasID = (int)reader["MakasID"];

                                if (reader["Picture_Path"] != System.DBNull.Value)
                                    PicturePath = (string)reader["Picture_Path"];
                                else
                                    PicturePath = null;
   

                                found = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        found = false;
                    }
                }

			}
            return found;
            
        }

		public static bool GetBalataInfoByCode(ref int BalataID, ref int MakzanID, ref int BalataTypeID, ref int MadeInID,  string Code,ref float M_in_B, ref decimal Salary, ref int MakasID,ref string PicturePath)
		{
			bool found = false;
			using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
			{
				string Qury = @"exec sp_GetBalataByCode @Code";

				using (SqlCommand command = new SqlCommand(Qury, conn))
				{
					command.Parameters.AddWithValue("@Code", Code);
					try
					{
						conn.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{
							if (reader.Read())
							{
                                BalataID = (int)reader["BalatID"];
								MakzanID = (int)reader["MakzanID"];
								BalataTypeID = (int)reader["TypeID"];
                                M_in_B = Convert.ToSingle(reader["M_in_B"]);
								MadeInID = (int)reader["MadeInID"];
								Salary = (decimal)reader["Salary"];
								MakasID = (int)reader["MakasID"];

								if (reader["Picture_Path"] != System.DBNull.Value)
									PicturePath = (string)reader["Picture_Path"];
								else
									PicturePath = null;


								found = true;
							}
						}
					}
					catch (Exception ex)
					{
						found = false;
					}
				}

			}
			return found;

		}

		public static int AddNewBalata( int MakzanID,  int BalataTypeID,int MadeInID,string Code,float M_in_B,decimal Salary, int MakasID,string Picture)
        {
            int Adding = -1;
            object Done;
            using( SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string query = @"exec sp_AddNewBalat 
                                 @TypeID,@MakzanID,@Code,@M_In_B,@MadeInID,@Salary,@MakasID,@Picture";

                using(SqlCommand command = new SqlCommand(query, conn))
                {
                    

                    command.Parameters.AddWithValue("@MakzanID", MakzanID);
                    command.Parameters.AddWithValue("@TypeID",BalataTypeID);
                    command.Parameters.AddWithValue("@MadeInID", MadeInID);
                    command.Parameters.AddWithValue("@Code",Code);
                    command.Parameters.AddWithValue("@M_In_B", M_in_B);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@MakasID", MakasID);

                    if (Picture != null)
                        command.Parameters.AddWithValue("@Picture", Picture);
                    else
                        command.Parameters.AddWithValue("@Picture",System.DBNull.Value);

                    try
                    {
                        conn.Open();
                        Done = command.ExecuteScalar();
                        if (int.TryParse(Done.ToString(), out int result))
                            Adding = result;
                    }
                    catch (Exception ex)
                    {
                        Adding = -1;
                    }
                    
                }

			}
            return Adding;
        } 

        public static bool UpdateBalata(int BalataID,int MakzanID, int BalataTypeID, int MadeInID, string Code,float M_in_B, decimal Salary, int MakasID,string Picture)
        {
            object Updateing = null;
            int Don = 0;

            using(SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
            {
                string Query = @"exec sp_UpdateBalat 
                                 @BalataID,
                                 @TypeID,
                                 @MakzanID,
                                 @Code,
                                 @M_in_B,
                                 @MadeInID,
                                 @Salary,
                                 @MakasID,@Picture_Path
";
                
                using(SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@MakzanID", MakzanID);
                    command.Parameters.AddWithValue("@Code",Code);
                    command.Parameters.AddWithValue("@M_in_B",M_in_B);
                    command.Parameters.AddWithValue("@MadeInID",MadeInID);
                    command.Parameters.AddWithValue("@TypeID",BalataTypeID);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@MakasID", MakasID);
                    command.Parameters.AddWithValue("@BalataID", BalataID);

					if (Picture != null)
						command.Parameters.AddWithValue("@Picture_Path", Picture);
					else
						command.Parameters.AddWithValue("@Picture_Path", System.DBNull.Value);

					try
                    {
                        connection.Open();
                        Updateing = command.ExecuteNonQuery();
                        if(int.TryParse(Updateing.ToString(), out int result))
                            Don = result;
					}
                    catch (SqlException ex)
                    {
                      
                    }
                }
			}
            return Don > 0;
        }

        public static bool IsBalatExist(int BalatID)
        {
            int found = 0;
            using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
            {
                string Query = @"select found = 1 from Balats where BalatID = @ID;";
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@ID", BalatID);
                    try
                    {
                        connection.Open();

                        if (int.TryParse(command.ExecuteScalar().ToString(), out int result))
                            found = result;
                    }
                    catch (SqlException ex)
                    {
                        found = 0;
                    }
                }
            }

            return (found > 0);
        }

        // Error 
		public static bool IsBalatExistByCode(int Code)
		{
			int found = 0;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select found = 1 from Balats where Code = @Code;";
				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@Code", Code);
					try
					{
						connection.Open();

						if (int.TryParse(command.ExecuteScalar().ToString(), out int result))
							found = result;
					}
					catch (SqlException ex)
					{
						found = 0;
					}
				}
			}

			return (found > 0);
		}   

		public static bool IsBalatExistByMakzanID(int MakzanID)
		{
			int found = 0;
			using (SqlConnection connection = new SqlConnection(DataSetting.Connaction_string))
			{
				string Query = @"select found = 1 from Balats where MakzanID = @ID;";
				using (SqlCommand command = new SqlCommand(Query, connection))
				{
					command.Parameters.AddWithValue("@ID", MakzanID);
					try
					{
						connection.Open();

						if (int.TryParse(command.ExecuteScalar().ToString(), out int result))
							found = result;
					}
					catch (SqlException ex)
					{
						found = 0;
					}
				}
			}

			return (found > 0);
		}

        public static bool DeleteRecord(int SenfID)
        {
            bool Deleteing = false;

            using (SqlConnection conn = new SqlConnection(DataSetting.Connaction_string))
            {
                string query = @"DELETE FROM [dbo].[Balats]
          WHERE BalatID = @SenfID";

                using(SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@SenfID", SenfID);
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        Deleteing = true;
                    }
                    catch (SqlException ex)
                    {
                        Deleteing = false;
                    }
                }

			}
            return Deleteing;
        }

	}
}
