﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Pickles.Example.Features._02TagsAndHooks
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Tag demonstrator")]
    public partial class TagDemonstratorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TagDemo.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tag demonstrator", "In order to show the capabilities of tags in SpecFlow\r\nAs a SpecFlow evanglist\r\nI" +
                    " want to write scenarios that has tags and show their usage in code", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ignored scenario")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void IgnoredScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ignored scenario", new string[] {
                        "ignore"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("that my scenario has the @ignore tag");
#line 9
 testRunner.When("I run the scenario");
#line 10
 testRunner.Then("the scenario is ignored");
#line 11
  testRunner.And("the missing step definitions are not reported");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario without tags")]
        public virtual void AScenarioWithoutTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario without tags", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("that my scenario has 0 tags");
#line 15
 testRunner.When("I run the scenario");
#line 16
 testRunner.Then("before scenario hook with \'\' is run");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario with 1 tag")]
        [NUnit.Framework.CategoryAttribute("testTag1")]
        public virtual void AScenarioWith1Tag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario with 1 tag", new string[] {
                        "testTag1"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("that my scenario has 1 tags");
#line 21
 testRunner.When("I run the scenario");
#line 22
 testRunner.Then("before scenario hook with \'testTag1\' is run");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario with 3 tags")]
        [NUnit.Framework.CategoryAttribute("testTag1")]
        [NUnit.Framework.CategoryAttribute("testTag2")]
        [NUnit.Framework.CategoryAttribute("testTag3")]
        public virtual void AScenarioWith3Tags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario with 3 tags", new string[] {
                        "testTag1",
                        "testTag2",
                        "testTag3"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given("that my scenario has 3 tags");
#line 27
 testRunner.When("I run the scenario");
#line 28
 testRunner.Then("before scenario hook with \'testTag1, testTag2, testTag3\' is run");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario with 2 tags")]
        [NUnit.Framework.CategoryAttribute("testTag1")]
        [NUnit.Framework.CategoryAttribute("testTag3")]
        public virtual void AScenarioWith2Tags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario with 2 tags", new string[] {
                        "testTag1",
                        "testTag3"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("that my scenario has 2 tags");
#line 33
 testRunner.When("I run the scenario");
#line 34
 testRunner.Then("before scenario hook with \'testTag1, testTag3\' is run");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
