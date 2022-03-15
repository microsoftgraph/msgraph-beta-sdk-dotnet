using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class AuditActor : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the Application.</summary>
        public string ApplicationDisplayName { get; set; }
        /// <summary>AAD Application Id.</summary>
        public string ApplicationId { get; set; }
        /// <summary>IPAddress.</summary>
        public string IpAddress { get; set; }
        /// <summary>Remote Tenant Id</summary>
        public string RemoteTenantId { get; set; }
        /// <summary>Remote User Id</summary>
        public string RemoteUserId { get; set; }
        /// <summary>Service Principal Name (SPN).</summary>
        public string ServicePrincipalName { get; set; }
        /// <summary>Actor Type.</summary>
        public string Type { get; set; }
        /// <summary>User Id.</summary>
        public string UserId { get; set; }
        /// <summary>List of user permissions when the audit was performed.</summary>
        public List<string> UserPermissions { get; set; }
        /// <summary>User Principal Name (UPN).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>List of user scope tags when the audit was performed.</summary>
        public List<RoleScopeTagInfo> UserRoleScopeTags { get; set; }
        /// <summary>
        /// Instantiates a new auditActor and sets the default values.
        /// </summary>
        public AuditActor() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuditActor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"applicationDisplayName", (o,n) => { (o as AuditActor).ApplicationDisplayName = n.GetStringValue(); } },
                {"applicationId", (o,n) => { (o as AuditActor).ApplicationId = n.GetStringValue(); } },
                {"ipAddress", (o,n) => { (o as AuditActor).IpAddress = n.GetStringValue(); } },
                {"remoteTenantId", (o,n) => { (o as AuditActor).RemoteTenantId = n.GetStringValue(); } },
                {"remoteUserId", (o,n) => { (o as AuditActor).RemoteUserId = n.GetStringValue(); } },
                {"servicePrincipalName", (o,n) => { (o as AuditActor).ServicePrincipalName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as AuditActor).Type = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as AuditActor).UserId = n.GetStringValue(); } },
                {"userPermissions", (o,n) => { (o as AuditActor).UserPermissions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"userPrincipalName", (o,n) => { (o as AuditActor).UserPrincipalName = n.GetStringValue(); } },
                {"userRoleScopeTags", (o,n) => { (o as AuditActor).UserRoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTagInfo>(RoleScopeTagInfo.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userId", UserId);
            writer.WriteCollectionOfPrimitiveValues<string>("userPermissions", UserPermissions);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<RoleScopeTagInfo>("userRoleScopeTags", UserRoleScopeTags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
