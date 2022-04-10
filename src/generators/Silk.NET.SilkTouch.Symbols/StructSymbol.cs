﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeSymbol"/> representing a <c>struct</c>.
/// </summary>
/// <remarks>
/// In this context, a Struct means a type that represents the layout of a continuous block of memory.
/// </remarks>
// /// Each meaningful place in this memory called a field (see <see cref="FieldSymbol"/>) is accessible via this type.
// /// Fields are allowed to overlap.
// /// Additionally it may contain one or multiple <see cref="MethodSymbol"/> that are called with an instance of this type as their first argument.
public sealed class StructSymbol : TypeSymbol
{
    /// <summary>
    /// Creates a struct symbol given it's identifier
    /// </summary>
    /// <param name="identifier">The identifier of the struct</param>
    public StructSymbol(IdentifierSymbol identifier)
    {
        Identifier = identifier;
    }
        
    /// <summary>
    /// The identifier of this struct
    /// </summary>
    public override IdentifierSymbol Identifier { get; }
}