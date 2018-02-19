using System.Collections.ObjectModel;
using System.ComponentModel;
namespace MVVMCharacters
{
    public class Powers : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        public Powers()
        {
            this.RemovePowerHighlighted = new RelayCommands(RemovePower);
        }
        private string _Power;
        private string _PowerDesc;

        public string Power
        {
            get
            {
                return _Power;
            }
            set
            {
                if (_Power == value)
                    return;
                _Power = value;
                OnPropertyChanged("Power");
            }
        }
        public string PowerDesc
        {
            get
            {
                return _PowerDesc;
            }
            set
            {
                if (_PowerDesc == value)
                    return;
                _PowerDesc = value;
                OnPropertyChanged("PowerDesc");
            }
        }

        private Powers _SelectedPower;
        public Powers SelectedPower
        {
            get { return _SelectedPower; }
            set
            {
                if (_SelectedPower == value)
                    return;
                _SelectedPower = value;
                OnPropertyChanged("SelectedPower");
            }
        }

        #region Public Commands

        public RelayCommands RemovePowerHighlighted { get; set; }

        private void RemovePower()
        {
            string stuff = this.SelectedPower.Power;
        }
        #endregion

        
    }
}
