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
    public partial class CloudPcAutopilotConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Indicates the number of minutes allowed for the Autopilot application to apply the device preparation profile (DPP) configurations to the device. If the Autopilot application doesn&apos;t finish within the specified time (applicationTimeoutInMinutes), the application error is added to the statusDetail property of the cloudPC object. The supported value is an integer between 10 and 360. Required.</summary>
        public int? ApplicationTimeoutInMinutes
        {
            get { return BackingStore?.Get<int?>("applicationTimeoutInMinutes"); }
            set { BackingStore?.Set("applicationTimeoutInMinutes", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The unique identifier (ID) of the Autopilot device preparation profile (DPP) that links a Windows Autopilot device preparation policy to ensure that devices are ready for users after provisioning. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DevicePreparationProfileId
        {
            get { return BackingStore?.Get<string?>("devicePreparationProfileId"); }
            set { BackingStore?.Set("devicePreparationProfileId", value); }
        }
#nullable restore
#else
        public string DevicePreparationProfileId
        {
            get { return BackingStore?.Get<string>("devicePreparationProfileId"); }
            set { BackingStore?.Set("devicePreparationProfileId", value); }
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
        /// <summary>Indicates whether the access to the device is allowed when the application of Autopilot device preparation profile (DPP) configurations fails or times out. If true, the status of the device is failed and the device is unable to access; otherwise, the status of the device is provisionedWithWarnings and the device is allowed to access. The default value is false. Required.</summary>
        public bool? OnFailureDeviceAccessDenied
        {
            get { return BackingStore?.Get<bool?>("onFailureDeviceAccessDenied"); }
            set { BackingStore?.Set("onFailureDeviceAccessDenied", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration"/> and sets the default values.
        /// </summary>
        public CloudPcAutopilotConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CloudPcAutopilotConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applicationTimeoutInMinutes", n => { ApplicationTimeoutInMinutes = n.GetIntValue(); } },
                { "devicePreparationProfileId", n => { DevicePreparationProfileId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "onFailureDeviceAccessDenied", n => { OnFailureDeviceAccessDenied = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("applicationTimeoutInMinutes", ApplicationTimeoutInMinutes);
            writer.WriteStringValue("devicePreparationProfileId", DevicePreparationProfileId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("onFailureDeviceAccessDenied", OnFailureDeviceAccessDenied);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
