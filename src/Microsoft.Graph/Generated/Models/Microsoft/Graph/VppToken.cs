using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class VppToken : Entity, IParsable {
        /// <summary>The apple Id associated with the given Apple Volume Purchase Program Token.</summary>
        public string AppleId { get; set; }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public bool? AutomaticallyUpdateApps { get; set; }
        /// <summary>Admin consent to allow claiming token management from external MDM.</summary>
        public bool? ClaimTokenManagementFromExternalMdm { get; set; }
        /// <summary>Whether or not apps for the VPP token will be automatically updated.</summary>
        public string CountryOrRegion { get; set; }
        /// <summary>Consent granted for data sharing with the Apple Volume Purchase Program.</summary>
        public bool? DataSharingConsentGranted { get; set; }
        /// <summary>An admin specified token friendly name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The expiration date time of the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Last modification date time associated with the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Current sync status of the last application sync which was triggered using the Apple Volume Purchase Program Token. Possible values are: none, inProgress, completed, failed. Possible values are: none, inProgress, completed, failed.</summary>
        public VppTokenSyncStatus? LastSyncStatus { get; set; }
        /// <summary>Token location returned from Apple VPP.</summary>
        public string LocationName { get; set; }
        /// <summary>The organization associated with the Apple Volume Purchase Program Token</summary>
        public string OrganizationName { get; set; }
        /// <summary>Role Scope Tags IDs assigned to this entity.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Current state of the Apple Volume Purchase Program Token. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM. Possible values are: unknown, valid, expired, invalid, assignedToExternalMDM.</summary>
        public VppTokenState? State { get; set; }
        /// <summary>The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</summary>
        public string Token { get; set; }
        /// <summary>The collection of statuses of the actions performed on the Apple Volume Purchase Program Token.</summary>
        public List<VppTokenActionResult> TokenActionResults { get; set; }
        /// <summary>The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.VppTokenAccountType? VppTokenAccountType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new VppToken CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VppToken();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appleId", (o,n) => { (o as VppToken).AppleId = n.GetStringValue(); } },
                {"automaticallyUpdateApps", (o,n) => { (o as VppToken).AutomaticallyUpdateApps = n.GetBoolValue(); } },
                {"claimTokenManagementFromExternalMdm", (o,n) => { (o as VppToken).ClaimTokenManagementFromExternalMdm = n.GetBoolValue(); } },
                {"countryOrRegion", (o,n) => { (o as VppToken).CountryOrRegion = n.GetStringValue(); } },
                {"dataSharingConsentGranted", (o,n) => { (o as VppToken).DataSharingConsentGranted = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as VppToken).DisplayName = n.GetStringValue(); } },
                {"expirationDateTime", (o,n) => { (o as VppToken).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as VppToken).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as VppToken).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncStatus", (o,n) => { (o as VppToken).LastSyncStatus = n.GetEnumValue<VppTokenSyncStatus>(); } },
                {"locationName", (o,n) => { (o as VppToken).LocationName = n.GetStringValue(); } },
                {"organizationName", (o,n) => { (o as VppToken).OrganizationName = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as VppToken).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", (o,n) => { (o as VppToken).State = n.GetEnumValue<VppTokenState>(); } },
                {"token", (o,n) => { (o as VppToken).Token = n.GetStringValue(); } },
                {"tokenActionResults", (o,n) => { (o as VppToken).TokenActionResults = n.GetCollectionOfObjectValues<VppTokenActionResult>(VppTokenActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"vppTokenAccountType", (o,n) => { (o as VppToken).VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteBoolValue("automaticallyUpdateApps", AutomaticallyUpdateApps);
            writer.WriteBoolValue("claimTokenManagementFromExternalMdm", ClaimTokenManagementFromExternalMdm);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteBoolValue("dataSharingConsentGranted", DataSharingConsentGranted);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<VppTokenSyncStatus>("lastSyncStatus", LastSyncStatus);
            writer.WriteStringValue("locationName", LocationName);
            writer.WriteStringValue("organizationName", OrganizationName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteEnumValue<VppTokenState>("state", State);
            writer.WriteStringValue("token", Token);
            writer.WriteCollectionOfObjectValues<VppTokenActionResult>("tokenActionResults", TokenActionResults);
            writer.WriteEnumValue<VppTokenAccountType>("vppTokenAccountType", VppTokenAccountType);
        }
    }
}
