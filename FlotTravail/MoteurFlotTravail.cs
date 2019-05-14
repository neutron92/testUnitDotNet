namespace FlotTravail
{
    public class MoteurFlotTravail
    {
        public MoteurFlotTravail()
        {
        }
        public void Executer(FlotTravail flotTravail)
        {
            foreach (var etape in flotTravail.Etapes)
            {
                etape.Executer();
            }
        }
    }
}