using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CloudPcAuditActor : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationDisplayName", (o,n) => { (o as CloudPcAuditActor).ApplicationDisplayName = n.GetStringValue(); } },
                {"applicationId", (o,n) => { (o as CloudPcAuditActor).ApplicationId = n.GetStringValue(); } },
                {"ipAddress", (o,n) => { (o as CloudPcAuditActor).IpAddress = n.GetStringValue(); } },
                {"remoteTenantId", (o,n) => { (o as CloudPcAuditActor).RemoteTenantId = n.GetStringValue(); } },
                {"remoteUserId", (o,n) => { (o as CloudPcAuditActor).RemoteUserId = n.GetStringValue(); } },
                {"servicePrincipalName", (o,n) => { (o as CloudPcAuditActor).ServicePrincipalName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as CloudPcAuditActor).Type = n.GetEnumValue<CloudPcAuditActorType>(); } },
                {"userId", (o,n) => { (o as CloudPcAuditActor).UserId = n.GetStringValue(); } },
                {"userPermissions", (o,n) => { (o as CloudPcAuditActor).UserPermissions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userPrincipalName", (o,n) => { (o as CloudPcAuditActor).UserPrincipalName = n.GetStringValue(); } },
                {"userRoleScopeTags", (o,n) => { (o as CloudPcAuditActor).UserRoleScopeTags = n.GetCollectionOfObjectValues<CloudPcUserRoleScopeTagInfo>().ToList(); } },
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
