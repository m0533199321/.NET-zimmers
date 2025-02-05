using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dataSet;
        public Repository(DataContext dataContext)
        {
            _dataSet = dataContext.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _dataSet.ToListAsync();
        }
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dataSet.FindAsync(id);
        }
        public async Task<T> AddAsync(T t)
        {
            await _dataSet.AddAsync(t);
            //_iManager.save();
            return t;
        }
        public async Task<T> UpdateAsync(int id, T updatedEntity)
        {
            var existingEntity = await _dataSet.FindAsync(id);
            if (existingEntity == null)
            {
                return null;
            }
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                      .Where(prop => prop.Name != "Id");

            foreach (var property in properties)
            {
                var updatedValue = property.GetValue(updatedEntity);

                if (updatedValue != null)
                {
                    property.SetValue(existingEntity, updatedValue);
                }
            }
            //_iManager.save();
            return existingEntity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            T find = await _dataSet.FindAsync(id);
            if (find != null)
            {
                _dataSet.Remove(find);
                //_iManager.save();
                return true;
            }
            return false;
        }
    }
}



//public T Update(int id, T t)
//{
//    var existingEntity = _dataSet.Find(id);
//    if (existingEntity == null)
//        return null;

//    var properties = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Public)
//     .Where(prop => prop.Name != "Id");

//    foreach (var property in properties)
//    {
//        var updatedValue = property.GetValue(t);

//        property.SetValue(existingEntity, updatedValue);
//    }
//    _iManager.save();
//    return t;
//}