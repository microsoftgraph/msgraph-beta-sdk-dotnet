using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Shift : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this shift that is viewable by managers. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShiftItem? DraftShift {
            get { return BackingStore?.Get<ShiftItem?>("draftShift"); }
            set { BackingStore?.Set("draftShift", value); }
        }
#nullable restore
#else
        public ShiftItem DraftShift {
            get { return BackingStore?.Get<ShiftItem>("draftShift"); }
            set { BackingStore?.Set("draftShift", value); }
        }
#endif
        /// <summary>The isStagedForDeletion property</summary>
        public bool? IsStagedForDeletion {
            get { return BackingStore?.Get<bool?>("isStagedForDeletion"); }
            set { BackingStore?.Set("isStagedForDeletion", value); }
        }
        /// <summary>The schedulingGroupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SchedulingGroupId {
            get { return BackingStore?.Get<string?>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#nullable restore
#else
        public string SchedulingGroupId {
            get { return BackingStore?.Get<string>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#endif
        /// <summary>The sharedShift property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ShiftItem? SharedShift {
            get { return BackingStore?.Get<ShiftItem?>("sharedShift"); }
            set { BackingStore?.Set("sharedShift", value); }
        }
#nullable restore
#else
        public ShiftItem SharedShift {
            get { return BackingStore?.Get<ShiftItem>("sharedShift"); }
            set { BackingStore?.Set("sharedShift", value); }
        }
#endif
        /// <summary>The userId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Shift and sets the default values.
        /// </summary>
        public Shift() : base() {
            OdataType = "#microsoft.graph.shift";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Shift CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Shift();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"draftShift", n => { DraftShift = n.GetObjectValue<ShiftItem>(ShiftItem.CreateFromDiscriminatorValue); } },
                {"isStagedForDeletion", n => { IsStagedForDeletion = n.GetBoolValue(); } },
                {"schedulingGroupId", n => { SchedulingGroupId = n.GetStringValue(); } },
                {"sharedShift", n => { SharedShift = n.GetObjectValue<ShiftItem>(ShiftItem.CreateFromDiscriminatorValue); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ShiftItem>("draftShift", DraftShift);
            writer.WriteBoolValue("isStagedForDeletion", IsStagedForDeletion);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<ShiftItem>("sharedShift", SharedShift);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
