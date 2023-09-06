using Details_Of_All_Staff_in_Softworks_Department.Net.Model.ResponseModel;
using System.Data;
using System.Data.SqlClient;

namespace Details_Of_All_Staff_in_Softworks_Department.Net.Utils
{
    public class StaffUtil
    {
        private readonly IConfiguration _configuration;

        // constructor
        public StaffUtil(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<List<StaffResponse>> GetAllStaff()
        {
            // return class model
            List<StaffResponse> response = new List<StaffResponse>();

            //connect to database
            SqlConnection connect = new SqlConnection(this._configuration.GetConnectionString("ConnString"));
            
            // try and catch is for defensive programming
            try
            {

                using (SqlCommand command = new SqlCommand("GetAllStaff", connect))
                {
                    await connect.OpenAsync();
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var staffResponse = new StaffResponse();
                            staffResponse.Name = Convert.ToString(reader[0]);
                            staffResponse.Email = Convert.ToString(reader[1]);
                            staffResponse.ContactInfo = Convert.ToString(reader[2]);
                            staffResponse.Company = Convert.ToString(reader[3]);
                            staffResponse.Department = Convert.ToString(reader[4]);
                            staffResponse.Position = Convert.ToString(reader[5]);
                            staffResponse.Gender = Convert.ToString(reader[6]);
                            staffResponse.DateOfBirth = Convert.ToDateTime(reader[7]);
                            staffResponse.Salary = Convert.ToDecimal(reader[8]);

                            response.Add(staffResponse);
                        }
                    }
                    else
                    {
                        Console.WriteLine("no data present");
                    }
                    return response;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<StaffResponseDateCreated>> GetAllStaffsAndDateCreated()
        {
            // return class model
            List<StaffResponseDateCreated> response = new List<StaffResponseDateCreated>();

            //connect to database
            SqlConnection connect = new SqlConnection(this._configuration.GetConnectionString("ConnString"));

            // try and catch is for defensive programming
            try
            {

                using (SqlCommand command = new SqlCommand("GetAllStaff", connect))
                {
                    await connect.OpenAsync();
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var StaffResponseDateCreated = new StaffResponseDateCreated();
                            StaffResponseDateCreated.Name = Convert.ToString(reader[0]);
                            StaffResponseDateCreated.Email = Convert.ToString(reader[1]);
                            StaffResponseDateCreated.ContactInfo = Convert.ToString(reader[2]);
                            StaffResponseDateCreated.Company = Convert.ToString(reader[3]);
                            StaffResponseDateCreated.Department = Convert.ToString(reader[4]);
                            StaffResponseDateCreated.Position = Convert.ToString(reader[5]);
                            StaffResponseDateCreated.Gender = Convert.ToString(reader[6]);
                            StaffResponseDateCreated.DateOfBirth = Convert.ToDateTime(reader[7]);
                            StaffResponseDateCreated.Salary = Convert.ToDecimal(reader[8]);
                            StaffResponseDateCreated.DateCreated = Convert.ToDateTime(reader[9]);
                            response.Add(StaffResponseDateCreated);
                        }
                    }
                    else
                    {
                        Console.WriteLine("no data present");
                    }
                    return response;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<StaffResponse> GetAllStaffByStaff_Id(int staff_Id)
        {
            // return class mode
            StaffResponse response = new StaffResponse();

            //connect to database
            SqlConnection connect = new SqlConnection(this._configuration.GetConnectionString("ConnString"));

            // try and catch is for defensive programming
            try
            {
                using (SqlCommand command = new SqlCommand("GetAllStaffByStaffId", connect))
                {
                    await connect.OpenAsync();
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@staff_Id", SqlDbType.Int).Value = staff_Id;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            var staffResponse = new StaffResponse();
                            staffResponse.Name = Convert.ToString(reader[0]);
                            staffResponse.Email = Convert.ToString(reader[1]);
                            staffResponse.ContactInfo = Convert.ToString(reader[2]);
                            staffResponse.Company = Convert.ToString(reader[3]);
                            staffResponse.Department = Convert.ToString(reader[4]);
                            staffResponse.Position = Convert.ToString(reader[5]);
                            staffResponse.Gender = Convert.ToString(reader[6]);
                            staffResponse.DateOfBirth = Convert.ToDateTime(reader[7]);
                            staffResponse.Salary = Convert.ToDecimal(reader[8]);

                            return staffResponse;

                        }
                    }
                    else
                    {
                        Console.WriteLine("no data present");
                    }
                    return response;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }








    }



}

