// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public sealed class ReferenceEqualityComparer<TElement> : IEqualityComparer<TElement>
    {
        private ReferenceEqualityComparer()
        {
        }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public static ReferenceEqualityComparer<TElement> Instance { get; } = new ReferenceEqualityComparer<TElement>();

        bool IEqualityComparer<TElement>.Equals(TElement x, TElement y) => ReferenceEquals(x, y);

        int IEqualityComparer<TElement>.GetHashCode(TElement obj) => RuntimeHelpers.GetHashCode(obj);
    }
}
