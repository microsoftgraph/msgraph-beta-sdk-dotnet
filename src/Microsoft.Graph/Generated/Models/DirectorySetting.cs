using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class DirectorySetting : Entity, IParsable {
        /// <summary>Display name of this group of settings, which comes from the associated template. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Unique identifier for the template used to create this group of settings. Read-only.</summary>
        public string TemplateId {
            get { return BackingStore?.Get<string>(nameof(TemplateId)); }
            set { BackingStore?.Set(nameof(TemplateId), value); }
        }
        /// <summary>Collection of name-value pairs corresponding to the name and defaultValue properties in the referenced directorySettingTemplates object.</summary>
        public List<SettingValue> Values {
            get { return BackingStore?.Get<List<SettingValue>>(nameof(Values)); }
            set { BackingStore?.Set(nameof(Values), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DirectorySetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectorySetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfObjectValues<SettingValue>(SettingValue.CreateFromDiscriminatorValue).ToList(); } },
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
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteCollectionOfObjectValues<SettingValue>("values", Values);
        }
    }
}
