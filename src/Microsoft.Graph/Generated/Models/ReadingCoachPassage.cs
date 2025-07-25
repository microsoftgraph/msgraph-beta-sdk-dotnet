// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ReadingCoachPassage : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates if the reading passage was completed.</summary>
        public bool? IsReadingCompleted
        {
            get { return BackingStore?.Get<bool?>("isReadingCompleted"); }
            set { BackingStore?.Set("isReadingCompleted", value); }
        }
        /// <summary>The language of the reading passage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag
        {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag
        {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>The date and time when the Reading Coach passage was practiced. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? PracticedAtDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("practicedAtDateTime"); }
            set { BackingStore?.Set("practicedAtDateTime", value); }
        }
        /// <summary>The list of challenging words for the student that they can practice further.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PracticeWords
        {
            get { return BackingStore?.Get<List<string>?>("practiceWords"); }
            set { BackingStore?.Set("practiceWords", value); }
        }
#nullable restore
#else
        public List<string> PracticeWords
        {
            get { return BackingStore?.Get<List<string>>("practiceWords"); }
            set { BackingStore?.Set("practiceWords", value); }
        }
#endif
        /// <summary>The storyType property</summary>
        public global::Microsoft.Graph.Beta.Models.ReadingCoachStoryType? StoryType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ReadingCoachStoryType?>("storyType"); }
            set { BackingStore?.Set("storyType", value); }
        }
        /// <summary>ID of the student that practiced the reading passage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StudentId
        {
            get { return BackingStore?.Get<string?>("studentId"); }
            set { BackingStore?.Set("studentId", value); }
        }
#nullable restore
#else
        public string StudentId
        {
            get { return BackingStore?.Get<string>("studentId"); }
            set { BackingStore?.Set("studentId", value); }
        }
#endif
        /// <summary>The time the student spent reading in seconds.</summary>
        public double? TimeSpentReadingInSeconds
        {
            get { return BackingStore?.Get<double?>("timeSpentReadingInSeconds"); }
            set { BackingStore?.Set("timeSpentReadingInSeconds", value); }
        }
        /// <summary>The percentage of words that the student read correctly.</summary>
        public double? WordsAccuracyPercentage
        {
            get { return BackingStore?.Get<double?>("wordsAccuracyPercentage"); }
            set { BackingStore?.Set("wordsAccuracyPercentage", value); }
        }
        /// <summary>The rate the student read at in words per minute.</summary>
        public double? WordsPerMinute
        {
            get { return BackingStore?.Get<double?>("wordsPerMinute"); }
            set { BackingStore?.Set("wordsPerMinute", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ReadingCoachPassage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ReadingCoachPassage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ReadingCoachPassage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isReadingCompleted", n => { IsReadingCompleted = n.GetBoolValue(); } },
                { "languageTag", n => { LanguageTag = n.GetStringValue(); } },
                { "practiceWords", n => { PracticeWords = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "practicedAtDateTime", n => { PracticedAtDateTime = n.GetDateTimeOffsetValue(); } },
                { "storyType", n => { StoryType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ReadingCoachStoryType>(); } },
                { "studentId", n => { StudentId = n.GetStringValue(); } },
                { "timeSpentReadingInSeconds", n => { TimeSpentReadingInSeconds = n.GetDoubleValue(); } },
                { "wordsAccuracyPercentage", n => { WordsAccuracyPercentage = n.GetDoubleValue(); } },
                { "wordsPerMinute", n => { WordsPerMinute = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isReadingCompleted", IsReadingCompleted);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteDateTimeOffsetValue("practicedAtDateTime", PracticedAtDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("practiceWords", PracticeWords);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ReadingCoachStoryType>("storyType", StoryType);
            writer.WriteStringValue("studentId", StudentId);
            writer.WriteDoubleValue("timeSpentReadingInSeconds", TimeSpentReadingInSeconds);
            writer.WriteDoubleValue("wordsAccuracyPercentage", WordsAccuracyPercentage);
            writer.WriteDoubleValue("wordsPerMinute", WordsPerMinute);
        }
    }
}
#pragma warning restore CS0618
