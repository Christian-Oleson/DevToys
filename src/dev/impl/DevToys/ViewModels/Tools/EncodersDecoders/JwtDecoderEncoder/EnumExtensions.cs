using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DevToys.ViewModels.Tools.EncodersDecoders.JwtDecoderEncoder
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Allows enum classes to return their human readable description (if available) instead of their internal representation.
        /// </summary>
        /// <param name="value">The enum to be converted</param>
        /// <returns>A pretty, human readable string version of the enum</returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo == null)
            {
                return null;
            }

            var attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute?.Description;
        }

        /// <summary>
        /// A generic extension method that retrieves any attribute that is applied to an enum.
        /// </summary>
        /// <param name="value">
        /// The enum value to retrieve attribute
        /// </param>
        /// <returns>
        /// The attribute value
        /// </returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            return value
                .GetType()
                .GetMember(value.ToString())
                .First()
                .GetCustomAttribute<TAttribute>();
        }
    }
}
