using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataAuditRecord
    {
        private DateTime dateTimeStampField;

        private ClinicalDataSubjectDataAuditRecordLocationRef locationRefField;

        private ClinicalDataSubjectDataAuditRecordUserRef userRefField;

        /// <remarks />
        public ClinicalDataSubjectDataAuditRecordUserRef UserRef
        {
            get => userRefField;
            set => userRefField = value;
        }

        /// <remarks />
        public ClinicalDataSubjectDataAuditRecordLocationRef LocationRef
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