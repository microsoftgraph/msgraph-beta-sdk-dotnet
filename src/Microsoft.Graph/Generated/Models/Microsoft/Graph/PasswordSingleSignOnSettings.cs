using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the instantiate method.</summary>
    public class PasswordSingleSignOnSettings : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<PasswordSingleSignOnField> Fields { get; set; }
        /// <summary>
        /// Instantiates a new passwordSingleSignOnSettings and sets the default values.
        /// </summary>
        public PasswordSingleSignOnSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PasswordSingleSignOnSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordSingleSignOnSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"fields", (o,n) => { (o as PasswordSingleSignOnSettings).Fields = n.GetCollectionOfObjectValues<PasswordSingleSignOnField>(PasswordSingleSignOnField.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PasswordSingleSignOnField>("fields", Fields);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
