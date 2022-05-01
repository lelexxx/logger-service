using LoggerService.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace LoggerService.Services;

public class LoggerServiceBase : ILoggerService
{
    protected ILogger Logger { get; }

    protected LoggerServiceBase(ILogger logger)
    {
        Logger = logger;
    }

    public TResult? Execute<TResult>(Func<TResult?> method)
    {
        try
        {
            return method();
        }
        catch (Exception e)
        {
            Logger.LogError(e, "Exception non gérée");
            throw;
        }
    }
}