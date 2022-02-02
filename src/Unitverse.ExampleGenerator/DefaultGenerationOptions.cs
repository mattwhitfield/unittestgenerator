﻿namespace Unitverse.ExampleGenerator
{
    using Unitverse.Core.Options;

    public class DefaultGenerationOptions : IGenerationOptions
    {
        public TestFrameworkTypes FrameworkType => TestFrameworkTypes.XUnit;

        public MockingFrameworkType MockingFrameworkType => MockingFrameworkType.NSubstitute;

        public bool UseFluentAssertions => true;

        public bool AutoDetectFrameworkTypes => false;

        public bool AllowGenerationWithoutTargetProject => false;

        public string TestProjectNaming => "{0}.Tests";

        public string TestFileNaming => "{0}Tests";

        public string TestTypeNaming => "{0}Tests";

        public bool EmitUsingsOutsideNamespace => false;

        public bool PartialGenerationAllowed => false;

        public bool EmitTestsForInternals => false;

        public bool AutomaticallyConfigureMocks => true;

        public bool EmitSubclassForProtectedMethods => true;
    }
}