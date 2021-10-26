using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicketTask.Domain.Abstraction
{
    public interface IRepository<T>
    {
        ObservableCollection<T> GetAllData();

        T GetData(int id);

        void AddData(T data);
        void DeleteData(T data);
        void UpdateData(T data);

    }
}
