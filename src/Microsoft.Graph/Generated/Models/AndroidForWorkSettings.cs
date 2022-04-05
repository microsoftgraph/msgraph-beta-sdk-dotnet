using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidForWorkSettings : Entity, IParsable {
        /// <summary>Bind status of the tenant with the Google EMM API. Possible values are: notBound, bound, boundAndValidated, unbinding.</summary>
        public AndroidForWorkBindStatus? BindStatus { get; set; }
        /// <summary>Indicates if this account is flighting for Android Device Owner Management with CloudDPC.</summary>
        public bool? DeviceOwnerManagementEnabled { get; set; }
        /// <summary>Indicates which users can enroll devices in Android for Work device management. Possible values are: none, all, targeted, targetedAsEnrollmentRestrictions.</summary>
        public AndroidForWorkEnrollmentTarget? EnrollmentTarget { get; set; }
        /// <summary>Last completion time for app sync</summary>
        public DateTimeOffset? LastAppSyncDateTime { get; set; }
        /// <summary>Last application sync result. Possible values are: success, credentialsNotValid, androidForWorkApiError, managementServiceError, unknownError, none.</summary>
        public AndroidForWorkSyncStatus? LastAppSyncStatus { get; set; }
        /// <summary>Last modification time for Android for Work settings</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Organization name used when onboarding Android for Work</summary>
        public string OwnerOrganizationName { get; set; }
        /// <summary>Owner UPN that created the enterprise</summary>
        public string OwnerUserPrincipalName { get; set; }
        /// <summary>Specifies which AAD groups can enroll devices in Android for Work device management if enrollmentTarget is set to &apos;Targeted&apos;</summary>
        public List<string> TargetGroupIds { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"bindStatus", (o,n) => { (o as AndroidForWorkSettings).BindStatus = n.GetEnumValue<AndroidForWorkBindStatus>(); } },
                {"deviceOwnerManagementEnabled", (o,n) => { (o as AndroidForWorkSettings).DeviceOwnerManagementEnabled = n.GetBoolValue(); } },
                {"enrollmentTarget", (o,n) => { (o as AndroidForWorkSettings).EnrollmentTarget = n.GetEnumValue<AndroidForWorkEnrollmentTarget>(); } },
                {"lastAppSyncDateTime", (o,n) => { (o as AndroidForWorkSettings).LastAppSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastAppSyncStatus", (o,n) => { (o as AndroidForWorkSettings).LastAppSyncStatus = n.GetEnumValue<AndroidForWorkSyncStatus>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as AndroidForWorkSettings).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"ownerOrganizationName", (o,n) => { (o as AndroidForWorkSettings).OwnerOrganizationName = n.GetStringValue(); } },
                {"ownerUserPrincipalName", (o,n) => { (o as AndroidForWorkSettings).OwnerUserPrincipalName = n.GetStringValue(); } },
                {"targetGroupIds", (o,n) => { (o as AndroidForWorkSettings).TargetGroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
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
