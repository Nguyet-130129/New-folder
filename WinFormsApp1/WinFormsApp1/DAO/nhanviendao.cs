﻿using WinFormsApp1.connect;
using WinFormsApp1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace WinFormsApp1.DAO
{
    internal class nhanviendao
    {
        private ketnoi connectObj = new ketnoi();
        
        public nhanviendao() { }
        
        public List<nhanviendto> GetNhanVien()
        {
            List<nhanviendto> employees = new List<nhanviendto>();

            using (SqlConnection connection = connectObj.connection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM NhanVien";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        nhanviendto employee = new nhanviendto
                        {
                            MaNhanVien = reader["MaNhanVien"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = Convert.ToString(reader["ngaysinh"]),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            Email = reader["Email"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                            PhongBan = reader["PhongBan"].ToString(),
                            ChucVu= reader["ChucVu"].ToString(),
                            HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                            TrangThai = Convert.ToInt32(reader["TrangThai"])
                            
                            
                        };
                        employees.Add(employee);
                    }
                reader.Close();
                connection.Close();
                return employees;
            }
        }

        public void AddEmployee(nhanviendto employee)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO NhanVien VALUES(@MaNV, @HoTen, @SDT, @Email, @TrangThai, @NgaySinh, @MaTK, @GioiTinh)", connection);
                command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                command.Parameters.AddWithValue("@HoTen", employee.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", employee.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@SDT", employee.SDT);
                command.Parameters.AddWithValue("@NguoiQuanLy", employee.NguoiQuanLy);
                command.Parameters.AddWithValue("@PhongBan", employee.PhongBan);
                command.Parameters.AddWithValue("@ChucVu", employee.ChucVu);
                command.Parameters.AddWithValue("@HoSoGioiThieu", employee.HoSoGioiThieu);
                command.Parameters.AddWithValue("@TrangThai", employee.TrangThai);
                
                //command.Parameters.AddWithValue("@MaTK", employee.MaTK);
                
                command.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand("UPDATE TaiKhoan SET TrangThai = 1 WHERE MaTaiKhoan = @MaTaiKhoan", connection);
                command1.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                command1.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(nhanviendto employee)
        {
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE NhanVien SET HoTen = @HoTen, ngaysinh = @NgaySinh,  GioiTinh = @GioiTinh, DiaChi=@DiaChi, SDT = @SDT, Email = @Email, NguoiQuanLy=@NguoiQuanLy, TrangThai = @TrangThai, PhongBan=@PhongBan, ChucVu=@ChucVu, HoSoGioiThieu=@HoSoGioiThieu WHERE MaNhanVien = @MaNhanVien";
                command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
                command.Parameters.AddWithValue("@HoTen", employee.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
                command.Parameters.AddWithValue("@GioiTinh", employee.GioiTinh);
                command.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                command.Parameters.AddWithValue("@Email", employee.Email);
                command.Parameters.AddWithValue("@SDT", employee.SDT);
                command.Parameters.AddWithValue("@NguoiQuanLy", employee.NguoiQuanLy);
                command.Parameters.AddWithValue("@PhongBan", employee.PhongBan);
                command.Parameters.AddWithValue("@ChucVu", employee.ChucVu);
                command.Parameters.AddWithValue("@HoSoGioiThieu", employee.HoSoGioiThieu);
                command.Parameters.AddWithValue("@TrangThai", employee.TrangThai);
                command.Connection = connection;
                command.ExecuteNonQuery();

            }
        }
        public ArrayList SearchEmployeeByID(string keyword)
        {
            ArrayList employees = new ArrayList();
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE MaNhanVien LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                        PhongBan = reader["PhongBan"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])




                        //MaNV = reader["MaNV"].ToString(),
                        //HoTen = reader["HoTen"].ToString(),
                        //SDT = reader["SDT"].ToString(),
                        //Email = reader["Email"].ToString(),
                        //GioiTinh = reader["GioiTinh"].ToString(),
                        //TrangThai = Convert.ToInt32(reader["TrangThai"]),
                        //NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        //MaTK = Convert.ToInt32(reader["maTK"])
                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }

        public ArrayList SearchEmployeeByName(string keyword)
        {
            ArrayList employees = new ArrayList();
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE HoTen LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataReader reader = command.ExecuteReader();
                /*while (reader.Read())
                {
                    string maNV = reader.GetString(0);
                    string hoTen = reader.GetString(1);
                    string sdt = reader.GetString(2);
                    string email = reader.GetString(3);
                    int trangThai = reader.GetInt32(4);
                    string ngaySinh = reader.GetString(5);
                    int maTK = reader.GetInt32(6);  
                    nhanviendto employee = new nhanviendto(maNV, hoTen, sdt, email, trangThai, ngaySinh, maTK);
                    employees.Add(employee);
                }*/
                while (reader.Read())
                {
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                        PhongBan = reader["PhongBan"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])



                        //MaNV = reader["MaNV"].ToString(),
                        //HoTen = reader["HoTen"].ToString(),
                        //SDT = reader["SDT"].ToString(),
                        //Email = reader["Email"].ToString(),
                        //GioiTinh = reader["GioiTinh"].ToString(),
                        //TrangThai = Convert.ToInt32(reader["TrangThai"]),
                        //NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        //MaTK = Convert.ToInt32(reader["maTK"])
                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }
        public ArrayList SearchEmployeeByPhoneNumber(string keyword)
        {
            ArrayList employees = new ArrayList();
            using (SqlConnection connection = connectObj.connection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE SDT LIKE @Keyword OR Email LIKE @Keyword", connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                SqlDataReader reader = command.ExecuteReader();
                /*while (reader.Read())
                {
                    string maNV = reader.GetString(0);
                    string hoTen = reader.GetString(1);
                    string sdt = reader.GetString(2);
                    string email = reader.GetString(3);
                    int trangThai = reader.GetInt32(4);
                    string ngaySinh = reader.GetString(5);
                    int maTK = reader.GetInt32(6);  
                    nhanviendto employee = new nhanviendto(maNV, hoTen, sdt, email, trangThai, ngaySinh, maTK);
                    employees.Add(employee);
                }*/
                while (reader.Read())
                {
                    nhanviendto employee = new nhanviendto
                    {
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        Email = reader["Email"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        NguoiQuanLy = reader["NguoiQuanLy"].ToString(),
                        PhongBan = reader["PhongBan"].ToString(),
                        ChucVu = reader["ChucVu"].ToString(),
                        HoSoGioiThieu = reader["HoSoGioiThieu"].ToString(),
                        TrangThai = Convert.ToInt32(reader["TrangThai"])


                        //MaNV = reader["MaNV"].ToString(),
                        //HoTen = reader["HoTen"].ToString(),
                        //SDT = reader["SDT"].ToString(),
                        //Email = reader["Email"].ToString(),
                        //GioiTinh = reader["GioiTinh"].ToString(),
                        //TrangThai = Convert.ToInt32(reader["TrangThai"]),
                        //NgaySinh = Convert.ToString(reader["ngaysinh"]),
                        //MaTK = Convert.ToInt32(reader["maTK"])
                    };
                    employees.Add(employee);
                }
                reader.Close();
            }
            return employees;
        }




        // Update TaiKhoan 

        //public List<string> LoadMaTK()
        //{
        //    List<string> userIDs = new List<string>();
        //    using (SqlConnection connection = connectObj.connection())
        //    {
        //        SqlCommand command = new SqlCommand("SELECT UserID FROM TaiKhoan WHERE TrangThai = 0", connection);
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            userIDs.Add(reader["UserID"].ToString());
        //        }
        //        reader.Close();
        //    }
        //    return userIDs;
        //}

        //public void ChangeStateHidden(nhanviendto employee)
        //{
        //    using (SqlConnection connection = connectObj.connection())
        //    {
        //        SqlCommand command = new SqlCommand("UPDATE TaiKhoan SET TrangThai = 0 FROM NhanVien JOIN TaiKhoan ON NhanVien.maTK = TaiKhoan.UserID WHERE NhanVien.maNV = @MaNV", connection);
        //        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void ChangeStateCurrent(nhanviendto employee)
        //{
        //    using (SqlConnection connection = connectObj.connection())
        //    {
        //        SqlCommand command = new SqlCommand("UPDATE TaiKhoan SET TrangThai = 1 FROM NhanVien JOIN TaiKhoan ON NhanVien.maTK = TaiKhoan.UserID WHERE NhanVien.maNV = @MaNV", connection);
        //        command.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
        //        command.ExecuteNonQuery();
        //    }
        //}

    }
}
