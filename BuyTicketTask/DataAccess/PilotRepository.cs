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
    class PilotRepository : IPilotRepository
    {
        public void AddData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Pilot> GetAllData()
        {
            using (var context = new AirTicketEntities())
            {
                var pilots = new ObservableCollection<Pilot>(context.Pilots);
                return pilots;
            }
        }

        public Pilot GetData(int id)
        {
            using(var context=new AirTicketEntities())
            {
                var pilot = context.Pilots.FirstOrDefault(p => p.Id == id);
                return pilot;
            }
        }

        public void UpdateData(Pilot data)
        {
            throw new NotImplementedException();
        }
    }
}
