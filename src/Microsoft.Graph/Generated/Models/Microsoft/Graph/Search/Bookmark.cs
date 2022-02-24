using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Search {
    public class Bookmark : SearchAnswer, IParsable {
        public DateTimeOffset? AvailabilityEndDateTime { get; set; }
        public DateTimeOffset? AvailabilityStartDateTime { get; set; }
        public List<string> Categories { get; set; }
        public List<string> GroupIds { get; set; }
        public bool? IsSuggested { get; set; }
        public AnswerKeyword Keywords { get; set; }
        public List<string> LanguageTags { get; set; }
        public List<DevicePlatformType?> Platforms { get; set; }
        public List<string> PowerAppIds { get; set; }
        public AnswerState? State { get; set; }
        public List<AnswerVariant> TargetedVariations { get; set; }
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
                {"keywords", (o,n) => { (o as Bookmark).Keywords = n.GetObjectValue<AnswerKeyword>(); } },
                {"languageTags", (o,n) => { (o as Bookmark).LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platforms", (o,n) => { (o as Bookmark).Platforms = n.GetCollectionOfEnumValues<DevicePlatformType>().ToList(); } },
                {"powerAppIds", (o,n) => { (o as Bookmark).PowerAppIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", (o,n) => { (o as Bookmark).State = n.GetEnumValue<AnswerState>(); } },
                {"targetedVariations", (o,n) => { (o as Bookmark).TargetedVariations = n.GetCollectionOfObjectValues<AnswerVariant>().ToList(); } },
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
