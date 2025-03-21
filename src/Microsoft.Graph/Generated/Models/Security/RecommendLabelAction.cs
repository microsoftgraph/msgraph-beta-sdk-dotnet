// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RecommendLabelAction : global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Actions to take if the label is accepted by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction>? Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction> Actions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>The actionSource property</summary>
        public global::Microsoft.Graph.Beta.Models.Security.ActionSource? ActionSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.ActionSource?>("actionSource"); }
            set { BackingStore?.Set("actionSource", value); }
        }
        /// <summary>The sensitive information type GUIDs that caused the recommendation to be given.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResponsibleSensitiveTypeIds
        {
            get { return BackingStore?.Get<List<string>?>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
#nullable restore
#else
        public List<string> ResponsibleSensitiveTypeIds
        {
            get { return BackingStore?.Get<List<string>>("responsibleSensitiveTypeIds"); }
            set { BackingStore?.Set("responsibleSensitiveTypeIds", value); }
        }
#endif
        /// <summary>The sensitivityLabelId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SensitivityLabelId
        {
            get { return BackingStore?.Get<string?>("sensitivityLabelId"); }
            set { BackingStore?.Set("sensitivityLabelId", value); }
        }
#nullable restore
#else
        public string SensitivityLabelId
        {
            get { return BackingStore?.Get<string>("sensitivityLabelId"); }
            set { BackingStore?.Set("sensitivityLabelId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.RecommendLabelAction"/> and sets the default values.
        /// </summary>
        public RecommendLabelAction() : base()
        {
            OdataType = "#microsoft.graph.security.recommendLabelAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.RecommendLabelAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.RecommendLabelAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.RecommendLabelAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionSource", n => { ActionSource = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.ActionSource>(); } },
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction>(global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "responsibleSensitiveTypeIds", n => { ResponsibleSensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "sensitivityLabelId", n => { SensitivityLabelId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.InformationProtectionAction>("actions", Actions);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.ActionSource>("actionSource", ActionSource);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibleSensitiveTypeIds", ResponsibleSensitiveTypeIds);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
        }
    }
}
#pragma warning restore CS0618
