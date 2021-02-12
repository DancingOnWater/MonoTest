using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMono
{
    public static class Config
    {
        public static string pgSqlConnectionString {
            get => "Host={адрес сервера};Database={имя БД};Username={имя пользователя};Password={пароль};";
        }

        public static string msSqlConnectionString {
            get => @"Data Source = {адрес сервера}\{экземпляр сервера}; Initial Catalog = {имя БД}; Persist Security Info = True; User ID = {имя пользователя}; PWD = {пароль};";
        }
    }
}
