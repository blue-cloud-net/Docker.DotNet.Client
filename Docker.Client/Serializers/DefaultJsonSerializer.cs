using System.Text.Json;

using Docker.Client.Abstractions.Serializers;

namespace Docker.Client.Serializers;

/// <summary>
/// 默认的 Json 序列化器
/// </summary>
public class DefaultJsonSerializer : IJsonSerializer
{
    /// <summary>
    /// 默认选项的Json序列化器
    /// </summary>
    public DefaultJsonSerializer()
    {
        this.JsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
    }

    /// <summary>
    /// Json序列化选项
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; set; }

    /// <inheritdoc/>
    public async ValueTask<T?> DeserializeAsync<T>(Stream stream, CancellationToken cancellationToken = default)
    {
        return await JsonSerializer.DeserializeAsync<T>(stream, this.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public T? DeserializeObject<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, this.JsonSerializerOptions);
    }

    /// <inheritdoc/>
    public Task SerializeAsync<T>(T value, Stream stream, CancellationToken cancellationToken = default)
    {
        return JsonSerializer.SerializeAsync(stream, value, this.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public string SerializeObject<T>(T value)
    {
        return JsonSerializer.Serialize(value, this.JsonSerializerOptions);
    }
}
