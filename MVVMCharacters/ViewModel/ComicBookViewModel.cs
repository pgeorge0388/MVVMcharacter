using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
namespace MVVMCharacters
{
    public class ComicBookViewModel : ObjectBase
    {
        //public ObservableCollection<ComicBookCharacter> Model { get; private set; }
        //public ComicBookViewModel()
        //{
        //    this.RemovePowerHighlighted = new RelayCommands(RemovePower);
        //    CreateSomeSuperHeros oCreateMeSuperHeros = new CreateSomeSuperHeros();
        //    Model = oCreateMeSuperHeros.CreatingSomeHeros();
        //}
        //#region Public Commands

        //public RelayCommands RemovePowerHighlighted { get; set; }

        //#endregion

        //private void RemovePower()
        //{
        //    string stuff = "";
        //}
        public ObservableCollection<ViewModelOneCharacter> Models { get; private set; }
        public ComicBookViewModel()
        {
            this.RemovePowerHighlighted = new RelayCommands(RemovePower);
            CreateSomeSuperHeros oCreateMeSuperHeros = new CreateSomeSuperHeros();
            Models = oCreateMeSuperHeros.CreatingSomeHeros();
        }

        #region Public Commands

        public RelayCommands RemovePowerHighlighted { get; set; }

        #endregion

        private void RemovePower()
        {
            string stuff = "";
        }
    }
}
