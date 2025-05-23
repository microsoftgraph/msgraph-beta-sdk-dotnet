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
    public partial class AuthenticationAppPolicyDetails : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The admin configuration of the policy on the user&apos;s authentication app. For a policy that does not impact the success/failure of the authentication, the evaluation defaults to notApplicable. The possible values are: notApplicable, enabled, disabled, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AuthenticationAppAdminConfiguration? AdminConfiguration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationAppAdminConfiguration?>("adminConfiguration"); }
            set { BackingStore?.Set("adminConfiguration", value); }
        }
        /// <summary>Evaluates the success/failure of the authentication based on the admin configuration of the policy on the user&apos;s client authentication app. The possible values are: success, failure, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AuthenticationAppEvaluation? AuthenticationEvaluation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationAppEvaluation?>("authenticationEvaluation"); }
            set { BackingStore?.Set("authenticationEvaluation", value); }
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
        /// <summary>The name of the policy enforced on the user&apos;s authentication app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PolicyName
        {
            get { return BackingStore?.Get<string?>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#nullable restore
#else
        public string PolicyName
        {
            get { return BackingStore?.Get<string>("policyName"); }
            set { BackingStore?.Set("policyName", value); }
        }
#endif
        /// <summary>Refers to whether the policy executed as expected on the user&apos;s client authentication app. The possible values are: unknown, appLockOutOfDate, appLockEnabled, appLockDisabled, appContextOutOfDate, appContextShown, appContextNotShown, locationContextOutOfDate, locationContextShown, locationContextNotShown, numberMatchOutOfDate, numberMatchCorrectNumberEntered, numberMatchIncorrectNumberEntered, numberMatchDeny, tamperResistantHardwareOutOfDate, tamperResistantHardwareUsed, tamperResistantHardwareNotUsed, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyDetails"/> and sets the default values.
        /// </summary>
        public AuthenticationAppPolicyDetails()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "adminConfiguration", n => { AdminConfiguration = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationAppAdminConfiguration>(); } },
                { "authenticationEvaluation", n => { AuthenticationEvaluation = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationAppEvaluation>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "policyName", n => { PolicyName = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationAppAdminConfiguration>("adminConfiguration", AdminConfiguration);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationAppEvaluation>("authenticationEvaluation", AuthenticationEvaluation);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("policyName", PolicyName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.AuthenticationAppPolicyStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
