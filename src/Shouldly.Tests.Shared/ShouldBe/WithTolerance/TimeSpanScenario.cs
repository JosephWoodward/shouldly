using System;
using Shouldly.Tests.Strings;
using Xunit;

namespace Shouldly.Tests.ShouldBe.WithTolerance
{
    public class TimeSpanScenario
    {
        [Fact]
        public void TimeSpanScenarioShouldFail()
        {
            var timeSpan = TimeSpan.FromHours(1);
            Verify.ShouldFail(() =>
                timeSpan.ShouldBe(timeSpan.Add(TimeSpan.FromHours(1.1d)), TimeSpan.FromHours(1)),

errorWithSource:
@"timeSpan (01:00:00)
    should be within
01:00:00
    of
02:06:00
    but had difference of
01:06:00",

errorWithoutSource:
@"timeSpan (01:00:00)
    should be within
01:00:00
    of
02:06:00
    but had difference of
01:06:00");
        }

        [Fact]
        public void ShouldPass()
        {
            var timeSpan = TimeSpan.FromHours(1);
            timeSpan.ShouldBe(timeSpan.Add(TimeSpan.FromHours(1.1d)), TimeSpan.FromHours(1.5d));
        }
    }
}