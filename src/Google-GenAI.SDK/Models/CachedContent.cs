namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Content that has been preprocessed and can be used in subsequent request to GenerativeService.  Cached content can be only used with model it was created for.
/// </summary>
public class CachedContent
{
    /// <summary>
    /// Optional. Immutable. The user-generated meaningful display name of the cached content. Maximum 128 Unicode characters.
    /// </summary>
    public string? DisplayName { get; init; }

    /// <summary>
    /// Output only. Identifier. The resource name referring to the cached content. Format: `cachedContents/{id}`
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Optional. Input only. Immutable. The content to cache.
    /// </summary>
    public IList<Content>? Contents { get; init; }

    /// <summary>
    /// Output only. Creation time of the cache entry.
    /// </summary>
    public System.DateTime? CreateTime { get; init; }

    /// <summary>
    /// Timestamp in UTC of when this resource is considered expired. This is *always* provided on output, regardless of what was sent on input.
    /// </summary>
    public System.DateTime? ExpireTime { get; init; }

    /// <summary>
    /// Output only. When the cache entry was last updated in UTC time.
    /// </summary>
    public System.DateTime? UpdateTime { get; init; }

    /// <summary>
    /// Input only. New TTL for this resource, input only.
    /// </summary>
    public string? Ttl { get; init; }

    /// <summary>
    /// Optional. Input only. Immutable. Developer set system instruction. Currently text only.
    /// </summary>
    public Content? SystemInstruction { get; init; }

    /// <summary>
    /// Optional. Input only. Immutable. A list of `Tools` the model may use to generate the next response
    /// </summary>
    public IList<Tool>? Tools { get; init; }

    /// <summary>
    /// Output only. Metadata on the usage of the cached content.
    /// </summary>
    public CachedContentUsageMetadata? UsageMetadata { get; init; }

    /// <summary>
    /// Required. Immutable. The name of the `Model` to use for cached content Format: `models/{model}`
    /// </summary>
    public required string Model { get; init; }

    /// <summary>
    /// Optional. Input only. Immutable. Tool config. This config is shared for all tools.
    /// </summary>
    public ToolConfig? ToolConfig { get; init; }
}