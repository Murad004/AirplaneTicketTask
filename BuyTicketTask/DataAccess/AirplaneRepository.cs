using BuyTicketTask.Domain.Abstraction;
using BuyTicketTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicketTask.DataAccess
{
    class AirplaneRepository : IAirplaneRepository
    {
        public void AddData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public  ObservableCollection<Airplane> GetAllData()
        {
            using (var context = new AirTicketEntities())
            {
                var airplanes = new ObservableCollection<Airplane>(context.Airplanes);

                return airplanes;
            }
        }

        public Airplane GetData(int id)
        {
            using(var context=new AirTicketEntities())
            {
                var airplane = context.Airplanes.FirstOrDefault(a => a.Id==id);
                return airplane;
            }
        }

        public void UpdateData(Airplane data)
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Airplane> IRepository<Airplane>.GetAllData()
        {
            throw new NotImplementedException();
        }
    }
}
