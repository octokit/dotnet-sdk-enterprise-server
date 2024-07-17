// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Models {
    #pragma warning disable CS1591
    public class AdvancedSecurityActiveCommittersUser : IAdditionalDataHolder, IParsable 
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
        /// <summary>The user_login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserLogin { get; set; }
#nullable restore
#else
        public string UserLogin { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AdvancedSecurityActiveCommittersUser"/> and sets the default values.
        /// </summary>
        public AdvancedSecurityActiveCommittersUser()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AdvancedSecurityActiveCommittersUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AdvancedSecurityActiveCommittersUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdvancedSecurityActiveCommittersUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"last_pushed_date", n => { LastPushedDate = n.GetStringValue(); } },
                {"user_login", n => { UserLogin = n.GetStringValue(); } },
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
            writer.WriteStringValue("user_login", UserLogin);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
