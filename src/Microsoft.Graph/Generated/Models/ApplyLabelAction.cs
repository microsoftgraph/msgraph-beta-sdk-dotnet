// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ApplyLabelAction : global::Microsoft.Graph.Beta.Models.InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The collection of specific actions that should be taken by the consuming application to label the document. See  informationProtectionAction for the full list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.InformationProtectionAction>? Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InformationProtectionAction>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.InformationProtectionAction> Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.InformationProtectionAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>The actionSource property</summary>
        public global::Microsoft.Graph.Beta.Models.ActionSource? ActionSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ActionSource?>("actionSource"); }
            set { BackingStore?.Set("actionSource", value); }
        }
        /// <summary>Object that describes the details of the label to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.LabelDetails? Label
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LabelDetails?>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.LabelDetails Label
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.LabelDetails>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#endif
        /// <summary>If the label was the result of an automatic classification, supply the list of sensitive info type GUIDs that resulted in the returned label.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ResponsibleSensitiveTypeIds
        {
            get { return BackingStore?.Get<List<Guid?>?>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
#nullable restore
#else
        public List<Guid?> ResponsibleSensitiveTypeIds
        {
            get { return BackingStore?.Get<List<Guid?>>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ApplyLabelAction"/> and sets the default values.
        /// </summary>
        public ApplyLabelAction() : base()
        {
            OdataType = "#microsoft.graph.applyLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ApplyLabelAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ApplyLabelAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ApplyLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionSource", n => { ActionSource = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.ActionSource>(); } },
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InformationProtectionAction>(global::Microsoft.Graph.Beta.Models.InformationProtectionAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "label", n => { Label = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.LabelDetails>(global::Microsoft.Graph.Beta.Models.LabelDetails.CreateFromDiscriminatorValue); } },
                { "responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<Guid?>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.InformationProtectionAction>("actions", Actions);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.ActionSource>("actionSource", ActionSource);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.LabelDetails>("label", Label);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
        }
    }
}
#pragma warning restore CS0618
