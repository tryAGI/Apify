#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Schedule : global::System.IEquatable<Schedule>
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
        public global::Apify.ScheduleVariant2? ScheduleVariant2 { get; init; }
#else
        public global::Apify.ScheduleVariant2? ScheduleVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScheduleVariant2))]
#endif
        public bool IsScheduleVariant2 => ScheduleVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickScheduleVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ScheduleVariant2? value)
        {
            value = ScheduleVariant2;
            return IsScheduleVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Schedule(global::Apify.ScheduleBase value) => new Schedule((global::Apify.ScheduleBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleBase?(Schedule @this) => @this.ScheduleBase;

        /// <summary>
        /// 
        /// </summary>
        public Schedule(global::Apify.ScheduleBase? value)
        {
            ScheduleBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Schedule FromScheduleBase(global::Apify.ScheduleBase? value) => new Schedule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Schedule(global::Apify.ScheduleVariant2 value) => new Schedule((global::Apify.ScheduleVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleVariant2?(Schedule @this) => @this.ScheduleVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Schedule(global::Apify.ScheduleVariant2? value)
        {
            ScheduleVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Schedule FromScheduleVariant2(global::Apify.ScheduleVariant2? value) => new Schedule(value);

        /// <summary>
        /// 
        /// </summary>
        public Schedule(
            global::Apify.ScheduleBase? scheduleBase,
            global::Apify.ScheduleVariant2? scheduleVariant2
            )
        {
            ScheduleBase = scheduleBase;
            ScheduleVariant2 = scheduleVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScheduleVariant2 as object ??
            ScheduleBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScheduleBase?.ToString() ??
            ScheduleVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScheduleBase && IsScheduleVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ScheduleBase, TResult>? scheduleBase = null,
            global::System.Func<global::Apify.ScheduleVariant2, TResult>? scheduleVariant2 = null,
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
            else if (IsScheduleVariant2 && scheduleVariant2 != null)
            {
                return scheduleVariant2(ScheduleVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleBase>? scheduleBase = null,

            global::System.Action<global::Apify.ScheduleVariant2>? scheduleVariant2 = null,
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
            else if (IsScheduleVariant2)
            {
                scheduleVariant2?.Invoke(ScheduleVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ScheduleBase>? scheduleBase = null,
            global::System.Action<global::Apify.ScheduleVariant2>? scheduleVariant2 = null,
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
            else if (IsScheduleVariant2)
            {
                scheduleVariant2?.Invoke(ScheduleVariant2!);
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
                ScheduleVariant2,
                typeof(global::Apify.ScheduleVariant2),
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
        public bool Equals(Schedule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleBase?>.Default.Equals(ScheduleBase, other.ScheduleBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleVariant2?>.Default.Equals(ScheduleVariant2, other.ScheduleVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Schedule obj1, Schedule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Schedule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Schedule obj1, Schedule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Schedule o && Equals(o);
        }
    }
}
