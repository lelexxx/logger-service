namespace LoggerService.Services.Interfaces;

public interface ILoggerService
{
    TResult? Execute<TResult>(Func<TResult?> method);

    ValueTask<TResult?> ExecuteAsync<TResult>(Func<ValueTask<TResult?>> method);
}