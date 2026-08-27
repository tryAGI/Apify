#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ListOfTasks : global::System.IEquatable<ListOfTasks>
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
        public global::Apify.ListOfTasksVariant2? ListOfTasksVariant2 { get; init; }
#else
        public global::Apify.ListOfTasksVariant2? ListOfTasksVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListOfTasksVariant2))]
#endif
        public bool IsListOfTasksVariant2 => ListOfTasksVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListOfTasksVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Apify.ListOfTasksVariant2? value)
        {
            value = ListOfTasksVariant2;
            return IsListOfTasksVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Apify.ListOfTasksVariant2 PickListOfTasksVariant2() => IsListOfTasksVariant2
            ? ListOfTasksVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListOfTasksVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListOfTasks(global::Apify.PaginationResponse value) => new ListOfTasks((global::Apify.PaginationResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.PaginationResponse?(ListOfTasks @this) => @this.PaginationResponse;

        /// <summary>
        ///
        /// </summary>
        public ListOfTasks(global::Apify.PaginationResponse? value)
        {
            PaginationResponse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListOfTasks FromPaginationResponse(global::Apify.PaginationResponse? value) => new ListOfTasks(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ListOfTasks(global::Apify.ListOfTasksVariant2 value) => new ListOfTasks((global::Apify.ListOfTasksVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Apify.ListOfTasksVariant2?(ListOfTasks @this) => @this.ListOfTasksVariant2;

        /// <summary>
        ///
        /// </summary>
        public ListOfTasks(global::Apify.ListOfTasksVariant2? value)
        {
            ListOfTasksVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ListOfTasks FromListOfTasksVariant2(global::Apify.ListOfTasksVariant2? value) => new ListOfTasks(value);

        /// <summary>
        ///
        /// </summary>
        public ListOfTasks(
            global::Apify.PaginationResponse? paginationResponse,
            global::Apify.ListOfTasksVariant2? listOfTasksVariant2
            )
        {
            PaginationResponse = paginationResponse;
            ListOfTasksVariant2 = listOfTasksVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ListOfTasksVariant2 as object ??
            PaginationResponse as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PaginationResponse?.ToString() ??
            ListOfTasksVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPaginationResponse && IsListOfTasksVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Apify.PaginationResponse, TResult>? paginationResponse = null,
            global::System.Func<global::Apify.ListOfTasksVariant2, TResult>? listOfTasksVariant2 = null,
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
            else if (IsListOfTasksVariant2 && listOfTasksVariant2 != null)
            {
                return listOfTasksVariant2(ListOfTasksVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,

            global::System.Action<global::Apify.ListOfTasksVariant2>? listOfTasksVariant2 = null,
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
            else if (IsListOfTasksVariant2)
            {
                listOfTasksVariant2?.Invoke(ListOfTasksVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Apify.PaginationResponse>? paginationResponse = null,
            global::System.Action<global::Apify.ListOfTasksVariant2>? listOfTasksVariant2 = null,
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
            else if (IsListOfTasksVariant2)
            {
                listOfTasksVariant2?.Invoke(ListOfTasksVariant2!);
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
                ListOfTasksVariant2,
                typeof(global::Apify.ListOfTasksVariant2),
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
        public bool Equals(ListOfTasks other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Apify.PaginationResponse?>.Default.Equals(PaginationResponse, other.PaginationResponse) &&
                global::System.Collections.Generic.EqualityComparer<global::Apify.ListOfTasksVariant2?>.Default.Equals(ListOfTasksVariant2, other.ListOfTasksVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ListOfTasks obj1, ListOfTasks obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListOfTasks>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListOfTasks obj1, ListOfTasks obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListOfTasks o && Equals(o);
        }
    }
}
