#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ScheduleListItem : global::System.IEquatable<ScheduleListItem>
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
        public global::Apify.ScheduleBase PickScheduleBase() => ScheduleBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScheduleBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ScheduleListItemVariant2? ScheduleListItemVariant2 { get; init; }
#else
        public global::Apify.ScheduleListItemVariant2? ScheduleListItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScheduleListItemVariant2))]
#endif
        public bool IsScheduleListItemVariant2 => ScheduleListItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScheduleListItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ScheduleListItemVariant2? value)
        {
            value = ScheduleListItemVariant2;
            return IsScheduleListItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ScheduleListItemVariant2 PickScheduleListItemVariant2() => ScheduleListItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScheduleListItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScheduleListItem(global::Apify.ScheduleBase value) => new ScheduleListItem((global::Apify.ScheduleBase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ScheduleBase?(ScheduleListItem @this) => @this.ScheduleBase;

        /// <summary>
        ///
        /// </summary>
        public ScheduleListItem(global::Apify.ScheduleBase? value)
        {
            ScheduleBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScheduleListItem FromScheduleBase(global::Apify.ScheduleBase? value) => new ScheduleListItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ScheduleListItem(global::Apify.ScheduleListItemVariant2 value) => new ScheduleListItem((global::Apify.ScheduleListItemVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ScheduleListItemVariant2?(ScheduleListItem @this) => @this.ScheduleListItemVariant2;

        /// <summary>
        ///
        /// </summary>
        public ScheduleListItem(global::Apify.ScheduleListItemVariant2? value)
        {
            ScheduleListItemVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ScheduleListItem FromScheduleListItemVariant2(global::Apify.ScheduleListItemVariant2? value) => new ScheduleListItem(value);

        /// <summary>
        ///
        /// </summary>
        public ScheduleListItem(
            global::Apify.ScheduleBase? scheduleBase,
            global::Apify.ScheduleListItemVariant2? scheduleListItemVariant2
            )
        {
            ScheduleBase = scheduleBase;
            ScheduleListItemVariant2 = scheduleListItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScheduleListItemVariant2 as object ??
            ScheduleBase as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ScheduleBase?.ToString() ??
            ScheduleListItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsScheduleBase && IsScheduleListItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ScheduleBase, TResult>? scheduleBase = null,
            global::System.Func<global::Apify.ScheduleListItemVariant2, TResult>? scheduleListItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ScheduleBase is { } __value0 && scheduleBase != null)
            {
                return scheduleBase(__value0);
            }
            else if (ScheduleListItemVariant2 is { } __value1 && scheduleListItemVariant2 != null)
            {
                return scheduleListItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ScheduleBase>? scheduleBase = null,

            global::System.Action<global::Apify.ScheduleListItemVariant2>? scheduleListItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ScheduleBase is { } __value0)
            {
                scheduleBase?.Invoke(__value0);
            }
            else if (ScheduleListItemVariant2 is { } __value1)
            {
                scheduleListItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ScheduleBase>? scheduleBase = null,
            global::System.Action<global::Apify.ScheduleListItemVariant2>? scheduleListItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ScheduleBase is { } __value0)
            {
                scheduleBase?.Invoke(__value0);
            }
            else if (ScheduleListItemVariant2 is { } __value1)
            {
                scheduleListItemVariant2?.Invoke(__value1);
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
                ScheduleListItemVariant2,
                typeof(global::Apify.ScheduleListItemVariant2),
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
        public bool Equals(ScheduleListItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleBase?>.Default.Equals(ScheduleBase, other.ScheduleBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ScheduleListItemVariant2?>.Default.Equals(ScheduleListItemVariant2, other.ScheduleListItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ScheduleListItem obj1, ScheduleListItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScheduleListItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScheduleListItem obj1, ScheduleListItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScheduleListItem o && Equals(o);
        }
    }
}
