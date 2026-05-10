#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UnknownBuildTagErrorDetail : global::System.IEquatable<UnknownBuildTagErrorDetail>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ErrorDetail? ErrorDetail { get; init; }
#else
        public global::Apify.ErrorDetail? ErrorDetail { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorDetail))]
#endif
        public bool IsErrorDetail => ErrorDetail != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickErrorDetail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ErrorDetail? value)
        {
            value = ErrorDetail;
            return IsErrorDetail;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.UnknownBuildTagErrorDetailVariant2? UnknownBuildTagErrorDetailVariant2 { get; init; }
#else
        public global::Apify.UnknownBuildTagErrorDetailVariant2? UnknownBuildTagErrorDetailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UnknownBuildTagErrorDetailVariant2))]
#endif
        public bool IsUnknownBuildTagErrorDetailVariant2 => UnknownBuildTagErrorDetailVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUnknownBuildTagErrorDetailVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.UnknownBuildTagErrorDetailVariant2? value)
        {
            value = UnknownBuildTagErrorDetailVariant2;
            return IsUnknownBuildTagErrorDetailVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnknownBuildTagErrorDetail(global::Apify.ErrorDetail value) => new UnknownBuildTagErrorDetail((global::Apify.ErrorDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ErrorDetail?(UnknownBuildTagErrorDetail @this) => @this.ErrorDetail;

        /// <summary>
        /// 
        /// </summary>
        public UnknownBuildTagErrorDetail(global::Apify.ErrorDetail? value)
        {
            ErrorDetail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnknownBuildTagErrorDetail FromErrorDetail(global::Apify.ErrorDetail? value) => new UnknownBuildTagErrorDetail(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UnknownBuildTagErrorDetail(global::Apify.UnknownBuildTagErrorDetailVariant2 value) => new UnknownBuildTagErrorDetail((global::Apify.UnknownBuildTagErrorDetailVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.UnknownBuildTagErrorDetailVariant2?(UnknownBuildTagErrorDetail @this) => @this.UnknownBuildTagErrorDetailVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UnknownBuildTagErrorDetail(global::Apify.UnknownBuildTagErrorDetailVariant2? value)
        {
            UnknownBuildTagErrorDetailVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UnknownBuildTagErrorDetail FromUnknownBuildTagErrorDetailVariant2(global::Apify.UnknownBuildTagErrorDetailVariant2? value) => new UnknownBuildTagErrorDetail(value);

        /// <summary>
        /// 
        /// </summary>
        public UnknownBuildTagErrorDetail(
            global::Apify.ErrorDetail? errorDetail,
            global::Apify.UnknownBuildTagErrorDetailVariant2? unknownBuildTagErrorDetailVariant2
            )
        {
            ErrorDetail = errorDetail;
            UnknownBuildTagErrorDetailVariant2 = unknownBuildTagErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UnknownBuildTagErrorDetailVariant2 as object ??
            ErrorDetail as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorDetail?.ToString() ??
            UnknownBuildTagErrorDetailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorDetail && IsUnknownBuildTagErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ErrorDetail, TResult>? errorDetail = null,
            global::System.Func<global::Apify.UnknownBuildTagErrorDetailVariant2, TResult>? unknownBuildTagErrorDetailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorDetail && errorDetail != null)
            {
                return errorDetail(ErrorDetail!);
            }
            else if (IsUnknownBuildTagErrorDetailVariant2 && unknownBuildTagErrorDetailVariant2 != null)
            {
                return unknownBuildTagErrorDetailVariant2(UnknownBuildTagErrorDetailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ErrorDetail>? errorDetail = null,

            global::System.Action<global::Apify.UnknownBuildTagErrorDetailVariant2>? unknownBuildTagErrorDetailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorDetail)
            {
                errorDetail?.Invoke(ErrorDetail!);
            }
            else if (IsUnknownBuildTagErrorDetailVariant2)
            {
                unknownBuildTagErrorDetailVariant2?.Invoke(UnknownBuildTagErrorDetailVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ErrorDetail>? errorDetail = null,
            global::System.Action<global::Apify.UnknownBuildTagErrorDetailVariant2>? unknownBuildTagErrorDetailVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsErrorDetail)
            {
                errorDetail?.Invoke(ErrorDetail!);
            }
            else if (IsUnknownBuildTagErrorDetailVariant2)
            {
                unknownBuildTagErrorDetailVariant2?.Invoke(UnknownBuildTagErrorDetailVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ErrorDetail,
                typeof(global::Apify.ErrorDetail),
                UnknownBuildTagErrorDetailVariant2,
                typeof(global::Apify.UnknownBuildTagErrorDetailVariant2),
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
        public bool Equals(UnknownBuildTagErrorDetail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ErrorDetail?>.Default.Equals(ErrorDetail, other.ErrorDetail) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.UnknownBuildTagErrorDetailVariant2?>.Default.Equals(UnknownBuildTagErrorDetailVariant2, other.UnknownBuildTagErrorDetailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UnknownBuildTagErrorDetail obj1, UnknownBuildTagErrorDetail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UnknownBuildTagErrorDetail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UnknownBuildTagErrorDetail obj1, UnknownBuildTagErrorDetail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnknownBuildTagErrorDetail o && Equals(o);
        }
    }
}
