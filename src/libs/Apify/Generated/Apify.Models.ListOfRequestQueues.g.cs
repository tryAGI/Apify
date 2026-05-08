#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// A paginated list of request queues.
    /// </summary>
    public readonly partial struct ListOfRequestQueues : global::System.IEquatable<ListOfRequestQueues>
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
        public global::Apify.ListOfRequestQueuesVariant2? ListOfRequestQueuesVariant2 { get; init; }
#else
        public global::Apify.ListOfRequestQueuesVariant2? ListOfRequestQueuesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfRequestQueuesVariant2))]
#endif
        public bool IsListOfRequestQueuesVariant2 => ListOfRequestQueuesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListOfRequestQueuesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfRequestQueuesVariant2? value)
        {
            value = ListOfRequestQueuesVariant2;
            return IsListOfRequestQueuesVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfRequestQueues(global::Apify.PaginationResponse value) => new ListOfRequestQueues((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfRequestQueues @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfRequestQueues(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfRequestQueues(global::Apify.ListOfRequestQueuesVariant2 value) => new ListOfRequestQueues((global::Apify.ListOfRequestQueuesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfRequestQueuesVariant2?(ListOfRequestQueues @this) => @this.ListOfRequestQueuesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfRequestQueues(global::Apify.ListOfRequestQueuesVariant2? value)
        {
            ListOfRequestQueuesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListOfRequestQueues(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfRequestQueuesVariant2? listOfRequestQueuesVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfRequestQueuesVariant2 = listOfRequestQueuesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfRequestQueuesVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfRequestQueuesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfRequestQueuesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfRequestQueuesVariant2, TResult>? listOfRequestQueuesVariant2 = null,
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
            else if (IsListOfRequestQueuesVariant2 && listOfRequestQueuesVariant2 != null)
            {
                return listOfRequestQueuesVariant2(ListOfRequestQueuesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfRequestQueuesVariant2>? listOfRequestQueuesVariant2 = null,
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
            else if (IsListOfRequestQueuesVariant2)
            {
                listOfRequestQueuesVariant2?.Invoke(ListOfRequestQueuesVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfRequestQueuesVariant2>? listOfRequestQueuesVariant2 = null,
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
            else if (IsListOfRequestQueuesVariant2)
            {
                listOfRequestQueuesVariant2?.Invoke(ListOfRequestQueuesVariant2!);
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
                ListOfRequestQueuesVariant2,
                typeof(global::Apify.ListOfRequestQueuesVariant2),
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
        public bool Equals(ListOfRequestQueues other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfRequestQueuesVariant2?>.Default.Equals(ListOfRequestQueuesVariant2, other.ListOfRequestQueuesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfRequestQueues obj1, ListOfRequestQueues obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfRequestQueues>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfRequestQueues obj1, ListOfRequestQueues obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfRequestQueues o && Equals(o);
        }
    }
}
