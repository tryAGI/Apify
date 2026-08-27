#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ListOfBuilds : global::System.IEquatable<ListOfBuilds>
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
        public global::Apify.ListOfBuildsVariant2? ListOfBuildsVariant2 { get; init; }
#else
        public global::Apify.ListOfBuildsVariant2? ListOfBuildsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfBuildsVariant2))]
#endif
        public bool IsListOfBuildsVariant2 => ListOfBuildsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListOfBuildsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfBuildsVariant2? value)
        {
            value = ListOfBuildsVariant2;
            return IsListOfBuildsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfBuildsVariant2 PickListOfBuildsVariant2() => IsListOfBuildsVariant2
            ? ListOfBuildsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListOfBuildsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListOfBuilds(global::Apify.PaginationResponse value) => new ListOfBuilds((global::Apify.PaginationResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfBuilds @this) => @this.PaginationResponse;

        /// <summary>
        ///
        /// </summary>
        public ListOfBuilds(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListOfBuilds FromPaginationResponse(global::Apify.PaginationResponse? value) => new ListOfBuilds(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListOfBuilds(global::Apify.ListOfBuildsVariant2 value) => new ListOfBuilds((global::Apify.ListOfBuildsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ListOfBuildsVariant2?(ListOfBuilds @this) => @this.ListOfBuildsVariant2;

        /// <summary>
        ///
        /// </summary>
        public ListOfBuilds(global::Apify.ListOfBuildsVariant2? value)
        {
            ListOfBuildsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListOfBuilds FromListOfBuildsVariant2(global::Apify.ListOfBuildsVariant2? value) => new ListOfBuilds(value);

        /// <summary>
        ///
        /// </summary>
        public ListOfBuilds(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfBuildsVariant2? listOfBuildsVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfBuildsVariant2 = listOfBuildsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListOfBuildsVariant2 as object ??
            PaginationResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfBuildsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfBuildsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfBuildsVariant2, TResult>? listOfBuildsVariant2 = null,
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
            else if (IsListOfBuildsVariant2 && listOfBuildsVariant2 != null)
            {
                return listOfBuildsVariant2(ListOfBuildsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfBuildsVariant2>? listOfBuildsVariant2 = null,
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
            else if (IsListOfBuildsVariant2)
            {
                listOfBuildsVariant2?.Invoke(ListOfBuildsVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfBuildsVariant2>? listOfBuildsVariant2 = null,
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
            else if (IsListOfBuildsVariant2)
            {
                listOfBuildsVariant2?.Invoke(ListOfBuildsVariant2!);
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
                ListOfBuildsVariant2,
                typeof(global::Apify.ListOfBuildsVariant2),
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
        public bool Equals(ListOfBuilds other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfBuildsVariant2?>.Default.Equals(ListOfBuildsVariant2, other.ListOfBuildsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListOfBuilds obj1, ListOfBuilds obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfBuilds>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListOfBuilds obj1, ListOfBuilds obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfBuilds o && Equals(o);
        }
    }
}
