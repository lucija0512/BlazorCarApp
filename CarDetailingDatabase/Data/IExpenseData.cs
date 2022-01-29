using CarDetailingDatabase.Models;

namespace CarDetailingDatabase.Data
{
    public interface IExpenseData
    {
        Task<List<ExpenseModel>> GetExpenses();
        Task<List<WebsiteModel>> GetWebsites();
        Task SaveNewExpense(ExpenseModel expense);
    }
}