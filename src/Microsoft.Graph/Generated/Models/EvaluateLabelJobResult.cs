// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EvaluateLabelJobResult : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The responsiblePolicy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ResponsiblePolicy? ResponsiblePolicy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResponsiblePolicy?>("responsiblePolicy"); }
            set { BackingStore?.Set("responsiblePolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ResponsiblePolicy ResponsiblePolicy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResponsiblePolicy>("responsiblePolicy"); }
            set { BackingStore?.Set("responsiblePolicy", value); }
        }
#endif
        /// <summary>The responsibleSensitiveTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ResponsibleSensitiveType>? ResponsibleSensitiveTypes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ResponsibleSensitiveType>?>("responsibleSensitiveTypes"); }
            set { BackingStore?.Set("responsibleSensitiveTypes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ResponsibleSensitiveType> ResponsibleSensitiveTypes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ResponsibleSensitiveType>>("responsibleSensitiveTypes"); }
            set { BackingStore?.Set("responsibleSensitiveTypes", value); }
        }
#endif
        /// <summary>The sensitivityLabel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MatchingLabel? SensitivityLabel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MatchingLabel?>("sensitivityLabel"); }
            set { BackingStore?.Set("sensitivityLabel", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MatchingLabel SensitivityLabel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MatchingLabel>("sensitivityLabel"); }
            set { BackingStore?.Set("sensitivityLabel", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.EvaluateLabelJobResult"/> and sets the default values.
        /// </summary>
        public EvaluateLabelJobResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EvaluateLabelJobResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.EvaluateLabelJobResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.EvaluateLabelJobResult();
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
                { "responsiblePolicy", n => { ResponsiblePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResponsiblePolicy>(Microsoft.Graph.Beta.Models.ResponsiblePolicy.CreateFromDiscriminatorValue); } },
                { "responsibleSensitiveTypes", n => { ResponsibleSensitiveTypes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ResponsibleSensitiveType>(Microsoft.Graph.Beta.Models.ResponsibleSensitiveType.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sensitivityLabel", n => { SensitivityLabel = n.GetObjectValue<Microsoft.Graph.Beta.Models.MatchingLabel>(Microsoft.Graph.Beta.Models.MatchingLabel.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResponsiblePolicy>("responsiblePolicy", ResponsiblePolicy);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ResponsibleSensitiveType>("responsibleSensitiveTypes", ResponsibleSensitiveTypes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MatchingLabel>("sensitivityLabel", SensitivityLabel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
