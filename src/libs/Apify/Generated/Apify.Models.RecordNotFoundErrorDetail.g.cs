#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecordNotFoundErrorDetail : global::System.IEquatable<RecordNotFoundErrorDetail>
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
        public global::Apify.RecordNotFoundErrorDetailVariant2? RecordNotFoundErrorDetailVariant2 { get; init; }
#else
        public global::Apify.RecordNotFoundErrorDetailVariant2? RecordNotFoundErrorDetailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RecordNotFoundErrorDetailVariant2))]
#endif
        public bool IsRecordNotFoundErrorDetailVariant2 => RecordNotFoundErrorDetailVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordNotFoundErrorDetail(global::Apify.ErrorDetail value) => new RecordNotFoundErrorDetail((global::Apify.ErrorDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ErrorDetail?(RecordNotFoundErrorDetail @this) => @this.ErrorDetail;

        /// <summary>
        /// 
        /// </summary>
        public RecordNotFoundErrorDetail(global::Apify.ErrorDetail? value)
        {
            ErrorDetail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordNotFoundErrorDetail(global::Apify.RecordNotFoundErrorDetailVariant2 value) => new RecordNotFoundErrorDetail((global::Apify.RecordNotFoundErrorDetailVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RecordNotFoundErrorDetailVariant2?(RecordNotFoundErrorDetail @this) => @this.RecordNotFoundErrorDetailVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RecordNotFoundErrorDetail(global::Apify.RecordNotFoundErrorDetailVariant2? value)
        {
            RecordNotFoundErrorDetailVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordNotFoundErrorDetail(
            global::Apify.ErrorDetail? errorDetail,
            global::Apify.RecordNotFoundErrorDetailVariant2? recordNotFoundErrorDetailVariant2
            )
        {
            ErrorDetail = errorDetail;
            RecordNotFoundErrorDetailVariant2 = recordNotFoundErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RecordNotFoundErrorDetailVariant2 as object ??
            ErrorDetail as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorDetail?.ToString() ??
            RecordNotFoundErrorDetailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorDetail && IsRecordNotFoundErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ErrorDetail?, TResult>? errorDetail = null,
            global::System.Func<global::Apify.RecordNotFoundErrorDetailVariant2?, TResult>? recordNotFoundErrorDetailVariant2 = null,
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
            else if (IsRecordNotFoundErrorDetailVariant2 && recordNotFoundErrorDetailVariant2 != null)
            {
                return recordNotFoundErrorDetailVariant2(RecordNotFoundErrorDetailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ErrorDetail?>? errorDetail = null,
            global::System.Action<global::Apify.RecordNotFoundErrorDetailVariant2?>? recordNotFoundErrorDetailVariant2 = null,
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
            else if (IsRecordNotFoundErrorDetailVariant2)
            {
                recordNotFoundErrorDetailVariant2?.Invoke(RecordNotFoundErrorDetailVariant2!);
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
                RecordNotFoundErrorDetailVariant2,
                typeof(global::Apify.RecordNotFoundErrorDetailVariant2),
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
        public bool Equals(RecordNotFoundErrorDetail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ErrorDetail?>.Default.Equals(ErrorDetail, other.ErrorDetail) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RecordNotFoundErrorDetailVariant2?>.Default.Equals(RecordNotFoundErrorDetailVariant2, other.RecordNotFoundErrorDetailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecordNotFoundErrorDetail obj1, RecordNotFoundErrorDetail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecordNotFoundErrorDetail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecordNotFoundErrorDetail obj1, RecordNotFoundErrorDetail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecordNotFoundErrorDetail o && Equals(o);
        }
    }
}
