// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SelfServiceSignUp : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The appDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName
        {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName
        {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>The appId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>The appliedEventListeners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener>? AppliedEventListeners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener>?>("appliedEventListeners"); }
            set { BackingStore?.Set("appliedEventListeners", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener> AppliedEventListeners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener>>("appliedEventListeners"); }
            set { BackingStore?.Set("appliedEventListeners", value); }
        }
#endif
        /// <summary>The correlationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId
        {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId
        {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The signUpIdentity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SignUpIdentity? SignUpIdentity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignUpIdentity?>("signUpIdentity"); }
            set { BackingStore?.Set("signUpIdentity", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SignUpIdentity SignUpIdentity
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignUpIdentity>("signUpIdentity"); }
            set { BackingStore?.Set("signUpIdentity", value); }
        }
#endif
        /// <summary>The signUpIdentityProvider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignUpIdentityProvider
        {
            get { return BackingStore?.Get<string?>("signUpIdentityProvider"); }
            set { BackingStore?.Set("signUpIdentityProvider", value); }
        }
#nullable restore
#else
        public string SignUpIdentityProvider
        {
            get { return BackingStore?.Get<string>("signUpIdentityProvider"); }
            set { BackingStore?.Set("signUpIdentityProvider", value); }
        }
#endif
        /// <summary>The signUpStage property</summary>
        public global::Microsoft.Graph.Beta.Models.SignUpStage? SignUpStage
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignUpStage?>("signUpStage"); }
            set { BackingStore?.Set("signUpStage", value); }
        }
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SignUpStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignUpStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SignUpStatus Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SignUpStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The userSnapshot property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CiamUserSnapshot? UserSnapshot
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CiamUserSnapshot?>("userSnapshot"); }
            set { BackingStore?.Set("userSnapshot", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CiamUserSnapshot UserSnapshot
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CiamUserSnapshot>("userSnapshot"); }
            set { BackingStore?.Set("userSnapshot", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SelfServiceSignUp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.SelfServiceSignUp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SelfServiceSignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "appliedEventListeners", n => { AppliedEventListeners = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener>(global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener.CreateFromDiscriminatorValue)?.AsList(); } },
                { "correlationId", n => { CorrelationId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "signUpIdentity", n => { SignUpIdentity = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SignUpIdentity>(global::Microsoft.Graph.Beta.Models.SignUpIdentity.CreateFromDiscriminatorValue); } },
                { "signUpIdentityProvider", n => { SignUpIdentityProvider = n.GetStringValue(); } },
                { "signUpStage", n => { SignUpStage = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.SignUpStage>(); } },
                { "status", n => { Status = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SignUpStatus>(global::Microsoft.Graph.Beta.Models.SignUpStatus.CreateFromDiscriminatorValue); } },
                { "userSnapshot", n => { UserSnapshot = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CiamUserSnapshot>(global::Microsoft.Graph.Beta.Models.CiamUserSnapshot.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.AppliedAuthenticationEventListener>("appliedEventListeners", AppliedEventListeners);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SignUpIdentity>("signUpIdentity", SignUpIdentity);
            writer.WriteStringValue("signUpIdentityProvider", SignUpIdentityProvider);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.SignUpStage>("signUpStage", SignUpStage);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SignUpStatus>("status", Status);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CiamUserSnapshot>("userSnapshot", UserSnapshot);
        }
    }
}
#pragma warning restore CS0618
