using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PasswordValidationInformation : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isValid", (o,n) => { (o as PasswordValidationInformation).IsValid = n.GetBoolValue(); } },
                {"validationResults", (o,n) => { (o as PasswordValidationInformation).ValidationResults = n.GetCollectionOfObjectValues<ValidationResult>().ToList(); } },
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
