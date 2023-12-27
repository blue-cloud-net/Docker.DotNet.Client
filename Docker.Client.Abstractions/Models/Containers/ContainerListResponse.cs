namespace Docker.Client.Abstractions.Models.Containers;

/// <summary>
/// 容器列表响应
/// </summary>
public class ContainerListResponse
{
    /// <summary>
    /// 容器ID
    /// </summary>
    public string Id { get; set; } = String.Empty;
}
