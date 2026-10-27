#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// Paginated list of webhooks with all their fields, including `payloadTemplate`.
    /// </summary>
    public readonly partial struct ListOfWebhookResources : global::System.IEquatable<ListOfWebhookResources>
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
        public global::Apify.PaginationResponse PickPaginationResponse() => PaginationResponse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PaginationResponse' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Apify.ListOfWebhookResourcesVariant2? ListOfWebhookResourcesVariant2 { get; init; }
#else
        public global::Apify.ListOfWebhookResourcesVariant2? ListOfWebhookResourcesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfWebhookResourcesVariant2))]
#endif
        public bool IsListOfWebhookResourcesVariant2 => ListOfWebhookResourcesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListOfWebhookResourcesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfWebhookResourcesVariant2? value)
        {
            value = ListOfWebhookResourcesVariant2;
            return IsListOfWebhookResourcesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfWebhookResourcesVariant2 PickListOfWebhookResourcesVariant2() => ListOfWebhookResourcesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListOfWebhookResourcesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListOfWebhookResources(global::Apify.PaginationResponse value) => new ListOfWebhookResources((global::Apify.PaginationResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfWebhookResources @this) => @this.PaginationResponse;

        /// <summary>
        ///
        /// </summary>
        public ListOfWebhookResources(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListOfWebhookResources FromPaginationResponse(global::Apify.PaginationResponse? value) => new ListOfWebhookResources(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListOfWebhookResources(global::Apify.ListOfWebhookResourcesVariant2 value) => new ListOfWebhookResources((global::Apify.ListOfWebhookResourcesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ListOfWebhookResourcesVariant2?(ListOfWebhookResources @this) => @this.ListOfWebhookResourcesVariant2;

        /// <summary>
        ///
        /// </summary>
        public ListOfWebhookResources(global::Apify.ListOfWebhookResourcesVariant2? value)
        {
            ListOfWebhookResourcesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListOfWebhookResources FromListOfWebhookResourcesVariant2(global::Apify.ListOfWebhookResourcesVariant2? value) => new ListOfWebhookResources(value);

        /// <summary>
        ///
        /// </summary>
        public ListOfWebhookResources(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfWebhookResourcesVariant2? listOfWebhookResourcesVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfWebhookResourcesVariant2 = listOfWebhookResourcesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListOfWebhookResourcesVariant2 as object ??
            PaginationResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfWebhookResourcesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfWebhookResourcesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfWebhookResourcesVariant2, TResult>? listOfWebhookResourcesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PaginationResponse is { } __value0 && paginationResponse != null)
            {
                return paginationResponse(__value0);
            }
            else if (ListOfWebhookResourcesVariant2 is { } __value1 && listOfWebhookResourcesVariant2 != null)
            {
                return listOfWebhookResourcesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfWebhookResourcesVariant2>? listOfWebhookResourcesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PaginationResponse is { } __value0)
            {
                paginationResponse?.Invoke(__value0);
            }
            else if (ListOfWebhookResourcesVariant2 is { } __value1)
            {
                listOfWebhookResourcesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfWebhookResourcesVariant2>? listOfWebhookResourcesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PaginationResponse is { } __value0)
            {
                paginationResponse?.Invoke(__value0);
            }
            else if (ListOfWebhookResourcesVariant2 is { } __value1)
            {
                listOfWebhookResourcesVariant2?.Invoke(__value1);
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
                ListOfWebhookResourcesVariant2,
                typeof(global::Apify.ListOfWebhookResourcesVariant2),
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
        public bool Equals(ListOfWebhookResources other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfWebhookResourcesVariant2?>.Default.Equals(ListOfWebhookResourcesVariant2, other.ListOfWebhookResourcesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListOfWebhookResources obj1, ListOfWebhookResources obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfWebhookResources>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListOfWebhookResources obj1, ListOfWebhookResources obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfWebhookResources o && Equals(o);
        }
    }
}
