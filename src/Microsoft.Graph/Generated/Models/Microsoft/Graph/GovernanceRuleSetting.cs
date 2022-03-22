using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GovernanceRuleSetting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The id of the rule. For example, ExpirationRule and MfaRule.</summary>
        public string RuleIdentifier { get; set; }
        /// <summary>The settings of the rule. The value is a JSON string with a list of pairs in the format of Parameter_Name:Parameter_Value. For example, {'permanentAssignment':false,'maximumGrantPeriodInMinutes':129600}</summary>
        public string Setting { get; set; }
        /// <summary>
        /// Instantiates a new governanceRuleSetting and sets the default values.
        /// </summary>
        public GovernanceRuleSetting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GovernanceRuleSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRuleSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"ruleIdentifier", (o,n) => { (o as GovernanceRuleSetting).RuleIdentifier = n.GetStringValue(); } },
                {"setting", (o,n) => { (o as GovernanceRuleSetting).Setting = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ruleIdentifier", RuleIdentifier);
            writer.WriteStringValue("setting", Setting);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
