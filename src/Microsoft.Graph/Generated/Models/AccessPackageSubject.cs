using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageSubject : Entity, IParsable {
        /// <summary>The altSecId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? AltSecId {
            get { return BackingStore?.Get<string?>("altSecId"); }
            set { BackingStore?.Set("altSecId", value); }
        }
#else
        public string AltSecId {
            get { return BackingStore?.Get<string>("altSecId"); }
            set { BackingStore?.Set("altSecId", value); }
        }
#endif
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.ConnectedOrganization? ConnectedOrganization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectedOrganization?>("connectedOrganization"); }
            set { BackingStore?.Set("connectedOrganization", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.ConnectedOrganization ConnectedOrganization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectedOrganization>("connectedOrganization"); }
            set { BackingStore?.Set("connectedOrganization", value); }
        }
#endif
        /// <summary>The identifier of the connected organization of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ConnectedOrganizationId {
            get { return BackingStore?.Get<string?>("connectedOrganizationId"); }
            set { BackingStore?.Set("connectedOrganizationId", value); }
        }
#else
        public string ConnectedOrganizationId {
            get { return BackingStore?.Get<string>("connectedOrganizationId"); }
            set { BackingStore?.Set("connectedOrganizationId", value); }
        }
#endif
        /// <summary>The display name of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The email address of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ObjectId {
            get { return BackingStore?.Get<string?>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#else
        public string ObjectId {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#endif
        /// <summary>The onPremisesSecurityIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string?>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#else
        public string OnPremisesSecurityIdentifier {
            get { return BackingStore?.Get<string>("onPremisesSecurityIdentifier"); }
            set { BackingStore?.Set("onPremisesSecurityIdentifier", value); }
        }
#endif
        /// <summary>The principal name, if known, of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PrincipalName {
            get { return BackingStore?.Get<string?>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#else
        public string PrincipalName {
            get { return BackingStore?.Get<string>("principalName"); }
            set { BackingStore?.Set("principalName", value); }
        }
#endif
        /// <summary>The subjectLifecycle property</summary>
        public AccessPackageSubjectLifecycle? SubjectLifecycle {
            get { return BackingStore?.Get<AccessPackageSubjectLifecycle?>("subjectLifecycle"); }
            set { BackingStore?.Set("subjectLifecycle", value); }
        }
        /// <summary>The resource type of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"subjectLifecycle", n => { SubjectLifecycle = n.GetEnumValue<AccessPackageSubjectLifecycle>(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
            writer.WriteEnumValue<AccessPackageSubjectLifecycle>("subjectLifecycle", SubjectLifecycle);
            writer.WriteStringValue("type", Type);
        }
    }
}
