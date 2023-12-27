using Docker.Client.HttpRequest;

namespace Docker.Client.Abstractions;

/// <summary>
/// Docker 客户端
/// </summary>
public interface IDockerClient
{
    Task<DockerApiResponse> SendRequestAsync(
        string path,
        IRequestContent body,
        IDictionary<string, string> headers,
        HttpMethod? method = null,
        CancellationToken cancellationToken = default);
}
