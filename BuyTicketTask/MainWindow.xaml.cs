using BuyTicketTask.DataAccess;
using BuyTicketTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuyTicketTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirTicketEntities context = new AirTicketEntities();
        int cityid;
        int airplaneid;
        int scheduleid;
        int flighttypeid;
        int pilotid;
        FlightTypeRepository flightTypeRepository = new FlightTypeRepository();

        CityRepository cityRepository = new CityRepository();
        AirplaneRepository AirplaneRepository = new AirplaneRepository();
        PilotRepository PilotRepository = new PilotRepository();
        ScheduleRepository ScheduleRepository = new ScheduleRepository();
        TicketRepository TicketRepository = new TicketRepository();
        public MainWindow()
        {
            InitializeComponent();

            FlightTypeRepository flightTypeRepository = new FlightTypeRepository();

            CityRepository cityRepository = new CityRepository();


            CityCmbBox.ItemsSource = cityRepository.GetAllData();
            FlightTypeCmbBox.ItemsSource = flightTypeRepository.GetAllData();
        }

        private void CityCmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var city = CityCmbBox.SelectedItem as City;
            cityid = city.Id;

            
            AirplaneCmbBox.Items.Add(AirplaneRepository.GetData(city.Airplane_Id));

            airplaneid = city.Airplane_Id;



            ScheduleCmbBox.Items.Add(ScheduleRepository.GetData(city.Schedules_Id));

            scheduleid = city.Schedules_Id;

            

            //pilotid = city.Airplane.Pilot_Id;



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var item = FlightTypeCmbBox.SelectedItem as FlightType;
            if (item.Type == "Eco")
            {
                MessageBox.Show("Biletiniz ugurla sifaris edildi Qiymet : 150");
            }
            else if (item.Type == "Business")
            {
                MessageBox.Show("Biletiniz ugurla sifaris edildi Qiymet : 200");
            }
            else if (item.Type == "Premium")
            {
                MessageBox.Show("Biletiniz ugurla sifaris edildi Qiymet : 400");
            }

            context.Tickets.Add(new Ticket
            {
                Airplane_Id = airplaneid,
                Schedules_Id = scheduleid,
                City_Id = cityid,
                FlightType_Id = flighttypeid
            });

            TicketDataGrid.ItemsSource = TicketRepository.GetAllData();

            

        }

        private void FlightTypeCmbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var flighttype = FlightTypeCmbBox.SelectedItem as FlightType;
            flighttypeid = flighttype.Id;
        }
    }
}
