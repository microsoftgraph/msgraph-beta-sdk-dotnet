using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DirectorySettingTemplate : DirectoryObject, IParsable {
        /// <summary>Description of the template. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Display name of the template. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>Collection of settingTemplateValues that list the set of available settings, defaults and types that make up this template.  Read-only.</summary>
        public List<SettingTemplateValue> Values { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as DirectorySettingTemplate).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DirectorySettingTemplate).DisplayName = n.GetStringValue(); } },
                {"values", (o,n) => { (o as DirectorySettingTemplate).Values = n.GetCollectionOfObjectValues<SettingTemplateValue>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<SettingTemplateValue>("values", Values);
        }
    }
}
