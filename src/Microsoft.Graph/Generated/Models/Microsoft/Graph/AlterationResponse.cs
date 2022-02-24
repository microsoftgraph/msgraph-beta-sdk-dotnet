using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AlterationResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the original user query string.</summary>
        public string OriginalQueryString { get; set; }
        /// <summary>Defines the details of the alteration information for the spelling correction.</summary>
        public SearchAlteration QueryAlteration { get; set; }
        /// <summary>Defines the type of the spelling correction. Possible values are: suggestion, modification.</summary>
        public SearchAlterationType? QueryAlterationType { get; set; }
        /// <summary>
        /// Instantiates a new alterationResponse and sets the default values.
        /// </summary>
        public AlterationResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"originalQueryString", (o,n) => { (o as AlterationResponse).OriginalQueryString = n.GetStringValue(); } },
                {"queryAlteration", (o,n) => { (o as AlterationResponse).QueryAlteration = n.GetObjectValue<SearchAlteration>(); } },
                {"queryAlterationType", (o,n) => { (o as AlterationResponse).QueryAlterationType = n.GetEnumValue<SearchAlterationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("originalQueryString", OriginalQueryString);
            writer.WriteObjectValue<SearchAlteration>("queryAlteration", QueryAlteration);
            writer.WriteEnumValue<SearchAlterationType>("queryAlterationType", QueryAlterationType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
