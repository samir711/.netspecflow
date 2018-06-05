﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Platform.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BaseScenarios")]
    public partial class BaseScenariosFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BaseScenarios.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BaseScenarios", "\t These Scenarios can be used in any project", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Validate the title of website")]
        [NUnit.Framework.CategoryAttribute("Debug")]
        public virtual void ValidateTheTitleOfWebsite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate the title of website", new string[] {
                        "Debug"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I navigate to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.Then("I see the page title contains \"Wikipedia\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate the Url of the website")]
        [NUnit.Framework.CategoryAttribute("Debug")]
        public virtual void ValidateTheUrlOfTheWebsite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate the Url of the website", new string[] {
                        "Debug"});
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.Given("I navigate to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.Then("I see the page Url contains \"www.wikipedia.org\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate the PageSource string on the website")]
        [NUnit.Framework.CategoryAttribute("Debug")]
        public virtual void ValidateThePageSourceStringOnTheWebsite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate the PageSource string on the website", new string[] {
                        "Debug"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I navigate to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.Then("I see \"The Free Encyclopedia\" in the PageSource", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate existence of multiple texts in PageSource")]
        [NUnit.Framework.CategoryAttribute("Debug")]
        public virtual void ValidateExistenceOfMultipleTextsInPageSource()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate existence of multiple texts in PageSource", new string[] {
                        "Debug"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.Given("I navigate to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "expectedText"});
            table1.AddRow(new string[] {
                        "The Free Encylopedia"});
            table1.AddRow(new string[] {
                        "Deutsch"});
            table1.AddRow(new string[] {
                        "Русский"});
            table1.AddRow(new string[] {
                        "日本語"});
#line 24
 testRunner.Then("I see", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
