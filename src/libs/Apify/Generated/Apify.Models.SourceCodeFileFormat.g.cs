
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum SourceCodeFileFormat
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceCodeFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceCodeFileFormat value)
        {
            return value switch
            {
                SourceCodeFileFormat.Base64 => "BASE64",
                SourceCodeFileFormat.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceCodeFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "BASE64" => SourceCodeFileFormat.Base64,
                "TEXT" => SourceCodeFileFormat.Text,
                _ => null,
            };
        }
    }
}