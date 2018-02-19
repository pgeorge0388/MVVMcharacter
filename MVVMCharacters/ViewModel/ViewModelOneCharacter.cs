using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using System.Windows.Input;
namespace MVVMCharacters
{
    public class ViewModelOneCharacter : ObjectBase
    {
        public ComicBookCharacter Model { get; private set; }
        //public ObservableCollection<ViewModelPowers> ModelPowers { get; private set; }
        public ObservableCollection<Powers> ModelPowers { get; private set; }

        public ViewModelOneCharacter(ComicBookCharacter _Model)
        {
            this.RemovePowerHighlighted = new RelayCommands(RemovePower);

            //ObservableCollection<Powers> ThePowers = new ObservableCollection<Powers>();
            //ThePowers.Add(new Powers { Power = "Flight", PowerDesc = "I Can Fly Baby!" });
            //ThePowers.Add(new Powers { Power = "X-Ray", PowerDesc = "I Can see Through walls!" });
            //ThePowers.Add(new Powers { Power = "Super Strength", PowerDesc = "I Can move shit easy!" });
            //ThePowers.Add(new Powers { Power = "Bullet Proof", PowerDesc = "I Can Die from being shot!" });
            //ModelPowers = ThePowers;
            //Model = new ComicBookCharacter { Name = "Clark Kent", HeroName = "Superman", MyPowers = ThePowers };
            Model = _Model;
            ModelPowers = Model.MyPowers;
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

        #endregion

        private void RemovePower()
        {
            string stuff = this.SelectedPower.Power;
        }
    }
}
