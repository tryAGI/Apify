#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ActorRunPricingInfo : global::System.IEquatable<ActorRunPricingInfo>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? PricingModel { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.PayPerEventActorPricingInfo? PayPerEvent { get; init; }
#else
        public global::Apify.PayPerEventActorPricingInfo? PayPerEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PayPerEvent))]
#endif
        public bool IsPayPerEvent => PayPerEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.PricePerDatasetItemActorPricingInfo? PricePerDatasetItem { get; init; }
#else
        public global::Apify.PricePerDatasetItemActorPricingInfo? PricePerDatasetItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricePerDatasetItem))]
#endif
        public bool IsPricePerDatasetItem => PricePerDatasetItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.FlatPricePerMonthActorPricingInfo? FlatPricePerMonth { get; init; }
#else
        public global::Apify.FlatPricePerMonthActorPricingInfo? FlatPricePerMonth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FlatPricePerMonth))]
#endif
        public bool IsFlatPricePerMonth => FlatPricePerMonth != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.FreeActorPricingInfo? Free { get; init; }
#else
        public global::Apify.FreeActorPricingInfo? Free { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Free))]
#endif
        public bool IsFree => Free != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActorRunPricingInfo(global::Apify.PayPerEventActorPricingInfo value) => new ActorRunPricingInfo((global::Apify.PayPerEventActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PayPerEventActorPricingInfo?(ActorRunPricingInfo @this) => @this.PayPerEvent;

        /// <summary>
        /// 
        /// </summary>
        public ActorRunPricingInfo(global::Apify.PayPerEventActorPricingInfo? value)
        {
            PayPerEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActorRunPricingInfo(global::Apify.PricePerDatasetItemActorPricingInfo value) => new ActorRunPricingInfo((global::Apify.PricePerDatasetItemActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PricePerDatasetItemActorPricingInfo?(ActorRunPricingInfo @this) => @this.PricePerDatasetItem;

        /// <summary>
        /// 
        /// </summary>
        public ActorRunPricingInfo(global::Apify.PricePerDatasetItemActorPricingInfo? value)
        {
            PricePerDatasetItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActorRunPricingInfo(global::Apify.FlatPricePerMonthActorPricingInfo value) => new ActorRunPricingInfo((global::Apify.FlatPricePerMonthActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.FlatPricePerMonthActorPricingInfo?(ActorRunPricingInfo @this) => @this.FlatPricePerMonth;

        /// <summary>
        /// 
        /// </summary>
        public ActorRunPricingInfo(global::Apify.FlatPricePerMonthActorPricingInfo? value)
        {
            FlatPricePerMonth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ActorRunPricingInfo(global::Apify.FreeActorPricingInfo value) => new ActorRunPricingInfo((global::Apify.FreeActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.FreeActorPricingInfo?(ActorRunPricingInfo @this) => @this.Free;

        /// <summary>
        /// 
        /// </summary>
        public ActorRunPricingInfo(global::Apify.FreeActorPricingInfo? value)
        {
            Free = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ActorRunPricingInfo(
            global::Apify.ActorRunPricingInfoDiscriminatorPricingModel? pricingModel,
            global::Apify.PayPerEventActorPricingInfo? payPerEvent,
            global::Apify.PricePerDatasetItemActorPricingInfo? pricePerDatasetItem,
            global::Apify.FlatPricePerMonthActorPricingInfo? flatPricePerMonth,
            global::Apify.FreeActorPricingInfo? free
            )
        {
            PricingModel = pricingModel;

            PayPerEvent = payPerEvent;
            PricePerDatasetItem = pricePerDatasetItem;
            FlatPricePerMonth = flatPricePerMonth;
            Free = free;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Free as object ??
            FlatPricePerMonth as object ??
            PricePerDatasetItem as object ??
            PayPerEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PayPerEvent?.ToString() ??
            PricePerDatasetItem?.ToString() ??
            FlatPricePerMonth?.ToString() ??
            Free?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPayPerEvent && !IsPricePerDatasetItem && !IsFlatPricePerMonth && !IsFree || !IsPayPerEvent && IsPricePerDatasetItem && !IsFlatPricePerMonth && !IsFree || !IsPayPerEvent && !IsPricePerDatasetItem && IsFlatPricePerMonth && !IsFree || !IsPayPerEvent && !IsPricePerDatasetItem && !IsFlatPricePerMonth && IsFree;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PayPerEventActorPricingInfo?, TResult>? payPerEvent = null,
            global::System.Func<global::Apify.PricePerDatasetItemActorPricingInfo?, TResult>? pricePerDatasetItem = null,
            global::System.Func<global::Apify.FlatPricePerMonthActorPricingInfo?, TResult>? flatPricePerMonth = null,
            global::System.Func<global::Apify.FreeActorPricingInfo?, TResult>? free = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPayPerEvent && payPerEvent != null)
            {
                return payPerEvent(PayPerEvent!);
            }
            else if (IsPricePerDatasetItem && pricePerDatasetItem != null)
            {
                return pricePerDatasetItem(PricePerDatasetItem!);
            }
            else if (IsFlatPricePerMonth && flatPricePerMonth != null)
            {
                return flatPricePerMonth(FlatPricePerMonth!);
            }
            else if (IsFree && free != null)
            {
                return free(Free!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PayPerEventActorPricingInfo?>? payPerEvent = null,
            global::System.Action<global::Apify.PricePerDatasetItemActorPricingInfo?>? pricePerDatasetItem = null,
            global::System.Action<global::Apify.FlatPricePerMonthActorPricingInfo?>? flatPricePerMonth = null,
            global::System.Action<global::Apify.FreeActorPricingInfo?>? free = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPayPerEvent)
            {
                payPerEvent?.Invoke(PayPerEvent!);
            }
            else if (IsPricePerDatasetItem)
            {
                pricePerDatasetItem?.Invoke(PricePerDatasetItem!);
            }
            else if (IsFlatPricePerMonth)
            {
                flatPricePerMonth?.Invoke(FlatPricePerMonth!);
            }
            else if (IsFree)
            {
                free?.Invoke(Free!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PayPerEvent,
                typeof(global::Apify.PayPerEventActorPricingInfo),
                PricePerDatasetItem,
                typeof(global::Apify.PricePerDatasetItemActorPricingInfo),
                FlatPricePerMonth,
                typeof(global::Apify.FlatPricePerMonthActorPricingInfo),
                Free,
                typeof(global::Apify.FreeActorPricingInfo),
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
        public bool Equals(ActorRunPricingInfo other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PayPerEventActorPricingInfo?>.Default.Equals(PayPerEvent, other.PayPerEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.PricePerDatasetItemActorPricingInfo?>.Default.Equals(PricePerDatasetItem, other.PricePerDatasetItem) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.FlatPricePerMonthActorPricingInfo?>.Default.Equals(FlatPricePerMonth, other.FlatPricePerMonth) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.FreeActorPricingInfo?>.Default.Equals(Free, other.Free) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ActorRunPricingInfo obj1, ActorRunPricingInfo obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ActorRunPricingInfo>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ActorRunPricingInfo obj1, ActorRunPricingInfo obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ActorRunPricingInfo o && Equals(o);
        }
    }
}
