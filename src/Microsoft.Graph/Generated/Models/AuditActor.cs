// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// A class containing the properties for Audit Actor.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AuditActor : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Name of the Application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationDisplayName
        {
            get { return BackingStore?.Get<string?>("applicationDisplayName"); }
            set { BackingStore?.Set("applicationDisplayName", value); }
        }
#nullable restore
#else
        public string ApplicationDisplayName
        {
            get { return BackingStore?.Get<string>("applicationDisplayName"); }
            set { BackingStore?.Set("applicationDisplayName", value); }
        }
#endif
        /// <summary>AAD Application Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationId
        {
            get { return BackingStore?.Get<string?>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#nullable restore
#else
        public string ApplicationId
        {
            get { return BackingStore?.Get<string>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#endif
        /// <summary>Actor Type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuditActorType
        {
            get { return BackingStore?.Get<string?>("auditActorType"); }
            set { BackingStore?.Set("auditActorType", value); }
        }
#nullable restore
#else
        public string AuditActorType
        {
            get { return BackingStore?.Get<string>("auditActorType"); }
            set { BackingStore?.Set("auditActorType", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>IPAddress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress
        {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress
        {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Remote Tenant Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteTenantId
        {
            get { return BackingStore?.Get<string?>("remoteTenantId"); }
            set { BackingStore?.Set("remoteTenantId", value); }
        }
#nullable restore
#else
        public string RemoteTenantId
        {
            get { return BackingStore?.Get<string>("remoteTenantId"); }
            set { BackingStore?.Set("remoteTenantId", value); }
        }
#endif
        /// <summary>Remote User Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteUserId
        {
            get { return BackingStore?.Get<string?>("remoteUserId"); }
            set { BackingStore?.Set("remoteUserId", value); }
        }
#nullable restore
#else
        public string RemoteUserId
        {
            get { return BackingStore?.Get<string>("remoteUserId"); }
            set { BackingStore?.Set("remoteUserId", value); }
        }
#endif
        /// <summary>Service Principal Name (SPN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalName
        {
            get { return BackingStore?.Get<string?>("servicePrincipalName"); }
            set { BackingStore?.Set("servicePrincipalName", value); }
        }
#nullable restore
#else
        public string ServicePrincipalName
        {
            get { return BackingStore?.Get<string>("servicePrincipalName"); }
            set { BackingStore?.Set("servicePrincipalName", value); }
        }
#endif
        /// <summary>Actor Type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type
        {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type
        {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>User Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>List of user permissions when the audit was performed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserPermissions
        {
            get { return BackingStore?.Get<List<string>?>("userPermissions"); }
            set { BackingStore?.Set("userPermissions", value); }
        }
#nullable restore
#else
        public List<string> UserPermissions
        {
            get { return BackingStore?.Get<List<string>>("userPermissions"); }
            set { BackingStore?.Set("userPermissions", value); }
        }
#endif
        /// <summary>User Principal Name (UPN).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>List of user scope tags when the audit was performed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo>? UserRoleScopeTags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo>?>("userRoleScopeTags"); }
            set { BackingStore?.Set("userRoleScopeTags", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo> UserRoleScopeTags
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo>>("userRoleScopeTags"); }
            set { BackingStore?.Set("userRoleScopeTags", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AuditActor"/> and sets the default values.
        /// </summary>
        public AuditActor()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuditActor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AuditActor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AuditActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applicationDisplayName", n => { ApplicationDisplayName = n.GetStringValue(); } },
                { "applicationId", n => { ApplicationId = n.GetStringValue(); } },
                { "auditActorType", n => { AuditActorType = n.GetStringValue(); } },
                { "ipAddress", n => { IpAddress = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "remoteTenantId", n => { RemoteTenantId = n.GetStringValue(); } },
                { "remoteUserId", n => { RemoteUserId = n.GetStringValue(); } },
                { "servicePrincipalName", n => { ServicePrincipalName = n.GetStringValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "userPermissions", n => { UserPermissions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "userRoleScopeTags", n => { UserRoleScopeTags = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo>(global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationDisplayName", ApplicationDisplayName);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("auditActorType", AuditActorType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("remoteTenantId", RemoteTenantId);
            writer.WriteStringValue("remoteUserId", RemoteUserId);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("userId", UserId);
            writer.WriteCollectionOfPrimitiveValues<string>("userPermissions", UserPermissions);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.RoleScopeTagInfo>("userRoleScopeTags", UserRoleScopeTags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
