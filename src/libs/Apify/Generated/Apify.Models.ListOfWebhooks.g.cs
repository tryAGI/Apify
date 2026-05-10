#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfWebhooks : global::System.IEquatable<ListOfWebhooks>
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
        public global::Apify.ListOfWebhooksVariant2? ListOfWebhooksVariant2 { get; init; }
#else
        public global::Apify.ListOfWebhooksVariant2? ListOfWebhooksVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfWebhooksVariant2))]
#endif
        public bool IsListOfWebhooksVariant2 => ListOfWebhooksVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListOfWebhooksVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfWebhooksVariant2? value)
        {
            value = ListOfWebhooksVariant2;
            return IsListOfWebhooksVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfWebhooks(global::Apify.PaginationResponse value) => new ListOfWebhooks((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfWebhooks @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfWebhooks(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListOfWebhooks FromPaginationResponse(global::Apify.PaginationResponse? value) => new ListOfWebhooks(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfWebhooks(global::Apify.ListOfWebhooksVariant2 value) => new ListOfWebhooks((global::Apify.ListOfWebhooksVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfWebhooksVariant2?(ListOfWebhooks @this) => @this.ListOfWebhooksVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfWebhooks(global::Apify.ListOfWebhooksVariant2? value)
        {
            ListOfWebhooksVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ListOfWebhooks FromListOfWebhooksVariant2(global::Apify.ListOfWebhooksVariant2? value) => new ListOfWebhooks(value);

        /// <summary>
        /// 
        /// </summary>
        public ListOfWebhooks(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfWebhooksVariant2? listOfWebhooksVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfWebhooksVariant2 = listOfWebhooksVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfWebhooksVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfWebhooksVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfWebhooksVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfWebhooksVariant2, TResult>? listOfWebhooksVariant2 = null,
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
            else if (IsListOfWebhooksVariant2 && listOfWebhooksVariant2 != null)
            {
                return listOfWebhooksVariant2(ListOfWebhooksVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfWebhooksVariant2>? listOfWebhooksVariant2 = null,
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
            else if (IsListOfWebhooksVariant2)
            {
                listOfWebhooksVariant2?.Invoke(ListOfWebhooksVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfWebhooksVariant2>? listOfWebhooksVariant2 = null,
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
            else if (IsListOfWebhooksVariant2)
            {
                listOfWebhooksVariant2?.Invoke(ListOfWebhooksVariant2!);
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
                ListOfWebhooksVariant2,
                typeof(global::Apify.ListOfWebhooksVariant2),
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
        public bool Equals(ListOfWebhooks other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfWebhooksVariant2?>.Default.Equals(ListOfWebhooksVariant2, other.ListOfWebhooksVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfWebhooks obj1, ListOfWebhooks obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfWebhooks>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfWebhooks obj1, ListOfWebhooks obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfWebhooks o && Equals(o);
        }
    }
}
