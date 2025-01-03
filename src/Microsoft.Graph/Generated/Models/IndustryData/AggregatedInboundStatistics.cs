// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class AggregatedInboundStatistics : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The aggregate count of errors encountered by activities during this run.</summary>
        public int? Errors
        {
            get { return BackingStore?.Get<int?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
        /// <summary>The aggregate count of active inbound groups processed during the run.</summary>
        public int? Groups
        {
            get { return BackingStore?.Get<int?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
        /// <summary>The aggregate count of active people matched to a Microsoft Entra user, by role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>? MatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>?>("matchedPeopleByRole"); }
            set { BackingStore?.Set("matchedPeopleByRole", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric> MatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>>("matchedPeopleByRole"); }
            set { BackingStore?.Set("matchedPeopleByRole", value); }
        }
#endif
        /// <summary>The aggregate count of active inbound memberships processed during the run.</summary>
        public int? Memberships
        {
            get { return BackingStore?.Get<int?>("memberships"); }
            set { BackingStore?.Set("memberships", value); }
        }
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
        /// <summary>The aggregate count of active inbound organizations processed during the run.</summary>
        public int? Organizations
        {
            get { return BackingStore?.Get<int?>("organizations"); }
            set { BackingStore?.Set("organizations", value); }
        }
        /// <summary>The aggregate count of active inbound people processed during the run.</summary>
        public int? People
        {
            get { return BackingStore?.Get<int?>("people"); }
            set { BackingStore?.Set("people", value); }
        }
        /// <summary>The aggregate count of active people not matched to a Microsoft Entra user, by role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>? UnmatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>?>("unmatchedPeopleByRole"); }
            set { BackingStore?.Set("unmatchedPeopleByRole", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric> UnmatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>>("unmatchedPeopleByRole"); }
            set { BackingStore?.Set("unmatchedPeopleByRole", value); }
        }
#endif
        /// <summary>The aggregate count of warnings generated by activities during this run.</summary>
        public int? Warnings
        {
            get { return BackingStore?.Get<int?>("warnings"); }
            set { BackingStore?.Set("warnings", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics"/> and sets the default values.
        /// </summary>
        public AggregatedInboundStatistics()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.IndustryData.AggregatedInboundStatistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "errors", n => { Errors = n.GetIntValue(); } },
                { "groups", n => { Groups = n.GetIntValue(); } },
                { "matchedPeopleByRole", n => { MatchedPeopleByRole = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>(global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "memberships", n => { Memberships = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "organizations", n => { Organizations = n.GetIntValue(); } },
                { "people", n => { People = n.GetIntValue(); } },
                { "unmatchedPeopleByRole", n => { UnmatchedPeopleByRole = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>(global::Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric.CreateFromDiscriminatorValue)?.AsList(); } },
                { "warnings", n => { Warnings = n.GetIntValue(); } },
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
