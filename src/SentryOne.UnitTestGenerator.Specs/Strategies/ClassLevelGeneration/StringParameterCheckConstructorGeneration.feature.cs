// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SentryOne.UnitTestGenerator.Specs.Strategies.ClassLevelGeneration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("StringParameterCheckConstructorGeneration")]
    public partial class StringParameterCheckConstructorGenerationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StringParameterCheckConstructorGeneration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StringParameterCheckConstructorGeneration", "\tI am checking the String Parameter Check Constructor Generation strategy", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("String Parameter Check Constructor Generation")]
        public virtual void StringParameterCheckConstructorGeneration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("String Parameter Check Constructor Generation", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 6
 testRunner.Given("I have a class defined as", @"public class TestClass
{
   public TestClass(string stringProp, ITest iTest)
   {

   }

   public TestClass(int? nullableIntProp, ITest iTest)
   {

   }

   public TestClass(int thisIsAProperty, ITest iTest)
   {

   }

   public void ThisIsAMethod(string methodName, int methodValue)
   {
    System.Console.WriteLine(""Testing this"");
   }

   public string WillReturnAString()
   {
       return ""Hello"";
   }

   private string _thisIsAString = string.Empty;
   public string ThisIsAWriteOnlyString { set { _thisIsAString = value; }}

   public int ThisIsAProperty { get;set;}

   public ITest GetITest { get; }

   public TestClass ThisClass {get;set;}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And("I set my test framework to \'MS Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("I set my mock framework to \'NSubstitute\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("I generate unit tests for the class using strategy \'StringParameterCheckConstruct" +
                    "orGenerationStrategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("I expect a method called \'CannotConstructWithInvalidStringProp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
  testRunner.And("I expect it to have the attribute \'DataTestMethod\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.And("I expect it to have the attribute \'DataRow(null)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("I expect it to have the attribute \'DataRow(\"\")\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
  testRunner.And("I expect it to have the attribute \'DataRow(\"   \")\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
  testRunner.And("I expect it to contain the statement \'Assert.ThrowsException<ArgumentNullExceptio" +
                    "n>(() => newTestClass(value, default(ITest)));\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion