using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PasswordValidationInformation : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies whether the password is valid based on the calculation of the results in the validationResults property. Not nullable. Read-only.</summary>
        public bool? IsValid {
            get { return BackingStore?.Get<bool?>(nameof(IsValid)); }
            set { BackingStore?.Set(nameof(IsValid), value); }
        }
        /// <summary>The list of password validation rules and whether the password passed those rules. Not nullable. Read-only.</summary>
        public List<ValidationResult> ValidationResults {
            get { return BackingStore?.Get<List<ValidationResult>>(nameof(ValidationResults)); }
            set { BackingStore?.Set(nameof(ValidationResults), value); }
        }
        /// <summary>
        /// Instantiates a new PasswordValidationInformation and sets the default values.
        /// </summary>
        public PasswordValidationInformation() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PasswordValidationInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordValidationInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isValid", n => { IsValid = n.GetBoolValue(); } },
                {"validationResults", n => { ValidationResults = n.GetCollectionOfObjectValues<ValidationResult>(ValidationResult.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isValid", IsValid);
            writer.WriteCollectionOfObjectValues<ValidationResult>("validationResults", ValidationResults);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
