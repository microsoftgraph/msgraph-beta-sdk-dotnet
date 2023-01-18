using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BusinessScenarioProperties : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identifier for the bucketDefinition configured in the plannerPlanConfiguration for the scenario. The task will be placed in the corresponding plannerBucket in the target plan. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ExternalBucketId {
            get { return BackingStore?.Get<string?>("externalBucketId"); }
            set { BackingStore?.Set("externalBucketId", value); }
        }
#else
        public string ExternalBucketId {
            get { return BackingStore?.Get<string>("externalBucketId"); }
            set { BackingStore?.Set("externalBucketId", value); }
        }
#endif
        /// <summary>The identifier for the context of the task. Context is an application controlled value, and tasks can be queried by their externalContextId. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ExternalContextId {
            get { return BackingStore?.Get<string?>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
#else
        public string ExternalContextId {
            get { return BackingStore?.Get<string>("externalContextId"); }
            set { BackingStore?.Set("externalContextId", value); }
        }
#endif
        /// <summary>Application-specific identifier for the task. Every task for the same scenario must have a unique identifier specified for this property. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ExternalObjectId {
            get { return BackingStore?.Get<string?>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
#else
        public string ExternalObjectId {
            get { return BackingStore?.Get<string>("externalObjectId"); }
            set { BackingStore?.Set("externalObjectId", value); }
        }
#endif
        /// <summary>Application-specific version of the task. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ExternalObjectVersion {
            get { return BackingStore?.Get<string?>("externalObjectVersion"); }
            set { BackingStore?.Set("externalObjectVersion", value); }
        }
#else
        public string ExternalObjectVersion {
            get { return BackingStore?.Get<string>("externalObjectVersion"); }
            set { BackingStore?.Set("externalObjectVersion", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The URL to the application-specific experience for this task. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? WebUrl {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#else
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new businessScenarioProperties and sets the default values.
        /// </summary>
        public BusinessScenarioProperties() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BusinessScenarioProperties CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BusinessScenarioProperties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"externalBucketId", n => { ExternalBucketId = n.GetStringValue(); } },
                {"externalContextId", n => { ExternalContextId = n.GetStringValue(); } },
                {"externalObjectId", n => { ExternalObjectId = n.GetStringValue(); } },
                {"externalObjectVersion", n => { ExternalObjectVersion = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("externalBucketId", ExternalBucketId);
            writer.WriteStringValue("externalContextId", ExternalContextId);
            writer.WriteStringValue("externalObjectId", ExternalObjectId);
            writer.WriteStringValue("externalObjectVersion", ExternalObjectVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
