using System.Runtime.InteropServices;

namespace Docker.Client;

/// <summary>
/// Docker 客户端构造工厂
/// </summary>
public class DockerClientFactory : IDockerClientFactory
{
    public DockerClientFactory(
        Uri? endpoint = null)
    {
        this.Configuration = new();
        this.Configuration.Endpoint = endpoint ?? GetLocalDockerEndpoint();
    }

    public DockerClientConfiguration Configuration { get; set; }

    private static Uri GetLocalDockerEndpoint()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return new Uri("npipe://./pipe/docker_engine");
        }
        else
        {
            return new Uri("unix:/var/run/docker.sock");
        }
    }

    public IDockerClient CreateClient()
        => new DockerClient(this.Configuration);
}
