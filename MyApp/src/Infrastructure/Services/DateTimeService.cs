using MyApp.Application.Common.Interfaces;

namespace MyApp.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
