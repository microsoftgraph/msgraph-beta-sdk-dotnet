using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcServicePlan : Entity, IParsable {
        /// <summary>The name for the service plan. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The size of the RAM in GB. Read-only.</summary>
        public int? RamInGB {
            get { return BackingStore?.Get<int?>("ramInGB"); }
            set { BackingStore?.Set("ramInGB", value); }
        }
        /// <summary>The size of the OS Disk in GB. Read-only.</summary>
        public int? StorageInGB {
            get { return BackingStore?.Get<int?>("storageInGB"); }
            set { BackingStore?.Set("storageInGB", value); }
        }
        /// <summary>The type of the service plan. Possible values are: enterprise, business, unknownFutureValue. Read-only.</summary>
        public CloudPcServicePlanType? Type {
            get { return BackingStore?.Get<CloudPcServicePlanType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The size of the user profile disk in GB. Read-only.</summary>
        public int? UserProfileInGB {
            get { return BackingStore?.Get<int?>("userProfileInGB"); }
            set { BackingStore?.Set("userProfileInGB", value); }
        }
        /// <summary>The number of vCPUs. Read-only.</summary>
        public int? VCpuCount {
            get { return BackingStore?.Get<int?>("vCpuCount"); }
            set { BackingStore?.Set("vCpuCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
