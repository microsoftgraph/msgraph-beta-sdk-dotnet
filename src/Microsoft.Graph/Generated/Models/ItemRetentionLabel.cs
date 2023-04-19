using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ItemRetentionLabel : Entity, IParsable {
        /// <summary>The isLabelAppliedExplicitly property</summary>
        public bool? IsLabelAppliedExplicitly {
            get { return BackingStore?.Get<bool?>("isLabelAppliedExplicitly"); }
            set { BackingStore?.Set("isLabelAppliedExplicitly", value); }
        }
        /// <summary>The labelAppliedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LabelAppliedBy {
            get { return BackingStore?.Get<IdentitySet?>("labelAppliedBy"); }
            set { BackingStore?.Set("labelAppliedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LabelAppliedBy {
            get { return BackingStore?.Get<IdentitySet>("labelAppliedBy"); }
            set { BackingStore?.Set("labelAppliedBy", value); }
        }
#endif
        /// <summary>The labelAppliedDateTime property</summary>
        public DateTimeOffset? LabelAppliedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("labelAppliedDateTime"); }
            set { BackingStore?.Set("labelAppliedDateTime", value); }
        }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The retentionSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RetentionLabelSettings? RetentionSettings {
            get { return BackingStore?.Get<RetentionLabelSettings?>("retentionSettings"); }
            set { BackingStore?.Set("retentionSettings", value); }
        }
#nullable restore
#else
        public RetentionLabelSettings RetentionSettings {
            get { return BackingStore?.Get<RetentionLabelSettings>("retentionSettings"); }
            set { BackingStore?.Set("retentionSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemRetentionLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemRetentionLabel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isLabelAppliedExplicitly", n => { IsLabelAppliedExplicitly = n.GetBoolValue(); } },
                {"labelAppliedBy", n => { LabelAppliedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"labelAppliedDateTime", n => { LabelAppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"retentionSettings", n => { RetentionSettings = n.GetObjectValue<RetentionLabelSettings>(RetentionLabelSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isLabelAppliedExplicitly", IsLabelAppliedExplicitly);
            writer.WriteObjectValue<IdentitySet>("labelAppliedBy", LabelAppliedBy);
            writer.WriteDateTimeOffsetValue("labelAppliedDateTime", LabelAppliedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<RetentionLabelSettings>("retentionSettings", RetentionSettings);
        }
    }
}
