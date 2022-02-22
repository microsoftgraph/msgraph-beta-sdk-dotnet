using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class EmbeddedSIMActivationCodePool : Entity, IParsable {
        /// <summary>The total count of activation codes which belong to this pool.</summary>
        public int? ActivationCodeCount { get; set; }
        /// <summary>The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.</summary>
        public List<EmbeddedSIMActivationCode> ActivationCodes { get; set; }
        /// <summary>Navigational property to a list of targets to which this pool is assigned.</summary>
        public List<EmbeddedSIMActivationCodePoolAssignment> Assignments { get; set; }
        /// <summary>The time the embedded SIM activation code pool was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Navigational property to a list of device states for this pool.</summary>
        public List<EmbeddedSIMDeviceState> DeviceStates { get; set; }
        /// <summary>The admin defined name of the embedded SIM activation code pool.</summary>
        public string DisplayName { get; set; }
        /// <summary>The time the embedded SIM activation code pool was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activationCodeCount", (o,n) => { (o as EmbeddedSIMActivationCodePool).ActivationCodeCount = n.GetIntValue(); } },
                {"activationCodes", (o,n) => { (o as EmbeddedSIMActivationCodePool).ActivationCodes = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCode>().ToList(); } },
                {"assignments", (o,n) => { (o as EmbeddedSIMActivationCodePool).Assignments = n.GetCollectionOfObjectValues<EmbeddedSIMActivationCodePoolAssignment>().ToList(); } },
                {"createdDateTime", (o,n) => { (o as EmbeddedSIMActivationCodePool).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceStates", (o,n) => { (o as EmbeddedSIMActivationCodePool).DeviceStates = n.GetCollectionOfObjectValues<EmbeddedSIMDeviceState>().ToList(); } },
                {"displayName", (o,n) => { (o as EmbeddedSIMActivationCodePool).DisplayName = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as EmbeddedSIMActivationCodePool).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activationCodeCount", ActivationCodeCount);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCode>("activationCodes", ActivationCodes);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMActivationCodePoolAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<EmbeddedSIMDeviceState>("deviceStates", DeviceStates);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
