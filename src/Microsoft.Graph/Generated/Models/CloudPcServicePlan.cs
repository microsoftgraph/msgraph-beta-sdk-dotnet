using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcServicePlan : Entity, IParsable {
        /// <summary>The name for the service plan. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The size of the RAM in GB. Read-only.</summary>
        public int? RamInGB {
            get { return BackingStore?.Get<int?>(nameof(RamInGB)); }
            set { BackingStore?.Set(nameof(RamInGB), value); }
        }
        /// <summary>The size of the OS Disk in GB. Read-only.</summary>
        public int? StorageInGB {
            get { return BackingStore?.Get<int?>(nameof(StorageInGB)); }
            set { BackingStore?.Set(nameof(StorageInGB), value); }
        }
        /// <summary>The type of the service plan. Possible values are: enterprise, business, unknownFutureValue. Read-only.</summary>
        public CloudPcServicePlanType? Type {
            get { return BackingStore?.Get<CloudPcServicePlanType?>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
        /// <summary>The size of the user profile disk in GB. Read-only.</summary>
        public int? UserProfileInGB {
            get { return BackingStore?.Get<int?>(nameof(UserProfileInGB)); }
            set { BackingStore?.Set(nameof(UserProfileInGB), value); }
        }
        /// <summary>The number of vCPUs. Read-only.</summary>
        public int? VCpuCount {
            get { return BackingStore?.Get<int?>(nameof(VCpuCount)); }
            set { BackingStore?.Set(nameof(VCpuCount), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"ramInGB", n => { RamInGB = n.GetIntValue(); } },
                {"storageInGB", n => { StorageInGB = n.GetIntValue(); } },
                {"type", n => { Type = n.GetEnumValue<CloudPcServicePlanType>(); } },
                {"userProfileInGB", n => { UserProfileInGB = n.GetIntValue(); } },
                {"vCpuCount", n => { VCpuCount = n.GetIntValue(); } },
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
