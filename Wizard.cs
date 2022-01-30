namespace projeto_rpg.src.Entities
{
    public class Wizard : Hero
    {
         public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HeroType = HeroType;
        }


         public override string Attack(){
            return this.Name + "Lançou Magia";
         }

         public string Attack(int Bonus){

             if(Bonus > 6){
            return this.Name + " " + "Lançou Magia super efetiva com força de bonus" + " " + Bonus;
             }else{
                 return this.Name + " " + "Lançou uma magia com força fraca com bonus de" + " " + Bonus;
             }
         }
    }
}