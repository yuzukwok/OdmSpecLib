using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyGlobalVariables
    {
        private string protocolNameField;

        private string studyDescriptionField;

        private string studyNameField;

        /// <remarks />
        public string StudyName
        {
            get => studyNameField;
            set => studyNameField = value;
        }

        /// <remarks />
        public string StudyDescription
        {
            get => studyDescriptionField;
            set => studyDescriptionField = value;
        }

        /// <remarks />
        public string ProtocolName
        {
            get => protocolNameField;
            set => protocolNameField = value;
        }
    }
}