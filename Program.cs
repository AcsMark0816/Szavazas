namespace pp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Party> parties = new List<Party>();
            parties = FileManager.ReadFile("party.txt");
            foreach (Party p in parties)
            {
                Console.WriteLine(p);
            }

            while(true)
            {

                Vote(parties);
                Console.Clear();
            } 



        }

        static void Vote(List<Party> parties)
        {
            Console.WriteLine("melyik partott valasztod");
            string ans = Console.ReadLine();
            foreach (Party p in parties)
            {
                if (p.name == ans.Trim())
                {
                    Console.WriteLine($"{p.PLussz(1)}");
                }
            }
        }
    }
}
    
