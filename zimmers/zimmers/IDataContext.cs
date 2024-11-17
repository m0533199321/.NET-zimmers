using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;
namespace zimmers
{
    public interface IDataContext
    {
        public List<User> jsonUsers { get; set; }

        public void Load();
        public bool Save();
    }
}
