﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanVeMayBay.Object;
using System.Data;

namespace QLBanVeMayBay.Model
{
    class ChiTietMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"select ct.MaHD, hh.TenMB MayBay, ct.SoLuong, ct.DonGia, ct.SoLuong*ct.DonGia ThanhTien from tb_CTHD ct, tb_MayBay hh where ct.MaHH = hh.MaMB and MaHD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(DataTable dt)
        {

            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.CommandText = "insert into tb_CTHD values ('" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "'," + dt.Rows[i][2].ToString() + "," + dt.Rows[i][3].ToString() + ")";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.Connection;
                    con.OpenConn();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_CTHD Where MaHD = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
