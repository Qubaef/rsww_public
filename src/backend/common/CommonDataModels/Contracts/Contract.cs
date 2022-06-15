using MassTransit;

namespace Shared.Contracts.Common;

public class RequestResultClient<Request, Result> where Request : class where Result : class
{
    private readonly IRequestClient<Request> _client;

    public RequestResultClient(IRequestClient<Request> client)
    {
        _client = client;
    }

    public async Task<Result> getResponse(Request request)
    {
        var response = await _client.GetResponse<Result>(request);
        return response.Message;
    }
}
public class Contract
{
    public Guid Guid { get; set; } = Guid.NewGuid();
}
