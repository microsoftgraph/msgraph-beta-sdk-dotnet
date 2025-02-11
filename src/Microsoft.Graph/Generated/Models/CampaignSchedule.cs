// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CampaignSchedule : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The date and time at which the campaign completed.</summary>
        public DateTimeOffset? CompletionDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>The date and time at which the campaign was launched.</summary>
        public DateTimeOffset? LaunchDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("launchDateTime"); }
            set { BackingStore?.Set("launchDateTime", value); }
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
        /// <summary>The current state of the campaign. The possible values are: unknown, draft, inProgress, scheduled, completed, failed, cancelled, excluded, deleted, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.CampaignStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CampaignStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CampaignSchedule"/> and sets the default values.
        /// </summary>
        public CampaignSchedule()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CampaignSchedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CampaignSchedule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CampaignSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                { "launchDateTime", n => { LaunchDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.CampaignStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteDateTimeOffsetValue("launchDateTime", LaunchDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.CampaignStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
