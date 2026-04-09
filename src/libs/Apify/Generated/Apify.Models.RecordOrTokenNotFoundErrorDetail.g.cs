#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecordOrTokenNotFoundErrorDetail : global::System.IEquatable<RecordOrTokenNotFoundErrorDetail>
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
#if NET6_0_OR_GREATER
        public global::Apify.RecordOrTokenNotFoundErrorDetailVariant2? RecordOrTokenNotFoundErrorDetailVariant2 { get; init; }
#else
        public global::Apify.RecordOrTokenNotFoundErrorDetailVariant2? RecordOrTokenNotFoundErrorDetailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecordOrTokenNotFoundErrorDetailVariant2))]
#endif
        public bool IsRecordOrTokenNotFoundErrorDetailVariant2 => RecordOrTokenNotFoundErrorDetailVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordOrTokenNotFoundErrorDetail(global::Apify.ErrorDetail value) => new RecordOrTokenNotFoundErrorDetail((global::Apify.ErrorDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ErrorDetail?(RecordOrTokenNotFoundErrorDetail @this) => @this.ErrorDetail;

        /// <summary>
        /// 
        /// </summary>
        public RecordOrTokenNotFoundErrorDetail(global::Apify.ErrorDetail? value)
        {
            ErrorDetail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordOrTokenNotFoundErrorDetail(global::Apify.RecordOrTokenNotFoundErrorDetailVariant2 value) => new RecordOrTokenNotFoundErrorDetail((global::Apify.RecordOrTokenNotFoundErrorDetailVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RecordOrTokenNotFoundErrorDetailVariant2?(RecordOrTokenNotFoundErrorDetail @this) => @this.RecordOrTokenNotFoundErrorDetailVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RecordOrTokenNotFoundErrorDetail(global::Apify.RecordOrTokenNotFoundErrorDetailVariant2? value)
        {
            RecordOrTokenNotFoundErrorDetailVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordOrTokenNotFoundErrorDetail(
            global::Apify.ErrorDetail? errorDetail,
            global::Apify.RecordOrTokenNotFoundErrorDetailVariant2? recordOrTokenNotFoundErrorDetailVariant2
            )
        {
            ErrorDetail = errorDetail;
            RecordOrTokenNotFoundErrorDetailVariant2 = recordOrTokenNotFoundErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RecordOrTokenNotFoundErrorDetailVariant2 as object ??
            ErrorDetail as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorDetail?.ToString() ??
            RecordOrTokenNotFoundErrorDetailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorDetail && IsRecordOrTokenNotFoundErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ErrorDetail?, TResult>? errorDetail = null,
            global::System.Func<global::Apify.RecordOrTokenNotFoundErrorDetailVariant2?, TResult>? recordOrTokenNotFoundErrorDetailVariant2 = null,
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
            else if (IsRecordOrTokenNotFoundErrorDetailVariant2 && recordOrTokenNotFoundErrorDetailVariant2 != null)
            {
                return recordOrTokenNotFoundErrorDetailVariant2(RecordOrTokenNotFoundErrorDetailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ErrorDetail?>? errorDetail = null,
            global::System.Action<global::Apify.RecordOrTokenNotFoundErrorDetailVariant2?>? recordOrTokenNotFoundErrorDetailVariant2 = null,
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
            else if (IsRecordOrTokenNotFoundErrorDetailVariant2)
            {
                recordOrTokenNotFoundErrorDetailVariant2?.Invoke(RecordOrTokenNotFoundErrorDetailVariant2!);
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
                RecordOrTokenNotFoundErrorDetailVariant2,
                typeof(global::Apify.RecordOrTokenNotFoundErrorDetailVariant2),
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
        public bool Equals(RecordOrTokenNotFoundErrorDetail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ErrorDetail?>.Default.Equals(ErrorDetail, other.ErrorDetail) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RecordOrTokenNotFoundErrorDetailVariant2?>.Default.Equals(RecordOrTokenNotFoundErrorDetailVariant2, other.RecordOrTokenNotFoundErrorDetailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecordOrTokenNotFoundErrorDetail obj1, RecordOrTokenNotFoundErrorDetail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecordOrTokenNotFoundErrorDetail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecordOrTokenNotFoundErrorDetail obj1, RecordOrTokenNotFoundErrorDetail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecordOrTokenNotFoundErrorDetail o && Equals(o);
        }
    }
}
