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
        private readonly IRepositoryManager _iManager;
        public Repository(DataContext dataContext, IRepositoryManager manager)
        {
            _dataSet = dataContext.Set<T>();
            _iManager = manager;
        }
        public IEnumerable<T> Get()
        {
            return _dataSet.ToList();
        }
        public T? GetById(int id)
        {
            return _dataSet.Find(id);
        }
        public T Add(T t)
        {
            _dataSet.Add(t);
            _iManager.save();
            return t;
        }
        public T Update(int id, T updatedEntity)
        {
            var existingEntity = _dataSet.Find(id);
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
            _iManager.save();
            return existingEntity;
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
        public bool Delete(int id)
        {
            T find = _dataSet.Find(id);
            if (find != null)
            {
                _dataSet.Remove(find);
                _iManager.save();
                return true;
            }
            return false;
        }
    }
}
