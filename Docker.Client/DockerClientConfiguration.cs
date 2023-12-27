namespace Docker.Client;

/// <summary>
/// Docker 客户端配置
/// </summary>
public class DockerClientConfiguration
{
    public DockerClientConfiguration()
    {
    }

    /// <summary>
    /// Docker Api 节点
    /// </summary>
    public Uri Endpoint { get; internal set; } = default!;
}
