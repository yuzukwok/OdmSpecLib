using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectData
    {
        private ClinicalDataSubjectDataAuditRecord auditRecordField;

        private ClinicalDataSubjectDataStudyEventData studyEventDataField;

        private string subjectKeyField;

        /// <remarks />
        public ClinicalDataSubjectDataAuditRecord AuditRecord
        {
            get => auditRecordField;
            set => auditRecordField = value;
        }

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventData StudyEventData
        {
            get => studyEventDataField;
            set => studyEventDataField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string SubjectKey
        {
            get => subjectKeyField;
            set => subjectKeyField = value;
        }
    }
}