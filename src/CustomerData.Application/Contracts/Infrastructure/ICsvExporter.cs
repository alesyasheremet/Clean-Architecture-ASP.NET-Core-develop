using CustomerData.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace CustomerData.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
