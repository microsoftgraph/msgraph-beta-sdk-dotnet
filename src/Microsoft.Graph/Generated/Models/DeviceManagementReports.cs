using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementReports : Entity, IParsable {
        /// <summary>Entity representing the configuration of a cached report</summary>
        public List<DeviceManagementCachedReportConfiguration> CachedReportConfigurations {
            get { return BackingStore?.Get<List<DeviceManagementCachedReportConfiguration>>("cachedReportConfigurations"); }
            set { BackingStore?.Set("cachedReportConfigurations", value); }
        }
        /// <summary>Entity representing a job to export a report</summary>
        public List<DeviceManagementExportJob> ExportJobs {
            get { return BackingStore?.Get<List<DeviceManagementExportJob>>("exportJobs"); }
            set { BackingStore?.Set("exportJobs", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementReports and sets the default values.
        /// </summary>
        public DeviceManagementReports() : base() {
            OdataType = "#microsoft.graph.deviceManagementReports";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementReports CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementReports();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cachedReportConfigurations", n => { CachedReportConfigurations = n.GetCollectionOfObjectValues<DeviceManagementCachedReportConfiguration>(DeviceManagementCachedReportConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"exportJobs", n => { ExportJobs = n.GetCollectionOfObjectValues<DeviceManagementExportJob>(DeviceManagementExportJob.CreateFromDiscriminatorValue).ToList(); } },
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
