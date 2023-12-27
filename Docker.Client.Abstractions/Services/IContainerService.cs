using Docker.Client.Abstractions.Models.Containers;

namespace Docker.DotNet.Sdk.Services;

public interface IContainerService
{
    /// <summary>
    /// 创建容器
    /// </summary>
    /// <param name="containerCreateParameters">容器创建参数</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>创建的容器</returns>
    Task<ContainerCreateParameters> CreateAsync(ContainerCreateParameters containerCreateParameters, CancellationToken cancellationToken = default);

    /// <summary>
    /// 启动容器
    /// </summary>
    /// <param name="containerId">容器 Id</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>启动的容器</returns>
    Task<bool> StartAsync(string containerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// 停止容器
    /// </summary>
    /// <param name="containerId">容器 Id</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>停止的容器</returns>
    Task<bool> StopAsync(string containerId, CancellationToken cancellationToken = default);

    ///  <summary>
    /// 删除容器
    /// </summary>
    /// <param name="containerId">容器 Id</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>删除的容器</returns>
    Task RemoveAsync(string containerId, CancellationToken cancellationToken = default);

    ///  <summary>
    /// 获取容器信息
    /// </summary>
    /// <param name="containerId">容器 Id</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>容器</returns>
    Task<ContainerInspectResponse> InspectAsync(string containerId, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取容器日志
    /// </summary>
    /// <param name="containerId">容器 Id</param>
    /// <param name="cancellationToken">取消令牌</param>
    /// <returns>容器日志</returns>
    Task<Stream> GetLogsAsync(string containerId, CancellationToken cancellationToken = default);
}
