using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to group.</summary>
    public class OpenShift : ChangeTrackedEntity, IParsable {
        /// <summary>An unpublished open shift.</summary>
        public OpenShiftItem DraftOpenShift {
            get { return BackingStore?.Get<OpenShiftItem>(nameof(DraftOpenShift)); }
            set { BackingStore?.Set(nameof(DraftOpenShift), value); }
        }
        /// <summary>The isStagedForDeletion property</summary>
        public bool? IsStagedForDeletion {
            get { return BackingStore?.Get<bool?>(nameof(IsStagedForDeletion)); }
            set { BackingStore?.Set(nameof(IsStagedForDeletion), value); }
        }
        /// <summary>ID for the scheduling group that the open shift belongs to.</summary>
        public string SchedulingGroupId {
            get { return BackingStore?.Get<string>(nameof(SchedulingGroupId)); }
            set { BackingStore?.Set(nameof(SchedulingGroupId), value); }
        }
        /// <summary>A published open shift.</summary>
        public OpenShiftItem SharedOpenShift {
            get { return BackingStore?.Get<OpenShiftItem>(nameof(SharedOpenShift)); }
            set { BackingStore?.Set(nameof(SharedOpenShift), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OpenShift CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OpenShift();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"draftOpenShift", n => { DraftOpenShift = n.GetObjectValue<OpenShiftItem>(OpenShiftItem.CreateFromDiscriminatorValue); } },
                {"isStagedForDeletion", n => { IsStagedForDeletion = n.GetBoolValue(); } },
                {"schedulingGroupId", n => { SchedulingGroupId = n.GetStringValue(); } },
                {"sharedOpenShift", n => { SharedOpenShift = n.GetObjectValue<OpenShiftItem>(OpenShiftItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OpenShiftItem>("draftOpenShift", DraftOpenShift);
            writer.WriteBoolValue("isStagedForDeletion", IsStagedForDeletion);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<OpenShiftItem>("sharedOpenShift", SharedOpenShift);
        }
    }
}
