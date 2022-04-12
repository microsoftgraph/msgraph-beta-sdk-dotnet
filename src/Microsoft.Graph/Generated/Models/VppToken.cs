using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        public Microsoft.Graph.Beta.Models.VppTokenAccountType? VppTokenAccountType { get; set; }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"automaticallyUpdateApps", n => { AutomaticallyUpdateApps = n.GetBoolValue(); } },
                {"claimTokenManagementFromExternalMdm", n => { ClaimTokenManagementFromExternalMdm = n.GetBoolValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"dataSharingConsentGranted", n => { DataSharingConsentGranted = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncStatus", n => { LastSyncStatus = n.GetEnumValue<VppTokenSyncStatus>(); } },
                {"locationName", n => { LocationName = n.GetStringValue(); } },
                {"organizationName", n => { OrganizationName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", n => { State = n.GetEnumValue<VppTokenState>(); } },
                {"token", n => { Token = n.GetStringValue(); } },
                {"tokenActionResults", n => { TokenActionResults = n.GetCollectionOfObjectValues<VppTokenActionResult>(VppTokenActionResult.CreateFromDiscriminatorValue).ToList(); } },
                {"vppTokenAccountType", n => { VppTokenAccountType = n.GetEnumValue<VppTokenAccountType>(); } },
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
