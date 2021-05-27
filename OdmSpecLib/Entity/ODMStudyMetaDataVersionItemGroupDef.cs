using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionItemGroupDef
    {
        private ODMStudyMetaDataVersionItemGroupDefTranslatedText[] descriptionField;

        private ODMStudyMetaDataVersionItemGroupDefItemRef[] itemRefField;

        private string nameField;

        private string oIDField;

        private string repeatingField;

        /// <remarks />
        [XmlArrayItem("TranslatedText", IsNullable = false)]
        public ODMStudyMetaDataVersionItemGroupDefTranslatedText[] Description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks />
        [XmlElement("ItemRef")]
        public ODMStudyMetaDataVersionItemGroupDefItemRef[] ItemRef
        {
            get => itemRefField;
            set => itemRefField = value;
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