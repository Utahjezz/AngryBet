using System;
using System.Reflection;

namespace Scommesse.Model
{
    // Questo attributo è usato per rappresentare un valore string per un valore di un enum
    public class StringValueAttribute : Attribute
    {
        #region Properties

        // Contiene il valore string per un valore di un enum
        public string StringValue { get; protected set; }

        #endregion

        #region Constructor

        // Costruttore usato per inizializzare un attributo StringValue
        public StringValueAttribute(string value)
        {
            StringValue = value;
        }

        #endregion

        public static string GetStringValue(Enum value)
        {
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            FieldInfo fieldInfo = type.GetField(value.ToString());

            // Get the stringvalue attributes
            var attribs = fieldInfo.GetCustomAttributes(
                typeof (StringValueAttribute), false) as StringValueAttribute[];

            // Return the first if there was a match.
            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }
    }
}