using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class EducationalActivityDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Shortened name of the degree or program (example: PhD, MBA)</summary>
        public string Abbreviation { get; set; }
        /// <summary>Extracurricular activities undertaken alongside the program.</summary>
        public List<string> Activities { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Any awards or honors associated with the program.</summary>
        public List<string> Awards { get; set; }
        /// <summary>Short description of the program provided by the user.</summary>
        public string Description { get; set; }
        /// <summary>Long-form name of the program that the user has provided.</summary>
        public string DisplayName { get; set; }
        /// <summary>Majors and minors associated with the program. (if applicable)</summary>
        public List<string> FieldsOfStudy { get; set; }
        /// <summary>The final grade, class, GPA or score.</summary>
        public string Grade { get; set; }
        /// <summary>Additional notes the user has provided.</summary>
        public string Notes { get; set; }
        /// <summary>Link to the degree or program page.</summary>
        public string WebUrl { get; set; }
        /// <summary>
        /// Instantiates a new educationalActivityDetail and sets the default values.
        /// </summary>
        public EducationalActivityDetail() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"abbreviation", (o,n) => { (o as EducationalActivityDetail).Abbreviation = n.GetStringValue(); } },
                {"activities", (o,n) => { (o as EducationalActivityDetail).Activities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"awards", (o,n) => { (o as EducationalActivityDetail).Awards = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as EducationalActivityDetail).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as EducationalActivityDetail).DisplayName = n.GetStringValue(); } },
                {"fieldsOfStudy", (o,n) => { (o as EducationalActivityDetail).FieldsOfStudy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"grade", (o,n) => { (o as EducationalActivityDetail).Grade = n.GetStringValue(); } },
                {"notes", (o,n) => { (o as EducationalActivityDetail).Notes = n.GetStringValue(); } },
                {"webUrl", (o,n) => { (o as EducationalActivityDetail).WebUrl = n.GetStringValue(); } },
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
