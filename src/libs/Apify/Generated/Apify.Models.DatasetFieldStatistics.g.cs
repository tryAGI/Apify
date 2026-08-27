
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetFieldStatistics
    {
        /// <summary>
        /// Minimum value of the field. For numbers, this is calculated directly. For strings, this is the length of the shortest string. For arrays, this is the length of the shortest array. For objects, this is the number of keys in the smallest object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Maximum value of the field. For numbers, this is calculated directly. For strings, this is the length of the longest string. For arrays, this is the length of the longest array. For objects, this is the number of keys in the largest object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// How many items in the dataset have a null value for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nullCount")]
        public int? NullCount { get; set; }

        /// <summary>
        /// How many items in the dataset are `undefined`, meaning that for example empty string is not considered empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptyCount")]
        public int? EmptyCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFieldStatistics" /> class.
        /// </summary>
        /// <param name="min">
        /// Minimum value of the field. For numbers, this is calculated directly. For strings, this is the length of the shortest string. For arrays, this is the length of the shortest array. For objects, this is the number of keys in the smallest object.
        /// </param>
        /// <param name="max">
        /// Maximum value of the field. For numbers, this is calculated directly. For strings, this is the length of the longest string. For arrays, this is the length of the longest array. For objects, this is the number of keys in the largest object.
        /// </param>
        /// <param name="nullCount">
        /// How many items in the dataset have a null value for this field.
        /// </param>
        /// <param name="emptyCount">
        /// How many items in the dataset are `undefined`, meaning that for example empty string is not considered empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetFieldStatistics(
            double? min,
            double? max,
            int? nullCount,
            int? emptyCount)
        {
            this.Min = min;
            this.Max = max;
            this.NullCount = nullCount;
            this.EmptyCount = emptyCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFieldStatistics" /> class.
        /// </summary>
        public DatasetFieldStatistics()
        {
        }

    }
}