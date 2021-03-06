﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.3.0
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bowling.SpecFlow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.3.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ボウリングスコア計算Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScoreCalculation.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ja-JP"), "ボウリングスコア計算", "トータススコアを計算するシステムがほしい", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ボウリングスコア計算")))
            {
                Bowling.SpecFlow.ボウリングスコア計算Feature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("ガーター")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ボウリングスコア計算")]
        public virtual void ガーター()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ガーター", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
  testRunner.Given("新しいゲームを始める", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "前提");
#line 6
  testRunner.When("すべてガーター", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "もし");
#line 7
  testRunner.Then("次のスコアになります:0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "ならば");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("初心者")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ボウリングスコア計算")]
        public virtual void 初心者()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("初心者", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
  testRunner.Given("新しいゲームを始める", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "前提");
#line 11
  testRunner.When("一投目2本、二投目7本倒した", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "もし");
#line 12
  testRunner.And("一投目3本、二投目4本倒した", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "かつ");
#line 13
  testRunner.And("8フレームすべてで、一投目1本、二投目1本倒した", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "かつ");
#line 14
  testRunner.Then("次のスコアになります:32", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "ならば");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("違う初心者")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ボウリングスコア計算")]
        public virtual void 違う初心者()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("違う初心者", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
  testRunner.Given("新しいゲームを始める", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "前提");
#line 18
  testRunner.When("次のピンを倒した:\t2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "もし");
#line 19
  testRunner.Then("次のスコアになります:40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "ならば");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("すべてストライク")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ボウリングスコア計算")]
        public virtual void すべてストライク()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("すべてストライク", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
  testRunner.Given("新しいゲームを始める", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "前提");
#line 23
  testRunner.When("すべてストライク", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "もし");
#line 24
  testRunner.Then("次のスコアになります:300", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "ならば");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("最初だけスペア")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ボウリングスコア計算")]
        public virtual void 最初だけスペア()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("最初だけスペア", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
   testRunner.Given("新しいゲームを始める", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "前提");
#line 28
   testRunner.When("次のピンを倒した: 2,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "もし");
#line 29
   testRunner.Then("次のスコアになります:29", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "ならば");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("すべてスペア")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ボウリングスコア計算")]
        public virtual void すべてスペア()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("すべてスペア", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
  testRunner.Given("新しいゲームを始める", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "前提");
#line 33
  testRunner.When("10フレームすべてで、一投目1本、二投目9本倒した", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "もし");
#line 34
  testRunner.And("1本倒した", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "かつ");
#line 35
  testRunner.Then("次のスコアになります:110", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "ならば");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
