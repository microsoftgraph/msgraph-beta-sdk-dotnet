using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Enterprise settings for an Android managed store account.</summary>
    public class AndroidManagedStoreAccountEnterpriseSettings : Entity, IParsable {
        /// <summary>Company codes for AndroidManagedStoreAccountEnterpriseSettings</summary>
        public bool? AndroidDeviceOwnerFullyManagedEnrollmentEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AndroidDeviceOwnerFullyManagedEnrollmentEnabled)); }
            set { BackingStore?.Set(nameof(AndroidDeviceOwnerFullyManagedEnrollmentEnabled), value); }
        }
        /// <summary>Bind status of the tenant with the Google EMM API. Possible values are: notBound, bound, boundAndValidated, unbinding.</summary>
        public AndroidManagedStoreAccountBindStatus? BindStatus {
            get { return BackingStore?.Get<AndroidManagedStoreAccountBindStatus?>(nameof(BindStatus)); }
            set { BackingStore?.Set(nameof(BindStatus), value); }
        }
        /// <summary>Company codes for AndroidManagedStoreAccountEnterpriseSettings</summary>
        public List<AndroidEnrollmentCompanyCode> CompanyCodes {
            get { return BackingStore?.Get<List<AndroidEnrollmentCompanyCode>>(nameof(CompanyCodes)); }
            set { BackingStore?.Set(nameof(CompanyCodes), value); }
        }
        /// <summary>Indicates if this account is flighting for Android Device Owner Management with CloudDPC.</summary>
        public bool? DeviceOwnerManagementEnabled {
            get { return BackingStore?.Get<bool?>(nameof(DeviceOwnerManagementEnabled)); }
            set { BackingStore?.Set(nameof(DeviceOwnerManagementEnabled), value); }
        }
        /// <summary>Indicates which users can enroll devices in Android Enterprise device management. Possible values are: none, all, targeted, targetedAsEnrollmentRestrictions.</summary>
        public AndroidManagedStoreAccountEnrollmentTarget? EnrollmentTarget {
            get { return BackingStore?.Get<AndroidManagedStoreAccountEnrollmentTarget?>(nameof(EnrollmentTarget)); }
            set { BackingStore?.Set(nameof(EnrollmentTarget), value); }
        }
        /// <summary>Last completion time for app sync</summary>
        public DateTimeOffset? LastAppSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastAppSyncDateTime)); }
            set { BackingStore?.Set(nameof(LastAppSyncDateTime), value); }
        }
        /// <summary>Last application sync result. Possible values are: success, credentialsNotValid, androidForWorkApiError, managementServiceError, unknownError, none.</summary>
        public AndroidManagedStoreAccountAppSyncStatus? LastAppSyncStatus {
            get { return BackingStore?.Get<AndroidManagedStoreAccountAppSyncStatus?>(nameof(LastAppSyncStatus)); }
            set { BackingStore?.Set(nameof(LastAppSyncStatus), value); }
        }
        /// <summary>Last modification time for Android enterprise settings</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Initial scope tags for MGP apps</summary>
        public List<string> ManagedGooglePlayInitialScopeTagIds {
            get { return BackingStore?.Get<List<string>>(nameof(ManagedGooglePlayInitialScopeTagIds)); }
            set { BackingStore?.Set(nameof(ManagedGooglePlayInitialScopeTagIds), value); }
        }
        /// <summary>Organization name used when onboarding Android Enterprise</summary>
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
                {"companyCodes", n => { CompanyCodes = n.GetCollectionOfObjectValues<AndroidEnrollmentCompanyCode>(AndroidEnrollmentCompanyCode.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceOwnerManagementEnabled", n => { DeviceOwnerManagementEnabled = n.GetBoolValue(); } },
                {"enrollmentTarget", n => { EnrollmentTarget = n.GetEnumValue<AndroidManagedStoreAccountEnrollmentTarget>(); } },
                {"lastAppSyncDateTime", n => { LastAppSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastAppSyncStatus", n => { LastAppSyncStatus = n.GetEnumValue<AndroidManagedStoreAccountAppSyncStatus>(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedGooglePlayInitialScopeTagIds", n => { ManagedGooglePlayInitialScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
