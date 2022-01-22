namespace DOTNET_POO.src.Entities
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
        public override string Attack(){
            return this.Name + " Laçou magia";
        }

        public string Attack(int Bonus){

            if (Bonus > 6)
            {
                return this.Name + " Laçou Magia super efetiva com bonus de ataque de " + Bonus;
            }else {
                return this.Name + " Laçou uma Magia com força fraca com bonus de ataque de " + Bonus;
            }
        }
    }
}