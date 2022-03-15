using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class LanguageProficiency : ItemFacet, IParsable {
        /// <summary>Contains the long-form name for the language.</summary>
        public string DisplayName { get; set; }
        public LanguageProficiencyLevel? Proficiency { get; set; }
        /// <summary>Represents the users reading comprehension for the language represented by the object. Possible values are: elementary, conversational, limitedWorking, professionalWorking, fullProfessional, nativeOrBilingual, unknownFutureValue.</summary>
        public LanguageProficiencyLevel? Reading { get; set; }
        /// <summary>Represents the users spoken proficiency for the language represented by the object. Possible values are: elementary, conversational, limitedWorking, professionalWorking, fullProfessional, nativeOrBilingual, unknownFutureValue.</summary>
        public LanguageProficiencyLevel? Spoken { get; set; }
        /// <summary>Contains the four-character BCP47 name for the language (en-US, no-NB, en-AU).</summary>
        public string Tag { get; set; }
        public string ThumbnailUrl { get; set; }
        /// <summary>Represents the users written proficiency for the language represented by the object. Possible values are: elementary, conversational, limitedWorking, professionalWorking, fullProfessional, nativeOrBilingual, unknownFutureValue.</summary>
        public LanguageProficiencyLevel? Written { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LanguageProficiency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LanguageProficiency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as LanguageProficiency).DisplayName = n.GetStringValue(); } },
                {"proficiency", (o,n) => { (o as LanguageProficiency).Proficiency = n.GetEnumValue<LanguageProficiencyLevel>(); } },
                {"reading", (o,n) => { (o as LanguageProficiency).Reading = n.GetEnumValue<LanguageProficiencyLevel>(); } },
                {"spoken", (o,n) => { (o as LanguageProficiency).Spoken = n.GetEnumValue<LanguageProficiencyLevel>(); } },
                {"tag", (o,n) => { (o as LanguageProficiency).Tag = n.GetStringValue(); } },
                {"thumbnailUrl", (o,n) => { (o as LanguageProficiency).ThumbnailUrl = n.GetStringValue(); } },
                {"written", (o,n) => { (o as LanguageProficiency).Written = n.GetEnumValue<LanguageProficiencyLevel>(); } },
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
            writer.WriteEnumValue<LanguageProficiencyLevel>("proficiency", Proficiency);
            writer.WriteEnumValue<LanguageProficiencyLevel>("reading", Reading);
            writer.WriteEnumValue<LanguageProficiencyLevel>("spoken", Spoken);
            writer.WriteStringValue("tag", Tag);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteEnumValue<LanguageProficiencyLevel>("written", Written);
        }
    }
}
