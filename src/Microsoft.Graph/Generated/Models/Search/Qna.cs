using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Search {
    public class Qna : SearchAnswer, IParsable {
        /// <summary>Timestamp of when the qna will stop to appear as a search result. Set as null for always available.</summary>
        public DateTimeOffset? AvailabilityEndDateTime { get; set; }
        /// <summary>Timestamp of when the qna will start to appear as a search result. Set as null for always available.</summary>
        public DateTimeOffset? AvailabilityStartDateTime { get; set; }
        /// <summary>List of security groups able to view this qna.</summary>
        public List<string> GroupIds { get; set; }
        /// <summary>True if this qna was suggested to the admin by a user or was mined and suggested by Microsoft. Read-only.</summary>
        public bool? IsSuggested { get; set; }
        /// <summary>Keywords that trigger this qna to appear in search results.</summary>
        public AnswerKeyword Keywords { get; set; }
        /// <summary>A list of language names that are geographically specific and that this QnA can be viewed in. Each language tag value follows the pattern {language}-{REGION}. As an example, en-US is English as used in the United States. See supported language tags for the list of possible values.</summary>
        public List<string> LanguageTags { get; set; }
        /// <summary>List of devices and operating systems able to view this qna. Possible values are: unknown, android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, androidASOP.</summary>
        public List<DevicePlatformType?> Platforms { get; set; }
        /// <summary>State of the qna. Possible values are: published, draft, excluded, or unknownFutureValue.</summary>
        public AnswerState? State { get; set; }
        /// <summary>Variations of a qna for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.</summary>
        public List<AnswerVariant> TargetedVariations { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Qna CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Qna();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availabilityEndDateTime", n => { AvailabilityEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"availabilityStartDateTime", n => { AvailabilityStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupIds", n => { GroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isSuggested", n => { IsSuggested = n.GetBoolValue(); } },
                {"keywords", n => { Keywords = n.GetObjectValue<AnswerKeyword>(AnswerKeyword.CreateFromDiscriminatorValue); } },
                {"languageTags", n => { LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platforms", n => { Platforms = n.GetCollectionOfEnumValues<DevicePlatformType>().ToList(); } },
                {"state", n => { State = n.GetEnumValue<AnswerState>(); } },
                {"targetedVariations", n => { TargetedVariations = n.GetCollectionOfObjectValues<AnswerVariant>(AnswerVariant.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("availabilityEndDateTime", AvailabilityEndDateTime);
            writer.WriteDateTimeOffsetValue("availabilityStartDateTime", AvailabilityStartDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("groupIds", GroupIds);
            writer.WriteBoolValue("isSuggested", IsSuggested);
            writer.WriteObjectValue<AnswerKeyword>("keywords", Keywords);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfEnumValues<DevicePlatformType>("platforms", Platforms);
            writer.WriteEnumValue<AnswerState>("state", State);
            writer.WriteCollectionOfObjectValues<AnswerVariant>("targetedVariations", TargetedVariations);
        }
    }
}
