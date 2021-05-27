using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionStudyEventDef
    {
        private ODMStudyMetaDataVersionStudyEventDefTranslatedText[] descriptionField;

        private ODMStudyMetaDataVersionStudyEventDefFormRef[] formRefField;

        private string nameField;

        private string oIDField;

        private string repeatingField;

        private string typeField;

        /// <remarks />
        [XmlArrayItem("TranslatedText", IsNullable = false)]
        public ODMStudyMetaDataVersionStudyEventDefTranslatedText[] Description
        {
            get => descriptionField;
            set => descriptionField = value;
        }

        /// <remarks />
        [XmlElement("FormRef")]
        public ODMStudyMetaDataVersionStudyEventDefFormRef[] FormRef
        {
            get => formRefField;
            set => formRefField = value;
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

        /// <remarks />
        [XmlAttribute]
        public string Type
        {
            get => typeField;
            set => typeField = value;
        }
    }
}