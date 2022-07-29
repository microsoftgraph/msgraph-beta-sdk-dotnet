using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcSupportedRegion : Entity, IParsable {
        /// <summary>The name for the supported region. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The status of the supported region. Possible values are: available, restricted, unavailable, unknownFutureValue. Read-only.</summary>
        public CloudPcSupportedRegionStatus? RegionStatus {
            get { return BackingStore?.Get<CloudPcSupportedRegionStatus?>("regionStatus"); }
            set { BackingStore?.Set("regionStatus", value); }
        }
        /// <summary>
        /// Instantiates a new CloudPcSupportedRegion and sets the default values.
        /// </summary>
        public CloudPcSupportedRegion() : base() {
            OdataType = "#microsoft.graph.cloudPcSupportedRegion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcSupportedRegion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcSupportedRegion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"regionStatus", n => { RegionStatus = n.GetEnumValue<CloudPcSupportedRegionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<CloudPcSupportedRegionStatus>("regionStatus", RegionStatus);
        }
    }
}
