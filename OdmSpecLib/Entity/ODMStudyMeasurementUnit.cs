using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMeasurementUnit
    {
        private string nameField;

        private string oIDField;

        private ODMStudyMeasurementUnitTranslatedText[] symbolField;

        /// <remarks />
        [XmlArrayItem("TranslatedText", IsNullable = false)]
        public ODMStudyMeasurementUnitTranslatedText[] Symbol
        {
            get => symbolField;
            set => symbolField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string OID
        {
            get => oIDField;
            set => oIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Name
        {
            get => nameField;
            set => nameField = value;
        }
    }
}