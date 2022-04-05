using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CrossTenantAccessPolicyConfigurationBase : Entity, IParsable {
        /// <summary>Defines your configuration for users from other organizations accessing your resources via Azure AD B2B collaboration.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound { get; set; }
        /// <summary>Defines your configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B collaboration.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound { get; set; }
        /// <summary>Defines your configuration for users from other organizations accessing your resources via Azure AD B2B direct connect.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound { get; set; }
        /// <summary>Defines your configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B direct connect.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound { get; set; }
        /// <summary>Determines the configuration for trusting other Conditional Access claims from external Azure AD organizations.</summary>
        public CrossTenantAccessPolicyInboundTrust InboundTrust { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CrossTenantAccessPolicyConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyConfigurationBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"b2bCollaborationInbound", (o,n) => { (o as CrossTenantAccessPolicyConfigurationBase).B2bCollaborationInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bCollaborationOutbound", (o,n) => { (o as CrossTenantAccessPolicyConfigurationBase).B2bCollaborationOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bDirectConnectInbound", (o,n) => { (o as CrossTenantAccessPolicyConfigurationBase).B2bDirectConnectInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bDirectConnectOutbound", (o,n) => { (o as CrossTenantAccessPolicyConfigurationBase).B2bDirectConnectOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"inboundTrust", (o,n) => { (o as CrossTenantAccessPolicyConfigurationBase).InboundTrust = n.GetObjectValue<CrossTenantAccessPolicyInboundTrust>(CrossTenantAccessPolicyInboundTrust.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationInbound", B2bCollaborationInbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bCollaborationOutbound", B2bCollaborationOutbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectInbound", B2bDirectConnectInbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyB2BSetting>("b2bDirectConnectOutbound", B2bDirectConnectOutbound);
            writer.WriteObjectValue<CrossTenantAccessPolicyInboundTrust>("inboundTrust", InboundTrust);
        }
    }
}
