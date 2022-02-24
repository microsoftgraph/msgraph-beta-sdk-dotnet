using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ImportedAppleDeviceIdentity : Entity, IParsable {
        /// <summary>Created Date Time of the device</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the device</summary>
        public string Description { get; set; }
        /// <summary>Apple device discovery source. Possible values are: unknown, adminImport, deviceEnrollmentProgram.</summary>
        public DiscoverySource? DiscoverySource { get; set; }
        /// <summary>The state of the device in Intune. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.</summary>
        public EnrollmentState? EnrollmentState { get; set; }
        /// <summary>Indicates if the device is deleted from Apple Business Manager</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>Indicates if the Apple device is supervised. More information is at: https://support.apple.com/en-us/HT202837</summary>
        public bool? IsSupervised { get; set; }
        /// <summary>Last Contacted Date Time of the device</summary>
        public DateTimeOffset? LastContactedDateTime { get; set; }
        /// <summary>The platform of the Device. Possible values are: unknown, ios, android, windows, windowsMobile, macOS.</summary>
        public Platform? Platform { get; set; }
        /// <summary>The time enrollment profile was assigned to the device</summary>
        public DateTimeOffset? RequestedEnrollmentProfileAssignmentDateTime { get; set; }
        /// <summary>Enrollment profile Id admin intends to apply to the device during next enrollment</summary>
        public string RequestedEnrollmentProfileId { get; set; }
        /// <summary>Device serial number</summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as ImportedAppleDeviceIdentity).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as ImportedAppleDeviceIdentity).Description = n.GetStringValue(); } },
                {"discoverySource", (o,n) => { (o as ImportedAppleDeviceIdentity).DiscoverySource = n.GetEnumValue<DiscoverySource>(); } },
                {"enrollmentState", (o,n) => { (o as ImportedAppleDeviceIdentity).EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"isDeleted", (o,n) => { (o as ImportedAppleDeviceIdentity).IsDeleted = n.GetBoolValue(); } },
                {"isSupervised", (o,n) => { (o as ImportedAppleDeviceIdentity).IsSupervised = n.GetBoolValue(); } },
                {"lastContactedDateTime", (o,n) => { (o as ImportedAppleDeviceIdentity).LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"platform", (o,n) => { (o as ImportedAppleDeviceIdentity).Platform = n.GetEnumValue<Platform>(); } },
                {"requestedEnrollmentProfileAssignmentDateTime", (o,n) => { (o as ImportedAppleDeviceIdentity).RequestedEnrollmentProfileAssignmentDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestedEnrollmentProfileId", (o,n) => { (o as ImportedAppleDeviceIdentity).RequestedEnrollmentProfileId = n.GetStringValue(); } },
                {"serialNumber", (o,n) => { (o as ImportedAppleDeviceIdentity).SerialNumber = n.GetStringValue(); } },
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
