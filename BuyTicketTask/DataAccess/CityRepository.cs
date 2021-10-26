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
    class CityRepository : ICityRepository
    {
        public void AddData(City data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAllData()
        {
            using (var context=new AirTicketEntities())
            {
                var cities = new ObservableCollection<City>(context.Cities);

                return cities;
            }
        }

        public City GetData(int id)
        {
            throw new NotImplementedException();
        }



        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
