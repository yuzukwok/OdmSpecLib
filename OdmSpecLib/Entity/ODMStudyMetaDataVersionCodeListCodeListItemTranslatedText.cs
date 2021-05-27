using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionCodeListCodeListItemTranslatedText
    {
        private string langField;

        private string valueField;

        /// <remarks />
        [XmlAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get => langField;
            set => langField = value;
        }

        /// <remarks />
        [XmlText]
        public string Value
        {
            get => valueField;
            set => valueField = value;
        }
    }
}