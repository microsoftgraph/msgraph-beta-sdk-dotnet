using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Shift : ChangeTrackedEntity, IParsable {
        /// <summary>The draft version of this shift that is viewable by managers. Required.</summary>
        public ShiftItem DraftShift {
            get { return BackingStore?.Get<ShiftItem>(nameof(DraftShift)); }
            set { BackingStore?.Set(nameof(DraftShift), value); }
        }
        /// <summary>The isStagedForDeletion property</summary>
        public bool? IsStagedForDeletion {
            get { return BackingStore?.Get<bool?>(nameof(IsStagedForDeletion)); }
            set { BackingStore?.Set(nameof(IsStagedForDeletion), value); }
        }
        /// <summary>ID of the scheduling group the shift is part of. Required.</summary>
        public string SchedulingGroupId {
            get { return BackingStore?.Get<string>(nameof(SchedulingGroupId)); }
            set { BackingStore?.Set(nameof(SchedulingGroupId), value); }
        }
        /// <summary>The shared version of this shift that is viewable by both employees and managers. Required.</summary>
        public ShiftItem SharedShift {
            get { return BackingStore?.Get<ShiftItem>(nameof(SharedShift)); }
            set { BackingStore?.Set(nameof(SharedShift), value); }
        }
        /// <summary>ID of the user assigned to the shift. Required.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
