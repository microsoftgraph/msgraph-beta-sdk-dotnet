using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class BroadcastMeetingCaptionSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether caption is enabled for this Teams live event.</summary>
        public bool? IsCaptionEnabled { get; set; }
        /// <summary>The spoken language.</summary>
        public string SpokenLanguage { get; set; }
        /// <summary>The translation languages (choose up to 6).</summary>
        public List<string> TranslationLanguages { get; set; }
        /// <summary>
        /// Instantiates a new broadcastMeetingCaptionSettings and sets the default values.
        /// </summary>
        public BroadcastMeetingCaptionSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isCaptionEnabled", (o,n) => { (o as BroadcastMeetingCaptionSettings).IsCaptionEnabled = n.GetBoolValue(); } },
                {"spokenLanguage", (o,n) => { (o as BroadcastMeetingCaptionSettings).SpokenLanguage = n.GetStringValue(); } },
                {"translationLanguages", (o,n) => { (o as BroadcastMeetingCaptionSettings).TranslationLanguages = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isCaptionEnabled", IsCaptionEnabled);
            writer.WriteStringValue("spokenLanguage", SpokenLanguage);
            writer.WriteCollectionOfPrimitiveValues<string>("translationLanguages", TranslationLanguages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
