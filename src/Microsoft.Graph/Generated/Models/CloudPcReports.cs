using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcReports : Entity, IParsable {
        /// <summary>The exportJobs property</summary>
        public List<CloudPcExportJob> ExportJobs {
            get { return BackingStore?.Get<List<CloudPcExportJob>>("exportJobs"); }
            set { BackingStore?.Set("exportJobs", value); }
        }
        /// <summary>
        /// Instantiates a new CloudPcReports and sets the default values.
        /// </summary>
        public CloudPcReports() : base() {
            OdataType = "#microsoft.graph.cloudPcReports";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcReports CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcReports();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exportJobs", n => { ExportJobs = n.GetCollectionOfObjectValues<CloudPcExportJob>(CloudPcExportJob.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CloudPcExportJob>("exportJobs", ExportJobs);
        }
    }
}
