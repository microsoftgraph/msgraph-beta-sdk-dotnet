using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Conflict summary for a set of device configuration policies.
    /// </summary>
    public class DeviceConfigurationConflictSummary : Entity, IParsable {
        /// <summary>The set of policies in conflict with the given setting</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SettingSource>? ConflictingDeviceConfigurations {
            get { return BackingStore?.Get<List<SettingSource>?>("conflictingDeviceConfigurations"); }
            set { BackingStore?.Set("conflictingDeviceConfigurations", value); }
        }
#nullable restore
#else
        public List<SettingSource> ConflictingDeviceConfigurations {
            get { return BackingStore?.Get<List<SettingSource>>("conflictingDeviceConfigurations"); }
            set { BackingStore?.Set("conflictingDeviceConfigurations", value); }
        }
#endif
        /// <summary>The set of settings in conflict with the given policies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContributingSettings {
            get { return BackingStore?.Get<List<string>?>("contributingSettings"); }
            set { BackingStore?.Set("contributingSettings", value); }
        }
#nullable restore
#else
        public List<string> ContributingSettings {
            get { return BackingStore?.Get<List<string>>("contributingSettings"); }
            set { BackingStore?.Set("contributingSettings", value); }
        }
#endif
        /// <summary>The count of checkins impacted by the conflicting policies and settings</summary>
        public int? DeviceCheckinsImpacted {
            get { return BackingStore?.Get<int?>("deviceCheckinsImpacted"); }
            set { BackingStore?.Set("deviceCheckinsImpacted", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SettingSource>("conflictingDeviceConfigurations", ConflictingDeviceConfigurations);
            writer.WriteCollectionOfPrimitiveValues<string>("contributingSettings", ContributingSettings);
            writer.WriteIntValue("deviceCheckinsImpacted", DeviceCheckinsImpacted);
        }
    }
}
