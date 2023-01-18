using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ThreatSubmissionRoot : Entity, IParsable {
        /// <summary>The emailThreats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EmailThreatSubmission>? EmailThreats {
            get { return BackingStore?.Get<List<EmailThreatSubmission>?>("emailThreats"); }
            set { BackingStore?.Set("emailThreats", value); }
        }
#else
        public List<EmailThreatSubmission> EmailThreats {
            get { return BackingStore?.Get<List<EmailThreatSubmission>>("emailThreats"); }
            set { BackingStore?.Set("emailThreats", value); }
        }
#endif
        /// <summary>The emailThreatSubmissionPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EmailThreatSubmissionPolicy>? EmailThreatSubmissionPolicies {
            get { return BackingStore?.Get<List<EmailThreatSubmissionPolicy>?>("emailThreatSubmissionPolicies"); }
            set { BackingStore?.Set("emailThreatSubmissionPolicies", value); }
        }
#else
        public List<EmailThreatSubmissionPolicy> EmailThreatSubmissionPolicies {
            get { return BackingStore?.Get<List<EmailThreatSubmissionPolicy>>("emailThreatSubmissionPolicies"); }
            set { BackingStore?.Set("emailThreatSubmissionPolicies", value); }
        }
#endif
        /// <summary>The fileThreats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<FileThreatSubmission>? FileThreats {
            get { return BackingStore?.Get<List<FileThreatSubmission>?>("fileThreats"); }
            set { BackingStore?.Set("fileThreats", value); }
        }
#else
        public List<FileThreatSubmission> FileThreats {
            get { return BackingStore?.Get<List<FileThreatSubmission>>("fileThreats"); }
            set { BackingStore?.Set("fileThreats", value); }
        }
#endif
        /// <summary>The urlThreats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UrlThreatSubmission>? UrlThreats {
            get { return BackingStore?.Get<List<UrlThreatSubmission>?>("urlThreats"); }
            set { BackingStore?.Set("urlThreats", value); }
        }
#else
        public List<UrlThreatSubmission> UrlThreats {
            get { return BackingStore?.Get<List<UrlThreatSubmission>>("urlThreats"); }
            set { BackingStore?.Set("urlThreats", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ThreatSubmissionRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThreatSubmissionRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"emailThreats", n => { EmailThreats = n.GetCollectionOfObjectValues<EmailThreatSubmission>(EmailThreatSubmission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emailThreatSubmissionPolicies", n => { EmailThreatSubmissionPolicies = n.GetCollectionOfObjectValues<EmailThreatSubmissionPolicy>(EmailThreatSubmissionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fileThreats", n => { FileThreats = n.GetCollectionOfObjectValues<FileThreatSubmission>(FileThreatSubmission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"urlThreats", n => { UrlThreats = n.GetCollectionOfObjectValues<UrlThreatSubmission>(UrlThreatSubmission.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EmailThreatSubmission>("emailThreats", EmailThreats);
            writer.WriteCollectionOfObjectValues<EmailThreatSubmissionPolicy>("emailThreatSubmissionPolicies", EmailThreatSubmissionPolicies);
            writer.WriteCollectionOfObjectValues<FileThreatSubmission>("fileThreats", FileThreats);
            writer.WriteCollectionOfObjectValues<UrlThreatSubmission>("urlThreats", UrlThreats);
        }
    }
}
