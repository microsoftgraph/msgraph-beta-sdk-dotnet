using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PasswordSingleSignOnField : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Title/label override for customization.</summary>
        public string CustomizedLabel { get; set; }
        /// <summary>Label that would be used if no customizedLabel is provided. Read only.</summary>
        public string DefaultLabel { get; set; }
        /// <summary>Id used to identity the field type. This is an internal id and possible values are param_1, param_2, param_userName, param_password.</summary>
        public string FieldId { get; set; }
        /// <summary>Type of the credential. The values can be text, password.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new passwordSingleSignOnField and sets the default values.
        /// </summary>
        public PasswordSingleSignOnField() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"customizedLabel", (o,n) => { (o as PasswordSingleSignOnField).CustomizedLabel = n.GetStringValue(); } },
                {"defaultLabel", (o,n) => { (o as PasswordSingleSignOnField).DefaultLabel = n.GetStringValue(); } },
                {"fieldId", (o,n) => { (o as PasswordSingleSignOnField).FieldId = n.GetStringValue(); } },
                {"type", (o,n) => { (o as PasswordSingleSignOnField).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("customizedLabel", CustomizedLabel);
            writer.WriteStringValue("defaultLabel", DefaultLabel);
            writer.WriteStringValue("fieldId", FieldId);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
