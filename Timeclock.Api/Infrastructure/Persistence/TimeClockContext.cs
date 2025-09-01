using Microsoft.EntityFrameworkCore;

namespace Timeclock.Api.Infrastructure.Persistence;

public class TimeClockContext(DbContextOptions options) : DbContext(options)
{
}
