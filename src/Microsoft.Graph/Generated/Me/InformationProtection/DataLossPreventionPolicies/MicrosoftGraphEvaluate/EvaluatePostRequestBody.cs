using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.InformationProtection.DataLossPreventionPolicies.MicrosoftGraphEvaluate {
    public class EvaluatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The evaluationInput property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DlpEvaluationInput? EvaluationInput {
            get { return BackingStore?.Get<DlpEvaluationInput?>("evaluationInput"); }
            set { BackingStore?.Set("evaluationInput", value); }
        }
#nullable restore
#else
        public DlpEvaluationInput EvaluationInput {
            get { return BackingStore?.Get<DlpEvaluationInput>("evaluationInput"); }
            set { BackingStore?.Set("evaluationInput", value); }
        }
#endif
        /// <summary>The notificationInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DlpNotification? NotificationInfo {
            get { return BackingStore?.Get<DlpNotification?>("notificationInfo"); }
            set { BackingStore?.Set("notificationInfo", value); }
        }
#nullable restore
#else
        public DlpNotification NotificationInfo {
            get { return BackingStore?.Get<DlpNotification>("notificationInfo"); }
            set { BackingStore?.Set("notificationInfo", value); }
        }
#endif
        /// <summary>The target property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Target {
            get { return BackingStore?.Get<string?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public string Target {
            get { return BackingStore?.Get<string>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new evaluatePostRequestBody and sets the default values.
        /// </summary>
        public EvaluatePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DlpEvaluationInput>("evaluationInput", EvaluationInput);
            writer.WriteObjectValue<DlpNotification>("notificationInfo", NotificationInfo);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
