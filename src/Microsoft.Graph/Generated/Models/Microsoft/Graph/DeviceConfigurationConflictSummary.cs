using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceConfigurationConflictSummary : Entity, IParsable {
        /// <summary>The set of policies in conflict with the given setting</summary>
        public List<SettingSource> ConflictingDeviceConfigurations { get; set; }
        /// <summary>The set of settings in conflict with the given policies</summary>
        public List<string> ContributingSettings { get; set; }
        /// <summary>The count of checkins impacted by the conflicting policies and settings</summary>
        public int? DeviceCheckinsImpacted { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conflictingDeviceConfigurations", (o,n) => { (o as DeviceConfigurationConflictSummary).ConflictingDeviceConfigurations = n.GetCollectionOfObjectValues<SettingSource>(SettingSource.CreateFromDiscriminatorValue).ToList(); } },
                {"contributingSettings", (o,n) => { (o as DeviceConfigurationConflictSummary).ContributingSettings = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deviceCheckinsImpacted", (o,n) => { (o as DeviceConfigurationConflictSummary).DeviceCheckinsImpacted = n.GetIntValue(); } },
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
