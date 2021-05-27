using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionCodeList
    {
        private ODMStudyMetaDataVersionCodeListCodeListItem[] codeListItemField;

        private string dataTypeField;

        private string nameField;

        private string oIDField;

        /// <remarks />
        [XmlElement("CodeListItem")]
        public ODMStudyMetaDataVersionCodeListCodeListItem[] CodeListItem
        {
            get => codeListItemField;
            set => codeListItemField = value;
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

        /// <remarks />
        [XmlAttribute]
        public string DataType
        {
            get => dataTypeField;
            set => dataTypeField = value;
        }
    }
}