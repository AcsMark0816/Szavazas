using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    public class FileManager
    {
        public static List<Party> ReadFile(string path)
        {
            try
            {
               List<Party> parties = new List<Party>();
                foreach(string line in File.ReadAllLines(path,Encoding.UTF8).Skip(1))
                {
                    string[] temp = line.Split(';');
                    if(temp.Length == 3)
                    {
                        parties.Add(new Party(temp));
                    }
                }
                return parties;
            } 
            catch(Exception error) 
            {
                Console.WriteLine(error.Message);
                return null;
            }
          
        }
    }
}
