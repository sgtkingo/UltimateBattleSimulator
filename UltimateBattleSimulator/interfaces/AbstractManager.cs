using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;

namespace UltimateBattleSimulator.interfaces
{
    internal abstract class  AbstractManager<T> where T : Ideable
    {
        public List<T> Temp{ get; private set; } = new List<T>();

        public List<T> Loaded{ get; private set; } = new List<T>();

        public virtual List<T> Get(bool includeFromFile = false)
        {
            Temp.RemoveAll(item => item.IsLoadedFromFile);
            if (includeFromFile)
            {
                Temp.AddRange(Loaded.FindAll(u => u.IsSelected == true));
            }
            return Temp;
        }

        public virtual void Reload()
        {
            Loaded.Clear();
        }

        public virtual void Clear()
        {
            Temp.Clear();
            Loaded.Clear();
        }

        public virtual T? Find(string text)
        {
            return Loaded.Find(item => item?.ToString()?.Contains(text) ?? false);
        }

        public virtual void Save(T item)
        {
            item.Save();
        }

        public virtual void SaveAll()
        {
            foreach (var item in Temp)
            {
                item.Save();
            }
        }

        public virtual void Delete(T item, bool permanent = false)
        {
            item.IsSelected = false;
            Temp.Remove(item);
            if (permanent)
            {
                item.Delete();
            }
        }

        public virtual void DeleteAll(bool permanent = false)
        {
            foreach (var item in Temp)
            {
                item.IsSelected = false;
                if (permanent)
                {
                    item.Delete();
                }
            }

            Temp.Clear();
        }
    }
}
