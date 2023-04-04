using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkSettings : Entity, IParsable {
        /// <summary>Bind status of the tenant with the Google EMM API</summary>
        public AndroidForWorkBindStatus? BindStatus {
            get { return BackingStore?.Get<AndroidForWorkBindStatus?>("bindStatus"); }
            set { BackingStore?.Set("bindStatus", value); }
        }
        /// <summary>Indicates if this account is flighting for Android Device Owner Management with CloudDPC.</summary>
        public bool? DeviceOwnerManagementEnabled {
            get { return BackingStore?.Get<bool?>("deviceOwnerManagementEnabled"); }
            set { BackingStore?.Set("deviceOwnerManagementEnabled", value); }
        }
        /// <summary>Android for Work device management targeting type for the account</summary>
        public AndroidForWorkEnrollmentTarget? EnrollmentTarget {
            get { return BackingStore?.Get<AndroidForWorkEnrollmentTarget?>("enrollmentTarget"); }
            set { BackingStore?.Set("enrollmentTarget", value); }
        }
        /// <summary>Last completion time for app sync</summary>
        public DateTimeOffset? LastAppSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastAppSyncDateTime"); }
            set { BackingStore?.Set("lastAppSyncDateTime", value); }
        }
        /// <summary>Sync status of the tenant with the Google EMM API</summary>
        public AndroidForWorkSyncStatus? LastAppSyncStatus {
            get { return BackingStore?.Get<AndroidForWorkSyncStatus?>("lastAppSyncStatus"); }
            set { BackingStore?.Set("lastAppSyncStatus", value); }
        }
        /// <summary>Last modification time for Android for Work settings</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Organization name used when onboarding Android for Work</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerOrganizationName {
            get { return BackingStore?.Get<string?>("ownerOrganizationName"); }
            set { BackingStore?.Set("ownerOrganizationName", value); }
        }
#nullable restore
#else
        public string OwnerOrganizationName {
            get { return BackingStore?.Get<string>("ownerOrganizationName"); }
            set { BackingStore?.Set("ownerOrganizationName", value); }
        }
#endif
        /// <summary>Owner UPN that created the enterprise</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerUserPrincipalName {
            get { return BackingStore?.Get<string?>("ownerUserPrincipalName"); }
            set { BackingStore?.Set("ownerUserPrincipalName", value); }
        }
#nullable restore
#else
        public string OwnerUserPrincipalName {
            get { return BackingStore?.Get<string>("ownerUserPrincipalName"); }
            set { BackingStore?.Set("ownerUserPrincipalName", value); }
        }
#endif
        /// <summary>Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to &apos;Targeted&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TargetGroupIds {
            get { return BackingStore?.Get<List<string>?>("targetGroupIds"); }
            set { BackingStore?.Set("targetGroupIds", value); }
        }
#nullable restore
#else
        public List<string> TargetGroupIds {
            get { return BackingStore?.Get<List<string>>("targetGroupIds"); }
            set { BackingStore?.Set("targetGroupIds", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"targetGroupIds", n => { TargetGroupIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
