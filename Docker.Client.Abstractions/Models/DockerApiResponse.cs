using System.Net;

namespace Docker.Client.Abstractions.Models;

/// <summary>
/// Docker API 响应
/// </summary>
public record struct DockerApiResponse(HttpStatusCode StatusCode, string ResponseBody);
