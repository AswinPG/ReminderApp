using ReminderApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReminderApp.DailyView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyPage : ContentView    
    {
        List<ReminderData> reminderDatas;
        public DailyPage()
        {
            InitializeComponent();
            reminderDatas = new List<ReminderData>()
            {
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(0,10,0,10),
                    TickVisibility = true
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(20,10,20,10),
                    TickVisibility = false
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(0,10,0,10),
                    TickVisibility = true
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(20,10,20,10),
                    TickVisibility = false
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(0,10,0,10),
                    TickVisibility = true
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(20,10,20,10),
                    TickVisibility = false
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(0,10,0,10),
                    TickVisibility = true
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(20,10,20,10),
                    TickVisibility = false
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(0,10,0,10),
                    TickVisibility = true
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(20,10,20,10),
                    TickVisibility = false
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(0,10,0,10),
                    TickVisibility = true
                },
                new ReminderData()
                {
                    Heading = "Meet Lawrance",
                    Time = "12 pm",
                    //Margin = new Thickness(20,10,20,10),
                    TickVisibility = false
                }
            };
            MainCollectionView.ItemsSource = reminderDatas;
            
        }

        private void DailyView_Clicked(object sender, EventArgs e)
        {
            BlueBack.TranslateTo(WhiteBox.Width / 2 - 30 , 0);
            DailyView.TextColor = Color.White;
            MonthView.TextColor = Color.Black;
        }

        private void MonthView_Clicked(object sender, EventArgs e)
        {
            BlueBack.TranslateTo(0, 0);
            DailyView.TextColor = Color.Black;
            MonthView.TextColor = Color.White;
        }
    }
}