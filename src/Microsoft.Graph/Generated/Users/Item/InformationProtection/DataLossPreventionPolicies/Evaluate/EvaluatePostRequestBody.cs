using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.InformationProtection.DataLossPreventionPolicies.Evaluate {
    /// <summary>Provides operations to call the evaluate method.</summary>
    public class EvaluatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The evaluationInput property</summary>
        public DlpEvaluationInput EvaluationInput {
            get { return BackingStore?.Get<DlpEvaluationInput>("evaluationInput"); }
            set { BackingStore?.Set("evaluationInput", value); }
        }
        /// <summary>The notificationInfo property</summary>
        public DlpNotification NotificationInfo {
            get { return BackingStore?.Get<DlpNotification>("notificationInfo"); }
            set { BackingStore?.Set("notificationInfo", value); }
        }
        /// <summary>The target property</summary>
        public string Target {
            get { return BackingStore?.Get<string>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Instantiates a new evaluatePostRequestBody and sets the default values.
        /// </summary>
        public EvaluatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"evaluationInput", n => { EvaluationInput = n.GetObjectValue<DlpEvaluationInput>(DlpEvaluationInput.CreateFromDiscriminatorValue); } },
                {"notificationInfo", n => { NotificationInfo = n.GetObjectValue<DlpNotification>(DlpNotification.CreateFromDiscriminatorValue); } },
                {"target", n => { Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DlpEvaluationInput>("evaluationInput", EvaluationInput);
            writer.WriteObjectValue<DlpNotification>("notificationInfo", NotificationInfo);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
