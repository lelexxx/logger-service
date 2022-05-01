namespace LoggerService.Services.Interfaces;

public interface ILoggerService
{
    TResult? Execute<TResult>(Func<TResult?> method);
}