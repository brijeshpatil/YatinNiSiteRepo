using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace YatinNiSite
{
    public class DataService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SmallAppConn"].ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        public DataService()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        #region ManageLocation

        public bool AddNewState(string StateName)
        {
            cmd = new SqlCommand("AddNewState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SName", StateName);
            con.Open();
            bool Status = Convert.ToBoolean(cmd.ExecuteNonQuery());
            con.Close();
            return Status;
        }

        public DataTable GetAllStates()
        {
            da = new SqlDataAdapter("GetAllStates", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateState(PService P)
        {
            cmd = new SqlCommand("UpdateState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SID", P.StateID);
            cmd.Parameters.AddWithValue("@SName", P.StateName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteState(int StateID)
        {
            cmd = new SqlCommand("DeleteState", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SID", StateID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AddNewCity(int StateID, string CityName)
        {
            cmd = new SqlCommand("AddNewCity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SID", StateID);
            cmd.Parameters.AddWithValue("@CName", CityName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetCityByState(int StateID)
        {
            da = new SqlDataAdapter("GetCityByState", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@SID", StateID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetCitiesWithStates()
        {
            da = new SqlDataAdapter("GetCitiesWithStates", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateCity(PService P)
        {
            cmd = new SqlCommand("UpdateCity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CID", P.CityID);
            cmd.Parameters.AddWithValue("@CName", P.CityName);
            cmd.Parameters.AddWithValue("@SID", P.StateID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteCity(int CityID)
        {
            cmd = new SqlCommand("DeleteCity", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CID", CityID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion

        #region ManageUser

        public void RegNewUser(PService P)
        {
            cmd = new SqlCommand("RegNewUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fname", P.FirstName);
            cmd.Parameters.AddWithValue("@Lname", P.LastName);
            cmd.Parameters.AddWithValue("@Gender", P.Gender);
            cmd.Parameters.AddWithValue("@SID", P.StateID);
            cmd.Parameters.AddWithValue("@CId", P.CityID);
            cmd.Parameters.AddWithValue("@UName", P.UserName);
            cmd.Parameters.AddWithValue("@Pass", P.Password);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool IsUser(string UserName, string Password)
        {
            cmd = new SqlCommand("IsUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UName", UserName);
            cmd.Parameters.AddWithValue("@Pass", Password);
            con.Open();
            bool IsUser = Convert.ToBoolean(cmd.ExecuteScalar());
            con.Close();
            return IsUser;
        }

        public DataTable GetUserProfile(string UserName)
        {
            da = new SqlDataAdapter("GetUserProfile", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@UName", UserName);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region ManagePost

        public void AddNewPost(PService P)
        {
            cmd = new SqlCommand("AddNewPost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", P.UserID);
            cmd.Parameters.AddWithValue("@PData", P.PostData);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetAllPosts()
        {
            da = new SqlDataAdapter("GetAllPosts", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void LikePost(int UserID, int PostID)
        {
            cmd = new SqlCommand("LikePost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@PID", PostID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UnLikePost(int UserID, int PostID)
        {
            cmd = new SqlCommand("UnLikePost", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@PID", PostID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool IsLiked(int UserID, int PostID)
        {
            cmd = new SqlCommand("IsLiked", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", UserID);
            cmd.Parameters.AddWithValue("@PID", PostID);
            con.Open();
            bool IsLiked = Convert.ToBoolean(cmd.ExecuteScalar());
            con.Close();
            return IsLiked;
        }

        public void PostComment(PService P)
        {
            cmd = new SqlCommand("PostComment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UID", P.UserID);
            cmd.Parameters.AddWithValue("@PID", P.PostID);
            cmd.Parameters.AddWithValue("@CData", P.CommentData);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable GetCommentsByPost(int PostID)
        {
            da = new SqlDataAdapter("GetCommentsByPost", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@PID", PostID);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

    }
}