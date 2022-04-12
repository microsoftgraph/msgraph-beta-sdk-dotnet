using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InsightsSettings : Entity, IParsable {
        /// <summary>The ID of an Azure Active Directory group, of which the specified type of insights are disabled for its members. Default is empty. Optional.</summary>
        public string DisabledForGroup { get; set; }
        /// <summary>true if the specified type of insights are enabled for the organization; false if the specified type of insights are disabled for all users without exceptions. Default is true. Optional.</summary>
        public bool? IsEnabledInOrganization { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InsightsSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InsightsSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"disabledForGroup", n => { DisabledForGroup = n.GetStringValue(); } },
                {"isEnabledInOrganization", n => { IsEnabledInOrganization = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("disabledForGroup", DisabledForGroup);
            writer.WriteBoolValue("isEnabledInOrganization", IsEnabledInOrganization);
        }
    }
}
