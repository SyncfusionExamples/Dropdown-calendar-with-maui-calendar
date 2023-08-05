using Syncfusion.Maui.Calendar;
using Syncfusion.Maui.Popup;

namespace DropDownCalendar;

public partial class MainPage : ContentPage
{
    private const string SelectedDateFormat = "dd/MM/yyyy";
    public MainPage()
    {
        InitializeComponent();
        TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += OnTapGestureTapped;
        //// Add the tap gesture recognizer to the date label for showing the calendar drop-down.
        dateLabel.GestureRecognizers.Add(tapGestureRecognizer);
    }

    /// <summary>
    /// Triggered when the date label is tapped.
    /// </summary>
    /// <param name="sender">Date label instance value.</param>
    /// <param name="e">The event argument details.</param>
    private void OnTapGestureTapped(object sender, EventArgs e)
    {
        DropdownViewModel bindingContext = (DropdownViewModel)this.BindingContext;
        //// Update the calendar display date value based on current selected date value for showing selected date month.
        bindingContext.DisplayDate = bindingContext.SelectedDate;
        //// Need to show month view while opening the calendar drop-down.
        bindingContext.CurrentView = CalendarView.Month;
        popup.ShowRelativeToView(dateLabel, PopupRelativePosition.AlignBottom, 0, 3);
    }

    /// <summary>
    /// Triggered when the calendar selection changed and it used to update the selected date string value.
    /// </summary>
    /// <param name="sender">The calendar instance.</param>
    /// <param name="e">Selection related details.</param>
    private void OnCalendarSelectionChanged(object sender, CalendarSelectionChangedEventArgs e)
    {
       DropdownViewModel bindingContext = (DropdownViewModel)this.BindingContext;
       bindingContext.SelectedDateString = ((DateTime)e.NewValue).ToString(SelectedDateFormat);
        //// Close the calendar drop-down after selection.
        if (popup != null)
        {
            popup.IsOpen = false;
        }
    }
}