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
    class FlightTypeRepository : IFlightTypeRepository
    {
        public void AddData(FlightType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(FlightType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<FlightType> GetAllData()
        {
            using (var context=new AirTicketEntities())
            {
                var flighttypes = new ObservableCollection<FlightType>(context.FlightTypes);
                return flighttypes;
            }
        }

        public FlightType GetData(int id)
        {
            using (var context = new AirTicketEntities())
            {
                var flighttype = context.FlightTypes.FirstOrDefault(a => a.Id == id);
                return flighttype;
            }
        }

        public void UpdateData(FlightType data)
        {
            throw new NotImplementedException();
        }
    }
}
