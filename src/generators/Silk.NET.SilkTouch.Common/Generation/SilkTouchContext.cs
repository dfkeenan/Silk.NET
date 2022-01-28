﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Configuration;

namespace Silk.NET.SilkTouch.Generation
{
    /// <summary>
    /// Represents a generator stage's view of a C# project.
    /// </summary>
    /// <param name="AssemblyName">The name of the assembly represented by the C# project.</param>
    /// <param name="Compilation">The Roslyn compilation, containing all C# compiler info (such as syntax trees)</param>
    /// <param name="Configuration">The project-specific configuration for this project.</param>
    /// <param name="GlobalConfiguration">
    /// The global/common configuration referenced by the <see cref="Configuration"/>'s
    /// <see cref="ProjectConfiguration.GlobalConfigFile"/>.</param>
    /// <param name="BaseDirectory">
    /// The "base directory", used as the root for all relative paths referenced elsewhere in the configuration. This is
    /// usually the same folder in which the C# project file (<c>csproj</c>) is contained.
    /// </param>
    public sealed record SilkTouchContext
    (
        string AssemblyName,
        Compilation Compilation,
        ProjectConfiguration Configuration,
        GlobalConfiguration? GlobalConfiguration,
        string BaseDirectory
    )
    {
        // Internal Properties
        internal List<(string FileNameHint, string Content)> Outputs { get; } = new();
        internal List<Diagnostic> Diagnostics { get; } = new();

        // Public Methods
        /// <summary>
        /// Registers generated output with the context to be added to the C# project, with a "file name hint" which may
        /// or may not be used by the form factor to identify this generated file.
        /// </summary>
        /// <param name="fileNameHint">The file name hint.</param>
        /// <param name="content">The generated file's content (i.e. C# code)</param>
        public void EmitOutput(string fileNameHint, string content)
            => Outputs.Add((fileNameHint, content));

        /// <summary>
        /// Raises a diagnostic with the context to be passed along to the user.
        /// </summary>
        /// <param name="diagnostic">The diagnostic to raise.</param>
        public void EmitDiagnostic(Diagnostic diagnostic) => Diagnostics.Add(diagnostic);

        /// <summary>
        /// Gets the outputs and diagnostics generated by the generator using this context.
        /// </summary>
        /// <returns>Outputs and diagnostics generated by the generator using this context.</returns>
        public (List<(string FileNameHint, string Content)> Outputs, List<Diagnostic>) GetResult()
            => (Outputs, Diagnostics);
    }
}