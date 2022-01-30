namespace projeto_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " " + "Atacou com sua espada";
         }

    }   
}