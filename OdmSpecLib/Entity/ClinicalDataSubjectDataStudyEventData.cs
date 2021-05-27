using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventData
    {
        private ClinicalDataSubjectDataStudyEventDataFormData formDataField;

        private string studyEventOIDField;

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormData FormData
        {
            get => formDataField;
            set => formDataField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string StudyEventOID
        {
            get => studyEventOIDField;
            set => studyEventOIDField = value;
        }
    }
}