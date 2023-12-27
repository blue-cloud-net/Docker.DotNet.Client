namespace Docker.Client.Abstractions;

/// <summary>
/// Docker 客户端工厂
/// </summary>
public interface IDockerClientFactory
{
    IDockerClient CreateClient();
}
