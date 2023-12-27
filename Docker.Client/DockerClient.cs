using Docker.Client.Abstractions.Models;
using Docker.Client.Abstractions.Serializers;
using Docker.Client.HttpRequest;
using Docker.Client.Serializers;
using Docker.Client.Services;

namespace Docker.Client;

/// <inheritdoc cref="IDockerClient"/>
public class DockerClient : IDockerClient, IDisposable
{
    public DockerClient(
        DockerClientConfiguration configuration)
    {
        this.Configuration = configuration;

        this.Serializer = new DefaultJsonSerializer();

        this.Image = new ImageService(this);

        var uri = this.Configuration.Endpoint;
        switch (uri.Scheme)
        {
            case "npipe":
            case "unix":
            case "tcp":
                throw new NotSupportedException($"不支持的协议：{uri.Scheme}");
            case "http":
            {
                this.MessageHandler = new HttpClientHandler
                {
                };
                break;
            }
            case "https":
                throw new NotSupportedException($"不支持的协议：{uri.Scheme}");
            default:
                throw new NotSupportedException($"不支持的协议：{uri.Scheme}");
        }
    }

    /// <summary>
    /// Docker 客户端配置
    /// </summary>
    public DockerClientConfiguration Configuration { get; }

    /// <summary>
    /// Json 序列化器
    /// </summary>
    public IJsonSerializer Serializer { get; }

    /// <summary>
    /// 消息处理器
    /// </summary>
    public HttpMessageHandler MessageHandler { get; }

    #region Services

    /// <summary>
    /// 镜像服务
    /// </summary>
    public IImageService Image { get; set; }

    #endregion Services

    public void Dispose()
    {
        this.MessageHandler.Dispose();
    }

    public Task<DockerApiResponse> SendRequestAsync(
        string path,
        IRequestContent body,
        IDictionary<string, string> headers,
        HttpMethod? method = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
