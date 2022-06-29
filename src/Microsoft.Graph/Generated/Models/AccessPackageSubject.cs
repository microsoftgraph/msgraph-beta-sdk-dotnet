using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class AccessPackageSubject : Entity, IParsable {
        /// <summary>The altSecId property</summary>
        public string AltSecId {
            get { return BackingStore?.Get<string>(nameof(AltSecId)); }
            set { BackingStore?.Set(nameof(AltSecId), value); }
        }
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.ConnectedOrganization ConnectedOrganization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectedOrganization>(nameof(ConnectedOrganization)); }
            set { BackingStore?.Set(nameof(ConnectedOrganization), value); }
        }
        /// <summary>The identifier of the connected organization of the subject.</summary>
        public string ConnectedOrganizationId {
            get { return BackingStore?.Get<string>(nameof(ConnectedOrganizationId)); }
            set { BackingStore?.Set(nameof(ConnectedOrganizationId), value); }
        }
        /// <summary>The display name of the subject.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The email address of the subject.</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant.</summary>
        public string ObjectId {
            get { return BackingStore?.Get<string>(nameof(ObjectId)); }
            set { BackingStore?.Set(nameof(ObjectId), value); }
        }
        /// <summary>A string representation of the principal&apos;s security identifier, if known, or null if the subject does not have a security identifier.</summary>
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>(nameof(OnPremisesSecurityIdentifier)); }
            set { BackingStore?.Set(nameof(OnPremisesSecurityIdentifier), value); }
        }
        /// <summary>The principal name, if known, of the subject.</summary>
        public string PrincipalName {
            get { return BackingStore?.Get<string>(nameof(PrincipalName)); }
            set { BackingStore?.Set(nameof(PrincipalName), value); }
        }
        /// <summary>The resource type of the subject.</summary>
        public string Type {
            get { return BackingStore?.Get<string>(nameof(Type)); }
            set { BackingStore?.Set(nameof(Type), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"altSecId", n => { AltSecId = n.GetStringValue(); } },
                {"connectedOrganization", n => { ConnectedOrganization = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConnectedOrganization>(Microsoft.Graph.Beta.Models.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                {"connectedOrganizationId", n => { ConnectedOrganizationId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
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
