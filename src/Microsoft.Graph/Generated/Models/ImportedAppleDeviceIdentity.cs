using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The importedAppleDeviceIdentity resource represents the imported device identity of an Apple device .</summary>
    public class ImportedAppleDeviceIdentity : Entity, IParsable {
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
        /// <summary>The discoverySource property</summary>
        public Microsoft.Graph.Beta.Models.DiscoverySource? DiscoverySource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DiscoverySource?>("discoverySource"); }
            set { BackingStore?.Set("discoverySource", value); }
        }
        /// <summary>The enrollmentState property</summary>
        public Microsoft.Graph.Beta.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EnrollmentState?>("enrollmentState"); }
            set { BackingStore?.Set("enrollmentState", value); }
        }
        /// <summary>Indicates if the device is deleted from Apple Business Manager</summary>
        public bool? IsDeleted {
            get { return BackingStore?.Get<bool?>("isDeleted"); }
            set { BackingStore?.Set("isDeleted", value); }
        }
        /// <summary>Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837</summary>
        public bool? IsSupervised {
            get { return BackingStore?.Get<bool?>("isSupervised"); }
            set { BackingStore?.Set("isSupervised", value); }
        }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastContactedDateTime"); }
            set { BackingStore?.Set("lastContactedDateTime", value); }
        }
        /// <summary>The platform property</summary>
        public Microsoft.Graph.Beta.Models.Platform? Platform {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Platform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>The time enrollment profile was assigned to the device</summary>
        public DateTimeOffset? RequestedEnrollmentProfileAssignmentDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("requestedEnrollmentProfileAssignmentDateTime"); }
            set { BackingStore?.Set("requestedEnrollmentProfileAssignmentDateTime", value); }
        }
        /// <summary>Enrollment profile Id admin intends to apply to the device during next enrollment</summary>
        public string RequestedEnrollmentProfileId {
            get { return BackingStore?.Get<string>("requestedEnrollmentProfileId"); }
            set { BackingStore?.Set("requestedEnrollmentProfileId", value); }
        }
        /// <summary>Device serial number</summary>
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
        /// <summary>
        /// Instantiates a new importedAppleDeviceIdentity and sets the default values.
        /// </summary>
        public ImportedAppleDeviceIdentity() : base() {
            OdataType = "#microsoft.graph.importedAppleDeviceIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ImportedAppleDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.importedAppleDeviceIdentityResult" => new ImportedAppleDeviceIdentityResult(),
                _ => new ImportedAppleDeviceIdentity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"discoverySource", n => { DiscoverySource = n.GetEnumValue<DiscoverySource>(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<Platform>(); } },
                {"requestedEnrollmentProfileAssignmentDateTime", n => { RequestedEnrollmentProfileAssignmentDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestedEnrollmentProfileId", n => { RequestedEnrollmentProfileId = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
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
            writer.WriteEnumValue<DiscoverySource>("discoverySource", DiscoverySource);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteBoolValue("isSupervised", IsSupervised);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteEnumValue<Platform>("platform", Platform);
            writer.WriteDateTimeOffsetValue("requestedEnrollmentProfileAssignmentDateTime", RequestedEnrollmentProfileAssignmentDateTime);
            writer.WriteStringValue("requestedEnrollmentProfileId", RequestedEnrollmentProfileId);
            writer.WriteStringValue("serialNumber", SerialNumber);
        }
    }
}
