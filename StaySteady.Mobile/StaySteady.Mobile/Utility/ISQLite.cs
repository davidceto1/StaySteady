using SQLite;

namespace StaySteady.Mobile.Utility
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}