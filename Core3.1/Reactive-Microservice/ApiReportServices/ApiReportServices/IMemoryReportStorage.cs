using System.Collections.Generic;

namespace ApiReportServices
{
    public interface IMemoryReportStorage
    {
        void Add(Report report);
        IEnumerable<Report> Get();
    }

}
