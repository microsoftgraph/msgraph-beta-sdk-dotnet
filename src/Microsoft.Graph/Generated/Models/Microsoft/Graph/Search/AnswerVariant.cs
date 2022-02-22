using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Search {
    public class AnswerVariant : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string LanguageTag { get; set; }
        public DevicePlatformType? Platform { get; set; }
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new answerVariant and sets the default values.
        /// </summary>
        public AnswerVariant() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as AnswerVariant).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AnswerVariant).DisplayName = n.GetStringValue(); } },
                {"languageTag", (o,n) => { (o as AnswerVariant).LanguageTag = n.GetStringValue(); } },
                {"platform", (o,n) => { (o as AnswerVariant).Platform = n.GetEnumValue<DevicePlatformType>(); } },
                {"webUrl", (o,n) => { (o as AnswerVariant).WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteEnumValue<DevicePlatformType>("platform", Platform);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
