using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The Base Class of Device Enrollment Configuration</summary>
    public class DeviceEnrollmentConfiguration : Entity, IParsable {
        /// <summary>The list of group assignments for the device configuration profile</summary>
        public List<EnrollmentConfigurationAssignment> Assignments {
            get { return BackingStore?.Get<List<EnrollmentConfigurationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>Created date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the device enrollment configuration</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Describes the TemplateFamily for the Template entity</summary>
        public Microsoft.Graph.Beta.Models.DeviceEnrollmentConfigurationType? DeviceEnrollmentConfigurationType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceEnrollmentConfigurationType?>("deviceEnrollmentConfigurationType"); }
            set { BackingStore?.Set("deviceEnrollmentConfigurationType", value); }
        }
        /// <summary>The display name of the device enrollment configuration</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Last modified date time in UTC of the device enrollment configuration</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Priority is used when a user exists in multiple groups that are assigned enrollment configuration. Users are subject only to the configuration with the lowest priority value.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Optional role scope tags for the enrollment restrictions.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>The version of the device enrollment configuration</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new deviceEnrollmentConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentConfiguration() : base() {
            Type = "#microsoft.graph.deviceEnrollmentConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceComanagementAuthorityConfiguration" => new DeviceComanagementAuthorityConfiguration(),
                "#microsoft.graph.deviceEnrollmentLimitConfiguration" => new DeviceEnrollmentLimitConfiguration(),
                "#microsoft.graph.deviceEnrollmentNotificationConfiguration" => new DeviceEnrollmentNotificationConfiguration(),
                "#microsoft.graph.deviceEnrollmentPlatformRestrictionConfiguration" => new DeviceEnrollmentPlatformRestrictionConfiguration(),
                "#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration" => new DeviceEnrollmentPlatformRestrictionsConfiguration(),
                "#microsoft.graph.deviceEnrollmentWindowsHelloForBusinessConfiguration" => new DeviceEnrollmentWindowsHelloForBusinessConfiguration(),
                "#microsoft.graph.windows10EnrollmentCompletionPageConfiguration" => new Windows10EnrollmentCompletionPageConfiguration(),
                _ => new DeviceEnrollmentConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EnrollmentConfigurationAssignment>(EnrollmentConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceEnrollmentConfigurationType", n => { DeviceEnrollmentConfigurationType = n.GetEnumValue<DeviceEnrollmentConfigurationType>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"version", n => { Version = n.GetIntValue(); } },
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
