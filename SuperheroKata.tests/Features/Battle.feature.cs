﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SuperheroKata.Tests.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "tag1")]
    public partial class RPGBattleSystemFeature : object, Xunit.IClassFixture<RPGBattleSystemFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "tag1"};
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "RPG Battle System", "  As a \"hero\"\r\n  I want to battle a monster\r\n  So that I can test my strength", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Battle.feature"
#line hidden
        
        public RPGBattleSystemFeature(RPGBattleSystemFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
        {
            await this.TestInitializeAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
        {
            await this.TestTearDownAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Hero attacks \"monster\"")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "Hero attacks \"monster\"")]
        public async System.Threading.Tasks.Task HeroAttacksMonster()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Hero attacks \"monster\"", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 8
    await testRunner.GivenAsync("a \"hero\" with 100 health and 20 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 9
    await testRunner.AndAsync("a \"monster\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 10
    await testRunner.WhenAsync("the \"hero\" attacks the \"monster\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 11
    await testRunner.ThenAsync("the \"monster\" should have 30 health remaining", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Monster attacks \"hero\"")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "Monster attacks \"hero\"")]
        public async System.Threading.Tasks.Task MonsterAttacksHero()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Monster attacks \"hero\"", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 13
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 14
    await testRunner.GivenAsync("a \"hero\" with 100 health and 20 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 15
    await testRunner.AndAsync("a \"monster\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 16
    await testRunner.WhenAsync("the \"monster\" attacks the \"hero\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 17
    await testRunner.ThenAsync("the \"hero\" should have 90 health remaining", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Hero defeats \"monster\"")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "Hero defeats \"monster\"")]
        public async System.Threading.Tasks.Task HeroDefeatsMonster()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Hero defeats \"monster\"", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 20
    await testRunner.GivenAsync("a \"hero\" with 100 health and 50 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 21
    await testRunner.AndAsync("a \"monster\" with 40 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 22
    await testRunner.WhenAsync("the \"hero\" attacks the \"monster\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 23
    await testRunner.ThenAsync("the \"monster\" should be defeated", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Hero lands a critical hit")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "Hero lands a critical hit")]
        public async System.Threading.Tasks.Task HeroLandsACriticalHit()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Hero lands a critical hit", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 25
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 26
    await testRunner.GivenAsync("a \"hero\" with 100 health and 20 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 27
    await testRunner.AndAsync("a \"monster\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 28
    await testRunner.WhenAsync("the \"hero\" lands a critical hit on \"monster\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 29
    await testRunner.ThenAsync("the \"monster\" should have 10 health remaining", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="multiplayer battles")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "multiplayer battles")]
        public async System.Threading.Tasks.Task MultiplayerBattles()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("multiplayer battles", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 32
    await testRunner.GivenAsync("a \"hero\" with 50 health and 20 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 33
    await testRunner.AndAsync("a \"heroe\" with 50 health and 20 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 34
    await testRunner.AndAsync("a \"monster\" with 60 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 35
    await testRunner.WhenAsync("the \"hero\" attacks the \"monster\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 36
    await testRunner.AndAsync("the \"heroe\" lands a critical hit on \"monster\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 37
    await testRunner.ThenAsync("the \"monster\" should be defeated", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="special abilities")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "special abilities")]
        public async System.Threading.Tasks.Task SpecialAbilities()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("special abilities", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 40
    await testRunner.GivenAsync("a \"hero\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 41
    await testRunner.AndAsync("the \"hero\" has the special ability \"power word kill\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 42
    await testRunner.AndAsync("a \"monster\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 43
    await testRunner.WhenAsync("the \"hero\" uses their ability on the \"monster\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 44
    await testRunner.ThenAsync("the \"monster\" should be defeated", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="random attack")]
        [Xunit.TraitAttribute("FeatureTitle", "RPG Battle System")]
        [Xunit.TraitAttribute("Description", "random attack")]
        public async System.Threading.Tasks.Task RandomAttack()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("random attack", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 47
    await testRunner.GivenAsync("a \"hero\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 48
    await testRunner.AndAsync("a \"monster\" with 50 health and 10 attack power", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 49
    await testRunner.WhenAsync("the \"hero\" attacks the \"monster\" seed 10", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 50
    await testRunner.ThenAsync("the \"monster\" should have 31 health remaining", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : object, Xunit.IAsyncLifetime
        {
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
            {
                await RPGBattleSystemFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await RPGBattleSystemFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion
