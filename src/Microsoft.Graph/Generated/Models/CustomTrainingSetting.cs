using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CustomTrainingSetting : TrainingSetting, IParsable {
        /// <summary>The assignedTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TrainingAssignedTo?>? AssignedTo {
            get { return BackingStore?.Get<List<TrainingAssignedTo?>?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public List<TrainingAssignedTo?> AssignedTo {
            get { return BackingStore?.Get<List<TrainingAssignedTo?>>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The durationInMinutes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DurationInMinutes {
            get { return BackingStore?.Get<string?>("durationInMinutes"); }
            set { BackingStore?.Set("durationInMinutes", value); }
        }
#nullable restore
#else
        public string DurationInMinutes {
            get { return BackingStore?.Get<string>("durationInMinutes"); }
            set { BackingStore?.Set("durationInMinutes", value); }
        }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url {
            get { return BackingStore?.Get<string?>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#nullable restore
#else
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new customTrainingSetting and sets the default values.
        /// </summary>
        public CustomTrainingSetting() : base() {
            OdataType = "#microsoft.graph.customTrainingSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomTrainingSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomTrainingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetCollectionOfEnumValues<TrainingAssignedTo>()?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"durationInMinutes", n => { DurationInMinutes = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<TrainingAssignedTo>("assignedTo", AssignedTo);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("durationInMinutes", DurationInMinutes);
            writer.WriteStringValue("url", Url);
        }
    }
}
