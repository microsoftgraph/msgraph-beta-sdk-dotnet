using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AndroidManagedStoreAccountEnterpriseSettings : Entity, IParsable {
        /// <summary>Company codes for AndroidManagedStoreAccountEnterpriseSettings</summary>
        public bool? AndroidDeviceOwnerFullyManagedEnrollmentEnabled { get; set; }
        /// <summary>Bind status of the tenant with the Google EMM API. Possible values are: notBound, bound, boundAndValidated, unbinding.</summary>
        public AndroidManagedStoreAccountBindStatus? BindStatus { get; set; }
        /// <summary>Company codes for AndroidManagedStoreAccountEnterpriseSettings</summary>
        public List<AndroidEnrollmentCompanyCode> CompanyCodes { get; set; }
        /// <summary>Indicates if this account is flighting for Android Device Owner Management with CloudDPC.</summary>
        public bool? DeviceOwnerManagementEnabled { get; set; }
        /// <summary>Indicates which users can enroll devices in Android Enterprise device management. Possible values are: none, all, targeted, targetedAsEnrollmentRestrictions.</summary>
        public AndroidManagedStoreAccountEnrollmentTarget? EnrollmentTarget { get; set; }
        /// <summary>Last completion time for app sync</summary>
        public DateTimeOffset? LastAppSyncDateTime { get; set; }
        /// <summary>Last application sync result. Possible values are: success, credentialsNotValid, androidForWorkApiError, managementServiceError, unknownError, none.</summary>
        public AndroidManagedStoreAccountAppSyncStatus? LastAppSyncStatus { get; set; }
        /// <summary>Last modification time for Android enterprise settings</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Initial scope tags for MGP apps</summary>
        public List<string> ManagedGooglePlayInitialScopeTagIds { get; set; }
        /// <summary>Organization name used when onboarding Android Enterprise</summary>
        public string OwnerOrganizationName { get; set; }
        /// <summary>Owner UPN that created the enterprise</summary>
        public string OwnerUserPrincipalName { get; set; }
        /// <summary>Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to 'Targeted'</summary>
        public List<string> TargetGroupIds { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"androidDeviceOwnerFullyManagedEnrollmentEnabled", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).AndroidDeviceOwnerFullyManagedEnrollmentEnabled = n.GetBoolValue(); } },
                {"bindStatus", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).BindStatus = n.GetEnumValue<AndroidManagedStoreAccountBindStatus>(); } },
                {"companyCodes", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).CompanyCodes = n.GetCollectionOfObjectValues<AndroidEnrollmentCompanyCode>().ToList(); } },
                {"deviceOwnerManagementEnabled", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).DeviceOwnerManagementEnabled = n.GetBoolValue(); } },
                {"enrollmentTarget", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).EnrollmentTarget = n.GetEnumValue<AndroidManagedStoreAccountEnrollmentTarget>(); } },
                {"lastAppSyncDateTime", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).LastAppSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastAppSyncStatus", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).LastAppSyncStatus = n.GetEnumValue<AndroidManagedStoreAccountAppSyncStatus>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedGooglePlayInitialScopeTagIds", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).ManagedGooglePlayInitialScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"ownerOrganizationName", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).OwnerOrganizationName = n.GetStringValue(); } },
                {"ownerUserPrincipalName", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).OwnerUserPrincipalName = n.GetStringValue(); } },
                {"targetGroupIds", (o,n) => { (o as AndroidManagedStoreAccountEnterpriseSettings).TargetGroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
