using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class LearningContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The additionalTags property</summary>
        public List<string> AdditionalTags {
            get { return BackingStore?.Get<List<string>>("additionalTags"); }
            set { BackingStore?.Set("additionalTags", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The contentWebUrl property</summary>
        public string ContentWebUrl {
            get { return BackingStore?.Get<string>("contentWebUrl"); }
            set { BackingStore?.Set("contentWebUrl", value); }
        }
        /// <summary>The contributor property</summary>
        public string Contributor {
            get { return BackingStore?.Get<string>("contributor"); }
            set { BackingStore?.Set("contributor", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The duration property</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>The externalId property</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
        /// <summary>The format property</summary>
        public string Format {
            get { return BackingStore?.Get<string>("format"); }
            set { BackingStore?.Set("format", value); }
        }
        /// <summary>The isActive property</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>The isPremium property</summary>
        public bool? IsPremium {
            get { return BackingStore?.Get<bool?>("isPremium"); }
            set { BackingStore?.Set("isPremium", value); }
        }
        /// <summary>The isSearchable property</summary>
        public bool? IsSearchable {
            get { return BackingStore?.Get<bool?>("isSearchable"); }
            set { BackingStore?.Set("isSearchable", value); }
        }
        /// <summary>The languageTag property</summary>
        public string LanguageTag {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The numberOfPages property</summary>
        public int? NumberOfPages {
            get { return BackingStore?.Get<int?>("numberOfPages"); }
            set { BackingStore?.Set("numberOfPages", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The skillTags property</summary>
        public List<string> SkillTags {
            get { return BackingStore?.Get<List<string>>("skillTags"); }
            set { BackingStore?.Set("skillTags", value); }
        }
        /// <summary>The sourceName property</summary>
        public string SourceName {
            get { return BackingStore?.Get<string>("sourceName"); }
            set { BackingStore?.Set("sourceName", value); }
        }
        /// <summary>The thumbnailWebUrl property</summary>
        public string ThumbnailWebUrl {
            get { return BackingStore?.Get<string>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
        /// <summary>The title property</summary>
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
        /// <summary>
        /// Instantiates a new learningContent and sets the default values.
        /// </summary>
        public LearningContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.learningContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static LearningContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LearningContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalTags", n => { AdditionalTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"contentWebUrl", n => { ContentWebUrl = n.GetStringValue(); } },
                {"contributor", n => { Contributor = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"format", n => { Format = n.GetStringValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"isPremium", n => { IsPremium = n.GetBoolValue(); } },
                {"isSearchable", n => { IsSearchable = n.GetBoolValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"numberOfPages", n => { NumberOfPages = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"skillTags", n => { SkillTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sourceName", n => { SourceName = n.GetStringValue(); } },
                {"thumbnailWebUrl", n => { ThumbnailWebUrl = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("additionalTags", AdditionalTags);
            writer.WriteStringValue("contentWebUrl", ContentWebUrl);
            writer.WriteStringValue("contributor", Contributor);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteTimeSpanValue("duration", Duration);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteStringValue("format", Format);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteBoolValue("isPremium", IsPremium);
            writer.WriteBoolValue("isSearchable", IsSearchable);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteIntValue("numberOfPages", NumberOfPages);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("skillTags", SkillTags);
            writer.WriteStringValue("sourceName", SourceName);
            writer.WriteStringValue("thumbnailWebUrl", ThumbnailWebUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
