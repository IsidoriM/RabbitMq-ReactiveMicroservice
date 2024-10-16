﻿using System.Collections.Generic;

namespace ApiReportServices
{
    public class MemoryReportStorage : IMemoryReportStorage
    {
        private readonly IList<Report> reports = new List<Report>();

        public void Add(Report report)
        {
            reports.Add(report);
        }

        public IEnumerable<Report> Get()
        {
            return reports;
        }
    }


}
