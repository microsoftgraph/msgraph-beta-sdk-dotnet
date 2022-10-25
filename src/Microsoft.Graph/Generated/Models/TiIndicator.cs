using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class TiIndicator : Entity, IParsable {
        /// <summary>The action to apply if the indicator is matched from within the targetProduct security tool. Possible values are: unknown, allow, block, alert. Required.</summary>
        public TiAction? Action {
            get { return BackingStore?.Get<TiAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.</summary>
        public List<string> ActivityGroupNames {
            get { return BackingStore?.Get<List<string>>("activityGroupNames"); }
            set { BackingStore?.Set("activityGroupNames", value); }
        }
        /// <summary>A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed. Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.</summary>
        public string AdditionalInformation {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
        /// <summary>Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.</summary>
        public string AzureTenantId {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
        /// <summary>An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.</summary>
        public int? Confidence {
            get { return BackingStore?.Get<int?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>Brief description (100 characters or less) of the threat represented by the indicator. Required.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The area of the Diamond Model in which this indicator exists. Possible values are: unknown, adversary, capability, infrastructure, victim.</summary>
        public Microsoft.Graph.Beta.Models.DiamondModel? DiamondModel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DiamondModel?>("diamondModel"); }
            set { BackingStore?.Set("diamondModel", value); }
        }
        /// <summary>The domainName property</summary>
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
        /// <summary>The emailEncoding property</summary>
        public string EmailEncoding {
            get { return BackingStore?.Get<string>("emailEncoding"); }
            set { BackingStore?.Set("emailEncoding", value); }
        }
        /// <summary>The emailLanguage property</summary>
        public string EmailLanguage {
            get { return BackingStore?.Get<string>("emailLanguage"); }
            set { BackingStore?.Set("emailLanguage", value); }
        }
        /// <summary>The emailRecipient property</summary>
        public string EmailRecipient {
            get { return BackingStore?.Get<string>("emailRecipient"); }
            set { BackingStore?.Set("emailRecipient", value); }
        }
        /// <summary>The emailSenderAddress property</summary>
        public string EmailSenderAddress {
            get { return BackingStore?.Get<string>("emailSenderAddress"); }
            set { BackingStore?.Set("emailSenderAddress", value); }
        }
        /// <summary>The emailSenderName property</summary>
        public string EmailSenderName {
            get { return BackingStore?.Get<string>("emailSenderName"); }
            set { BackingStore?.Set("emailSenderName", value); }
        }
        /// <summary>The emailSourceDomain property</summary>
        public string EmailSourceDomain {
            get { return BackingStore?.Get<string>("emailSourceDomain"); }
            set { BackingStore?.Set("emailSourceDomain", value); }
        }
        /// <summary>The emailSourceIpAddress property</summary>
        public string EmailSourceIpAddress {
            get { return BackingStore?.Get<string>("emailSourceIpAddress"); }
            set { BackingStore?.Set("emailSourceIpAddress", value); }
        }
        /// <summary>The emailSubject property</summary>
        public string EmailSubject {
            get { return BackingStore?.Get<string>("emailSubject"); }
            set { BackingStore?.Set("emailSubject", value); }
        }
        /// <summary>The emailXMailer property</summary>
        public string EmailXMailer {
            get { return BackingStore?.Get<string>("emailXMailer"); }
            set { BackingStore?.Set("emailXMailer", value); }
        }
        /// <summary>DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).</summary>
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
        /// <summary>The fileCompileDateTime property</summary>
        public DateTimeOffset? FileCompileDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("fileCompileDateTime"); }
            set { BackingStore?.Set("fileCompileDateTime", value); }
        }
        /// <summary>The fileCreatedDateTime property</summary>
        public DateTimeOffset? FileCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("fileCreatedDateTime"); }
            set { BackingStore?.Set("fileCreatedDateTime", value); }
        }
        /// <summary>The fileHashType property</summary>
        public Microsoft.Graph.Beta.Models.FileHashType? FileHashType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FileHashType?>("fileHashType"); }
            set { BackingStore?.Set("fileHashType", value); }
        }
        /// <summary>The fileHashValue property</summary>
        public string FileHashValue {
            get { return BackingStore?.Get<string>("fileHashValue"); }
            set { BackingStore?.Set("fileHashValue", value); }
        }
        /// <summary>The fileMutexName property</summary>
        public string FileMutexName {
            get { return BackingStore?.Get<string>("fileMutexName"); }
            set { BackingStore?.Set("fileMutexName", value); }
        }
        /// <summary>The fileName property</summary>
        public string FileName {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
        /// <summary>The filePacker property</summary>
        public string FilePacker {
            get { return BackingStore?.Get<string>("filePacker"); }
            set { BackingStore?.Set("filePacker", value); }
        }
        /// <summary>The filePath property</summary>
        public string FilePath {
            get { return BackingStore?.Get<string>("filePath"); }
            set { BackingStore?.Set("filePath", value); }
        }
        /// <summary>The fileSize property</summary>
        public long? FileSize {
            get { return BackingStore?.Get<long?>("fileSize"); }
            set { BackingStore?.Set("fileSize", value); }
        }
        /// <summary>The fileType property</summary>
        public string FileType {
            get { return BackingStore?.Get<string>("fileType"); }
            set { BackingStore?.Set("fileType", value); }
        }
        /// <summary>Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? IngestedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("ingestedDateTime"); }
            set { BackingStore?.Set("ingestedDateTime", value); }
        }
        /// <summary>Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.</summary>
        public bool? IsActive {
            get { return BackingStore?.Get<bool?>("isActive"); }
            set { BackingStore?.Set("isActive", value); }
        }
        /// <summary>A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.</summary>
        public List<string> KillChain {
            get { return BackingStore?.Get<List<string>>("killChain"); }
            set { BackingStore?.Set("killChain", value); }
        }
        /// <summary>Scenarios in which the indicator may cause false positives. This should be human-readable text.</summary>
        public string KnownFalsePositives {
            get { return BackingStore?.Get<string>("knownFalsePositives"); }
            set { BackingStore?.Set("knownFalsePositives", value); }
        }
        /// <summary>The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastReportedDateTime"); }
            set { BackingStore?.Set("lastReportedDateTime", value); }
        }
        /// <summary>The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.</summary>
        public List<string> MalwareFamilyNames {
            get { return BackingStore?.Get<List<string>>("malwareFamilyNames"); }
            set { BackingStore?.Set("malwareFamilyNames", value); }
        }
        /// <summary>The networkCidrBlock property</summary>
        public string NetworkCidrBlock {
            get { return BackingStore?.Get<string>("networkCidrBlock"); }
            set { BackingStore?.Set("networkCidrBlock", value); }
        }
        /// <summary>The networkDestinationAsn property</summary>
        public long? NetworkDestinationAsn {
            get { return BackingStore?.Get<long?>("networkDestinationAsn"); }
            set { BackingStore?.Set("networkDestinationAsn", value); }
        }
        /// <summary>The networkDestinationCidrBlock property</summary>
        public string NetworkDestinationCidrBlock {
            get { return BackingStore?.Get<string>("networkDestinationCidrBlock"); }
            set { BackingStore?.Set("networkDestinationCidrBlock", value); }
        }
        /// <summary>The networkDestinationIPv4 property</summary>
        public string NetworkDestinationIPv4 {
            get { return BackingStore?.Get<string>("networkDestinationIPv4"); }
            set { BackingStore?.Set("networkDestinationIPv4", value); }
        }
        /// <summary>The networkDestinationIPv6 property</summary>
        public string NetworkDestinationIPv6 {
            get { return BackingStore?.Get<string>("networkDestinationIPv6"); }
            set { BackingStore?.Set("networkDestinationIPv6", value); }
        }
        /// <summary>The networkDestinationPort property</summary>
        public int? NetworkDestinationPort {
            get { return BackingStore?.Get<int?>("networkDestinationPort"); }
            set { BackingStore?.Set("networkDestinationPort", value); }
        }
        /// <summary>The networkIPv4 property</summary>
        public string NetworkIPv4 {
            get { return BackingStore?.Get<string>("networkIPv4"); }
            set { BackingStore?.Set("networkIPv4", value); }
        }
        /// <summary>The networkIPv6 property</summary>
        public string NetworkIPv6 {
            get { return BackingStore?.Get<string>("networkIPv6"); }
            set { BackingStore?.Set("networkIPv6", value); }
        }
        /// <summary>The networkPort property</summary>
        public int? NetworkPort {
            get { return BackingStore?.Get<int?>("networkPort"); }
            set { BackingStore?.Set("networkPort", value); }
        }
        /// <summary>The networkProtocol property</summary>
        public int? NetworkProtocol {
            get { return BackingStore?.Get<int?>("networkProtocol"); }
            set { BackingStore?.Set("networkProtocol", value); }
        }
        /// <summary>The networkSourceAsn property</summary>
        public long? NetworkSourceAsn {
            get { return BackingStore?.Get<long?>("networkSourceAsn"); }
            set { BackingStore?.Set("networkSourceAsn", value); }
        }
        /// <summary>The networkSourceCidrBlock property</summary>
        public string NetworkSourceCidrBlock {
            get { return BackingStore?.Get<string>("networkSourceCidrBlock"); }
            set { BackingStore?.Set("networkSourceCidrBlock", value); }
        }
        /// <summary>The networkSourceIPv4 property</summary>
        public string NetworkSourceIPv4 {
            get { return BackingStore?.Get<string>("networkSourceIPv4"); }
            set { BackingStore?.Set("networkSourceIPv4", value); }
        }
        /// <summary>The networkSourceIPv6 property</summary>
        public string NetworkSourceIPv6 {
            get { return BackingStore?.Get<string>("networkSourceIPv6"); }
            set { BackingStore?.Set("networkSourceIPv6", value); }
        }
        /// <summary>The networkSourcePort property</summary>
        public int? NetworkSourcePort {
            get { return BackingStore?.Get<int?>("networkSourcePort"); }
            set { BackingStore?.Set("networkSourcePort", value); }
        }
        /// <summary>Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they will simply log that a match occurred but will not perform the action. Default value is false.</summary>
        public bool? PassiveOnly {
            get { return BackingStore?.Get<bool?>("passiveOnly"); }
            set { BackingStore?.Set("passiveOnly", value); }
        }
        /// <summary>An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.</summary>
        public int? Severity {
            get { return BackingStore?.Get<int?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>A JSON array of strings that stores arbitrary tags/keywords.</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required</summary>
        public string TargetProduct {
            get { return BackingStore?.Get<string>("targetProduct"); }
            set { BackingStore?.Set("targetProduct", value); }
        }
        /// <summary>Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.</summary>
        public string ThreatType {
            get { return BackingStore?.Get<string>("threatType"); }
            set { BackingStore?.Set("threatType", value); }
        }
        /// <summary>Traffic Light Protocol value for the indicator. Possible values are: unknown, white, green, amber, red. Required.</summary>
        public Microsoft.Graph.Beta.Models.TlpLevel? TlpLevel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TlpLevel?>("tlpLevel"); }
            set { BackingStore?.Set("tlpLevel", value); }
        }
        /// <summary>The url property</summary>
        public string Url {
            get { return BackingStore?.Get<string>("url"); }
            set { BackingStore?.Set("url", value); }
        }
        /// <summary>The userAgent property</summary>
        public string UserAgent {
            get { return BackingStore?.Get<string>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
        /// <summary>
        /// Instantiates a new tiIndicator and sets the default values.
        /// </summary>
        public TiIndicator() : base() {
            OdataType = "#microsoft.graph.tiIndicator";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TiIndicator CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TiIndicator();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<TiAction>(); } },
                {"activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"diamondModel", n => { DiamondModel = n.GetEnumValue<DiamondModel>(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"emailEncoding", n => { EmailEncoding = n.GetStringValue(); } },
                {"emailLanguage", n => { EmailLanguage = n.GetStringValue(); } },
                {"emailRecipient", n => { EmailRecipient = n.GetStringValue(); } },
                {"emailSenderAddress", n => { EmailSenderAddress = n.GetStringValue(); } },
                {"emailSenderName", n => { EmailSenderName = n.GetStringValue(); } },
                {"emailSourceDomain", n => { EmailSourceDomain = n.GetStringValue(); } },
                {"emailSourceIpAddress", n => { EmailSourceIpAddress = n.GetStringValue(); } },
                {"emailSubject", n => { EmailSubject = n.GetStringValue(); } },
                {"emailXMailer", n => { EmailXMailer = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"fileCompileDateTime", n => { FileCompileDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileCreatedDateTime", n => { FileCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileHashType", n => { FileHashType = n.GetEnumValue<FileHashType>(); } },
                {"fileHashValue", n => { FileHashValue = n.GetStringValue(); } },
                {"fileMutexName", n => { FileMutexName = n.GetStringValue(); } },
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"filePacker", n => { FilePacker = n.GetStringValue(); } },
                {"filePath", n => { FilePath = n.GetStringValue(); } },
                {"fileSize", n => { FileSize = n.GetLongValue(); } },
                {"fileType", n => { FileType = n.GetStringValue(); } },
                {"ingestedDateTime", n => { IngestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isActive", n => { IsActive = n.GetBoolValue(); } },
                {"killChain", n => { KillChain = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"knownFalsePositives", n => { KnownFalsePositives = n.GetStringValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareFamilyNames", n => { MalwareFamilyNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"networkCidrBlock", n => { NetworkCidrBlock = n.GetStringValue(); } },
                {"networkDestinationAsn", n => { NetworkDestinationAsn = n.GetLongValue(); } },
                {"networkDestinationCidrBlock", n => { NetworkDestinationCidrBlock = n.GetStringValue(); } },
                {"networkDestinationIPv4", n => { NetworkDestinationIPv4 = n.GetStringValue(); } },
                {"networkDestinationIPv6", n => { NetworkDestinationIPv6 = n.GetStringValue(); } },
                {"networkDestinationPort", n => { NetworkDestinationPort = n.GetIntValue(); } },
                {"networkIPv4", n => { NetworkIPv4 = n.GetStringValue(); } },
                {"networkIPv6", n => { NetworkIPv6 = n.GetStringValue(); } },
                {"networkPort", n => { NetworkPort = n.GetIntValue(); } },
                {"networkProtocol", n => { NetworkProtocol = n.GetIntValue(); } },
                {"networkSourceAsn", n => { NetworkSourceAsn = n.GetLongValue(); } },
                {"networkSourceCidrBlock", n => { NetworkSourceCidrBlock = n.GetStringValue(); } },
                {"networkSourceIPv4", n => { NetworkSourceIPv4 = n.GetStringValue(); } },
                {"networkSourceIPv6", n => { NetworkSourceIPv6 = n.GetStringValue(); } },
                {"networkSourcePort", n => { NetworkSourcePort = n.GetIntValue(); } },
                {"passiveOnly", n => { PassiveOnly = n.GetBoolValue(); } },
                {"severity", n => { Severity = n.GetIntValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"targetProduct", n => { TargetProduct = n.GetStringValue(); } },
                {"threatType", n => { ThreatType = n.GetStringValue(); } },
                {"tlpLevel", n => { TlpLevel = n.GetEnumValue<TlpLevel>(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"userAgent", n => { UserAgent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TiAction>("action", Action);
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DiamondModel>("diamondModel", DiamondModel);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("emailEncoding", EmailEncoding);
            writer.WriteStringValue("emailLanguage", EmailLanguage);
            writer.WriteStringValue("emailRecipient", EmailRecipient);
            writer.WriteStringValue("emailSenderAddress", EmailSenderAddress);
            writer.WriteStringValue("emailSenderName", EmailSenderName);
            writer.WriteStringValue("emailSourceDomain", EmailSourceDomain);
            writer.WriteStringValue("emailSourceIpAddress", EmailSourceIpAddress);
            writer.WriteStringValue("emailSubject", EmailSubject);
            writer.WriteStringValue("emailXMailer", EmailXMailer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteDateTimeOffsetValue("fileCompileDateTime", FileCompileDateTime);
            writer.WriteDateTimeOffsetValue("fileCreatedDateTime", FileCreatedDateTime);
            writer.WriteEnumValue<FileHashType>("fileHashType", FileHashType);
            writer.WriteStringValue("fileHashValue", FileHashValue);
            writer.WriteStringValue("fileMutexName", FileMutexName);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("filePacker", FilePacker);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteLongValue("fileSize", FileSize);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteDateTimeOffsetValue("ingestedDateTime", IngestedDateTime);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteCollectionOfPrimitiveValues<string>("killChain", KillChain);
            writer.WriteStringValue("knownFalsePositives", KnownFalsePositives);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("malwareFamilyNames", MalwareFamilyNames);
            writer.WriteStringValue("networkCidrBlock", NetworkCidrBlock);
            writer.WriteLongValue("networkDestinationAsn", NetworkDestinationAsn);
            writer.WriteStringValue("networkDestinationCidrBlock", NetworkDestinationCidrBlock);
            writer.WriteStringValue("networkDestinationIPv4", NetworkDestinationIPv4);
            writer.WriteStringValue("networkDestinationIPv6", NetworkDestinationIPv6);
            writer.WriteIntValue("networkDestinationPort", NetworkDestinationPort);
            writer.WriteStringValue("networkIPv4", NetworkIPv4);
            writer.WriteStringValue("networkIPv6", NetworkIPv6);
            writer.WriteIntValue("networkPort", NetworkPort);
            writer.WriteIntValue("networkProtocol", NetworkProtocol);
            writer.WriteLongValue("networkSourceAsn", NetworkSourceAsn);
            writer.WriteStringValue("networkSourceCidrBlock", NetworkSourceCidrBlock);
            writer.WriteStringValue("networkSourceIPv4", NetworkSourceIPv4);
            writer.WriteStringValue("networkSourceIPv6", NetworkSourceIPv6);
            writer.WriteIntValue("networkSourcePort", NetworkSourcePort);
            writer.WriteBoolValue("passiveOnly", PassiveOnly);
            writer.WriteIntValue("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("targetProduct", TargetProduct);
            writer.WriteStringValue("threatType", ThreatType);
            writer.WriteEnumValue<TlpLevel>("tlpLevel", TlpLevel);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("userAgent", UserAgent);
        }
    }
}
