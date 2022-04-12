using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcAuditActor : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the application.</summary>
        public string ApplicationDisplayName { get; set; }
        /// <summary>Azure AD application ID.</summary>
        public string ApplicationId { get; set; }
        /// <summary>IP address.</summary>
        public string IpAddress { get; set; }
        /// <summary>The delegated partner tenant ID.</summary>
        public string RemoteTenantId { get; set; }
        /// <summary>The delegated partner user ID.</summary>
        public string RemoteUserId { get; set; }
        /// <summary>Service Principal Name (SPN).</summary>
        public string ServicePrincipalName { get; set; }
        /// <summary>The actor type. Possible values include ItPro, Application, Partner and Unknown.</summary>
        public CloudPcAuditActorType? Type { get; set; }
        /// <summary>Azure AD user ID.</summary>
        public string UserId { get; set; }
        /// <summary>List of user permissions and application permissions when the audit event was performed.</summary>
        public List<string> UserPermissions { get; set; }
        /// <summary>User Principal Name (UPN).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>List of role scope tags.</summary>
        public List<CloudPcUserRoleScopeTagInfo> UserRoleScopeTags { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcAuditActor and sets the default values.
        /// </summary>
        public CloudPcAuditActor() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcAuditActor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcAuditActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationDisplayName", n => { ApplicationDisplayName = n.GetStringValue(); } },
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"remoteTenantId", n => { RemoteTenantId = n.GetStringValue(); } },
                {"remoteUserId", n => { RemoteUserId = n.GetStringValue(); } },
                {"servicePrincipalName", n => { ServicePrincipalName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<CloudPcAuditActorType>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPermissions", n => { UserPermissions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userRoleScopeTags", n => { UserRoleScopeTags = n.GetCollectionOfObjectValues<CloudPcUserRoleScopeTagInfo>(CloudPcUserRoleScopeTagInfo.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationDisplayName", ApplicationDisplayName);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("remoteTenantId", RemoteTenantId);
            writer.WriteStringValue("remoteUserId", RemoteUserId);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteEnumValue<CloudPcAuditActorType>("type", Type);
            writer.WriteStringValue("userId", UserId);
            writer.WriteCollectionOfPrimitiveValues<string>("userPermissions", UserPermissions);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<CloudPcUserRoleScopeTagInfo>("userRoleScopeTags", UserRoleScopeTags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
