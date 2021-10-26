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
    class ScheduleRepository : IScheduleRepository
    {
        public void AddData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Schedule> GetAllData()
        {
            using (var context = new AirTicketEntities())
            {
                var schedules = new ObservableCollection<Schedule>(context.Schedules);
                return schedules;
            }
        }

        public Schedule GetData(int id)
        {
            using (var context = new AirTicketEntities())
            {
                var schedule = context.Schedules.FirstOrDefault(s => s.Id == id);
                return schedule;
            }
        }

        public void UpdateData(Schedule data)
        {
            throw new NotImplementedException();
        }
    }
}
