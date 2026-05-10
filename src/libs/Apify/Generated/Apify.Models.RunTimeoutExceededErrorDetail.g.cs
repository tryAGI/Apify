#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RunTimeoutExceededErrorDetail : global::System.IEquatable<RunTimeoutExceededErrorDetail>
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
        public global::Apify.RunTimeoutExceededErrorDetailVariant2? RunTimeoutExceededErrorDetailVariant2 { get; init; }
#else
        public global::Apify.RunTimeoutExceededErrorDetailVariant2? RunTimeoutExceededErrorDetailVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunTimeoutExceededErrorDetailVariant2))]
#endif
        public bool IsRunTimeoutExceededErrorDetailVariant2 => RunTimeoutExceededErrorDetailVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRunTimeoutExceededErrorDetailVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.RunTimeoutExceededErrorDetailVariant2? value)
        {
            value = RunTimeoutExceededErrorDetailVariant2;
            return IsRunTimeoutExceededErrorDetailVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunTimeoutExceededErrorDetail(global::Apify.ErrorDetail value) => new RunTimeoutExceededErrorDetail((global::Apify.ErrorDetail?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ErrorDetail?(RunTimeoutExceededErrorDetail @this) => @this.ErrorDetail;

        /// <summary>
        /// 
        /// </summary>
        public RunTimeoutExceededErrorDetail(global::Apify.ErrorDetail? value)
        {
            ErrorDetail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RunTimeoutExceededErrorDetail FromErrorDetail(global::Apify.ErrorDetail? value) => new RunTimeoutExceededErrorDetail(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RunTimeoutExceededErrorDetail(global::Apify.RunTimeoutExceededErrorDetailVariant2 value) => new RunTimeoutExceededErrorDetail((global::Apify.RunTimeoutExceededErrorDetailVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.RunTimeoutExceededErrorDetailVariant2?(RunTimeoutExceededErrorDetail @this) => @this.RunTimeoutExceededErrorDetailVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RunTimeoutExceededErrorDetail(global::Apify.RunTimeoutExceededErrorDetailVariant2? value)
        {
            RunTimeoutExceededErrorDetailVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RunTimeoutExceededErrorDetail FromRunTimeoutExceededErrorDetailVariant2(global::Apify.RunTimeoutExceededErrorDetailVariant2? value) => new RunTimeoutExceededErrorDetail(value);

        /// <summary>
        /// 
        /// </summary>
        public RunTimeoutExceededErrorDetail(
            global::Apify.ErrorDetail? errorDetail,
            global::Apify.RunTimeoutExceededErrorDetailVariant2? runTimeoutExceededErrorDetailVariant2
            )
        {
            ErrorDetail = errorDetail;
            RunTimeoutExceededErrorDetailVariant2 = runTimeoutExceededErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RunTimeoutExceededErrorDetailVariant2 as object ??
            ErrorDetail as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ErrorDetail?.ToString() ??
            RunTimeoutExceededErrorDetailVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsErrorDetail && IsRunTimeoutExceededErrorDetailVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.ErrorDetail, TResult>? errorDetail = null,
            global::System.Func<global::Apify.RunTimeoutExceededErrorDetailVariant2, TResult>? runTimeoutExceededErrorDetailVariant2 = null,
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
            else if (IsRunTimeoutExceededErrorDetailVariant2 && runTimeoutExceededErrorDetailVariant2 != null)
            {
                return runTimeoutExceededErrorDetailVariant2(RunTimeoutExceededErrorDetailVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.ErrorDetail>? errorDetail = null,

            global::System.Action<global::Apify.RunTimeoutExceededErrorDetailVariant2>? runTimeoutExceededErrorDetailVariant2 = null,
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
            else if (IsRunTimeoutExceededErrorDetailVariant2)
            {
                runTimeoutExceededErrorDetailVariant2?.Invoke(RunTimeoutExceededErrorDetailVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.ErrorDetail>? errorDetail = null,
            global::System.Action<global::Apify.RunTimeoutExceededErrorDetailVariant2>? runTimeoutExceededErrorDetailVariant2 = null,
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
            else if (IsRunTimeoutExceededErrorDetailVariant2)
            {
                runTimeoutExceededErrorDetailVariant2?.Invoke(RunTimeoutExceededErrorDetailVariant2!);
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
                RunTimeoutExceededErrorDetailVariant2,
                typeof(global::Apify.RunTimeoutExceededErrorDetailVariant2),
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
        public bool Equals(RunTimeoutExceededErrorDetail other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.ErrorDetail?>.Default.Equals(ErrorDetail, other.ErrorDetail) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.RunTimeoutExceededErrorDetailVariant2?>.Default.Equals(RunTimeoutExceededErrorDetailVariant2, other.RunTimeoutExceededErrorDetailVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RunTimeoutExceededErrorDetail obj1, RunTimeoutExceededErrorDetail obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RunTimeoutExceededErrorDetail>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RunTimeoutExceededErrorDetail obj1, RunTimeoutExceededErrorDetail obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RunTimeoutExceededErrorDetail o && Equals(o);
        }
    }
}
