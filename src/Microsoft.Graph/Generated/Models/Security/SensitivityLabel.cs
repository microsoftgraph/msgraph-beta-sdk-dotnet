using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class SensitivityLabel : Entity, IParsable {
        /// <summary>The color property</summary>
        public string Color {
            get { return BackingStore?.Get<string>(nameof(Color)); }
            set { BackingStore?.Set(nameof(Color), value); }
        }
        /// <summary>The contentFormats property</summary>
        public List<string> ContentFormats {
            get { return BackingStore?.Get<List<string>>(nameof(ContentFormats)); }
            set { BackingStore?.Set(nameof(ContentFormats), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The hasProtection property</summary>
        public bool? HasProtection {
            get { return BackingStore?.Get<bool?>(nameof(HasProtection)); }
            set { BackingStore?.Set(nameof(HasProtection), value); }
        }
        /// <summary>The isActive property</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>(nameof(IsActive)); }
            set { BackingStore?.Set(nameof(IsActive), value); }
        }
        /// <summary>The isAppliable property</summary>
        public bool? IsAppliable {
            get { return BackingStore?.Get<bool?>(nameof(IsAppliable)); }
            set { BackingStore?.Set(nameof(IsAppliable), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The parent property</summary>
        public SensitivityLabel Parent {
            get { return BackingStore?.Get<SensitivityLabel>(nameof(Parent)); }
            set { BackingStore?.Set(nameof(Parent), value); }
        }
        /// <summary>The sensitivity property</summary>
        public int? Sensitivity {
            get { return BackingStore?.Get<int?>(nameof(Sensitivity)); }
            set { BackingStore?.Set(nameof(Sensitivity), value); }
        }
        /// <summary>The tooltip property</summary>
        public string Tooltip {
            get { return BackingStore?.Get<string>(nameof(Tooltip)); }
            set { BackingStore?.Set(nameof(Tooltip), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SensitivityLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitivityLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"color", n => { Color = n.GetStringValue(); } },
                {"contentFormats", n => { ContentFormats = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"hasProtection", n => { HasProtection = n.GetBoolValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"isAppliable", n => { IsAppliable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue); } },
                {"sensitivity", n => { Sensitivity = n.GetIntValue(); } },
                {"tooltip", n => { Tooltip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("color", Color);
            writer.WriteCollectionOfPrimitiveValues<string>("contentFormats", ContentFormats);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("hasProtection", HasProtection);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteBoolValue("isAppliable", IsAppliable);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<SensitivityLabel>("parent", Parent);
            writer.WriteIntValue("sensitivity", Sensitivity);
            writer.WriteStringValue("tooltip", Tooltip);
        }
    }
}
