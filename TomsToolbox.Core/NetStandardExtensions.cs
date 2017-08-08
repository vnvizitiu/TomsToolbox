﻿namespace TomsToolbox.Core
{
#if !NETSTANDARD1_0
    // ReSharper disable All
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;
    using System.Reflection;

    /// <summary>
    /// Some emulations of .NetStandard methods
    /// </summary>
    public static class NetStandardExtensions
    {
        /// <summary>
        /// Gets the method information from a delegate.
        /// </summary>
        /// <param name="delegate">The delegate.</param>
        /// <returns>The <see cref="MethodInfo"/></returns>
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "CA seems to be wrong about this!")]
        [Pure]
        public static MethodInfo GetMethodInfo(this Delegate @delegate)
        {
            Contract.Requires(@delegate != null);
            Contract.Ensures(Contract.Result<MethodInfo>() != null);

            // ReSharper disable once AssignNullToNotNullAttribute
            return @delegate.Method;
        }

        /// <summary>
        /// Gets the type information for a type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The specified type.</returns>
        [System.Diagnostics.Contracts.Pure]
        public static Type GetTypeInfo(this Type type)
        {
            Contract.Requires(type != null);
            Contract.Ensures(Contract.Result<Type>() != null);

            return type;
        }
    }
#endif
}