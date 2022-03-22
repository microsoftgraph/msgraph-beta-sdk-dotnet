using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ValidationResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The string containing the reason for why the rule passed or not. Read-only. Not nullable.</summary>
        public string Message { get; set; }
        /// <summary>The string containing the name of the password validation rule that the action was validated against. Read-only. Not nullable.</summary>
        public string RuleName { get; set; }
        /// <summary>Whether the password passed or failed the validation rule. Read-only. Not nullable.</summary>
        public bool? ValidationPassed { get; set; }
        /// <summary>
        /// Instantiates a new validationResult and sets the default values.
        /// </summary>
        public ValidationResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ValidationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"message", (o,n) => { (o as ValidationResult).Message = n.GetStringValue(); } },
                {"ruleName", (o,n) => { (o as ValidationResult).RuleName = n.GetStringValue(); } },
                {"validationPassed", (o,n) => { (o as ValidationResult).ValidationPassed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("ruleName", RuleName);
            writer.WriteBoolValue("validationPassed", ValidationPassed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
