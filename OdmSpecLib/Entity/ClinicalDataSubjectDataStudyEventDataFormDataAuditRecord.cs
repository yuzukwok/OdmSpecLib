using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataAuditRecord
    {
        private DateTime dateTimeStampField;

        private ClinicalDataSubjectDataStudyEventDataFormDataAuditRecordLocationRef locationRefField;

        private ClinicalDataSubjectDataStudyEventDataFormDataAuditRecordUserRef userRefField;

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataAuditRecordUserRef UserRef
        {
            get => userRefField;
            set => userRefField = value;
        }

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataAuditRecordLocationRef LocationRef
        {
            get => locationRefField;
            set => locationRefField = value;
        }

        /// <remarks />
        public DateTime DateTimeStamp
        {
            get => dateTimeStampField;
            set => dateTimeStampField = value;
        }
    }
}