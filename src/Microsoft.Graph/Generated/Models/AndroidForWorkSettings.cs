using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Settings for Android For Work.</summary>
    public class AndroidForWorkSettings : Entity, IParsable {
        /// <summary>Bind status of the tenant with the Google EMM API. Possible values are: notBound, bound, boundAndValidated, unbinding.</summary>
        public AndroidForWorkBindStatus? BindStatus {
            get { return BackingStore?.Get<AndroidForWorkBindStatus?>(nameof(BindStatus)); }
            set { BackingStore?.Set(nameof(BindStatus), value); }
        }
        /// <summary>Indicates if this account is flighting for Android Device Owner Management with CloudDPC.</summary>
        public bool? DeviceOwnerManagementEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceOwnerManagementEnabled)); }
            set { BackingStore?.Set(nameof(DeviceOwnerManagementEnabled), value); }
        }
        /// <summary>Indicates which users can enroll devices in Android for Work device management. Possible values are: none, all, targeted, targetedAsEnrollmentRestrictions.</summary>
        public AndroidForWorkEnrollmentTarget? EnrollmentTarget {
            get { return BackingStore?.Get<AndroidForWorkEnrollmentTarget?>(nameof(EnrollmentTarget)); }
            set { BackingStore?.Set(nameof(EnrollmentTarget), value); }
        }
        /// <summary>Last completion time for app sync</summary>
        public DateTimeOffset? LastAppSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastAppSyncDateTime)); }
            set { BackingStore?.Set(nameof(LastAppSyncDateTime), value); }
        }
        /// <summary>Last application sync result. Possible values are: success, credentialsNotValid, androidForWorkApiError, managementServiceError, unknownError, none.</summary>
        public AndroidForWorkSyncStatus? LastAppSyncStatus {
            get { return BackingStore?.Get<AndroidForWorkSyncStatus?>(nameof(LastAppSyncStatus)); }
            set { BackingStore?.Set(nameof(LastAppSyncStatus), value); }
        }
        /// <summary>Last modification time for Android for Work settings</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Organization name used when onboarding Android for Work</summary>
        public string OwnerOrganizationName {
            get { return BackingStore?.Get<string>(nameof(OwnerOrganizationName)); }
            set { BackingStore?.Set(nameof(OwnerOrganizationName), value); }
        }
        /// <summary>Owner UPN that created the enterprise</summary>
        public string OwnerUserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(OwnerUserPrincipalName)); }
            set { BackingStore?.Set(nameof(OwnerUserPrincipalName), value); }
        }
        /// <summary>Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to &apos;Targeted&apos;</summary>
        public List<string> TargetGroupIds {
            get { return BackingStore?.Get<List<string>>(nameof(TargetGroupIds)); }
            set { BackingStore?.Set(nameof(TargetGroupIds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidForWorkSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bindStatus", n => { BindStatus = n.GetEnumValue<AndroidForWorkBindStatus>(); } },
                {"deviceOwnerManagementEnabled", n => { DeviceOwnerManagementEnabled = n.GetBoolValue(); } },
                {"enrollmentTarget", n => { EnrollmentTarget = n.GetEnumValue<AndroidForWorkEnrollmentTarget>(); } },
                {"lastAppSyncDateTime", n => { LastAppSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastAppSyncStatus", n => { LastAppSyncStatus = n.GetEnumValue<AndroidForWorkSyncStatus>(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"ownerOrganizationName", n => { OwnerOrganizationName = n.GetStringValue(); } },
                {"ownerUserPrincipalName", n => { OwnerUserPrincipalName = n.GetStringValue(); } },
                {"targetGroupIds", n => { TargetGroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AndroidForWorkBindStatus>("bindStatus", BindStatus);
            writer.WriteBoolValue("deviceOwnerManagementEnabled", DeviceOwnerManagementEnabled);
            writer.WriteEnumValue<AndroidForWorkEnrollmentTarget>("enrollmentTarget", EnrollmentTarget);
            writer.WriteDateTimeOffsetValue("lastAppSyncDateTime", LastAppSyncDateTime);
            writer.WriteEnumValue<AndroidForWorkSyncStatus>("lastAppSyncStatus", LastAppSyncStatus);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("ownerOrganizationName", OwnerOrganizationName);
            writer.WriteStringValue("ownerUserPrincipalName", OwnerUserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("targetGroupIds", TargetGroupIds);
        }
    }
}
