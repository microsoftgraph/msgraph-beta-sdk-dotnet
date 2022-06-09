using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ActiveDirectoryWindowsAutopilotDeploymentProfile : WindowsAutopilotDeploymentProfile, IParsable {
        /// <summary>Configuration to join Active Directory domain</summary>
        public WindowsDomainJoinConfiguration DomainJoinConfiguration {
            get { return BackingStore?.Get<WindowsDomainJoinConfiguration>(nameof(DomainJoinConfiguration)); }
            set { BackingStore?.Set(nameof(DomainJoinConfiguration), value); }
        }
        /// <summary>The Autopilot Hybrid Azure AD join flow will continue even if it does not establish domain controller connectivity during OOBE.</summary>
        public bool? HybridAzureADJoinSkipConnectivityCheck {
            get { return BackingStore?.Get<bool?>(nameof(HybridAzureADJoinSkipConnectivityCheck)); }
            set { BackingStore?.Set(nameof(HybridAzureADJoinSkipConnectivityCheck), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ActiveDirectoryWindowsAutopilotDeploymentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActiveDirectoryWindowsAutopilotDeploymentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"domainJoinConfiguration", n => { DomainJoinConfiguration = n.GetObjectValue<WindowsDomainJoinConfiguration>(WindowsDomainJoinConfiguration.CreateFromDiscriminatorValue); } },
                {"hybridAzureADJoinSkipConnectivityCheck", n => { HybridAzureADJoinSkipConnectivityCheck = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WindowsDomainJoinConfiguration>("domainJoinConfiguration", DomainJoinConfiguration);
            writer.WriteBoolValue("hybridAzureADJoinSkipConnectivityCheck", HybridAzureADJoinSkipConnectivityCheck);
        }
    }
}
