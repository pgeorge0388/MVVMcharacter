using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace MVVMCharacters
{
    public class CreateSomeSuperHeros
    {
        //public ObservableCollection<ComicBookCharacter> CreatingSomeHeros()
        //{
        //    ObservableCollection<ComicBookCharacter> SomeHeros = new ObservableCollection<ComicBookCharacter>();
        //    ObservableCollection<Powers> ThePowers = new ObservableCollection<Powers>();
            
        //    ThePowers.Add(new Powers{Power = "Flight", PowerDesc = "I Can Fly Baby!"});
        //    ThePowers.Add(new Powers{Power = "X-Ray", PowerDesc = "I Can see Through walls!"});
        //    ThePowers.Add(new Powers{Power = "Super Strength", PowerDesc = "I Can move shit easy!"});
        //    ThePowers.Add(new Powers{Power = "Bullet Proof", PowerDesc = "I Can Die from being shot!"});
        //    SomeHeros.Add(new ComicBookCharacter { Name = "Clark Kent", HeroName = "Superman", MyPowers = ThePowers });

        //    ThePowers = new ObservableCollection<Powers>();
        //    ThePowers.Add(new Powers { Power = "Shoot Webs", PowerDesc = "I Can make webs!" });
        //    ThePowers.Add(new Powers { Power = "Spider Sense", PowerDesc = "I Can sense danger!" });
        //    SomeHeros.Add(new ComicBookCharacter { Name = "Peter Parker", HeroName = "Spider Man", MyPowers = ThePowers });

        //    ThePowers = new ObservableCollection<Powers>();
        //    ThePowers.Add(new Powers { Power = "Muscles For Days", PowerDesc = "I look awesome!" });
        //    ThePowers.Add(new Powers { Power = "Don't age", PowerDesc = "I never grow past 20 so I can't drink!" });
        //    SomeHeros.Add(new ComicBookCharacter { Name = "Steve Rogers", HeroName = "Captain America", MyPowers = ThePowers });

        //    return SomeHeros;
        //}
        public ObservableCollection<ViewModelOneCharacter> CreatingSomeHeros()
        {
            ObservableCollection<ViewModelOneCharacter> SomeHeros = new ObservableCollection<ViewModelOneCharacter>();
            ObservableCollection<Powers> ThePowers = new ObservableCollection<Powers>();

            ThePowers.Add(new Powers { Power = "Flight", PowerDesc = "I Can Fly Baby!" });
            ThePowers.Add(new Powers { Power = "X-Ray", PowerDesc = "I Can see Through walls!" });
            ThePowers.Add(new Powers { Power = "Super Strength", PowerDesc = "I Can move shit easy!" });
            ThePowers.Add(new Powers { Power = "Bullet Proof", PowerDesc = "I Can Die from being shot!" });
            SomeHeros.Add(new ViewModelOneCharacter(new ComicBookCharacter { Name = "Clark Kent", HeroName = "Superman", MyPowers = ThePowers}));

            ThePowers = new ObservableCollection<Powers>();
            ThePowers.Add(new Powers { Power = "Shoot Webs", PowerDesc = "I Can make webs!" });
            ThePowers.Add(new Powers { Power = "Spider Sense", PowerDesc = "I Can sense danger!" });
            SomeHeros.Add(new ViewModelOneCharacter(new ComicBookCharacter { Name = "Peter Parker", HeroName = "Spider Man", MyPowers = ThePowers }));

            ThePowers = new ObservableCollection<Powers>();
            ThePowers.Add(new Powers { Power = "Muscles For Days", PowerDesc = "I look awesome!" });
            ThePowers.Add(new Powers { Power = "Don't age", PowerDesc = "I never grow past 20 so I can't drink!" });
            SomeHeros.Add(new ViewModelOneCharacter(new ComicBookCharacter { Name = "Steve Rogers", HeroName = "Captain America", MyPowers = ThePowers }));

            return SomeHeros;
        }
    }
}
