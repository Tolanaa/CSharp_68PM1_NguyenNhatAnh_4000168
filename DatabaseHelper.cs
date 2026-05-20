using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace QuanLySinhVien
{
    public static class DatabaseHelper
    {
        private static string dbPath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "QuanLySinhVien.db");

        private static string ConnectionString
        {
            get { return "Data Source=" + dbPath + ";Version=3;"; }
        }

        public static void InitDatabase()
        {
            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string createLopHoc = @"
                    CREATE TABLE IF NOT EXISTS LopHoc (
                        MaID INTEGER PRIMARY KEY AUTOINCREMENT,
                        MaLop TEXT NOT NULL,
                        TenLop TEXT NOT NULL,
                        GhiChu TEXT
                    );";

                string createSinhVien = @"
                    CREATE TABLE IF NOT EXISTS SinhVien (
                        MaSV INTEGER PRIMARY KEY AUTOINCREMENT,
                        HoVaTen TEXT NOT NULL,
                        NgaySinh TEXT,
                        GioiTinh TEXT,
                        MaLop TEXT,
                        FOREIGN KEY(MaLop) REFERENCES LopHoc(MaLop)
                    );";

                new SQLiteCommand(createLopHoc, conn).ExecuteNonQuery();
                new SQLiteCommand(createSinhVien, conn).ExecuteNonQuery();
            }
        }

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public static DataTable ExecuteQuery(string sql, SQLiteParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                var dt = new DataTable();
                new SQLiteDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string sql, SQLiteParameter[] parameters = null)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand(sql, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}