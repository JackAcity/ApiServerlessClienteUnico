using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Time
{
    public class TimeProvider : ITimeProvider
    {
        private readonly TimeZoneInfo _peruTimeZone;

        public TimeProvider()
        {
            var isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            var timeZoneId = isWindows ? "SA Pacific Standard Time" : "America/Lima";
            _peruTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        }

        public DateTime NowPeru => TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _peruTimeZone);
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
