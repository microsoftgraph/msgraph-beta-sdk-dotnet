using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcUserSetting : Entity, IParsable {
        /// <summary>Represents the set of Microsoft 365 groups and security groups in Azure AD that have cloudPCUserSetting assigned. Returned only on $expand. For an example, see Get cloudPcUserSettingample.</summary>
        public List<CloudPcUserSettingAssignment> Assignments { get; set; }
        /// <summary>The date and time the setting was created. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The setting name displayed in the user interface.</summary>
        public string DisplayName { get; set; }
        /// <summary>The last date and time the setting was modified. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Indicates whether the local admin option is enabled. Default value is false. To enable the local admin option, change the setting to true. If the local admin option is enabled, the end user can be an admin of the Cloud PC device.</summary>
        public bool? LocalAdminEnabled { get; set; }
        /// <summary>Defines how frequently a restore point is created that is, a snapshot is taken) for users&apos; provisioned Cloud PCs (default is 12 hours), and whether the user is allowed to restore their own Cloud PCs to a backup made at a specific point in time.</summary>
        public CloudPcRestorePointSetting RestorePointSetting { get; set; }
        /// <summary>Indicates whether the self-service option is enabled. Default value is false. To enable the self-service option, change the setting to true. If the self-service option is enabled, the end user is allowed to perform some self-service operations, such as upgrading the Cloud PC through the end user portal.</summary>
        public bool? SelfServiceEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcUserSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcUserSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as CloudPcUserSetting).Assignments = n.GetCollectionOfObjectValues<CloudPcUserSettingAssignment>(CloudPcUserSettingAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as CloudPcUserSetting).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as CloudPcUserSetting).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as CloudPcUserSetting).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"localAdminEnabled", (o,n) => { (o as CloudPcUserSetting).LocalAdminEnabled = n.GetBoolValue(); } },
                {"restorePointSetting", (o,n) => { (o as CloudPcUserSetting).RestorePointSetting = n.GetObjectValue<CloudPcRestorePointSetting>(CloudPcRestorePointSetting.CreateFromDiscriminatorValue); } },
                {"selfServiceEnabled", (o,n) => { (o as CloudPcUserSetting).SelfServiceEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CloudPcUserSettingAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteBoolValue("localAdminEnabled", LocalAdminEnabled);
            writer.WriteObjectValue<CloudPcRestorePointSetting>("restorePointSetting", RestorePointSetting);
            writer.WriteBoolValue("selfServiceEnabled", SelfServiceEnabled);
        }
    }
}
