using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionCodeListCodeListItem
    {
        private string codedValueField;

        private ODMStudyMetaDataVersionCodeListCodeListItemTranslatedText[] decodeField;

        /// <remarks />
        [XmlArrayItem("TranslatedText", IsNullable = false)]
        public ODMStudyMetaDataVersionCodeListCodeListItemTranslatedText[] Decode
        {
            get => decodeField;
            set => decodeField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string CodedValue
        {
            get => codedValueField;
            set => codedValueField = value;
        }
    }
}