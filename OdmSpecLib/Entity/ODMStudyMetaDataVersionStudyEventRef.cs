using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersionStudyEventRef
    {
        private string mandatoryField;

        private string studyEventOIDField;

        /// <remarks />
        [XmlAttribute]
        public string StudyEventOID
        {
            get => studyEventOIDField;
            set => studyEventOIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Mandatory
        {
            get => mandatoryField;
            set => mandatoryField = value;
        }
    }
}