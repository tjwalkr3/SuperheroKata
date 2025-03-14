using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroKata.Console;

public class Unit
{
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public bool Defeated => Health <= 0;

    public void Attack(Unit monster, bool crit = false)
    {
        if (monster == null)
        {
            throw new ArgumentNullException(nameof(monster));
        }
        if (crit)
        {
            monster.Health -= AttackPower * 2;
        }
        else
        {
            monster.Health -= AttackPower;
        }
    }
}
