using System;
using System.Runtime.CompilerServices;
using Reqnroll;
using Shouldly;
using SuperheroKata.Console;

namespace SuperheroKata.Tests.StepDefinitions
{
    [Binding]
    public class RPGBattleSystemStepDefinitions(ScenarioContext context)
    {
        [Given("a {string} with {int} health and {int} attack power")]
        public void GivenAHeroWithHealthAndAttackPower(string key, int health, int attackPower)
        {
            Unit newHero = new()
            {
                Health = health,
                AttackPower = attackPower
            };

            context.Set(newHero, key);
        }

        [When("the {string} attacks the {string}")]
        public void WhenTheHeroAttacksTheMonster(string key1, string key2)
        {
            var hero = context.Get<Unit>(key1);
            var monster = context.Get<Unit>(key2);
            if (hero == null || monster == null)
            {
                throw new ArgumentNullException("Hero or Monster is not set in the context.");
            }
            hero.Attack(monster);
        }

        [Then("the {string} should have {int} health remaining")]
        public void ThenTheMonsterShouldHaveHealthRemaining(string key1, int health)
        {
            var monster = context.Get<Unit>(key1);
            monster.Health.ShouldBe(health);
        }

        [Then("the {string} should be defeated")]
        public void ThenTheMonsterShouldBeDefeated(string key1)
        {
            var monster = context.Get<Unit>(key1);
            monster.Defeated.ShouldBe(true);
        }

        [When("the {string} lands a critical hit on {string}")]
        public void WhenTheHeroLandsACriticalHit(string key1, string key2)
        {
            var hero = context.Get<Unit>(key1);
            var monster = context.Get<Unit>(key2);

            hero.Attack(monster, true);
        }

        [Given("the {string} has the special ability {string}")]
        public void GivenATheHasTheSpecialAbilityPowerWordKill(string key1, string ability)
        {
            var hero = context.Get<Unit>(key1);
            hero.AddAbility(ability);
        }

        [When("the {string} uses their ability on the {string}")]
        public void WhenTheHeroUsesTheirAbility(string key1, string key2)
        {
            var hero = context.Get<Unit>(key1);
            var monster = context.Get<Unit>(key2);
            hero.UseAbility(monster);
        }

        [When("the {string} attacks the {string} seed {int}")]
        public void WhenTheAttacksTheSeed(string key1, string key2, int seed)
        {
            var hero = context.Get<Unit>(key1);
            var monster = context.Get<Unit>(key2);
            hero.Attack(monster, false, seed);
        }

    }
}
