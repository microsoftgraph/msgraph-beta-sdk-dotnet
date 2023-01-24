using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidManagedStoreAccountEnterpriseSettings : Entity, IParsable {
        /// <summary>Company codes for AndroidManagedStoreAccountEnterpriseSettings</summary>
        public bool? AndroidDeviceOwnerFullyManagedEnrollmentEnabled {
            get { return BackingStore?.Get<bool?>("androidDeviceOwnerFullyManagedEnrollmentEnabled"); }
            set { BackingStore?.Set("androidDeviceOwnerFullyManagedEnrollmentEnabled", value); }
        }
        /// <summary>Bind status of the tenant with the Google EMM API</summary>
        public AndroidManagedStoreAccountBindStatus? BindStatus {
            get { return BackingStore?.Get<AndroidManagedStoreAccountBindStatus?>("bindStatus"); }
            set { BackingStore?.Set("bindStatus", value); }
        }
        /// <summary>Company codes for AndroidManagedStoreAccountEnterpriseSettings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidEnrollmentCompanyCode>? CompanyCodes {
            get { return BackingStore?.Get<List<AndroidEnrollmentCompanyCode>?>("companyCodes"); }
            set { BackingStore?.Set("companyCodes", value); }
        }
#nullable restore
#else
        public List<AndroidEnrollmentCompanyCode> CompanyCodes {
            get { return BackingStore?.Get<List<AndroidEnrollmentCompanyCode>>("companyCodes"); }
            set { BackingStore?.Set("companyCodes", value); }
        }
#endif
        /// <summary>Indicates if this account is flighting for Android Device Owner Management with CloudDPC.</summary>
        public bool? DeviceOwnerManagementEnabled {
            get { return BackingStore?.Get<bool?>("deviceOwnerManagementEnabled"); }
            set { BackingStore?.Set("deviceOwnerManagementEnabled", value); }
        }
        /// <summary>Android for Work device management targeting type for the account</summary>
        public AndroidManagedStoreAccountEnrollmentTarget? EnrollmentTarget {
            get { return BackingStore?.Get<AndroidManagedStoreAccountEnrollmentTarget?>("enrollmentTarget"); }
            set { BackingStore?.Set("enrollmentTarget", value); }
        }
        /// <summary>Last completion time for app sync</summary>
        public DateTimeOffset? LastAppSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastAppSyncDateTime"); }
            set { BackingStore?.Set("lastAppSyncDateTime", value); }
        }
        /// <summary>Sync status of the tenant with the Google EMM API</summary>
        public AndroidManagedStoreAccountAppSyncStatus? LastAppSyncStatus {
            get { return BackingStore?.Get<AndroidManagedStoreAccountAppSyncStatus?>("lastAppSyncStatus"); }
            set { BackingStore?.Set("lastAppSyncStatus", value); }
        }
        /// <summary>Last modification time for Android enterprise settings</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Initial scope tags for MGP apps</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ManagedGooglePlayInitialScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("managedGooglePlayInitialScopeTagIds"); }
            set { BackingStore?.Set("managedGooglePlayInitialScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> ManagedGooglePlayInitialScopeTagIds {
            get { return BackingStore?.Get<List<string>>("managedGooglePlayInitialScopeTagIds"); }
            set { BackingStore?.Set("managedGooglePlayInitialScopeTagIds", value); }
        }
#endif
        /// <summary>Organization name used when onboarding Android Enterprise</summary>
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
        public static new AndroidManagedStoreAccountEnterpriseSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedStoreAccountEnterpriseSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidDeviceOwnerFullyManagedEnrollmentEnabled", n => { AndroidDeviceOwnerFullyManagedEnrollmentEnabled = n.GetBoolValue(); } },
                {"bindStatus", n => { BindStatus = n.GetEnumValue<AndroidManagedStoreAccountBindStatus>(); } },
                {"companyCodes", n => { CompanyCodes = n.GetCollectionOfObjectValues<AndroidEnrollmentCompanyCode>(AndroidEnrollmentCompanyCode.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceOwnerManagementEnabled", n => { DeviceOwnerManagementEnabled = n.GetBoolValue(); } },
                {"enrollmentTarget", n => { EnrollmentTarget = n.GetEnumValue<AndroidManagedStoreAccountEnrollmentTarget>(); } },
                {"lastAppSyncDateTime", n => { LastAppSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastAppSyncStatus", n => { LastAppSyncStatus = n.GetEnumValue<AndroidManagedStoreAccountAppSyncStatus>(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedGooglePlayInitialScopeTagIds", n => { ManagedGooglePlayInitialScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteBoolValue("androidDeviceOwnerFullyManagedEnrollmentEnabled", AndroidDeviceOwnerFullyManagedEnrollmentEnabled);
            writer.WriteEnumValue<AndroidManagedStoreAccountBindStatus>("bindStatus", BindStatus);
            writer.WriteCollectionOfObjectValues<AndroidEnrollmentCompanyCode>("companyCodes", CompanyCodes);
            writer.WriteBoolValue("deviceOwnerManagementEnabled", DeviceOwnerManagementEnabled);
            writer.WriteEnumValue<AndroidManagedStoreAccountEnrollmentTarget>("enrollmentTarget", EnrollmentTarget);
            writer.WriteDateTimeOffsetValue("lastAppSyncDateTime", LastAppSyncDateTime);
            writer.WriteEnumValue<AndroidManagedStoreAccountAppSyncStatus>("lastAppSyncStatus", LastAppSyncStatus);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("managedGooglePlayInitialScopeTagIds", ManagedGooglePlayInitialScopeTagIds);
            writer.WriteStringValue("ownerOrganizationName", OwnerOrganizationName);
            writer.WriteStringValue("ownerUserPrincipalName", OwnerUserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("targetGroupIds", TargetGroupIds);
        }
    }
}
