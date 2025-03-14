using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroKata.Console;

public class SuperMegaAwesomeCalculator
{
    public List<int> Numbers { get; set; } = new();
    public int Add()
    {
        if (Numbers.Count > 0)
        {
            return Numbers.Sum();
        }
        else
        {
            return 0;
        }
    }
}
