using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionFormDef
    {
        private ODMStudyMetaDataVersionFormDefTranslatedText[] descriptionField;

        private ODMStudyMetaDataVersionFormDefItemGroupRef[] itemGroupRefField;

        private string nameField;

        private string oIDField;

        private string repeatingField;

        /// <remarks />
        [XmlArrayItem("TranslatedText", IsNullable = false)]
        public ODMStudyMetaDataVersionFormDefTranslatedText[] Description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks />
        [XmlElement("ItemGroupRef")]
        public ODMStudyMetaDataVersionFormDefItemGroupRef[] ItemGroupRef
        {
            get => itemGroupRefField;
            set => itemGroupRefField = value;
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
        public string Repeating
        {
            get => repeatingField;
            set => repeatingField = value;
        }
    }
}