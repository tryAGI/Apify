#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunFailedErrorDetail : global::System.IEquatable<RunFailedErrorDetail>
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
        public global::Apify.RunFailedErrorDetailVariant2? RunFailedErrorDetailVariant2 { get; init; }
#else
        public global::Apify.RunFailedErrorDetailVariant2? RunFailedErrorDetailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunFailedErrorDetailVariant2))]
#endif
        public bool IsRunFailedErrorDetailVariant2 => RunFailedErrorDetailVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunFailedErrorDetail(global::Apify.ErrorDetail value) => new RunFailedErrorDetail((global::Apify.ErrorDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ErrorDetail?(RunFailedErrorDetail @this) => @this.ErrorDetail;

        /// <summary>
        /// 
        /// </summary>
        public RunFailedErrorDetail(global::Apify.ErrorDetail? value)
        {
            ErrorDetail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunFailedErrorDetail(global::Apify.RunFailedErrorDetailVariant2 value) => new RunFailedErrorDetail((global::Apify.RunFailedErrorDetailVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RunFailedErrorDetailVariant2?(RunFailedErrorDetail @this) => @this.RunFailedErrorDetailVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RunFailedErrorDetail(global::Apify.RunFailedErrorDetailVariant2? value)
        {
            RunFailedErrorDetailVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RunFailedErrorDetail(
            global::Apify.ErrorDetail? errorDetail,
            global::Apify.RunFailedErrorDetailVariant2? runFailedErrorDetailVariant2
            )
        {
            ErrorDetail = errorDetail;
            RunFailedErrorDetailVariant2 = runFailedErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunFailedErrorDetailVariant2 as object ??
            ErrorDetail as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorDetail?.ToString() ??
            RunFailedErrorDetailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorDetail && IsRunFailedErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ErrorDetail?, TResult>? errorDetail = null,
            global::System.Func<global::Apify.RunFailedErrorDetailVariant2?, TResult>? runFailedErrorDetailVariant2 = null,
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
            else if (IsRunFailedErrorDetailVariant2 && runFailedErrorDetailVariant2 != null)
            {
                return runFailedErrorDetailVariant2(RunFailedErrorDetailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ErrorDetail?>? errorDetail = null,
            global::System.Action<global::Apify.RunFailedErrorDetailVariant2?>? runFailedErrorDetailVariant2 = null,
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
            else if (IsRunFailedErrorDetailVariant2)
            {
                runFailedErrorDetailVariant2?.Invoke(RunFailedErrorDetailVariant2!);
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
                RunFailedErrorDetailVariant2,
                typeof(global::Apify.RunFailedErrorDetailVariant2),
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
        public bool Equals(RunFailedErrorDetail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ErrorDetail?>.Default.Equals(ErrorDetail, other.ErrorDetail) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RunFailedErrorDetailVariant2?>.Default.Equals(RunFailedErrorDetailVariant2, other.RunFailedErrorDetailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunFailedErrorDetail obj1, RunFailedErrorDetail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunFailedErrorDetail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunFailedErrorDetail obj1, RunFailedErrorDetail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunFailedErrorDetail o && Equals(o);
        }
    }
}
