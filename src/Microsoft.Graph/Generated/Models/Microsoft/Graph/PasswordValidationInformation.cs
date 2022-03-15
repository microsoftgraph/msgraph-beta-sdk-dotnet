using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the validatePassword method.</summary>
    public class PasswordValidationInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies whether the password is valid based on the calculation of the results in the validationResults property. Not nullable. Read-only.</summary>
        public bool? IsValid { get; set; }
        /// <summary>The list of password validation rules and whether the password passed those rules. Not nullable. Read-only.</summary>
        public List<ValidationResult> ValidationResults { get; set; }
        /// <summary>
        /// Instantiates a new passwordValidationInformation and sets the default values.
        /// </summary>
        public PasswordValidationInformation() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isValid", (o,n) => { (o as PasswordValidationInformation).IsValid = n.GetBoolValue(); } },
                {"validationResults", (o,n) => { (o as PasswordValidationInformation).ValidationResults = n.GetCollectionOfObjectValues<ValidationResult>(ValidationResult.CreateFromDiscriminatorValue).ToList(); } },
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
