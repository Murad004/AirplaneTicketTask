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
    class TicketRepository : ITicketRepository
    {
        public void AddData(Ticket data)
        {
            using(var context=new AirTicketEntities())
            {
                context.Tickets.Add(data);
            }
        }

        public void DeleteData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Ticket> GetAllData()
        {
            using (var context=new AirTicketEntities())
            {
                var tickets = new ObservableCollection<Ticket>(context.Tickets);
                return tickets;
            }
        }

        public Ticket GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
