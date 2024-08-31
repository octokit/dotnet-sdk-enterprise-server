// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.17.0")]
    #pragma warning disable CS1591
    public partial class AdvancedSecurityActiveCommittersUser : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The last_pushed_date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastPushedDate { get; set; }
#nullable restore
#else
        public string LastPushedDate { get; set; }
#endif
        /// <summary>The last_pushed_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastPushedEmail { get; set; }
#nullable restore
#else
        public string LastPushedEmail { get; set; }
#endif
        /// <summary>The user_login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserLogin { get; set; }
#nullable restore
#else
        public string UserLogin { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Models.AdvancedSecurityActiveCommittersUser"/> and sets the default values.
        /// </summary>
        public AdvancedSecurityActiveCommittersUser()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Models.AdvancedSecurityActiveCommittersUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Models.AdvancedSecurityActiveCommittersUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Models.AdvancedSecurityActiveCommittersUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "last_pushed_date", n => { LastPushedDate = n.GetStringValue(); } },
                { "last_pushed_email", n => { LastPushedEmail = n.GetStringValue(); } },
                { "user_login", n => { UserLogin = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("last_pushed_date", LastPushedDate);
            writer.WriteStringValue("last_pushed_email", LastPushedEmail);
            writer.WriteStringValue("user_login", UserLogin);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
