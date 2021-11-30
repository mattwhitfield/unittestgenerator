﻿namespace Unitverse.Core.Options
{
    public interface IUnitTestGeneratorOptions
    {
        IGenerationOptions GenerationOptions { get; }

        INamingOptions NamingOptions { get; }
    }
}