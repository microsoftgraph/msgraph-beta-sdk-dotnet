using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OpenShift : ChangeTrackedEntity, IParsable {
        /// <summary>An unpublished open shift.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public OpenShiftItem? DraftOpenShift {
            get { return BackingStore?.Get<OpenShiftItem?>("draftOpenShift"); }
            set { BackingStore?.Set("draftOpenShift", value); }
        }
#else
        public OpenShiftItem DraftOpenShift {
            get { return BackingStore?.Get<OpenShiftItem>("draftOpenShift"); }
            set { BackingStore?.Set("draftOpenShift", value); }
        }
#endif
        /// <summary>The isStagedForDeletion property</summary>
        public bool? IsStagedForDeletion {
            get { return BackingStore?.Get<bool?>("isStagedForDeletion"); }
            set { BackingStore?.Set("isStagedForDeletion", value); }
        }
        /// <summary>ID for the scheduling group that the open shift belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SchedulingGroupId {
            get { return BackingStore?.Get<string?>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#else
        public string SchedulingGroupId {
            get { return BackingStore?.Get<string>("schedulingGroupId"); }
            set { BackingStore?.Set("schedulingGroupId", value); }
        }
#endif
        /// <summary>A published open shift.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public OpenShiftItem? SharedOpenShift {
            get { return BackingStore?.Get<OpenShiftItem?>("sharedOpenShift"); }
            set { BackingStore?.Set("sharedOpenShift", value); }
        }
#else
        public OpenShiftItem SharedOpenShift {
            get { return BackingStore?.Get<OpenShiftItem>("sharedOpenShift"); }
            set { BackingStore?.Set("sharedOpenShift", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new OpenShift and sets the default values.
        /// </summary>
        public OpenShift() : base() {
            OdataType = "#microsoft.graph.openShift";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
