using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class SensitiveType : Entity, IParsable {
        /// <summary>The classificationMethod property</summary>
        public Microsoft.Graph.Beta.Models.ClassificationMethod? ClassificationMethod {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClassificationMethod?>(nameof(ClassificationMethod)); }
            set { BackingStore?.Set(nameof(ClassificationMethod), value); }
        }
        /// <summary>The description property</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The publisherName property</summary>
        public string PublisherName {
            get { return BackingStore?.Get<string>(nameof(PublisherName)); }
            set { BackingStore?.Set(nameof(PublisherName), value); }
        }
        /// <summary>The rulePackageId property</summary>
        public string RulePackageId {
            get { return BackingStore?.Get<string>(nameof(RulePackageId)); }
            set { BackingStore?.Set(nameof(RulePackageId), value); }
        }
        /// <summary>The rulePackageType property</summary>
        public string RulePackageType {
            get { return BackingStore?.Get<string>(nameof(RulePackageType)); }
            set { BackingStore?.Set(nameof(RulePackageType), value); }
        }
        /// <summary>The scope property</summary>
        public SensitiveTypeScope? Scope {
            get { return BackingStore?.Get<SensitiveTypeScope?>(nameof(Scope)); }
            set { BackingStore?.Set(nameof(Scope), value); }
        }
        /// <summary>The sensitiveTypeSource property</summary>
        public Microsoft.Graph.Beta.Models.SensitiveTypeSource? SensitiveTypeSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SensitiveTypeSource?>(nameof(SensitiveTypeSource)); }
            set { BackingStore?.Set(nameof(SensitiveTypeSource), value); }
        }
        /// <summary>The state property</summary>
        public string State {
            get { return BackingStore?.Get<string>(nameof(State)); }
            set { BackingStore?.Set(nameof(State), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SensitiveType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classificationMethod", n => { ClassificationMethod = n.GetEnumValue<ClassificationMethod>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"publisherName", n => { PublisherName = n.GetStringValue(); } },
                {"rulePackageId", n => { RulePackageId = n.GetStringValue(); } },
                {"rulePackageType", n => { RulePackageType = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetEnumValue<SensitiveTypeScope>(); } },
                {"sensitiveTypeSource", n => { SensitiveTypeSource = n.GetEnumValue<SensitiveTypeSource>(); } },
                {"state", n => { State = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ClassificationMethod>("classificationMethod", ClassificationMethod);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("publisherName", PublisherName);
            writer.WriteStringValue("rulePackageId", RulePackageId);
            writer.WriteStringValue("rulePackageType", RulePackageType);
            writer.WriteEnumValue<SensitiveTypeScope>("scope", Scope);
            writer.WriteEnumValue<SensitiveTypeSource>("sensitiveTypeSource", SensitiveTypeSource);
            writer.WriteStringValue("state", State);
        }
    }
}
