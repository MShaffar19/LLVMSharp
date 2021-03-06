// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;
using LLVMSharp.Interop;

namespace LLVMSharp
{
    public sealed class Metadata : IEquatable<Metadata>
    {
        public LLVMMetadataRef Handle { get; }

        public static bool operator ==(Metadata left, Metadata right) => ReferenceEquals(left, right) || (left?.Handle == right?.Handle);

        public static bool operator !=(Metadata left, Metadata right) => !(left == right);

        public override bool Equals(object obj) => (obj is Metadata other) && Equals(other);

        public bool Equals(Metadata other) => this == other;

        public override int GetHashCode() => Handle.GetHashCode();

        public override string ToString() => Handle.ToString();
    }
}
