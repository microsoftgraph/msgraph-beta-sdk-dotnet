using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SecurityBaselineTemplate : DeviceManagementTemplate, IParsable {
        /// <summary>The security baseline per category device state summary</summary>
        public List<SecurityBaselineCategoryStateSummary> CategoryDeviceStateSummaries {
            get { return BackingStore?.Get<List<SecurityBaselineCategoryStateSummary>>(nameof(CategoryDeviceStateSummaries)); }
            set { BackingStore?.Set(nameof(CategoryDeviceStateSummaries), value); }
        }
        /// <summary>The security baseline device states</summary>
        public List<SecurityBaselineDeviceState> DeviceStates {
            get { return BackingStore?.Get<List<SecurityBaselineDeviceState>>(nameof(DeviceStates)); }
            set { BackingStore?.Set(nameof(DeviceStates), value); }
        }
        /// <summary>The security baseline device state summary</summary>
        public SecurityBaselineStateSummary DeviceStateSummary {
            get { return BackingStore?.Get<SecurityBaselineStateSummary>(nameof(DeviceStateSummary)); }
            set { BackingStore?.Set(nameof(DeviceStateSummary), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecurityBaselineTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categoryDeviceStateSummaries", n => { CategoryDeviceStateSummaries = n.GetCollectionOfObjectValues<SecurityBaselineCategoryStateSummary>(SecurityBaselineCategoryStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<SecurityBaselineDeviceState>(SecurityBaselineDeviceState.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStateSummary", n => { DeviceStateSummary = n.GetObjectValue<SecurityBaselineStateSummary>(SecurityBaselineStateSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SecurityBaselineCategoryStateSummary>("categoryDeviceStateSummaries", CategoryDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<SecurityBaselineDeviceState>("deviceStates", DeviceStates);
            writer.WriteObjectValue<SecurityBaselineStateSummary>("deviceStateSummary", DeviceStateSummary);
        }
    }
}
