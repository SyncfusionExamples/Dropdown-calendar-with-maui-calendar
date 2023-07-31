using Syncfusion.Maui.Calendar;
using System.ComponentModel;

namespace DropDownCalendar
{
    /// <summary>
    /// View model class for the calendar drop-down used to handle the selected date value and calendar view configuration on opening the drop-down.
    /// </summary>
    public class DropdownViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Holds the selected date string value.
        /// </summary>
        private string selectedDateString = DateTime.Now.ToString("dd/MM/yyyy");

        /// <summary>
        /// Gets or sets the selected date string value.
        /// </summary>
        public string SelectedDateString
        {
            get
            {
                return selectedDateString;
            }
            set
            {
                selectedDateString = value;
                OnPropertyChanged("SelectedDateString");
            }
        }

        /// <summary>
        /// Holds the calendar display date value.
        /// </summary>
        private DateTime selectedDate = DateTime.Now;

        /// <summary>
        /// Gets or sets the calendar display date value.
        /// </summary>
        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                selectedDate = value;
                OnPropertyChanged("SelectedDate");
            }
        }

        /// <summary>
        /// Holds the current calendar view value.
        /// </summary>
        private CalendarView currentView = CalendarView.Month;

        /// <summary>
        /// Gets or sets the current calendar view value.
        /// </summary>
        public CalendarView CurrentView
        {
            get
            {
                return currentView;
            }
            set
            {
                currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
