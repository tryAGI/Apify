#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfKeyValueStores : global::System.IEquatable<ListOfKeyValueStores>
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
        public global::Apify.ListOfKeyValueStoresVariant2? ListOfKeyValueStoresVariant2 { get; init; }
#else
        public global::Apify.ListOfKeyValueStoresVariant2? ListOfKeyValueStoresVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfKeyValueStoresVariant2))]
#endif
        public bool IsListOfKeyValueStoresVariant2 => ListOfKeyValueStoresVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfKeyValueStores(global::Apify.PaginationResponse value) => new ListOfKeyValueStores((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfKeyValueStores @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfKeyValueStores(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfKeyValueStores(global::Apify.ListOfKeyValueStoresVariant2 value) => new ListOfKeyValueStores((global::Apify.ListOfKeyValueStoresVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfKeyValueStoresVariant2?(ListOfKeyValueStores @this) => @this.ListOfKeyValueStoresVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfKeyValueStores(global::Apify.ListOfKeyValueStoresVariant2? value)
        {
            ListOfKeyValueStoresVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListOfKeyValueStores(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfKeyValueStoresVariant2? listOfKeyValueStoresVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfKeyValueStoresVariant2 = listOfKeyValueStoresVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfKeyValueStoresVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfKeyValueStoresVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfKeyValueStoresVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse?, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfKeyValueStoresVariant2?, TResult>? listOfKeyValueStoresVariant2 = null,
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
            else if (IsListOfKeyValueStoresVariant2 && listOfKeyValueStoresVariant2 != null)
            {
                return listOfKeyValueStoresVariant2(ListOfKeyValueStoresVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse?>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfKeyValueStoresVariant2?>? listOfKeyValueStoresVariant2 = null,
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
            else if (IsListOfKeyValueStoresVariant2)
            {
                listOfKeyValueStoresVariant2?.Invoke(ListOfKeyValueStoresVariant2!);
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
                ListOfKeyValueStoresVariant2,
                typeof(global::Apify.ListOfKeyValueStoresVariant2),
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
        public bool Equals(ListOfKeyValueStores other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfKeyValueStoresVariant2?>.Default.Equals(ListOfKeyValueStoresVariant2, other.ListOfKeyValueStoresVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfKeyValueStores obj1, ListOfKeyValueStores obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfKeyValueStores>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfKeyValueStores obj1, ListOfKeyValueStores obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfKeyValueStores o && Equals(o);
        }
    }
}
