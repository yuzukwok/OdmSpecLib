using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataAnnotationFlagFlagValue
    {
        private string codeListOIDField;

        private byte valueField;

        /// <remarks />
        [XmlAttribute]
        public string CodeListOID
        {
            get => codeListOIDField;
            set => codeListOIDField = value;
        }

        /// <remarks />
        [XmlText]
        public byte Value
        {
            get => valueField;
            set => valueField = value;
        }
    }
}