using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Text.Json;

namespace CleanArchitectrure.Application.UseCases.Commons.Behaviours
{
    public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly Stopwatch _timer;
        private readonly ILogger<TRequest> _logger;

        public PerformanceBehaviour( ILogger<TRequest> logger)
        {
            _timer = new Stopwatch() ?? throw new ArgumentNullException(nameof(Stopwatch));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            _timer.Start();
            var response = await next();
            _timer.Stop();

            var elapsedMilliseconds = _timer.ElapsedMilliseconds;
            if (elapsedMilliseconds > 10)
            {
                var requestName = typeof(TRequest).Name;
                _logger.LogWarning("Clean Architecture Long Running: {name} ({elapsedMilliseconds} milliseconds) {@request}",
                    requestName,
                    elapsedMilliseconds,
                    JsonSerializer.Serialize(request));
            }
            return response;
        }
    }
}
