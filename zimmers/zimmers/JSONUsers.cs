using zimmers.Entities;
using System.Text.Json;

namespace zimmers
{
    public class JSONUsers : IDataContext
    {
        public List<User> jsonUsers { get; set; }
        public void Load()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
            string jsonString = File.ReadAllText(path);
            jsonUsers = JsonSerializer.Deserialize<DataUsers>(jsonString).db;
        }
        public bool Save()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                DataUsers dataUsers = new DataUsers();
                dataUsers.db = jsonUsers;
                string jsonString = JsonSerializer.Serialize<DataUsers>(dataUsers);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

