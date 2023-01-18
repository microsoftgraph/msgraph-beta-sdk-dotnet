using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcUserSetting : Entity, IParsable {
        /// <summary>Represents the set of Microsoft 365 groups and security groups in Azure Active Directory that have cloudPCUserSetting assigned. Returned only on $expand. For an example, see Get cloudPcUserSettingample.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<CloudPcUserSettingAssignment>? Assignments {
            get { return BackingStore?.Get<List<CloudPcUserSettingAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#else
        public List<CloudPcUserSettingAssignment> Assignments {
            get { return BackingStore?.Get<List<CloudPcUserSettingAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The date and time the setting was created. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The setting name displayed in the user interface.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The last date and time the setting was modified. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Indicates whether the local admin option is enabled. Default value is false. To enable the local admin option, change the setting to true. If the local admin option is enabled, the end user can be an admin of the Cloud PC device.</summary>
        public bool? LocalAdminEnabled {
            get { return BackingStore?.Get<bool?>("localAdminEnabled"); }
            set { BackingStore?.Set("localAdminEnabled", value); }
        }
        /// <summary>Defines how frequently a restore point is created that is, a snapshot is taken) for users&apos; provisioned Cloud PCs (default is 12 hours), and whether the user is allowed to restore their own Cloud PCs to a backup made at a specific point in time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public CloudPcRestorePointSetting? RestorePointSetting {
            get { return BackingStore?.Get<CloudPcRestorePointSetting?>("restorePointSetting"); }
            set { BackingStore?.Set("restorePointSetting", value); }
        }
#else
        public CloudPcRestorePointSetting RestorePointSetting {
            get { return BackingStore?.Get<CloudPcRestorePointSetting>("restorePointSetting"); }
            set { BackingStore?.Set("restorePointSetting", value); }
        }
#endif
        /// <summary>Indicates whether the self-service option is enabled. Default value is false. To enable the self-service option, change the setting to true. If the self-service option is enabled, the end user is allowed to perform some self-service operations, such as upgrading the Cloud PC through the end user portal.</summary>
        public bool? SelfServiceEnabled {
            get { return BackingStore?.Get<bool?>("selfServiceEnabled"); }
            set { BackingStore?.Set("selfServiceEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcUserSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcUserSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<CloudPcUserSettingAssignment>(CloudPcUserSettingAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"localAdminEnabled", n => { LocalAdminEnabled = n.GetBoolValue(); } },
                {"restorePointSetting", n => { RestorePointSetting = n.GetObjectValue<CloudPcRestorePointSetting>(CloudPcRestorePointSetting.CreateFromDiscriminatorValue); } },
                {"selfServiceEnabled", n => { SelfServiceEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
