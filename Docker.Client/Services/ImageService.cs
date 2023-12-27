using Docker.Client.Abstractions.Models.Images;

namespace Docker.Client.Services;

/// <inheritdoc cref="IImageService"/>
public class ImageService : IImageService
{
    private readonly DockerClient _dockerClient;

    public ImageService(
        DockerClient dockerClient)
    {
        _dockerClient = dockerClient;
    }

    /// <inheritdoc/>
    public Task<IList<ImagesListResponse>> ListImagesAsync(
        ImagesListParameters parameters, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
