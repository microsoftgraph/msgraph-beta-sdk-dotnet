using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class SecurityBaselineState : Entity, IParsable {
        /// <summary>The display name of the security baseline</summary>
        public string DisplayName { get; set; }
        /// <summary>The security baseline template id</summary>
        public string SecurityBaselineTemplateId { get; set; }
        /// <summary>The security baseline state for different settings for a device</summary>
        public List<SecurityBaselineSettingState> SettingStates { get; set; }
        /// <summary>Security baseline compliance state</summary>
        public SecurityBaselineComplianceState? State { get; set; }
        /// <summary>User Principal Name</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SecurityBaselineState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as SecurityBaselineState).DisplayName = n.GetStringValue(); } },
                {"securityBaselineTemplateId", (o,n) => { (o as SecurityBaselineState).SecurityBaselineTemplateId = n.GetStringValue(); } },
                {"settingStates", (o,n) => { (o as SecurityBaselineState).SettingStates = n.GetCollectionOfObjectValues<SecurityBaselineSettingState>(SecurityBaselineSettingState.CreateFromDiscriminatorValue).ToList(); } },
                {"state", (o,n) => { (o as SecurityBaselineState).State = n.GetEnumValue<SecurityBaselineComplianceState>(); } },
                {"userPrincipalName", (o,n) => { (o as SecurityBaselineState).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("securityBaselineTemplateId", SecurityBaselineTemplateId);
            writer.WriteCollectionOfObjectValues<SecurityBaselineSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<SecurityBaselineComplianceState>("state", State);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
