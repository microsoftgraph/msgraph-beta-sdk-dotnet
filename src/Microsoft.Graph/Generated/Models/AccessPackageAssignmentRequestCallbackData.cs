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
    public partial class AccessPackageAssignmentRequestCallbackData : global::Microsoft.Graph.Beta.Models.CustomExtensionData, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Details for the callback.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomExtensionStageInstanceDetail
        {
            get { return BackingStore?.Get<string?>("customExtensionStageInstanceDetail"); }
            set { BackingStore?.Set("customExtensionStageInstanceDetail", value); }
        }
#nullable restore
#else
        public string CustomExtensionStageInstanceDetail
        {
            get { return BackingStore?.Get<string>("customExtensionStageInstanceDetail"); }
            set { BackingStore?.Set("customExtensionStageInstanceDetail", value); }
        }
#endif
        /// <summary>Unique identifier of the callout to the custom extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomExtensionStageInstanceId
        {
            get { return BackingStore?.Get<string?>("customExtensionStageInstanceId"); }
            set { BackingStore?.Set("customExtensionStageInstanceId", value); }
        }
#nullable restore
#else
        public string CustomExtensionStageInstanceId
        {
            get { return BackingStore?.Get<string>("customExtensionStageInstanceId"); }
            set { BackingStore?.Set("customExtensionStageInstanceId", value); }
        }
#endif
        /// <summary>Indicates the stage at which the custom callout extension is executed. The possible values are: assignmentRequestCreated, assignmentRequestApproved, assignmentRequestGranted, assignmentRequestRemoved, assignmentFourteenDaysBeforeExpiration, assignmentOneDayBeforeExpiration, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage? Stage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage?>("stage"); }
            set { BackingStore?.Set("stage", value); }
        }
        /// <summary>Allow the extension to be able to deny or cancel the request submitted by the requestor. The supported values are Denied and Canceled. This property can only be set for an assignmentRequestCreated stage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State
        {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State
        {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequestCallbackData"/> and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestCallbackData() : base()
        {
            OdataType = "#microsoft.graph.accessPackageAssignmentRequestCallbackData";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequestCallbackData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequestCallbackData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.assignmentRequestApprovalStageCallbackData" => new global::Microsoft.Graph.Beta.Models.AssignmentRequestApprovalStageCallbackData(),
                _ => new global::Microsoft.Graph.Beta.Models.AccessPackageAssignmentRequestCallbackData(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "customExtensionStageInstanceDetail", n => { CustomExtensionStageInstanceDetail = n.GetStringValue(); } },
                { "customExtensionStageInstanceId", n => { CustomExtensionStageInstanceId = n.GetStringValue(); } },
                { "stage", n => { Stage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage>(); } },
                { "state", n => { State = n.GetStringValue(); } },
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
            writer.WriteStringValue("customExtensionStageInstanceDetail", CustomExtensionStageInstanceDetail);
            writer.WriteStringValue("customExtensionStageInstanceId", CustomExtensionStageInstanceId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AccessPackageCustomExtensionStage>("stage", Stage);
            writer.WriteStringValue("state", State);
        }
    }
}
#pragma warning restore CS0618
