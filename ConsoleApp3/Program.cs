namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente nuovoUtente = new ContoCorrente("Antonio", "Marucci", 0, true);
            nuovoUtente.StartMenu();

            //ContoCorrente secondoUtente = new ContoCorrente();
            //secondoUtente.StartMenu();

        }
    }
}
