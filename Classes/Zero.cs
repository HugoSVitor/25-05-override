namespace POOAula2505.Classes
{
    public class Zero : Player
    {
        private string Sword;

        public override string Pular()
        {
            return "O Zero pulou de maneira magnifica!";
        }

        public override string Correr()
        {
            this.Sword = "Espada maneira!";
            
            return base.Correr();
        }
    }
}