using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityEvaluateRemoval {
    public class EvaluateRemovalPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The contentInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.ContentInfo? ContentInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ContentInfo?>("contentInfo"); }
            set { BackingStore?.Set("contentInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.ContentInfo ContentInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ContentInfo>("contentInfo"); }
            set { BackingStore?.Set("contentInfo", value); }
        }
#endif
        /// <summary>The downgradeJustification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.DowngradeJustification? DowngradeJustification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DowngradeJustification?>("downgradeJustification"); }
            set { BackingStore?.Set("downgradeJustification", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.DowngradeJustification DowngradeJustification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>("downgradeJustification"); }
            set { BackingStore?.Set("downgradeJustification", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new evaluateRemovalPostRequestBody and sets the default values.
        /// </summary>
        public EvaluateRemovalPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EvaluateRemovalPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateRemovalPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.ContentInfo>(Microsoft.Graph.Beta.Models.Security.ContentInfo.CreateFromDiscriminatorValue); } },
                {"downgradeJustification", n => { DowngradeJustification = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>(Microsoft.Graph.Beta.Models.Security.DowngradeJustification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
