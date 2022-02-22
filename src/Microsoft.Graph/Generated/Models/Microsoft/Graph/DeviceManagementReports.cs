using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceManagementReports : Entity, IParsable {
        /// <summary>Entity representing the configuration of a cached report</summary>
        public List<DeviceManagementCachedReportConfiguration> CachedReportConfigurations { get; set; }
        /// <summary>Entity representing a job to export a report</summary>
        public List<DeviceManagementExportJob> ExportJobs { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"cachedReportConfigurations", (o,n) => { (o as DeviceManagementReports).CachedReportConfigurations = n.GetCollectionOfObjectValues<DeviceManagementCachedReportConfiguration>().ToList(); } },
                {"exportJobs", (o,n) => { (o as DeviceManagementReports).ExportJobs = n.GetCollectionOfObjectValues<DeviceManagementExportJob>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementCachedReportConfiguration>("cachedReportConfigurations", CachedReportConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceManagementExportJob>("exportJobs", ExportJobs);
        }
    }
}
