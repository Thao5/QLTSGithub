using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;

namespace QLTS.DAO
{
    public class QLTSDAO
    {
        public QLTSDAO()
        {
        }
        
        public static void connect_database()
        {

            string connectionString = "Data Source=DESKTOP-P05V5E6;Initial Catalog=quanlytiemsach;User ID=sa;Password=1;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string query =
                        @"CREATE TABLE dbo.NXB
                        (
                            id varchar(8)  NOT NULL,
                            name varchar(50) NOT NULL,
                            constraint pk_idnxb PRIMARY KEY(id)
                        );";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query =
                        @"CREATE TABLE dbo.taikhoan
                        (
                            id varchar(8) NOT NULL,
                            username varchar(30) NOT NULL,
                            password varchar(12) NOT NULL,
                            ho varchar(50) NOT NULL,
                            ten varchar(12) NOT NULL,
                            ngaysinh DATETIME NOT NULL,
                            sotienconlai MONEY NOT NULL,
                            phanquyen INT NOT NULL,
                            constraint pk_iduser PRIMARY KEY(id)
                        );";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query =
                        @"CREATE TABLE dbo.sach
                        (
                            id varchar(8) NOT NULL,
                            name varchar(50) NOT NULL,
                            ngay_xuat_ban DATETIME NOT NULL,
                            gia_ban MONEY NOT NULL,
                            gia_thue MONEY NOT NULL,
                            so_luong INT NOT NULL,
                            the_loai varchar(30) NOT NULL,
                            gia_nhap MONEY NOT NULL,
                            id_nxb varchar(8) NOT NULL,
                            constraint pk_idsach PRIMARY KEY(id),
                            FOREIGN KEY(id_nxb) REFERENCES dbo.NXB(id)
                        );";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query =
                        @"CREATE TABLE dbo.sachduocthue
                        (
                            id int identity(1,1) NOT NULL,
                            ngay_thue DATETIME NOT NULL,
                            ngay_tra DATETIME,
                            gia_thue MONEY NOT NULL,
                            created_date DATETIME NOT NULL,
                            id_sach varchar(8) NOT NULL,
                            id_user varchar(8) NOT NULL,
                            constraint pk_idsachduocthue PRIMARY KEY(id),
                            FOREIGN KEY (id_sach) REFERENCES dbo.sach(id),
                            FOREIGN KEY (id_user) REFERENCES dbo.taikhoan(id)
                        );";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query =
                        @"CREATE TABLE dbo.sachduocmua
                        (
                            id int identity(1,1) NOT NULL,
                            gia_ban MONEY NOT NULL,
                            created_date DATETIME NOT NULL,
                            id_sach varchar(8) NOT NULL,
                            id_user varchar(8) NOT NULL,
                            constraint pk_idsachduocmua PRIMARY KEY(id),
                            FOREIGN KEY (id_sach) REFERENCES dbo.sach(id),
                            FOREIGN KEY (id_user) REFERENCES dbo.taikhoan(id)                        
                        );";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query =
                        @"CREATE TABLE dbo.sachthuoctacgia
                        (
                            id int identity(1,1) NOT NULL,
                            id_sach varchar(8) NOT NULL,
                            id_user varchar(8) NOT NULL,
                            constraint pk_idsachthuoctacgia PRIMARY KEY(id),
                            FOREIGN KEY (id_sach) REFERENCES dbo.sach(id),
                            FOREIGN KEY (id_user) REFERENCES dbo.taikhoan(id)
                        );";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    query =
                        @"CREATE TABLE dbo.code(
                            id varchar(8) NOT NULL,
                            valid bit NOT NULL,
                            id_user varchar(8),
                            ngaynap DATETIME,
                            FOREIGN KEY (id_user) REFERENCES dbo.taikhoan(id)
                        );";
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("thanh cong");
                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine("that bai");
                }
            }

        }
        [STAThread]
        static void Main()
        {
            connect_database();
        }
    }
}