using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class DeviceEnrollmentConfiguration : Entity, IParsable {
        /// <summary>The list of group assignments for the device configuration profile</summary>
        public List<EnrollmentConfigurationAssignment> Assignments { get; set; }
        /// <summary>Created date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the device enrollment configuration</summary>
        public string Description { get; set; }
        /// <summary>Support for Enrollment Configuration Type</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceEnrollmentConfigurationType? DeviceEnrollmentConfigurationType { get; set; }
        /// <summary>The display name of the device enrollment configuration</summary>
        public string DisplayName { get; set; }
        /// <summary>Last modified date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.</summary>
        public int? Priority { get; set; }
        /// <summary>Optional role scope tags for the enrollment restrictions.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>The version of the device enrollment configuration</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as DeviceEnrollmentConfiguration).Assignments = n.GetCollectionOfObjectValues<EnrollmentConfigurationAssignment>(EnrollmentConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as DeviceEnrollmentConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as DeviceEnrollmentConfiguration).Description = n.GetStringValue(); } },
                {"deviceEnrollmentConfigurationType", (o,n) => { (o as DeviceEnrollmentConfiguration).DeviceEnrollmentConfigurationType = n.GetEnumValue<DeviceEnrollmentConfigurationType>(); } },
                {"displayName", (o,n) => { (o as DeviceEnrollmentConfiguration).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as DeviceEnrollmentConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", (o,n) => { (o as DeviceEnrollmentConfiguration).Priority = n.GetIntValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as DeviceEnrollmentConfiguration).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"version", (o,n) => { (o as DeviceEnrollmentConfiguration).Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EnrollmentConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DeviceEnrollmentConfigurationType>("deviceEnrollmentConfigurationType", DeviceEnrollmentConfigurationType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("priority", Priority);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteIntValue("version", Version);
        }
    }
}
