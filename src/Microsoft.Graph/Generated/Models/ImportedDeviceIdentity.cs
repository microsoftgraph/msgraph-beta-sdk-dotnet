using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The importedDeviceIdentity resource represents a unique hardware identity of a device that has been pre-staged for pre-enrollment configuration.</summary>
    public class ImportedDeviceIdentity : Entity, IParsable {
        /// <summary>Created Date Time of the device</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The description of the device</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The state of the device in Intune. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>(nameof(EnrollmentState)); }
            set { BackingStore?.Set(nameof(EnrollmentState), value); }
        }
        /// <summary>Imported Device Identifier</summary>
        public string ImportedDeviceIdentifier {
            get { return BackingStore?.Get<string>(nameof(ImportedDeviceIdentifier)); }
            set { BackingStore?.Set(nameof(ImportedDeviceIdentifier), value); }
        }
        /// <summary>Type of Imported Device Identity. Possible values are: unknown, imei, serialNumber.</summary>
        public Microsoft.Graph.Beta.Models.ImportedDeviceIdentityType? ImportedDeviceIdentityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ImportedDeviceIdentityType?>(nameof(ImportedDeviceIdentityType)); }
            set { BackingStore?.Set(nameof(ImportedDeviceIdentityType), value); }
        }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastContactedDateTime)); }
            set { BackingStore?.Set(nameof(LastContactedDateTime), value); }
        }
        /// <summary>Last Modified DateTime of the description</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The platform of the Device. Possible values are: unknown, ios, android, windows, windowsMobile, macOS.</summary>
        public Microsoft.Graph.Beta.Models.Platform? Platform {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Platform?>(nameof(Platform)); }
            set { BackingStore?.Set(nameof(Platform), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ImportedDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.importedDeviceIdentityResult" => new ImportedDeviceIdentityResult(),
                _ => new ImportedDeviceIdentity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"importedDeviceIdentifier", n => { ImportedDeviceIdentifier = n.GetStringValue(); } },
                {"importedDeviceIdentityType", n => { ImportedDeviceIdentityType = n.GetEnumValue<ImportedDeviceIdentityType>(); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<Platform>(); } },
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
