using Docker.Client.Abstractions.Models.Images;

namespace Docker.Client.Abstractions.Services;

/// <summary>
/// 镜像服务
/// </summary>
public interface IImageService
{
    /// <summary>
    /// 列出镜像
    /// </summary>
    /// <param name="parameters"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IList<ImagesListResponse>> ListImagesAsync(ImagesListParameters parameters, CancellationToken cancellationToken);
}
