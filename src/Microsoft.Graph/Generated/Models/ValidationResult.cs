using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ValidationResult : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The string containing the reason for why the rule passed or not. Read-only. Not nullable.</summary>
        public string Message {
            get { return BackingStore?.Get<string>(nameof(Message)); }
            set { BackingStore?.Set(nameof(Message), value); }
        }
        /// <summary>The string containing the name of the password validation rule that the action was validated against. Read-only. Not nullable.</summary>
        public string RuleName {
            get { return BackingStore?.Get<string>(nameof(RuleName)); }
            set { BackingStore?.Set(nameof(RuleName), value); }
        }
        /// <summary>Whether the password passed or failed the validation rule. Read-only. Not nullable.</summary>
        public bool? ValidationPassed {
            get { return BackingStore?.Get<bool?>(nameof(ValidationPassed)); }
            set { BackingStore?.Set(nameof(ValidationPassed), value); }
        }
        /// <summary>
        /// Instantiates a new validationResult and sets the default values.
        /// </summary>
        public ValidationResult() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"message", n => { Message = n.GetStringValue(); } },
                {"ruleName", n => { RuleName = n.GetStringValue(); } },
                {"validationPassed", n => { ValidationPassed = n.GetBoolValue(); } },
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
