using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Search {
    public class Bookmark : SearchAnswer, IParsable {
        /// <summary>Timestamp of when the bookmark will stop to appear as a search result. Set as null for always available.</summary>
        public DateTimeOffset? AvailabilityEndDateTime { get; set; }
        /// <summary>Timestamp of when the bookmark will start to appear as a search result. Set as null for always available.</summary>
        public DateTimeOffset? AvailabilityStartDateTime { get; set; }
        /// <summary>Categories commonly used to describe this bookmark. For example, IT and HR.</summary>
        public List<string> Categories { get; set; }
        /// <summary>List of security groups able to view this bookmark.</summary>
        public List<string> GroupIds { get; set; }
        /// <summary>True if this bookmark was suggested to the admin by a user or was mined and suggested by Microsoft. Read-only.</summary>
        public bool? IsSuggested { get; set; }
        /// <summary>Keywords that trigger this bookmark to appear in search results.</summary>
        public AnswerKeyword Keywords { get; set; }
        /// <summary>A list of language names that are geographically specific and that this bookmark can be viewed in. Each language tag value follows the pattern {language}-{REGION}. As an example, en-US is English as used in the United States. See supported language tags for the list of possible values.</summary>
        public List<string> LanguageTags { get; set; }
        /// <summary>List of devices and operating systems able to view this bookmark. Possible values are: unknown, android, androidForWork, ios, macOS, windowsPhone81, windowsPhone81AndLater, windows10AndLater, androidWorkProfile, androidASOP.</summary>
        public List<DevicePlatformType?> Platforms { get; set; }
        /// <summary>List of Power Apps associated with this bookmark. If users add existing Power Apps to a bookmark, they can complete tasks, such as to enter vacation time or to report expenses on the search results page.</summary>
        public List<string> PowerAppIds { get; set; }
        /// <summary>State of the bookmark. Possible values are: published, draft, excluded, or unknownFutureValue.</summary>
        public AnswerState? State { get; set; }
        /// <summary>Variations of a bookmark for different countries or devices. Use when you need to show different content to users based on their device, country/region, or both. The date and group settings will apply to all variations.</summary>
        public List<AnswerVariant> TargetedVariations { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Bookmark CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Bookmark();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"availabilityEndDateTime", (o,n) => { (o as Bookmark).AvailabilityEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"availabilityStartDateTime", (o,n) => { (o as Bookmark).AvailabilityStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"categories", (o,n) => { (o as Bookmark).Categories = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"groupIds", (o,n) => { (o as Bookmark).GroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isSuggested", (o,n) => { (o as Bookmark).IsSuggested = n.GetBoolValue(); } },
                {"keywords", (o,n) => { (o as Bookmark).Keywords = n.GetObjectValue<AnswerKeyword>(AnswerKeyword.CreateFromDiscriminatorValue); } },
                {"languageTags", (o,n) => { (o as Bookmark).LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platforms", (o,n) => { (o as Bookmark).Platforms = n.GetCollectionOfEnumValues<DevicePlatformType>().ToList(); } },
                {"powerAppIds", (o,n) => { (o as Bookmark).PowerAppIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", (o,n) => { (o as Bookmark).State = n.GetEnumValue<AnswerState>(); } },
                {"targetedVariations", (o,n) => { (o as Bookmark).TargetedVariations = n.GetCollectionOfObjectValues<AnswerVariant>(AnswerVariant.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfPrimitiveValues<string>("groupIds", GroupIds);
            writer.WriteBoolValue("isSuggested", IsSuggested);
            writer.WriteObjectValue<AnswerKeyword>("keywords", Keywords);
            writer.WriteCollectionOfPrimitiveValues<string>("languageTags", LanguageTags);
            writer.WriteCollectionOfEnumValues<DevicePlatformType>("platforms", Platforms);
            writer.WriteCollectionOfPrimitiveValues<string>("powerAppIds", PowerAppIds);
            writer.WriteEnumValue<AnswerState>("state", State);
            writer.WriteCollectionOfObjectValues<AnswerVariant>("targetedVariations", TargetedVariations);
        }
    }
}
