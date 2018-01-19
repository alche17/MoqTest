using System;
using System.Collections.Generic;

namespace UnitTest.Interfaces
{
    public interface ISurvey
    {
        string Name { get; set; }
        int RespondentCount { get; set; }
        IList<string> Questions { get; }
    }

    public interface ISurveryRepository
    {
        IEnumerable<ISurvey> Surveys { get; }
    }
}
