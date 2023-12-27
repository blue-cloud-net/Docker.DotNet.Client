namespace Docker.Client.Abstractions.Models.Containers;

/// <summary>
/// 容器创建响应
/// </summary>
public class ContainerCreateResponse
{
    /// <summary>
    /// 容器ID
    /// </summary>
    public string Id { get; set; } = String.Empty;
}
