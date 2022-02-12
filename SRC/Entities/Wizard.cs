namespace JogoRPG.SRC.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
                    :base(Name, Level, HeroType)

        {
        
        }
        public override string Attack()
        {
            return this.Name + " " + "Lançou magia";
        }

        public string  Attack(int Bonus)
        {
            if(Bonus > 6){
                return this.Name + " Lançou Magia super efetiva com bonus de ataque de " + Bonus;

            }else{
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
            
        }


    }
}