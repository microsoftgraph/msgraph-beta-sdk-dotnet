using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Search {
    /// <summary>Provides operations to manage the searchEntity singleton.</summary>
    public class AnswerVariant : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Answer variation description shown on search results page.</summary>
        public string Description { get; set; }
        /// <summary>Answer variation name displayed in search results.</summary>
        public string DisplayName { get; set; }
        public string LanguageTag { get; set; }
        public DevicePlatformType? Platform { get; set; }
        /// <summary>Answer variation URL link. When users click this answer variation in search results, they will go to this URL.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new answerVariant and sets the default values.
        /// </summary>
        public AnswerVariant() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AnswerVariant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerVariant();
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
