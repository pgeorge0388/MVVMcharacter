using System.Collections.ObjectModel;
using System.ComponentModel;
namespace MVVMCharacters
{
    public class ComicBookCharacter : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        internal void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }

        //private string _HeroName;
        //private ObservableCollection<string> _Enemies;
        //private ObservableCollection<Powers> _MyPowers;

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set 
            {
                if (_Name == value)
                    return;
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _HeroName;
        public string HeroName
        {
            get { return _HeroName; }
            set 
            {
                if (_HeroName == value)
                    return;
                _HeroName = value;
                OnPropertyChanged("HeroName");
            }
        }

        //private ObservableCollection<string> _Enemies;
        //public ObservableCollection<string> Enemies
        //{
        //    get { return _Enemies; }
        //    set 
        //    {
        //        if (_Enemies == value)
        //            return;
        //        _Enemies = value;
        //        OnPropertyChanged("Enemies");
        //    }
        //}

        private ObservableCollection<Powers> _MyPowers;
        public ObservableCollection<Powers> MyPowers
        {
            get { return _MyPowers; }
            set 
            {
                if (_MyPowers == value)
                    return;
                _MyPowers = value;
                OnPropertyChanged("MyPowers");
            }
        }
        
    }
}
