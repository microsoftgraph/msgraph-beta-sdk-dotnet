using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class CloudPcServicePlan : Entity, IParsable {
        /// <summary>The name for the service plan. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The size of the RAM in GB. Read-only.</summary>
        public int? RamInGB { get; set; }
        /// <summary>The size of the OS Disk in GB. Read-only.</summary>
        public int? StorageInGB { get; set; }
        /// <summary>The type of the service plan. Possible values are: enterprise, business, unknownFutureValue. Read-only.</summary>
        public CloudPcServicePlanType? Type { get; set; }
        /// <summary>The size of the user profile disk in GB. Read-only.</summary>
        public int? UserProfileInGB { get; set; }
        /// <summary>The number of vCPUs. Read-only.</summary>
        public int? VCpuCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcServicePlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcServicePlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as CloudPcServicePlan).DisplayName = n.GetStringValue(); } },
                {"ramInGB", (o,n) => { (o as CloudPcServicePlan).RamInGB = n.GetIntValue(); } },
                {"storageInGB", (o,n) => { (o as CloudPcServicePlan).StorageInGB = n.GetIntValue(); } },
                {"type", (o,n) => { (o as CloudPcServicePlan).Type = n.GetEnumValue<CloudPcServicePlanType>(); } },
                {"userProfileInGB", (o,n) => { (o as CloudPcServicePlan).UserProfileInGB = n.GetIntValue(); } },
                {"vCpuCount", (o,n) => { (o as CloudPcServicePlan).VCpuCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("ramInGB", RamInGB);
            writer.WriteIntValue("storageInGB", StorageInGB);
            writer.WriteEnumValue<CloudPcServicePlanType>("type", Type);
            writer.WriteIntValue("userProfileInGB", UserProfileInGB);
            writer.WriteIntValue("vCpuCount", VCpuCount);
        }
    }
}
