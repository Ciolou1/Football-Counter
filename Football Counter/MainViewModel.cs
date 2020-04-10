using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Football_Counter
{
    public class MainViewModel : INotifyPropertyChanged // Interface enables data binding
    {
        public MainViewModel()
        {
            // Now the Increase command executes the 'ChiefsIncreaseCount' method
            ChiefsIncreaseCommand = new Command(ChiefsIncreaseCount); // Pass a function to be the command
            RavensIncreaseCommand = new Command(RavensIncreaseCount);
        }
        
        // Implementation of interface 
        public event PropertyChangedEventHandler PropertyChanged;
        // This is how we notify Xamarin that a properties value has changed
        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Variables
        int chiefsCount = 0;
        int ravensCount = 0;

        // Properties
        public int ChiefsCount
        {
            get { return chiefsCount; }
            set
            {
                chiefsCount = value;
                OnPropertyChanged(nameof(ChiefsCount));
            }
        }
        public int RavensCount
        {
            get { return ravensCount; }
            set
            {
                ravensCount = value;
                OnPropertyChanged(nameof(RavensCount));
            }
        }

        // Methods
        void ChiefsIncreaseCount()
        {
            ChiefsCount++;
            OnPropertyChanged(nameof(ChiefsCount));
        }
        void RavensIncreaseCount()
        {
            RavensCount++;
            OnPropertyChanged(nameof(RavensCount));
        }

        // Commands
        public ICommand ChiefsIncreaseCommand { get; }
        public ICommand RavensIncreaseCommand { get; }
    }
}
