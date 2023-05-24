using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskDetails : PlannerDelta, IParsable {
        /// <summary>The collection of checklist items on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerChecklistItems? Checklist {
            get { return BackingStore?.Get<PlannerChecklistItems?>("checklist"); }
            set { BackingStore?.Set("checklist", value); }
        }
#nullable restore
#else
        public PlannerChecklistItems Checklist {
            get { return BackingStore?.Get<PlannerChecklistItems>("checklist"); }
            set { BackingStore?.Set("checklist", value); }
        }
#endif
        /// <summary>The completionRequirements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerTaskCompletionRequirementDetails? CompletionRequirements {
            get { return BackingStore?.Get<PlannerTaskCompletionRequirementDetails?>("completionRequirements"); }
            set { BackingStore?.Set("completionRequirements", value); }
        }
#nullable restore
#else
        public PlannerTaskCompletionRequirementDetails CompletionRequirements {
            get { return BackingStore?.Get<PlannerTaskCompletionRequirementDetails>("completionRequirements"); }
            set { BackingStore?.Set("completionRequirements", value); }
        }
#endif
        /// <summary>Description of the task.</summary>
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
        /// <summary>Rich text description of the task. To be used by HTML-aware clients. For backwards compatibility, a plain-text version of the HTML description will be synced to the &apos;description&apos; field. If this field has not previously been set but &apos;description&apos; has been, the existing description will be synchronized to &apos;notes&apos; with minimal whitespace-preserving HTML markup. Setting both &apos;description&apos; and &apos;notes&apos; is an error and will result in an exception.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Notes {
            get { return BackingStore?.Get<ItemBody?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public ItemBody Notes {
            get { return BackingStore?.Get<ItemBody>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>This sets the type of preview that shows up on the task. Possible values are: automatic, noPreview, checklist, description, reference. When set to automatic the displayed preview is chosen by the app viewing the task.</summary>
        public PlannerPreviewType? PreviewType {
            get { return BackingStore?.Get<PlannerPreviewType?>("previewType"); }
            set { BackingStore?.Set("previewType", value); }
        }
        /// <summary>The collection of references on the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerExternalReferences? References {
            get { return BackingStore?.Get<PlannerExternalReferences?>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#nullable restore
#else
        public PlannerExternalReferences References {
            get { return BackingStore?.Get<PlannerExternalReferences>("references"); }
            set { BackingStore?.Set("references", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTaskDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"checklist", n => { Checklist = n.GetObjectValue<PlannerChecklistItems>(PlannerChecklistItems.CreateFromDiscriminatorValue); } },
                {"completionRequirements", n => { CompletionRequirements = n.GetObjectValue<PlannerTaskCompletionRequirementDetails>(PlannerTaskCompletionRequirementDetails.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"previewType", n => { PreviewType = n.GetEnumValue<PlannerPreviewType>(); } },
                {"references", n => { References = n.GetObjectValue<PlannerExternalReferences>(PlannerExternalReferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PlannerChecklistItems>("checklist", Checklist);
            writer.WriteObjectValue<PlannerTaskCompletionRequirementDetails>("completionRequirements", CompletionRequirements);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteEnumValue<PlannerPreviewType>("previewType", PreviewType);
            writer.WriteObjectValue<PlannerExternalReferences>("references", References);
        }
    }
}
