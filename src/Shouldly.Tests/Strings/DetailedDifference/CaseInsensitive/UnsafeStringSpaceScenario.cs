﻿using Xunit;

namespace Shouldly.Tests.Strings.DetailedDifference.CaseInsensitive
{
    public class UnsafeStringSpaceScenario
    {
        [Fact]
        public void UnsafeStringSpaceScenarioShouldFail()
        {
            Verify.ShouldFail(() =>
    "StringOne Space".ShouldBe("Stringone\tSpace", StringCompareShould.IgnoreCase),

    errorWithSource:
@"""StringOne Space""
    should be
""Stringone\tSpace""
    but was
""StringOne Space""
    difference
Case Insensitive and Line Ending Sensitive Comparison
Difference     |                                               |                            
                |                                              \|/                           
Index          | 0    1    2    3    4    5    6    7    8    9    10   11   12   13   14   
Expected Value | S    t    r    i    n    g    o    n    e    \t   S    p    a    c    e    
Actual Value   | S    t    r    i    n    g    O    n    e    \s   S    p    a    c    e    
Expected Code  | 83   116  114  105  110  103  111  110  101  9    83   112  97   99   101  
Actual Code    | 83   116  114  105  110  103  79   110  101  32   83   112  97   99   101  ",

errorWithoutSource:
@"""StringOne Space""
    should be
""Stringone\tSpace""
    but was
""StringOne Space""
    difference
Case Insensitive and Line Ending Sensitive Comparison
Difference     |                                               |                            
                |                                              \|/                           
Index          | 0    1    2    3    4    5    6    7    8    9    10   11   12   13   14   
Expected Value | S    t    r    i    n    g    o    n    e    \t   S    p    a    c    e    
Actual Value   | S    t    r    i    n    g    O    n    e    \s   S    p    a    c    e    
Expected Code  | 83   116  114  105  110  103  111  110  101  9    83   112  97   99   101  
Actual Code    | 83   116  114  105  110  103  79   110  101  32   83   112  97   99   101  ");
        }

        [Fact]
        public void ShouldPass()
        {
            "StringOne Space".ShouldBe("Stringone Space", StringCompareShould.IgnoreCase);
        }
    }
}
