#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfStoreActors : global::System.IEquatable<ListOfStoreActors>
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
        public bool TryPickPaginationResponse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.PaginationResponse? value)
        {
            value = PaginationResponse;
            return IsPaginationResponse;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ListOfStoreActorsVariant2? ListOfStoreActorsVariant2 { get; init; }
#else
        public global::Apify.ListOfStoreActorsVariant2? ListOfStoreActorsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfStoreActorsVariant2))]
#endif
        public bool IsListOfStoreActorsVariant2 => ListOfStoreActorsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListOfStoreActorsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfStoreActorsVariant2? value)
        {
            value = ListOfStoreActorsVariant2;
            return IsListOfStoreActorsVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfStoreActors(global::Apify.PaginationResponse value) => new ListOfStoreActors((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfStoreActors @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfStoreActors(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListOfStoreActors FromPaginationResponse(global::Apify.PaginationResponse? value) => new ListOfStoreActors(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfStoreActors(global::Apify.ListOfStoreActorsVariant2 value) => new ListOfStoreActors((global::Apify.ListOfStoreActorsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfStoreActorsVariant2?(ListOfStoreActors @this) => @this.ListOfStoreActorsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfStoreActors(global::Apify.ListOfStoreActorsVariant2? value)
        {
            ListOfStoreActorsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListOfStoreActors FromListOfStoreActorsVariant2(global::Apify.ListOfStoreActorsVariant2? value) => new ListOfStoreActors(value);

        /// <summary>
        /// 
        /// </summary>
        public ListOfStoreActors(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfStoreActorsVariant2? listOfStoreActorsVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfStoreActorsVariant2 = listOfStoreActorsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfStoreActorsVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfStoreActorsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfStoreActorsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfStoreActorsVariant2, TResult>? listOfStoreActorsVariant2 = null,
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
            else if (IsListOfStoreActorsVariant2 && listOfStoreActorsVariant2 != null)
            {
                return listOfStoreActorsVariant2(ListOfStoreActorsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfStoreActorsVariant2>? listOfStoreActorsVariant2 = null,
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
            else if (IsListOfStoreActorsVariant2)
            {
                listOfStoreActorsVariant2?.Invoke(ListOfStoreActorsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfStoreActorsVariant2>? listOfStoreActorsVariant2 = null,
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
            else if (IsListOfStoreActorsVariant2)
            {
                listOfStoreActorsVariant2?.Invoke(ListOfStoreActorsVariant2!);
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
                ListOfStoreActorsVariant2,
                typeof(global::Apify.ListOfStoreActorsVariant2),
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
        public bool Equals(ListOfStoreActors other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfStoreActorsVariant2?>.Default.Equals(ListOfStoreActorsVariant2, other.ListOfStoreActorsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfStoreActors obj1, ListOfStoreActors obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfStoreActors>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfStoreActors obj1, ListOfStoreActors obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfStoreActors o && Equals(o);
        }
    }
}
