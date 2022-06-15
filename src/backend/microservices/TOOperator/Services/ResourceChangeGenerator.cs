using MassTransit;
using Shared.Contracts;
using Shared.DataModels.Hotel;
using Shared.DataModels.Offer;

namespace TOOperator.Services;
public class ResourceChangeGenerator
{
    private Random _Random;
    private readonly IBus _Bus;

    private readonly int size = 10;
    public readonly List<TourOperatorUpdate> updateHistory;

    private readonly ILogger<ResourceChangeGenerator> _logger;

    private CancellationTokenSource? source = null;

    public ResourceChangeGenerator(IBus bus, ILogger<ResourceChangeGenerator> logger)
    {
        updateHistory = new List<TourOperatorUpdate>();
        _Random = new Random();
        _Bus = bus;
        _logger = logger;
    }

    public void AddToHistory(TourOperatorUpdate update)
    {
        updateHistory.Add(update);
        if (updateHistory.Count > size)
            updateHistory.RemoveAt(0);
    }

    public async Task Modify(IEnumerable<Offer> offers)
    {
        if (source != null)
        {
            source.Cancel();
        }
        source = new CancellationTokenSource();

        try
        {
            await ModifyTask(offers, source.Token);
        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation("Task Cancelled");
        }
    }

    public List<TourOperatorUpdate> GetUpdateHistory()
    {
        return new List<TourOperatorUpdate>(updateHistory);
    }

    public async Task ModifyTask(IEnumerable<Offer> offers, CancellationToken token)
    {
        var modificationChance = 10;
        var shuffledOffers = offers.OrderBy(x => _Random.Next());
        foreach (var offer in shuffledOffers)
        {
            token.ThrowIfCancellationRequested();

            if (_Random.Next(100) + 1 <= modificationChance)
            {
                _logger.LogInformation("Waiting 3-10 seconds before modifying offer");
                await Task.Delay(_Random.Next(3000, 10000), token);
                token.ThrowIfCancellationRequested();

                switch (_Random.Next(3))
                {
                    case 0:
                        if (_Random.Next(2) == 0)
                        {
                            var update = new UpdateTransport
                            {
                                Id = offer.TransportTo.TransportId,
                                NewPrice = _Random.Next(100, 201),
                                NewAvailableSeats = null
                            };
                            await _Bus.Publish(update);
                            AddToHistory(update);
                        }
                        else
                        {
                            var update = new UpdateTransport
                            {
                                Id = offer.TransportTo.TransportId,
                                NewPrice = null,
                                NewAvailableSeats = _Random.Next(30, 120)
                            };
                            await _Bus.Publish(update);
                            AddToHistory(update);
                        }
                        break;

                    case 1:
                        if (_Random.Next(2) == 0)
                        {
                            var update = new UpdateTransport
                            {
                                Id = offer.TransportBack.TransportId,
                                NewPrice = _Random.Next(100, 201),
                                NewAvailableSeats = null
                            };
                            await _Bus.Publish(update);
                            AddToHistory(update);
                        }
                        else
                        {
                            var update = new UpdateTransport
                            {
                                Id = offer.TransportBack.TransportId,
                                NewPrice = null,
                                NewAvailableSeats = _Random.Next(30, 120)
                            };
                            await _Bus.Publish(update);
                            AddToHistory(update);
                        }
                        break;

                    case 2:
                        if (_Random.Next(2) == 0)
                        {
                            var update = new UpdateHotel
                            {
                                Id = offer.Hotel.HotelId,
                                NewBasePrice = _Random.Next(1000, 3500),
                                RoomType = null,
                                NewCount = null
                            };
                            await _Bus.Publish(update);
                            AddToHistory(update);
                        }
                        else
                        {
                            var values = Enum.GetValues(typeof(RoomType));
                            var update = new UpdateHotel
                            {
                                Id = offer.Hotel.HotelId,
                                NewBasePrice = null,
                                RoomType = (RoomType)values.GetValue(_Random.Next(values.Length)),
                                NewCount = _Random.Next(5)
                            };
                            await _Bus.Publish(update);
                            AddToHistory(update);
                        }
                        break;
                }

            }
        }

    }
}
