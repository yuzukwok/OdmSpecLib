using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionConditionDefFormalExpression
    {
        private string contextField;

        private string valueField;

        /// <remarks />
        [XmlAttribute]
        public string Context
        {
            get => contextField;
            set => contextField = value;
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