#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScheduleShort : global::System.IEquatable<ScheduleShort>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleBase? ScheduleBase { get; init; }
#else
        public global::Apify.ScheduleBase? ScheduleBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScheduleBase))]
#endif
        public bool IsScheduleBase => ScheduleBase != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScheduleBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ScheduleBase? value)
        {
            value = ScheduleBase;
            return IsScheduleBase;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleShortVariant2? ScheduleShortVariant2 { get; init; }
#else
        public global::Apify.ScheduleShortVariant2? ScheduleShortVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScheduleShortVariant2))]
#endif
        public bool IsScheduleShortVariant2 => ScheduleShortVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScheduleShortVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ScheduleShortVariant2? value)
        {
            value = ScheduleShortVariant2;
            return IsScheduleShortVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleShort(global::Apify.ScheduleBase value) => new ScheduleShort((global::Apify.ScheduleBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleBase?(ScheduleShort @this) => @this.ScheduleBase;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleShort(global::Apify.ScheduleBase? value)
        {
            ScheduleBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScheduleShort FromScheduleBase(global::Apify.ScheduleBase? value) => new ScheduleShort(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScheduleShort(global::Apify.ScheduleShortVariant2 value) => new ScheduleShort((global::Apify.ScheduleShortVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleShortVariant2?(ScheduleShort @this) => @this.ScheduleShortVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ScheduleShort(global::Apify.ScheduleShortVariant2? value)
        {
            ScheduleShortVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ScheduleShort FromScheduleShortVariant2(global::Apify.ScheduleShortVariant2? value) => new ScheduleShort(value);

        /// <summary>
        /// 
        /// </summary>
        public ScheduleShort(
            global::Apify.ScheduleBase? scheduleBase,
            global::Apify.ScheduleShortVariant2? scheduleShortVariant2
            )
        {
            ScheduleBase = scheduleBase;
            ScheduleShortVariant2 = scheduleShortVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScheduleShortVariant2 as object ??
            ScheduleBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScheduleBase?.ToString() ??
            ScheduleShortVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScheduleBase && IsScheduleShortVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ScheduleBase, TResult>? scheduleBase = null,
            global::System.Func<global::Apify.ScheduleShortVariant2, TResult>? scheduleShortVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScheduleBase && scheduleBase != null)
            {
                return scheduleBase(ScheduleBase!);
            }
            else if (IsScheduleShortVariant2 && scheduleShortVariant2 != null)
            {
                return scheduleShortVariant2(ScheduleShortVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleBase>? scheduleBase = null,

            global::System.Action<global::Apify.ScheduleShortVariant2>? scheduleShortVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScheduleBase)
            {
                scheduleBase?.Invoke(ScheduleBase!);
            }
            else if (IsScheduleShortVariant2)
            {
                scheduleShortVariant2?.Invoke(ScheduleShortVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ScheduleBase>? scheduleBase = null,
            global::System.Action<global::Apify.ScheduleShortVariant2>? scheduleShortVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScheduleBase)
            {
                scheduleBase?.Invoke(ScheduleBase!);
            }
            else if (IsScheduleShortVariant2)
            {
                scheduleShortVariant2?.Invoke(ScheduleShortVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScheduleBase,
                typeof(global::Apify.ScheduleBase),
                ScheduleShortVariant2,
                typeof(global::Apify.ScheduleShortVariant2),
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
        public bool Equals(ScheduleShort other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleBase?>.Default.Equals(ScheduleBase, other.ScheduleBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleShortVariant2?>.Default.Equals(ScheduleShortVariant2, other.ScheduleShortVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScheduleShort obj1, ScheduleShort obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleShort>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScheduleShort obj1, ScheduleShort obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleShort o && Equals(o);
        }
    }
}
