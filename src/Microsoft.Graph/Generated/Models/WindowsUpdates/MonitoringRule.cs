// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MonitoringRule : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action triggered when the threshold for the given signal is reached. Possible values are: alertError, pauseDeployment, offerFallback, unknownFutureValue. The offerFallback member is only supported on feature update deployments of Windows 11 and must be paired with the ineligible signal. The fallback version offered is the version 22H2 of Windows 10.</summary>
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringAction? Action
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
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
        /// <summary>The signal to monitor. Possible values are: rollback, ineligible, unknownFutureValue. The ineligible member is only supported on feature update deployments of Windows 11 and must be paired with the offerFallback action.</summary>
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringSignal? Signal
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringSignal?>("signal"); }
            set { BackingStore?.Set("signal", value); }
        }
        /// <summary>The threshold for a signal at which to trigger the action. An integer from 1 to 100 (inclusive). This value is ignored when the signal is ineligible and the action is offerFallback.</summary>
        public int? Threshold
        {
            get { return BackingStore?.Get<int?>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringRule"/> and sets the default values.
        /// </summary>
        public MonitoringRule()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringAction>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "signal", n => { Signal = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringSignal>(); } },
                { "threshold", n => { Threshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringAction>("action", Action);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.MonitoringSignal>("signal", Signal);
            writer.WriteIntValue("threshold", Threshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
