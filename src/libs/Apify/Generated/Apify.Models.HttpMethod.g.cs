
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Connect,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Head,
        /// <summary>
        /// 
        /// </summary>
        Options,
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HttpMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HttpMethod value)
        {
            return value switch
            {
                HttpMethod.Connect => "CONNECT",
                HttpMethod.Delete => "DELETE",
                HttpMethod.Get => "GET",
                HttpMethod.Head => "HEAD",
                HttpMethod.Options => "OPTIONS",
                HttpMethod.Patch => "PATCH",
                HttpMethod.Post => "POST",
                HttpMethod.Put => "PUT",
                HttpMethod.Trace => "TRACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HttpMethod? ToEnum(string value)
        {
            return value switch
            {
                "CONNECT" => HttpMethod.Connect,
                "DELETE" => HttpMethod.Delete,
                "GET" => HttpMethod.Get,
                "HEAD" => HttpMethod.Head,
                "OPTIONS" => HttpMethod.Options,
                "PATCH" => HttpMethod.Patch,
                "POST" => HttpMethod.Post,
                "PUT" => HttpMethod.Put,
                "TRACE" => HttpMethod.Trace,
                _ => null,
            };
        }
    }
}