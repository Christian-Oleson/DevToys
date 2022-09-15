using System.ComponentModel;

namespace DevToys.ViewModels.Tools.EncodersDecoders.JwtDecoderEncoder
{
    public enum RegisteredPayloadClaims
    {
        [ShortCode("aud")]
        [Description("Audience (who or what the token is intended for) - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.3")]
        Audience,
        [ShortCode("exp")]
        [Description("Expiration time (seconds since Unix epoch) - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.4")]
        Expiration,
        [ShortCode("iat")]
        [Description("Issued at (seconds since Unix epoch) - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.6")]
        IssuedAt,
        [ShortCode("jwt")]
        [Description("JWT ID - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.7")]
        JWTID,
        [ShortCode("iss")]
        [Description("Issuer (who created and signed this token) - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.1")]
        Issuer,
        [ShortCode("nbf")]
        [Description("Not valid before (seconds since Unix epoch) - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.5")]
        NotBefore,
        [ShortCode("sub")]
        [Description("Subject (the principal that is the subject of the JWT) - https://www.rfc-editor.org/rfc/rfc7519#section-4.1.2")]
        Subject,
    }
}
