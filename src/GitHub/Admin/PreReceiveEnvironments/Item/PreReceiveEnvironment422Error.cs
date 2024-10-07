// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace GitHub.Admin.PreReceiveEnvironments.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class PreReceiveEnvironment422Error : ApiException, IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The errors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error_errors>? Errors { get; set; }
#nullable restore
#else
        public List<global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error_errors> Errors { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => MessageEscaped ?? string.Empty; }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageEscaped { get; set; }
#nullable restore
#else
        public string MessageEscaped { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error"/> and sets the default values.
        /// </summary>
        public PreReceiveEnvironment422Error()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error_errors>(global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error_errors.CreateFromDiscriminatorValue)?.AsList(); } },
                { "message", n => { MessageEscaped = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::GitHub.Admin.PreReceiveEnvironments.Item.PreReceiveEnvironment422Error_errors>("errors", Errors);
            writer.WriteStringValue("message", MessageEscaped);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
