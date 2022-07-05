using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class OAuth2PermissionGrant : Entity, IParsable {
        /// <summary>The id of the client service principal for the application which is authorized to act on behalf of a signed-in user when accessing an API. Required. Supports $filter (eq only).</summary>
        public string ClientId {
            get { return BackingStore?.Get<string>(nameof(ClientId)); }
            set { BackingStore?.Set(nameof(ClientId), value); }
        }
        /// <summary>Indicates whether authorization is granted for the client application to impersonate all users or only a specific user. AllPrincipals indicates authorization to impersonate all users. Principal indicates authorization to impersonate a specific user. Consent on behalf of all users can be granted by an administrator. Non-admin users may be authorized to consent on behalf of themselves in some cases, for some delegated permissions. Required. Supports $filter (eq only).</summary>
        public string ConsentType {
            get { return BackingStore?.Get<string>(nameof(ConsentType)); }
            set { BackingStore?.Set(nameof(ConsentType), value); }
        }
        /// <summary>Currently, the end time value is ignored, but a value is required when creating an oAuth2PermissionGrant. Required.</summary>
        public DateTimeOffset? ExpiryTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ExpiryTime)); }
            set { BackingStore?.Set(nameof(ExpiryTime), value); }
        }
        /// <summary>The id of the user on behalf of whom the client is authorized to access the resource, when consentType is Principal. If consentType is AllPrincipals this value is null. Required when consentType is Principal. Supports $filter (eq only).</summary>
        public string PrincipalId {
            get { return BackingStore?.Get<string>(nameof(PrincipalId)); }
            set { BackingStore?.Set(nameof(PrincipalId), value); }
        }
        /// <summary>The id of the resource service principal to which access is authorized. This identifies the API which the client is authorized to attempt to call on behalf of a signed-in user. Supports $filter (eq only).</summary>
        public string ResourceId {
            get { return BackingStore?.Get<string>(nameof(ResourceId)); }
            set { BackingStore?.Set(nameof(ResourceId), value); }
        }
        /// <summary>A space-separated list of the claim values for delegated permissions which should be included in access tokens for the resource application (the API). For example, openid User.Read GroupMember.Read.All. Each claim value should match the value field of one of the delegated permissions defined by the API, listed in the publishedPermissionScopes property of the resource service principal.</summary>
        public string Scope {
            get { return BackingStore?.Get<string>(nameof(Scope)); }
            set { BackingStore?.Set(nameof(Scope), value); }
        }
        /// <summary>Currently, the start time value is ignored, but a value is required when creating an oAuth2PermissionGrant. Required.</summary>
        public DateTimeOffset? StartTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(StartTime)); }
            set { BackingStore?.Set(nameof(StartTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OAuth2PermissionGrant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OAuth2PermissionGrant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"clientId", n => { ClientId = n.GetStringValue(); } },
                {"consentType", n => { ConsentType = n.GetStringValue(); } },
                {"expiryTime", n => { ExpiryTime = n.GetDateTimeOffsetValue(); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetStringValue(); } },
                {"startTime", n => { StartTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientId", ClientId);
            writer.WriteStringValue("consentType", ConsentType);
            writer.WriteDateTimeOffsetValue("expiryTime", ExpiryTime);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("scope", Scope);
            writer.WriteDateTimeOffsetValue("startTime", StartTime);
        }
    }
}
