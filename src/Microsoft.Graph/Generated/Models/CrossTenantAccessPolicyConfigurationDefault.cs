using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to application.</summary>
    public class CrossTenantAccessPolicyConfigurationDefault : Entity, IParsable {
        /// <summary>Defines your default configuration for users from other organizations accessing your resources via Azure AD B2B collaboration.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationInbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>(nameof(B2bCollaborationInbound)); }
            set { BackingStore?.Set(nameof(B2bCollaborationInbound), value); }
        }
        /// <summary>Defines your default configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B collaboration.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bCollaborationOutbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>(nameof(B2bCollaborationOutbound)); }
            set { BackingStore?.Set(nameof(B2bCollaborationOutbound), value); }
        }
        /// <summary>Defines your default configuration for users from other organizations accessing your resources via Azure AD B2B direct connect.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectInbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>(nameof(B2bDirectConnectInbound)); }
            set { BackingStore?.Set(nameof(B2bDirectConnectInbound), value); }
        }
        /// <summary>Defines your default configuration for users in your organization going outbound to access resources in another organization via Azure AD B2B direct connect.</summary>
        public CrossTenantAccessPolicyB2BSetting B2bDirectConnectOutbound {
            get { return BackingStore?.Get<CrossTenantAccessPolicyB2BSetting>(nameof(B2bDirectConnectOutbound)); }
            set { BackingStore?.Set(nameof(B2bDirectConnectOutbound), value); }
        }
        /// <summary>Determines the default configuration for trusting other Conditional Access claims from external Azure AD organizations.</summary>
        public CrossTenantAccessPolicyInboundTrust InboundTrust {
            get { return BackingStore?.Get<CrossTenantAccessPolicyInboundTrust>(nameof(InboundTrust)); }
            set { BackingStore?.Set(nameof(InboundTrust), value); }
        }
        /// <summary>If true, the default configuration is set to the system default configuration. If false, the default settings have been customized.</summary>
        public bool? IsServiceDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsServiceDefault)); }
            set { BackingStore?.Set(nameof(IsServiceDefault), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CrossTenantAccessPolicyConfigurationDefault CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CrossTenantAccessPolicyConfigurationDefault();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"b2bCollaborationInbound", n => { B2bCollaborationInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bCollaborationOutbound", n => { B2bCollaborationOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bDirectConnectInbound", n => { B2bDirectConnectInbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"b2bDirectConnectOutbound", n => { B2bDirectConnectOutbound = n.GetObjectValue<CrossTenantAccessPolicyB2BSetting>(CrossTenantAccessPolicyB2BSetting.CreateFromDiscriminatorValue); } },
                {"inboundTrust", n => { InboundTrust = n.GetObjectValue<CrossTenantAccessPolicyInboundTrust>(CrossTenantAccessPolicyInboundTrust.CreateFromDiscriminatorValue); } },
                {"isServiceDefault", n => { IsServiceDefault = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("isServiceDefault", IsServiceDefault);
        }
    }
}
