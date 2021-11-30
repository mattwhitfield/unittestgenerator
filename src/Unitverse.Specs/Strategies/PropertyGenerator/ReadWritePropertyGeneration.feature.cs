﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Unitverse.Specs.Strategies.PropertyGenerator
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ReadWritePropertyGeneration")]
    public partial class ReadWritePropertyGenerationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ReadWritePropertyGeneration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Strategies/PropertyGenerator", "ReadWritePropertyGeneration", "\tI am checking the Read Write Property Generation strategy", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        public virtual void TestTearDown()
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
        [NUnit.Framework.DescriptionAttribute("Read Write Property Generation")]
        public virtual void ReadWritePropertyGeneration()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Read Write Property Generation", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("I have a class defined as", @"using System.IO;
using System.Windows;

namespace TestNamespace {


public abstract class TestClass
{
	protected TestClass(int intProperty, string value, Stream targetStream)
	{

	}

	public abstract int SomeMethod();

	public abstract void SomeVoidMethod();

	protected abstract void SomeProtectedAbstractMethod();

	public int IntProperty { get; set; }

	protected int IntGetOnlyProperty { get; private set; }

	protected string Value { get; set; }

	protected string Value2 { get; private set; }

	protected string Value3 { private get; set; }

	protected abstract string AbstractValue { get; set; }

	protected abstract string AbstractValue2 { get; }

	protected abstract string AbstractValue3 { set; }

	protected Stream TargetStream { get; }

	protected string SomeMethod(int i, int j) { return string.Empty; }

	protected abstract string SomeAbstractMethod(int i, int j);

	public abstract string SomePublicAbstractMethod(int p, int r);

	protected void SomeMethodVoid(int s, int t) {  }

	protected internal void SomeMethodVoid2(int s, int t) {  }

	protected internal abstract void SomeMethodVoid3(int s, int t);

	private protected abstract void SomeMethodVoid4(int s, int t);
}
}", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 61
 testRunner.And("I set my test framework to \'NUnit3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("I set my mock framework to \'FakeItEasy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.When("I generate tests for the property using the strategy \'ReadWritePropertyGeneration" +
                        "Strategy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("I expect a method called \'CanSetAndGetIntProperty\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
  testRunner.And("I expect it to contain the statement \'_testClass.IntProperty = testValue;\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
  testRunner.And("I expect it to contain the statement \'Assert.That(_testClass.IntProperty, Is.Equa" +
                        "lTo(testValue));\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
  testRunner.And("I expect it to contain a statement like \'var testValue = {{{AnyInteger}}};\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("I expect a method called \'CanSetAndGetAbstractValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
  testRunner.And("I expect it to contain the variable \'testValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
  testRunner.And("I expect it to contain the statement \'_testClass.AbstractValue = testValue;\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
  testRunner.And("I expect it to contain the statement \'Assert.That(_testClass.AbstractValue, Is.Eq" +
                        "ualTo(testValue));\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("I expect a method called \'CanSetAndGetValue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
  testRunner.And("I expect it to have the attribute \'Test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
  testRunner.And("I expect it to contain a statement like \'var testValue = {{{AnyString}}};\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("I expect no method with a name like \'.*IntGetOnlyProperty.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("I expect no method with a name like \'.*AbstractValue2.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("I expect no method with a name like \'.*AbstractValue3.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And("I expect no method with a name like \'.*Value2.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("I expect no method with a name like \'.*Value3.*\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion