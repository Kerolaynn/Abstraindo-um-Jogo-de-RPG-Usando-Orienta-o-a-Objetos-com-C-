namespace rpg.src.Entites
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack()
        {
            return this.Name + " Lançou shuriken";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return this.Name + " Lançou shuriken na cabeça com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou shuriken com pouca força bonus de " + Bonus;
            }
        }
    }
}