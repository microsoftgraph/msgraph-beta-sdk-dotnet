using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ImportedDeviceIdentity : Entity, IParsable {
        /// <summary>Created Date Time of the device</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the device</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The enrollmentState property</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>("enrollmentState"); }
            set { BackingStore?.Set("enrollmentState", value); }
        }
        /// <summary>Imported Device Identifier</summary>
        public string ImportedDeviceIdentifier {
            get { return BackingStore?.Get<string>("importedDeviceIdentifier"); }
            set { BackingStore?.Set("importedDeviceIdentifier", value); }
        }
        /// <summary>The importedDeviceIdentityType property</summary>
        public Microsoft.Graph.Beta.Models.ImportedDeviceIdentityType? ImportedDeviceIdentityType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ImportedDeviceIdentityType?>("importedDeviceIdentityType"); }
            set { BackingStore?.Set("importedDeviceIdentityType", value); }
        }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastContactedDateTime"); }
            set { BackingStore?.Set("lastContactedDateTime", value); }
        }
        /// <summary>Last Modified DateTime of the description</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The platform property</summary>
        public Microsoft.Graph.Beta.Models.Platform? Platform {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Platform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>
        /// Instantiates a new ImportedDeviceIdentity and sets the default values.
        /// </summary>
        public ImportedDeviceIdentity() : base() {
            OdataType = "#microsoft.graph.importedDeviceIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ImportedDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
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
