
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public enum StorageOwnership
    {
        /// <summary>
        ///
        /// </summary>
        OwnedByMe,
        /// <summary>
        ///
        /// </summary>
        SharedWithMe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StorageOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StorageOwnership value)
        {
            return value switch
            {
                StorageOwnership.OwnedByMe => "ownedByMe",
                StorageOwnership.SharedWithMe => "sharedWithMe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StorageOwnership? ToEnum(string value)
        {
            return value switch
            {
                "ownedByMe" => StorageOwnership.OwnedByMe,
                "sharedWithMe" => StorageOwnership.SharedWithMe,
                _ => null,
            };
        }
    }
}