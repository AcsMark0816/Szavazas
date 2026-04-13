using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    public class Party
    {
       public string name {  get; private set; }
       public int votes { get; private set; }
        public string pres { get; private set; }
       
        public Party(string name, int votes, string pres)
        {
            this.name = name;
            this.votes = votes;
            this.pres = pres;
        }
        public Party(string[] data)
        {
            name = data[0];
            votes = int.Parse(data[1]);
            pres = data[2];
        }
        public Party() { }
        public override string ToString()
        {
            return $"{name} {votes} {pres}";
        }
        public int PLussz(int plussz)
        {
            if(votes < 0)
            {
                return votes;
            }
            votes += plussz;
            return votes;
        }
        
            

    }
}
