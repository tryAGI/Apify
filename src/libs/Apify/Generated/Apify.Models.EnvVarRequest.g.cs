#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EnvVarRequest : global::System.IEquatable<EnvVarRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.EnvVar? EnvVar { get; init; }
#else
        public global::Apify.EnvVar? EnvVar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvVar))]
#endif
        public bool IsEnvVar => EnvVar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? EnvVarRequestVariant2 { get; init; }
#else
        public object? EnvVarRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvVarRequestVariant2))]
#endif
        public bool IsEnvVarRequestVariant2 => EnvVarRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvVarRequest(global::Apify.EnvVar value) => new EnvVarRequest((global::Apify.EnvVar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.EnvVar?(EnvVarRequest @this) => @this.EnvVar;

        /// <summary>
        /// 
        /// </summary>
        public EnvVarRequest(global::Apify.EnvVar? value)
        {
            EnvVar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EnvVarRequest(
            global::Apify.EnvVar? envVar,
            object? envVarRequestVariant2
            )
        {
            EnvVar = envVar;
            EnvVarRequestVariant2 = envVarRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EnvVarRequestVariant2 as object ??
            EnvVar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EnvVar?.ToString() ??
            EnvVarRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnvVar && IsEnvVarRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.EnvVar?, TResult>? envVar = null,
            global::System.Func<object?, TResult>? envVarRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvVar && envVar != null)
            {
                return envVar(EnvVar!);
            }
            else if (IsEnvVarRequestVariant2 && envVarRequestVariant2 != null)
            {
                return envVarRequestVariant2(EnvVarRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.EnvVar?>? envVar = null,
            global::System.Action<object?>? envVarRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvVar)
            {
                envVar?.Invoke(EnvVar!);
            }
            else if (IsEnvVarRequestVariant2)
            {
                envVarRequestVariant2?.Invoke(EnvVarRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EnvVar,
                typeof(global::Apify.EnvVar),
                EnvVarRequestVariant2,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EnvVarRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.EnvVar?>.Default.Equals(EnvVar, other.EnvVar) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(EnvVarRequestVariant2, other.EnvVarRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EnvVarRequest obj1, EnvVarRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvVarRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EnvVarRequest obj1, EnvVarRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvVarRequest o && Equals(o);
        }
    }
}
