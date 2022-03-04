using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessPackageSubject : Entity, IParsable {
        public string AltSecId { get; set; }
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectedOrganization ConnectedOrganization { get; set; }
        /// <summary>The identifier of the connected organization of the subject.</summary>
        public string ConnectedOrganizationId { get; set; }
        /// <summary>The display name of the subject.</summary>
        public string DisplayName { get; set; }
        /// <summary>The email address of the subject.</summary>
        public string Email { get; set; }
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant.</summary>
        public string ObjectId { get; set; }
        /// <summary>A string representation of the principal's security identifier, if known, or null if the subject does not have a security identifier.</summary>
        public string OnPremisesSecurityIdentifier { get; set; }
        /// <summary>The principal name, if known, of the subject.</summary>
        public string PrincipalName { get; set; }
        /// <summary>The resource type of the subject.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"altSecId", (o,n) => { (o as AccessPackageSubject).AltSecId = n.GetStringValue(); } },
                {"connectedOrganization", (o,n) => { (o as AccessPackageSubject).ConnectedOrganization = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectedOrganization>(MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                {"connectedOrganizationId", (o,n) => { (o as AccessPackageSubject).ConnectedOrganizationId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageSubject).DisplayName = n.GetStringValue(); } },
                {"email", (o,n) => { (o as AccessPackageSubject).Email = n.GetStringValue(); } },
                {"objectId", (o,n) => { (o as AccessPackageSubject).ObjectId = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", (o,n) => { (o as AccessPackageSubject).OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"principalName", (o,n) => { (o as AccessPackageSubject).PrincipalName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as AccessPackageSubject).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("altSecId", AltSecId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("connectedOrganizationId", ConnectedOrganizationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteStringValue("type", Type);
        }
    }
}
