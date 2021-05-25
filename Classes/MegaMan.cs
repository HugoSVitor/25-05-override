namespace POOAula2505.Classes 
{
    public class MegaMan : Player
    {
        private string Buster;

        public override string Correr()
        {
            return "O Mega-Man correu em uma velocidade extraordinária!";
        }

        public override string Pular()
        {
            this.Buster = "Mega-Man utilizou buster para dar um baita pulo kk";
            return base.Pular();
        }
    }
}