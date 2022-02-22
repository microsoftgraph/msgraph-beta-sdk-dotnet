using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ImportedDeviceIdentity : Entity, IParsable {
        /// <summary>Created Date Time of the device</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the device</summary>
        public string Description { get; set; }
        /// <summary>The state of the device in Intune. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public EnrollmentState? EnrollmentState { get; set; }
        /// <summary>Imported Device Identifier</summary>
        public string ImportedDeviceIdentifier { get; set; }
        /// <summary>Type of Imported Device Identity. Possible values are: unknown, imei, serialNumber.</summary>
        public ImportedDeviceIdentityType? ImportedDeviceIdentityType { get; set; }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime { get; set; }
        /// <summary>Last Modified DateTime of the description</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The platform of the Device. Possible values are: unknown, ios, android, windows, windowsMobile, macOS.</summary>
        public Platform? Platform { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as ImportedDeviceIdentity).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ImportedDeviceIdentity).Description = n.GetStringValue(); } },
                {"enrollmentState", (o,n) => { (o as ImportedDeviceIdentity).EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"importedDeviceIdentifier", (o,n) => { (o as ImportedDeviceIdentity).ImportedDeviceIdentifier = n.GetStringValue(); } },
                {"importedDeviceIdentityType", (o,n) => { (o as ImportedDeviceIdentity).ImportedDeviceIdentityType = n.GetEnumValue<ImportedDeviceIdentityType>(); } },
                {"lastContactedDateTime", (o,n) => { (o as ImportedDeviceIdentity).LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as ImportedDeviceIdentity).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", (o,n) => { (o as ImportedDeviceIdentity).Platform = n.GetEnumValue<Platform>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteStringValue("importedDeviceIdentifier", ImportedDeviceIdentifier);
            writer.WriteEnumValue<ImportedDeviceIdentityType>("importedDeviceIdentityType", ImportedDeviceIdentityType);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Platform>("platform", Platform);
        }
    }
}
