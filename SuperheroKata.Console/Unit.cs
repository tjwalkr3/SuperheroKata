using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroKata.Console;

public class Unit
{
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public bool Defeated => Health <= 0;
    private Ability unitAbility;

    public void Attack(Unit monster, bool crit = false, int? seed = null)
    {
        var mult = 1.0;
        if (seed!=null)
            mult = GetMultiplier((int)seed);
        if (monster == null)
        {
            throw new ArgumentNullException(nameof(monster));
        }
        if (crit)
        {
            monster.Health -= (int)(AttackPower * 2 * mult);
        }
        else
        {
            monster.Health -= (int)(AttackPower*mult);
        }
    }

    public void AddAbility(string ability)
    {
        switch(ability)
        {
            case "power word kill":
                unitAbility = Ability.PowerWordKill;
                break;
        }
    }

    public void UseAbility(Unit target)
    {
        switch (unitAbility)
        {
            case Ability.PowerWordKill:
                target.Health = 0;
                break;
        }
    }

    public double GetMultiplier(int seed)
    {
        Random rand = new(seed);
        return rand.NextDouble()*2;
    }
}

public enum Ability { PowerWordKill }