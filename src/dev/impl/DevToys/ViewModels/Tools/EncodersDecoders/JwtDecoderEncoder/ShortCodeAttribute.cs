using System;

namespace DevToys.ViewModels.Tools.EncodersDecoders.JwtDecoderEncoder
{
    public class ShortCodeAttribute : Attribute
    {
        public string ShortName { get; set; }

        public ShortCodeAttribute(string shortName)
        {
            ShortName = shortName;
        }
    }
}
