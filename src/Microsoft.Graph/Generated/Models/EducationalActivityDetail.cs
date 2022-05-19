using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EducationalActivityDetail : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Shortened name of the degree or program (example: PhD, MBA)</summary>
        public string Abbreviation {
            get { return BackingStore?.Get<string>(nameof(Abbreviation)); }
            set { BackingStore?.Set(nameof(Abbreviation), value); }
        }
        /// <summary>Extracurricular activities undertaken alongside the program.</summary>
        public List<string> Activities {
            get { return BackingStore?.Get<List<string>>(nameof(Activities)); }
            set { BackingStore?.Set(nameof(Activities), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Any awards or honors associated with the program.</summary>
        public List<string> Awards {
            get { return BackingStore?.Get<List<string>>(nameof(Awards)); }
            set { BackingStore?.Set(nameof(Awards), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Short description of the program provided by the user.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Long-form name of the program that the user has provided.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Majors and minors associated with the program. (if applicable)</summary>
        public List<string> FieldsOfStudy {
            get { return BackingStore?.Get<List<string>>(nameof(FieldsOfStudy)); }
            set { BackingStore?.Set(nameof(FieldsOfStudy), value); }
        }
        /// <summary>The final grade, class, GPA or score.</summary>
        public string Grade {
            get { return BackingStore?.Get<string>(nameof(Grade)); }
            set { BackingStore?.Set(nameof(Grade), value); }
        }
        /// <summary>Additional notes the user has provided.</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>Link to the degree or program page.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Instantiates a new educationalActivityDetail and sets the default values.
        /// </summary>
        public EducationalActivityDetail() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EducationalActivityDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationalActivityDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"abbreviation", n => { Abbreviation = n.GetStringValue(); } },
                {"activities", n => { Activities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"awards", n => { Awards = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fieldsOfStudy", n => { FieldsOfStudy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"grade", n => { Grade = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("abbreviation", Abbreviation);
            writer.WriteCollectionOfPrimitiveValues<string>("activities", Activities);
            writer.WriteCollectionOfPrimitiveValues<string>("awards", Awards);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("fieldsOfStudy", FieldsOfStudy);
            writer.WriteStringValue("grade", Grade);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
