#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfActors : global::System.IEquatable<ListOfActors>
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
        public global::Apify.PaginationResponse PickPaginationResponse() => IsPaginationResponse
            ? PaginationResponse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PaginationResponse' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ListOfActorsVariant2? ListOfActorsVariant2 { get; init; }
#else
        public global::Apify.ListOfActorsVariant2? ListOfActorsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfActorsVariant2))]
#endif
        public bool IsListOfActorsVariant2 => ListOfActorsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListOfActorsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfActorsVariant2? value)
        {
            value = ListOfActorsVariant2;
            return IsListOfActorsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Apify.ListOfActorsVariant2 PickListOfActorsVariant2() => IsListOfActorsVariant2
            ? ListOfActorsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListOfActorsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfActors(global::Apify.PaginationResponse value) => new ListOfActors((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfActors @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfActors(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListOfActors FromPaginationResponse(global::Apify.PaginationResponse? value) => new ListOfActors(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfActors(global::Apify.ListOfActorsVariant2 value) => new ListOfActors((global::Apify.ListOfActorsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfActorsVariant2?(ListOfActors @this) => @this.ListOfActorsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfActors(global::Apify.ListOfActorsVariant2? value)
        {
            ListOfActorsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListOfActors FromListOfActorsVariant2(global::Apify.ListOfActorsVariant2? value) => new ListOfActors(value);

        /// <summary>
        /// 
        /// </summary>
        public ListOfActors(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfActorsVariant2? listOfActorsVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfActorsVariant2 = listOfActorsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfActorsVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfActorsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfActorsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfActorsVariant2, TResult>? listOfActorsVariant2 = null,
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
            else if (IsListOfActorsVariant2 && listOfActorsVariant2 != null)
            {
                return listOfActorsVariant2(ListOfActorsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfActorsVariant2>? listOfActorsVariant2 = null,
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
            else if (IsListOfActorsVariant2)
            {
                listOfActorsVariant2?.Invoke(ListOfActorsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfActorsVariant2>? listOfActorsVariant2 = null,
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
            else if (IsListOfActorsVariant2)
            {
                listOfActorsVariant2?.Invoke(ListOfActorsVariant2!);
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
                ListOfActorsVariant2,
                typeof(global::Apify.ListOfActorsVariant2),
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
        public bool Equals(ListOfActors other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfActorsVariant2?>.Default.Equals(ListOfActorsVariant2, other.ListOfActorsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfActors obj1, ListOfActors obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfActors>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfActors obj1, ListOfActors obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfActors o && Equals(o);
        }
    }
}
