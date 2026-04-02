#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfSchedules : global::System.IEquatable<ListOfSchedules>
    {
        /// <summary>
        /// Common pagination fields for list responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.PaginationResponse? PaginationResponse { get; init; }
#else
        public global::Apify.PaginationResponse? PaginationResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PaginationResponse))]
#endif
        public bool IsPaginationResponse => PaginationResponse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ListOfSchedulesVariant2? ListOfSchedulesVariant2 { get; init; }
#else
        public global::Apify.ListOfSchedulesVariant2? ListOfSchedulesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfSchedulesVariant2))]
#endif
        public bool IsListOfSchedulesVariant2 => ListOfSchedulesVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfSchedules(global::Apify.PaginationResponse value) => new ListOfSchedules((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfSchedules @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfSchedules(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfSchedules(global::Apify.ListOfSchedulesVariant2 value) => new ListOfSchedules((global::Apify.ListOfSchedulesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfSchedulesVariant2?(ListOfSchedules @this) => @this.ListOfSchedulesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfSchedules(global::Apify.ListOfSchedulesVariant2? value)
        {
            ListOfSchedulesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListOfSchedules(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfSchedulesVariant2? listOfSchedulesVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfSchedulesVariant2 = listOfSchedulesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfSchedulesVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfSchedulesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfSchedulesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse?, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfSchedulesVariant2?, TResult>? listOfSchedulesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginationResponse && paginationResponse != null)
            {
                return paginationResponse(PaginationResponse!);
            }
            else if (IsListOfSchedulesVariant2 && listOfSchedulesVariant2 != null)
            {
                return listOfSchedulesVariant2(ListOfSchedulesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse?>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfSchedulesVariant2?>? listOfSchedulesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPaginationResponse)
            {
                paginationResponse?.Invoke(PaginationResponse!);
            }
            else if (IsListOfSchedulesVariant2)
            {
                listOfSchedulesVariant2?.Invoke(ListOfSchedulesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PaginationResponse,
                typeof(global::Apify.PaginationResponse),
                ListOfSchedulesVariant2,
                typeof(global::Apify.ListOfSchedulesVariant2),
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
        public bool Equals(ListOfSchedules other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfSchedulesVariant2?>.Default.Equals(ListOfSchedulesVariant2, other.ListOfSchedulesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfSchedules obj1, ListOfSchedules obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfSchedules>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfSchedules obj1, ListOfSchedules obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfSchedules o && Equals(o);
        }
    }
}
