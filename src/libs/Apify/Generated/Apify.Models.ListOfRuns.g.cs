#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfRuns : global::System.IEquatable<ListOfRuns>
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
        public global::Apify.ListOfRunsVariant2? ListOfRunsVariant2 { get; init; }
#else
        public global::Apify.ListOfRunsVariant2? ListOfRunsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfRunsVariant2))]
#endif
        public bool IsListOfRunsVariant2 => ListOfRunsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfRuns(global::Apify.PaginationResponse value) => new ListOfRuns((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfRuns @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfRuns(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfRuns(global::Apify.ListOfRunsVariant2 value) => new ListOfRuns((global::Apify.ListOfRunsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfRunsVariant2?(ListOfRuns @this) => @this.ListOfRunsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfRuns(global::Apify.ListOfRunsVariant2? value)
        {
            ListOfRunsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListOfRuns(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfRunsVariant2? listOfRunsVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfRunsVariant2 = listOfRunsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfRunsVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfRunsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfRunsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse?, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfRunsVariant2?, TResult>? listOfRunsVariant2 = null,
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
            else if (IsListOfRunsVariant2 && listOfRunsVariant2 != null)
            {
                return listOfRunsVariant2(ListOfRunsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse?>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfRunsVariant2?>? listOfRunsVariant2 = null,
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
            else if (IsListOfRunsVariant2)
            {
                listOfRunsVariant2?.Invoke(ListOfRunsVariant2!);
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
                ListOfRunsVariant2,
                typeof(global::Apify.ListOfRunsVariant2),
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
        public bool Equals(ListOfRuns other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfRunsVariant2?>.Default.Equals(ListOfRunsVariant2, other.ListOfRunsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfRuns obj1, ListOfRuns obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfRuns>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfRuns obj1, ListOfRuns obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfRuns o && Equals(o);
        }
    }
}
