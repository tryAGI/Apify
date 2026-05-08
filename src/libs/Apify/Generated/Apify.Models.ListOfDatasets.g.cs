#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListOfDatasets : global::System.IEquatable<ListOfDatasets>
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
        public global::Apify.ListOfDatasetsVariant2? ListOfDatasetsVariant2 { get; init; }
#else
        public global::Apify.ListOfDatasetsVariant2? ListOfDatasetsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfDatasetsVariant2))]
#endif
        public bool IsListOfDatasetsVariant2 => ListOfDatasetsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickListOfDatasetsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfDatasetsVariant2? value)
        {
            value = ListOfDatasetsVariant2;
            return IsListOfDatasetsVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfDatasets(global::Apify.PaginationResponse value) => new ListOfDatasets((global::Apify.PaginationResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfDatasets @this) => @this.PaginationResponse;

        /// <summary>
        /// 
        /// </summary>
        public ListOfDatasets(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListOfDatasets(global::Apify.ListOfDatasetsVariant2 value) => new ListOfDatasets((global::Apify.ListOfDatasetsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Apify.ListOfDatasetsVariant2?(ListOfDatasets @this) => @this.ListOfDatasetsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ListOfDatasets(global::Apify.ListOfDatasetsVariant2? value)
        {
            ListOfDatasetsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListOfDatasets(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfDatasetsVariant2? listOfDatasetsVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfDatasetsVariant2 = listOfDatasetsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ListOfDatasetsVariant2 as object ??
            PaginationResponse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfDatasetsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfDatasetsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfDatasetsVariant2, TResult>? listOfDatasetsVariant2 = null,
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
            else if (IsListOfDatasetsVariant2 && listOfDatasetsVariant2 != null)
            {
                return listOfDatasetsVariant2(ListOfDatasetsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfDatasetsVariant2>? listOfDatasetsVariant2 = null,
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
            else if (IsListOfDatasetsVariant2)
            {
                listOfDatasetsVariant2?.Invoke(ListOfDatasetsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfDatasetsVariant2>? listOfDatasetsVariant2 = null,
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
            else if (IsListOfDatasetsVariant2)
            {
                listOfDatasetsVariant2?.Invoke(ListOfDatasetsVariant2!);
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
                ListOfDatasetsVariant2,
                typeof(global::Apify.ListOfDatasetsVariant2),
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
        public bool Equals(ListOfDatasets other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfDatasetsVariant2?>.Default.Equals(ListOfDatasetsVariant2, other.ListOfDatasetsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListOfDatasets obj1, ListOfDatasets obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfDatasets>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListOfDatasets obj1, ListOfDatasets obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfDatasets o && Equals(o);
        }
    }
}
