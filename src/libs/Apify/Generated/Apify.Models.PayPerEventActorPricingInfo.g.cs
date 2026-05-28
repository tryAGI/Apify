#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PayPerEventActorPricingInfo : global::System.IEquatable<PayPerEventActorPricingInfo>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.CommonActorPricingInfo? CommonActorPricingInfo { get; init; }
#else
        public global::Apify.CommonActorPricingInfo? CommonActorPricingInfo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommonActorPricingInfo))]
#endif
        public bool IsCommonActorPricingInfo => CommonActorPricingInfo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCommonActorPricingInfo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.CommonActorPricingInfo? value)
        {
            value = CommonActorPricingInfo;
            return IsCommonActorPricingInfo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.CommonActorPricingInfo PickCommonActorPricingInfo() => IsCommonActorPricingInfo
            ? CommonActorPricingInfo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommonActorPricingInfo' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.PayPerEventActorPricingInfoVariant2? PayPerEventActorPricingInfoVariant2 { get; init; }
#else
        public global::Apify.PayPerEventActorPricingInfoVariant2? PayPerEventActorPricingInfoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PayPerEventActorPricingInfoVariant2))]
#endif
        public bool IsPayPerEventActorPricingInfoVariant2 => PayPerEventActorPricingInfoVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPayPerEventActorPricingInfoVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.PayPerEventActorPricingInfoVariant2? value)
        {
            value = PayPerEventActorPricingInfoVariant2;
            return IsPayPerEventActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.PayPerEventActorPricingInfoVariant2 PickPayPerEventActorPricingInfoVariant2() => IsPayPerEventActorPricingInfoVariant2
            ? PayPerEventActorPricingInfoVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PayPerEventActorPricingInfoVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayPerEventActorPricingInfo(global::Apify.CommonActorPricingInfo value) => new PayPerEventActorPricingInfo((global::Apify.CommonActorPricingInfo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.CommonActorPricingInfo?(PayPerEventActorPricingInfo @this) => @this.CommonActorPricingInfo;

        /// <summary>
        /// 
        /// </summary>
        public PayPerEventActorPricingInfo(global::Apify.CommonActorPricingInfo? value)
        {
            CommonActorPricingInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PayPerEventActorPricingInfo FromCommonActorPricingInfo(global::Apify.CommonActorPricingInfo? value) => new PayPerEventActorPricingInfo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayPerEventActorPricingInfo(global::Apify.PayPerEventActorPricingInfoVariant2 value) => new PayPerEventActorPricingInfo((global::Apify.PayPerEventActorPricingInfoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PayPerEventActorPricingInfoVariant2?(PayPerEventActorPricingInfo @this) => @this.PayPerEventActorPricingInfoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PayPerEventActorPricingInfo(global::Apify.PayPerEventActorPricingInfoVariant2? value)
        {
            PayPerEventActorPricingInfoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PayPerEventActorPricingInfo FromPayPerEventActorPricingInfoVariant2(global::Apify.PayPerEventActorPricingInfoVariant2? value) => new PayPerEventActorPricingInfo(value);

        /// <summary>
        /// 
        /// </summary>
        public PayPerEventActorPricingInfo(
            global::Apify.CommonActorPricingInfo? commonActorPricingInfo,
            global::Apify.PayPerEventActorPricingInfoVariant2? payPerEventActorPricingInfoVariant2
            )
        {
            CommonActorPricingInfo = commonActorPricingInfo;
            PayPerEventActorPricingInfoVariant2 = payPerEventActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PayPerEventActorPricingInfoVariant2 as object ??
            CommonActorPricingInfo as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonActorPricingInfo?.ToString() ??
            PayPerEventActorPricingInfoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonActorPricingInfo && IsPayPerEventActorPricingInfoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.CommonActorPricingInfo, TResult>? commonActorPricingInfo = null,
            global::System.Func<global::Apify.PayPerEventActorPricingInfoVariant2, TResult>? payPerEventActorPricingInfoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonActorPricingInfo && commonActorPricingInfo != null)
            {
                return commonActorPricingInfo(CommonActorPricingInfo!);
            }
            else if (IsPayPerEventActorPricingInfoVariant2 && payPerEventActorPricingInfoVariant2 != null)
            {
                return payPerEventActorPricingInfoVariant2(PayPerEventActorPricingInfoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.CommonActorPricingInfo>? commonActorPricingInfo = null,

            global::System.Action<global::Apify.PayPerEventActorPricingInfoVariant2>? payPerEventActorPricingInfoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonActorPricingInfo)
            {
                commonActorPricingInfo?.Invoke(CommonActorPricingInfo!);
            }
            else if (IsPayPerEventActorPricingInfoVariant2)
            {
                payPerEventActorPricingInfoVariant2?.Invoke(PayPerEventActorPricingInfoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.CommonActorPricingInfo>? commonActorPricingInfo = null,
            global::System.Action<global::Apify.PayPerEventActorPricingInfoVariant2>? payPerEventActorPricingInfoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonActorPricingInfo)
            {
                commonActorPricingInfo?.Invoke(CommonActorPricingInfo!);
            }
            else if (IsPayPerEventActorPricingInfoVariant2)
            {
                payPerEventActorPricingInfoVariant2?.Invoke(PayPerEventActorPricingInfoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CommonActorPricingInfo,
                typeof(global::Apify.CommonActorPricingInfo),
                PayPerEventActorPricingInfoVariant2,
                typeof(global::Apify.PayPerEventActorPricingInfoVariant2),
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
        public bool Equals(PayPerEventActorPricingInfo other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.CommonActorPricingInfo?>.Default.Equals(CommonActorPricingInfo, other.CommonActorPricingInfo) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.PayPerEventActorPricingInfoVariant2?>.Default.Equals(PayPerEventActorPricingInfoVariant2, other.PayPerEventActorPricingInfoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayPerEventActorPricingInfo obj1, PayPerEventActorPricingInfo obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayPerEventActorPricingInfo>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayPerEventActorPricingInfo obj1, PayPerEventActorPricingInfo obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayPerEventActorPricingInfo o && Equals(o);
        }
    }
}
