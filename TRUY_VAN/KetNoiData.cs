using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Quan_Ly_Khach_San.TRUY_VAN
{
     public class KetNoiData
    {
        private static SqlConnection connect;

        private void MoKetNoi()
        {
            if (KetNoiData.connect == null)


                //Tạo connection
                KetNoiData.connect = new SqlConnection(@"Data Source=.;Initial Catalog=QL_KS;Integrated Security=True");

                

                //KetNoiData.connect = new SqlConnection(@"Data Source=DESKTOP-Q9B8A27\SQLEXPRESS;Initial Catalog=QL_KS;Integrated Security=True");


                //KetNoiData.connect = new SqlConnection(@"Data Source=CHI-BUI;Initial Catalog=QL_KS;Integrated Security=True");

                

            if (KetNoiData.connect.State != ConnectionState.Open)
                KetNoiData.connect.Open();  //Mở connection
        }

        private void DongKetNoi()
        {
            if (KetNoiData.connect != null)
            {
                if (KetNoiData.connect.State == ConnectionState.Open)
                {
                    KetNoiData.connect.Close(); //Đóng connection
                }
            }
        }

        /// <summary>
        /// Thực hiện query: Insert, Delete, Update
        /// </summary>
        /// <param name="query"></param>
        /// <returns>success: 1; fail: 0</returns>
        public int ThucHienLenh(string query)
        {
            try
            {
                MoKetNoi();

                //Đối tượng SqlCommand dùng để thực hiện câu lệnh SQL hoặc thủ tục Store procedure
                SqlCommand sqlcmd = new SqlCommand(query, connect);

                //Thực hiện lệnh và trả về số dòng thay đổi
                sqlcmd.ExecuteNonQuery();

                DongKetNoi();
                return 1;
            }
            catch
            {
                DongKetNoi();
                return 0;
            }
        }

        /// <summary>
        /// Thực hiện câu query
        /// </summary>
        /// <param name="query"></param>
        /// <returns>DataTable data</returns>
        public DataTable GetDataTable(string query)
        {
            try
            {
                MoKetNoi();
                DataTable data = new DataTable();

                //Trung gian thực hiện câu truy vấn lấy dữ liệu ra từ csdl
                SqlDataAdapter sqlda = new SqlDataAdapter(query, connect);  
                //Đổ dữ liệu ra  DataTable
                sqlda.Fill(data);

                DongKetNoi();
                return data;
            }
            catch
            {
                DongKetNoi();
                return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string GetValue(string query)
        {
            try
            {
                MoKetNoi();
                string value = "";
                //Đối tượng Command dùng để thực thi câu lệnh Sql hoăc thủ tục Store Procedure
                SqlCommand cmd = new SqlCommand(query, connect);

                //Đối tượng DataReader dùng để dọc dữ liệu: forward-only 
                SqlDataReader reader = cmd.ExecuteReader();

                //Đọc dữ liệu
                while (reader.Read())
                {
                    value = (reader.GetValue(0).ToString());
                }
                reader.Close();

                DongKetNoi();
                return value;
            }
            catch
            {
                DongKetNoi();
                return "";
            }
        }
    }
}
