
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing Actor build data.
    /// </summary>
    public sealed partial class BuildResponse
    {
        /// <summary>
        /// Example: {"id":"HG7ML7M8z78YcAPEB","actId":"janedoe~my-actor","userId":"klmdEpoiojmdEMlk3","startedAt":"2019-11-30T07:34:24.202Z","finishedAt":"2019-12-12T09:30:12.202Z","status":"SUCCEEDED","meta":{"origin":"WEB","clientIp":"172.234.12.34","userAgent":"Mozilla/5.0 (iPad)"},"stats":{"durationMillis":1000,"runTimeSecs":45.718,"computeUnits":0.012699444444444444},"options":{"useCache":false,"betaPackages":false,"memoryMbytes":1024,"diskMbytes":2048},"usage":{"ACTOR_COMPUTE_UNITS":0.08},"usageTotalUsd":0.02,"usageUsd":{"ACTOR_COMPUTE_UNITS":0.02},"inputSchema":"{\\n  \u0022title\u0022: \u0022Schema for ...\u0022}","readme":"# Magic Actor\\nThis Actor is magic.","buildNumber":"0.1.1","actorDefinition":{"actorSpecification":1,"name":"example-actor","version":"1.0","buildTag":"latest","environmentVariables":{"DEBUG_MODE":"false"},"input":{"type":"object","properties":{"prompt":{"type":"string","description":"The text prompt to generate completions for."},"maxTokens":{"type":"integer","description":"The maximum number of tokens to generate."}},"required":["prompt"]},"storages":{"dataset":{"type":"object","$schema":"http://json-schema.org/draft-07/schema#","properties":{"id":{"type":"string","description":"Unique identifier for the generated text."},"text":{"type":"string","description":"The generated text output from the model."}},"required":["id","text"]}},"minMemoryMbytes":512,"maxMemoryMbytes":2048,"usesStandbyMode":false}}
        /// </summary>
        /// <example>{"id":"HG7ML7M8z78YcAPEB","actId":"janedoe~my-actor","userId":"klmdEpoiojmdEMlk3","startedAt":"2019-11-30T07:34:24.202Z","finishedAt":"2019-12-12T09:30:12.202Z","status":"SUCCEEDED","meta":{"origin":"WEB","clientIp":"172.234.12.34","userAgent":"Mozilla/5.0 (iPad)"},"stats":{"durationMillis":1000,"runTimeSecs":45.718,"computeUnits":0.012699444444444444},"options":{"useCache":false,"betaPackages":false,"memoryMbytes":1024,"diskMbytes":2048},"usage":{"ACTOR_COMPUTE_UNITS":0.08},"usageTotalUsd":0.02,"usageUsd":{"ACTOR_COMPUTE_UNITS":0.02},"inputSchema":"{\\n  \u0022title\u0022: \u0022Schema for ...\u0022}","readme":"# Magic Actor\\nThis Actor is magic.","buildNumber":"0.1.1","actorDefinition":{"actorSpecification":1,"name":"example-actor","version":"1.0","buildTag":"latest","environmentVariables":{"DEBUG_MODE":"false"},"input":{"type":"object","properties":{"prompt":{"type":"string","description":"The text prompt to generate completions for."},"maxTokens":{"type":"integer","description":"The maximum number of tokens to generate."}},"required":["prompt"]},"storages":{"dataset":{"type":"object","$schema":"http://json-schema.org/draft-07/schema#","properties":{"id":{"type":"string","description":"Unique identifier for the generated text."},"text":{"type":"string","description":"The generated text output from the model."}},"required":["id","text"]}},"minMemoryMbytes":512,"maxMemoryMbytes":2048,"usesStandbyMode":false}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.Build Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"id":"HG7ML7M8z78YcAPEB","actId":"janedoe~my-actor","userId":"klmdEpoiojmdEMlk3","startedAt":"2019-11-30T07:34:24.202Z","finishedAt":"2019-12-12T09:30:12.202Z","status":"SUCCEEDED","meta":{"origin":"WEB","clientIp":"172.234.12.34","userAgent":"Mozilla/5.0 (iPad)"},"stats":{"durationMillis":1000,"runTimeSecs":45.718,"computeUnits":0.012699444444444444},"options":{"useCache":false,"betaPackages":false,"memoryMbytes":1024,"diskMbytes":2048},"usage":{"ACTOR_COMPUTE_UNITS":0.08},"usageTotalUsd":0.02,"usageUsd":{"ACTOR_COMPUTE_UNITS":0.02},"inputSchema":"{\\n  \u0022title\u0022: \u0022Schema for ...\u0022}","readme":"# Magic Actor\\nThis Actor is magic.","buildNumber":"0.1.1","actorDefinition":{"actorSpecification":1,"name":"example-actor","version":"1.0","buildTag":"latest","environmentVariables":{"DEBUG_MODE":"false"},"input":{"type":"object","properties":{"prompt":{"type":"string","description":"The text prompt to generate completions for."},"maxTokens":{"type":"integer","description":"The maximum number of tokens to generate."}},"required":["prompt"]},"storages":{"dataset":{"type":"object","$schema":"http://json-schema.org/draft-07/schema#","properties":{"id":{"type":"string","description":"Unique identifier for the generated text."},"text":{"type":"string","description":"The generated text output from the model."}},"required":["id","text"]}},"minMemoryMbytes":512,"maxMemoryMbytes":2048,"usesStandbyMode":false}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildResponse(
            global::Apify.Build data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildResponse" /> class.
        /// </summary>
        public BuildResponse()
        {
        }

    }
}