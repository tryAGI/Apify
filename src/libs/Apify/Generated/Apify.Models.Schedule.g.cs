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
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleVariant2? Value2 { get; init; }
#else
        public global::Apify.ScheduleVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
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
        public static implicit operator Schedule(global::Apify.ScheduleVariant2 value) => new Schedule((global::Apify.ScheduleVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ScheduleVariant2?(Schedule @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Schedule(global::Apify.ScheduleVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Schedule(
            global::Apify.ScheduleBase? scheduleBase,
            global::Apify.ScheduleVariant2? value2
            )
        {
            ScheduleBase = scheduleBase;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ScheduleBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScheduleBase?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScheduleBase && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ScheduleBase?, TResult>? scheduleBase = null,
            global::System.Func<global::Apify.ScheduleVariant2?, TResult>? value2 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleBase?>? scheduleBase = null,
            global::System.Action<global::Apify.ScheduleVariant2?>? value2 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
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
                Value2,
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
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleVariant2?>.Default.Equals(Value2, other.Value2) 
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
