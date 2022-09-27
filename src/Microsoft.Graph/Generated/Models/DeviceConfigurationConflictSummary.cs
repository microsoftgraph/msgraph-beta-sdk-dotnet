using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Conflict summary for a set of device configuration policies.</summary>
    public class DeviceConfigurationConflictSummary : Entity, IParsable {
        /// <summary>The set of policies in conflict with the given setting</summary>
        public List<SettingSource> ConflictingDeviceConfigurations {
            get { return BackingStore?.Get<List<SettingSource>>("conflictingDeviceConfigurations"); }
            set { BackingStore?.Set("conflictingDeviceConfigurations", value); }
        }
        /// <summary>The set of settings in conflict with the given policies</summary>
        public List<string> ContributingSettings {
            get { return BackingStore?.Get<List<string>>("contributingSettings"); }
            set { BackingStore?.Set("contributingSettings", value); }
        }
        /// <summary>The count of checkins impacted by the conflicting policies and settings</summary>
        public int? DeviceCheckinsImpacted {
            get { return BackingStore?.Get<int?>("deviceCheckinsImpacted"); }
            set { BackingStore?.Set("deviceCheckinsImpacted", value); }
        }
        /// <summary>
        /// Instantiates a new deviceConfigurationConflictSummary and sets the default values.
        /// </summary>
        public DeviceConfigurationConflictSummary() : base() {
            OdataType = "#microsoft.graph.deviceConfigurationConflictSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfigurationConflictSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationConflictSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conflictingDeviceConfigurations", n => { ConflictingDeviceConfigurations = n.GetCollectionOfObjectValues<SettingSource>(SettingSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contributingSettings", n => { ContributingSettings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deviceCheckinsImpacted", n => { DeviceCheckinsImpacted = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SettingSource>("conflictingDeviceConfigurations", ConflictingDeviceConfigurations);
            writer.WriteCollectionOfPrimitiveValues<string>("contributingSettings", ContributingSettings);
            writer.WriteIntValue("deviceCheckinsImpacted", DeviceCheckinsImpacted);
        }
    }
}
