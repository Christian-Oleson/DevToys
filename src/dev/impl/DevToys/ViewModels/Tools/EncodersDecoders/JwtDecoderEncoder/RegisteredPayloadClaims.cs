using System.ComponentModel;

namespace DevToys.ViewModels.Tools.EncodersDecoders.JwtDecoderEncoder
{
    public enum RegisteredPayloadClaims
    {
        [ShortCode("aud")]
        [Description("Audience - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.3")]
        Audience,
        [ShortCode("exp")]
        [Description("Expiration Time - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.4")]
        Expiration,
        [ShortCode("iat")]
        [Description("Issued At - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.6")]
        IssuedAt,
        [ShortCode("jwt")]
        [Description("JWT ID - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.7")]
        JWTID,
        [ShortCode("iss")]
        [Description("Issuer - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.1")]
        Issuer,
        [ShortCode("nbf")]
        [Description("Not Before - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.5")]
        NotBefore,
        [ShortCode("sub")]
        [Description("Subject - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.2")]
        Subject,
    }
}
