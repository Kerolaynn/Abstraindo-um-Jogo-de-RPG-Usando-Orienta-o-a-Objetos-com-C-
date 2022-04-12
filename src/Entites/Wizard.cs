namespace rpg.src.Entites
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia com foça fraca com bonus de " + Bonus;
            }
        }
    }
}