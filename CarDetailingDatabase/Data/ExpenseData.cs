using CarDetailingDatabase.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetailingDatabase.Data
{
    public class ExpenseData : IExpenseData
    {
        private readonly IDatabaseAccess _db;

        public ExpenseData(IDatabaseAccess db)
        {
            _db = db;
        }

        public Task<List<WebsiteModel>> GetWebsites()
        {
            var sql = "SELECT * FROM website";
            return _db.LoadData<WebsiteModel, dynamic>(sql, new { });
        }

        public async Task<List<ExpenseModel>> GetExpenses()
        {
            string connectionString = _db._config.GetConnectionString(_db.ConnectionStringName);
            string sql = "SELECT * FROM expense JOIN website ON expense.website_id = website.id";

            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<ExpenseModel, WebsiteModel, ExpenseModel>(sql,
                    (e, w) => { e.Website = w; return e; },
                    splitOn: "Id");

                return data.ToList();
            }
        }

        public Task SaveNewExpense(ExpenseModel expense)
        {
            string sql = @"INSERT INTO expense (website_id, price, bought) VALUES (@WebsiteId, @Price, @Bought)";

            return _db.SaveData(sql, new { WebsiteId = expense.Website.Id, Price = expense.Price, Bought = expense.Bought != DateOnly.MinValue ? expense.Bought.ToDateTime(TimeOnly.MinValue) : (DateTime?)null });
        }
    }
}
