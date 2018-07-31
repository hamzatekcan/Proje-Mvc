using HtnLog.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtnLog.BLL
{
    public class RepoBase<T, Param> where T:class
    {
        protected HtnLogEntities context =new HtnLogEntities();

        public List<T> GetAll()
        {
          return  context.Set<T>().ToList();
        }

        public T GetById(Param id)
        {
            return context.Set<T>().Find(id);
        }


        public bool Add(T data)
        {
            try
            {
                context.Set<T>().Attach(data);
                context.Entry<T>(data).State = EntityState.Added;
                return true;
            }
            catch (Exception e)
            {
                return false;

                throw;
            }
        }

        public bool Update(T data)
        {
            try
            {
                context.Set<T>().Attach(data);
                context.Entry<T>(data).State = EntityState.Modified;
                return true;
            }
            catch (Exception e)
            {
                return false;

                throw;
            }
        }

        public bool Delete(T data)
        {
            try
            {
                context.Set<T>().Attach(data);
                context.Entry<T>(data).State = EntityState.Deleted;
                return true;
            }
            catch (Exception e)
            {
                return false;

                throw;
            }
        }


    }
}
