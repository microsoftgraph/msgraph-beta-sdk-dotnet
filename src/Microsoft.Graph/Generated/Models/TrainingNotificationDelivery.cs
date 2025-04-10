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
    public partial class TrainingNotificationDelivery : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The number of users to whom mails couldn&apos;t be delivered.</summary>
        public int? FailedMessageDeliveryCount
        {
            get { return BackingStore?.Get<int?>("failedMessageDeliveryCount"); }
            set { BackingStore?.Set("failedMessageDeliveryCount", value); }
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
        /// <summary>The number of users whose email address was successfully resolved from target users.</summary>
        public int? ResolvedTargetsCount
        {
            get { return BackingStore?.Get<int?>("resolvedTargetsCount"); }
            set { BackingStore?.Set("resolvedTargetsCount", value); }
        }
        /// <summary>The number of users who received a mail while the training campaign was in the &apos;in progress&apos; state.</summary>
        public int? SuccessfulMessageDeliveryCount
        {
            get { return BackingStore?.Get<int?>("successfulMessageDeliveryCount"); }
            set { BackingStore?.Set("successfulMessageDeliveryCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.TrainingNotificationDelivery"/> and sets the default values.
        /// </summary>
        public TrainingNotificationDelivery()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.TrainingNotificationDelivery"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.TrainingNotificationDelivery CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.TrainingNotificationDelivery();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "failedMessageDeliveryCount", n => { FailedMessageDeliveryCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "resolvedTargetsCount", n => { ResolvedTargetsCount = n.GetIntValue(); } },
                { "successfulMessageDeliveryCount", n => { SuccessfulMessageDeliveryCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedMessageDeliveryCount", FailedMessageDeliveryCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("resolvedTargetsCount", ResolvedTargetsCount);
            writer.WriteIntValue("successfulMessageDeliveryCount", SuccessfulMessageDeliveryCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
