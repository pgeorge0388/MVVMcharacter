using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCharacters
{
    public class ViewModelPowers
    {
        public Powers Model { get; set; }
        public ViewModelPowers(Powers _Model)
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
        }

        #region Public Commands

        public RelayCommands RemovePowerHighlighted { get; set; }

        #endregion

        private void RemovePower()
        {
            
        }
    }
}
