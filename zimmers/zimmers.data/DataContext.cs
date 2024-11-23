using System.Text.Json;
using zimmers.core.Entities;

namespace zimmers.data
{
    public class DataContext
    {
        public List<Cleaner> cleaners;
        public List<Order> orders;
        public List<Owner> owners;
        public List<User> users;
        public List<Zimmer> zimmers;

        public DataContext()
        {
            cleaners = Load<Cleaner>("cleaner.json");
            orders = Load<Order>("order.json");
            owners = Load<Owner>("owner.json");
            users = Load<User>("user.json");
            zimmers = Load<Zimmer>("zimmer.json");
        }
        private List<T> Load<T>(string pathJson)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", pathJson);
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }
        public bool Save<T>(List<T> lst, string pathJson)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", pathJson);
                string jsonString = JsonSerializer.Serialize<List<T>>(lst);
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