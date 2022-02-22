using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TrustFrameworkKey : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>RSA Key - private exponent. Field cannot be read back.</summary>
        public string D { get; set; }
        /// <summary>RSA Key - first exponent. Field cannot be read back.</summary>
        public string Dp { get; set; }
        /// <summary>RSA Key - second exponent. Field cannot be read back.</summary>
        public string Dq { get; set; }
        /// <summary>RSA Key - public exponent</summary>
        public string E { get; set; }
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Exp { get; set; }
        /// <summary>Symmetric Key for oct key type. Field cannot be read back.</summary>
        public string K { get; set; }
        /// <summary>The unique identifier for the key.</summary>
        public string Kid { get; set; }
        /// <summary>The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.</summary>
        public string Kty { get; set; }
        /// <summary>RSA Key - modulus</summary>
        public string N { get; set; }
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Nbf { get; set; }
        /// <summary>RSA Key - first prime. Field cannot be read back.</summary>
        public string P { get; set; }
        /// <summary>RSA Key - second prime. Field cannot be read back.</summary>
        public string Q { get; set; }
        /// <summary>RSA Key - Coefficient. Field cannot be read back.</summary>
        public string Qi { get; set; }
        /// <summary>The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)</summary>
        public string Use { get; set; }
        /// <summary>The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.</summary>
        public List<string> X5c { get; set; }
        /// <summary>The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (a.k.a. digest) of the DER encoding of an X.509 certificate RFC 5280.</summary>
        public string X5t { get; set; }
        /// <summary>
        /// Instantiates a new trustFrameworkKey and sets the default values.
        /// </summary>
        public TrustFrameworkKey() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"d", (o,n) => { (o as TrustFrameworkKey).D = n.GetStringValue(); } },
                {"dp", (o,n) => { (o as TrustFrameworkKey).Dp = n.GetStringValue(); } },
                {"dq", (o,n) => { (o as TrustFrameworkKey).Dq = n.GetStringValue(); } },
                {"e", (o,n) => { (o as TrustFrameworkKey).E = n.GetStringValue(); } },
                {"exp", (o,n) => { (o as TrustFrameworkKey).Exp = n.GetLongValue(); } },
                {"k", (o,n) => { (o as TrustFrameworkKey).K = n.GetStringValue(); } },
                {"kid", (o,n) => { (o as TrustFrameworkKey).Kid = n.GetStringValue(); } },
                {"kty", (o,n) => { (o as TrustFrameworkKey).Kty = n.GetStringValue(); } },
                {"n", (o,n) => { (o as TrustFrameworkKey).N = n.GetStringValue(); } },
                {"nbf", (o,n) => { (o as TrustFrameworkKey).Nbf = n.GetLongValue(); } },
                {"p", (o,n) => { (o as TrustFrameworkKey).P = n.GetStringValue(); } },
                {"q", (o,n) => { (o as TrustFrameworkKey).Q = n.GetStringValue(); } },
                {"qi", (o,n) => { (o as TrustFrameworkKey).Qi = n.GetStringValue(); } },
                {"use", (o,n) => { (o as TrustFrameworkKey).Use = n.GetStringValue(); } },
                {"x5c", (o,n) => { (o as TrustFrameworkKey).X5c = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"x5t", (o,n) => { (o as TrustFrameworkKey).X5t = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("d", D);
            writer.WriteStringValue("dp", Dp);
            writer.WriteStringValue("dq", Dq);
            writer.WriteStringValue("e", E);
            writer.WriteLongValue("exp", Exp);
            writer.WriteStringValue("k", K);
            writer.WriteStringValue("kid", Kid);
            writer.WriteStringValue("kty", Kty);
            writer.WriteStringValue("n", N);
            writer.WriteLongValue("nbf", Nbf);
            writer.WriteStringValue("p", P);
            writer.WriteStringValue("q", Q);
            writer.WriteStringValue("qi", Qi);
            writer.WriteStringValue("use", Use);
            writer.WriteCollectionOfPrimitiveValues<string>("x5c", X5c);
            writer.WriteStringValue("x5t", X5t);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
