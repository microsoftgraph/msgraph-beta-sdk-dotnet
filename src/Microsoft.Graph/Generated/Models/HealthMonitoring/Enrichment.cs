// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.HealthMonitoring
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Enrichment : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>A collection of resource impact summaries that gives a high level view of the kind of resources that were impacted and to what degree.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary>? Impacts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary>?>("impacts"); }
            set { BackingStore?.Set("impacts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary> Impacts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary>>("impacts"); }
            set { BackingStore?.Set("impacts", value); }
        }
#endif
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
        /// <summary>The state property</summary>
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.EnrichmentState? State
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.EnrichmentState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>A collection of supportingData locations that can be queried for debugging the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData? SupportingData
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData?>("supportingData"); }
            set { BackingStore?.Set("supportingData", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData SupportingData
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData>("supportingData"); }
            set { BackingStore?.Set("supportingData", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment"/> and sets the default values.
        /// </summary>
        public Enrichment()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.HealthMonitoring.Enrichment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "impacts", n => { Impacts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary>(global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.EnrichmentState>(); } },
                { "supportingData", n => { SupportingData = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData>(global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.HealthMonitoring.ResourceImpactSummary>("impacts", Impacts);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.EnrichmentState>("state", State);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.HealthMonitoring.SupportingData>("supportingData", SupportingData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
