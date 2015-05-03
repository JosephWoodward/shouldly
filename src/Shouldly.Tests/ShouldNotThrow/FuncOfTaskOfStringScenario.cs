﻿#if net40
using System;
using System.Threading;
using System.Threading.Tasks;
using Shouldly.Tests.TestHelpers;

namespace Shouldly.Tests.ShouldNotThrow
{
    public class FuncOfTaskOfStringScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            Should.NotThrow(() =>
            {
                var task = Task.Factory.StartNew<string>(() => { throw new RankException(); },
                    CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default);
                return task;
            }, "Some additional context");
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get
            {
                return "Should should not throw but threw System.RankException with message \"Attempted to operate on an array with the incorrect number of dimensions.\"" +
                        " Additional Info:" +
                        " Some additional context";
            }
        }

        protected override void ShouldPass()
        {
            Should.NotThrow(() =>
            {
                var task = Task.Factory.StartNew(() => "Foo",
                    CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default);
                return task;
            }).ShouldBe("Foo");
        }
    }
}
#endif