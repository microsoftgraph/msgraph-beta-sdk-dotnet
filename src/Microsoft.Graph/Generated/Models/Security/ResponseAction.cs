// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ResponseAction : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.ResponseAction"/> and sets the default values.
        /// </summary>
        public ResponseAction()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.ResponseAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.Security.ResponseAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.allowFileResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.AllowFileResponseAction(),
                "#microsoft.graph.security.blockFileResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.BlockFileResponseAction(),
                "#microsoft.graph.security.collectInvestigationPackageIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.CollectInvestigationPackageIncidentTaskResponseAction(),
                "#microsoft.graph.security.collectInvestigationPackageResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.CollectInvestigationPackageResponseAction(),
                "#microsoft.graph.security.disableUserIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.DisableUserIncidentTaskResponseAction(),
                "#microsoft.graph.security.disableUserResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.DisableUserResponseAction(),
                "#microsoft.graph.security.enableUserIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.EnableUserIncidentTaskResponseAction(),
                "#microsoft.graph.security.forceUserPasswordResetIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.ForceUserPasswordResetIncidentTaskResponseAction(),
                "#microsoft.graph.security.forceUserPasswordResetResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.ForceUserPasswordResetResponseAction(),
                "#microsoft.graph.security.hardDeleteEmailIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.HardDeleteEmailIncidentTaskResponseAction(),
                "#microsoft.graph.security.hardDeleteResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.HardDeleteResponseAction(),
                "#microsoft.graph.security.incidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.IncidentTaskResponseAction(),
                "#microsoft.graph.security.initiateInvestigationResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.InitiateInvestigationResponseAction(),
                "#microsoft.graph.security.isolateDeviceIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.IsolateDeviceIncidentTaskResponseAction(),
                "#microsoft.graph.security.isolateDeviceResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.IsolateDeviceResponseAction(),
                "#microsoft.graph.security.markUserAsCompromisedIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.MarkUserAsCompromisedIncidentTaskResponseAction(),
                "#microsoft.graph.security.markUserAsCompromisedResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.MarkUserAsCompromisedResponseAction(),
                "#microsoft.graph.security.moveToDeletedItemsResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.MoveToDeletedItemsResponseAction(),
                "#microsoft.graph.security.moveToInboxResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.MoveToInboxResponseAction(),
                "#microsoft.graph.security.moveToJunkResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.MoveToJunkResponseAction(),
                "#microsoft.graph.security.requireSignInIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.RequireSignInIncidentTaskResponseAction(),
                "#microsoft.graph.security.restrictAppExecutionIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.RestrictAppExecutionIncidentTaskResponseAction(),
                "#microsoft.graph.security.restrictAppExecutionResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.RestrictAppExecutionResponseAction(),
                "#microsoft.graph.security.runAntivirusScanIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.RunAntivirusScanIncidentTaskResponseAction(),
                "#microsoft.graph.security.runAntivirusScanResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.RunAntivirusScanResponseAction(),
                "#microsoft.graph.security.softDeleteIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.SoftDeleteIncidentTaskResponseAction(),
                "#microsoft.graph.security.softDeleteResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.SoftDeleteResponseAction(),
                "#microsoft.graph.security.stopAndQuarantineFileIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.StopAndQuarantineFileIncidentTaskResponseAction(),
                "#microsoft.graph.security.stopAndQuarantineFileResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.StopAndQuarantineFileResponseAction(),
                "#microsoft.graph.security.unIsolateDeviceIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.UnIsolateDeviceIncidentTaskResponseAction(),
                "#microsoft.graph.security.unRestrictAppExecutionIncidentTaskResponseAction" => new global::Microsoft.Graph.Beta.Models.Security.UnRestrictAppExecutionIncidentTaskResponseAction(),
                _ => new global::Microsoft.Graph.Beta.Models.Security.ResponseAction(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
