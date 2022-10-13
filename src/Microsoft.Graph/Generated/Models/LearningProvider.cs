using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class LearningProvider : Entity, IParsable {
        /// <summary>The display name that appears in Viva Learning. Required.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The state of the provider. Optional.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Learning catalog items for the provider.</summary>
        public List<LearningContent> LearningContents {
            get { return BackingStore?.Get<List<LearningContent>>("learningContents"); }
            set { BackingStore?.Set("learningContents", value); }
        }
        /// <summary>Authentication URL to access the courses for the provider. Optional.</summary>
        public string LoginWebUrl {
            get { return BackingStore?.Get<string>("loginWebUrl"); }
            set { BackingStore?.Set("loginWebUrl", value); }
        }
        /// <summary>The long logo URL for the dark mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
        public string LongLogoWebUrlForDarkTheme {
            get { return BackingStore?.Get<string>("longLogoWebUrlForDarkTheme"); }
            set { BackingStore?.Set("longLogoWebUrlForDarkTheme", value); }
        }
        /// <summary>The long logo URL for the light mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering  within the Viva Learning app. Required.</summary>
        public string LongLogoWebUrlForLightTheme {
            get { return BackingStore?.Get<string>("longLogoWebUrlForLightTheme"); }
            set { BackingStore?.Set("longLogoWebUrlForLightTheme", value); }
        }
        /// <summary>The square logo URL for the dark mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
        public string SquareLogoWebUrlForDarkTheme {
            get { return BackingStore?.Get<string>("squareLogoWebUrlForDarkTheme"); }
            set { BackingStore?.Set("squareLogoWebUrlForDarkTheme", value); }
        }
        /// <summary>The square logo URL for the light mode, which needs to be a publicly accessible image. This image would be saved to the Blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
        public string SquareLogoWebUrlForLightTheme {
            get { return BackingStore?.Get<string>("squareLogoWebUrlForLightTheme"); }
            set { BackingStore?.Set("squareLogoWebUrlForLightTheme", value); }
        }
        /// <summary>
        /// Instantiates a new learningProvider and sets the default values.
        /// </summary>
        public LearningProvider() : base() {
            OdataType = "#microsoft.graph.learningProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LearningProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LearningProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"learningContents", n => { LearningContents = n.GetCollectionOfObjectValues<LearningContent>(LearningContent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"loginWebUrl", n => { LoginWebUrl = n.GetStringValue(); } },
                {"longLogoWebUrlForDarkTheme", n => { LongLogoWebUrlForDarkTheme = n.GetStringValue(); } },
                {"longLogoWebUrlForLightTheme", n => { LongLogoWebUrlForLightTheme = n.GetStringValue(); } },
                {"squareLogoWebUrlForDarkTheme", n => { SquareLogoWebUrlForDarkTheme = n.GetStringValue(); } },
                {"squareLogoWebUrlForLightTheme", n => { SquareLogoWebUrlForLightTheme = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<LearningContent>("learningContents", LearningContents);
            writer.WriteStringValue("loginWebUrl", LoginWebUrl);
            writer.WriteStringValue("longLogoWebUrlForDarkTheme", LongLogoWebUrlForDarkTheme);
            writer.WriteStringValue("longLogoWebUrlForLightTheme", LongLogoWebUrlForLightTheme);
            writer.WriteStringValue("squareLogoWebUrlForDarkTheme", SquareLogoWebUrlForDarkTheme);
            writer.WriteStringValue("squareLogoWebUrlForLightTheme", SquareLogoWebUrlForLightTheme);
        }
    }
}
