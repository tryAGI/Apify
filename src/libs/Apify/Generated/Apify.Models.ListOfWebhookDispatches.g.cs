#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfWebhookDispatches : global::System.IEquatable<ListOfWebhookDispatches>
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
        public global::Apify.ListOfWebhookDispatchesVariant2? ListOfWebhookDispatchesVariant2 { get; init; }
#else
        public global::Apify.ListOfWebhookDispatchesVariant2? ListOfWebhookDispatchesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfWebhookDispatchesVariant2))]
#endif
        public bool IsListOfWebhookDispatchesVariant2 => ListOfWebhookDispatchesVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfWebhookDispatches(global::Apify.PaginationResponse value) => new ListOfWebhookDispatches((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfWebhookDispatches @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfWebhookDispatches(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfWebhookDispatches(global::Apify.ListOfWebhookDispatchesVariant2 value) => new ListOfWebhookDispatches((global::Apify.ListOfWebhookDispatchesVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfWebhookDispatchesVariant2?(ListOfWebhookDispatches @this) => @this.ListOfWebhookDispatchesVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfWebhookDispatches(global::Apify.ListOfWebhookDispatchesVariant2? value)
        {
            ListOfWebhookDispatchesVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListOfWebhookDispatches(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfWebhookDispatchesVariant2? listOfWebhookDispatchesVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfWebhookDispatchesVariant2 = listOfWebhookDispatchesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfWebhookDispatchesVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfWebhookDispatchesVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfWebhookDispatchesVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse?, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfWebhookDispatchesVariant2?, TResult>? listOfWebhookDispatchesVariant2 = null,
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
            else if (IsListOfWebhookDispatchesVariant2 && listOfWebhookDispatchesVariant2 != null)
            {
                return listOfWebhookDispatchesVariant2(ListOfWebhookDispatchesVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse?>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfWebhookDispatchesVariant2?>? listOfWebhookDispatchesVariant2 = null,
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
            else if (IsListOfWebhookDispatchesVariant2)
            {
                listOfWebhookDispatchesVariant2?.Invoke(ListOfWebhookDispatchesVariant2!);
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
                ListOfWebhookDispatchesVariant2,
                typeof(global::Apify.ListOfWebhookDispatchesVariant2),
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
        public bool Equals(ListOfWebhookDispatches other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfWebhookDispatchesVariant2?>.Default.Equals(ListOfWebhookDispatchesVariant2, other.ListOfWebhookDispatchesVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfWebhookDispatches obj1, ListOfWebhookDispatches obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfWebhookDispatches>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfWebhookDispatches obj1, ListOfWebhookDispatches obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfWebhookDispatches o && Equals(o);
        }
    }
}
