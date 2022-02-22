using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.Search {
    public class Qna : SearchAnswer, IParsable {
        public DateTimeOffset? AvailabilityEndDateTime { get; set; }
        public DateTimeOffset? AvailabilityStartDateTime { get; set; }
        public List<string> GroupIds { get; set; }
        public bool? IsSuggested { get; set; }
        public AnswerKeyword Keywords { get; set; }
        public List<string> LanguageTags { get; set; }
        public List<DevicePlatformType?> Platforms { get; set; }
        public AnswerState? State { get; set; }
        public List<AnswerVariant> TargetedVariations { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"availabilityEndDateTime", (o,n) => { (o as Qna).AvailabilityEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"availabilityStartDateTime", (o,n) => { (o as Qna).AvailabilityStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"groupIds", (o,n) => { (o as Qna).GroupIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isSuggested", (o,n) => { (o as Qna).IsSuggested = n.GetBoolValue(); } },
                {"keywords", (o,n) => { (o as Qna).Keywords = n.GetObjectValue<AnswerKeyword>(); } },
                {"languageTags", (o,n) => { (o as Qna).LanguageTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"platforms", (o,n) => { (o as Qna).Platforms = n.GetCollectionOfEnumValues<DevicePlatformType>().ToList(); } },
                {"state", (o,n) => { (o as Qna).State = n.GetEnumValue<AnswerState>(); } },
                {"targetedVariations", (o,n) => { (o as Qna).TargetedVariations = n.GetCollectionOfObjectValues<AnswerVariant>().ToList(); } },
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
