using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormData
    {
        private ClinicalDataSubjectDataStudyEventDataFormDataAnnotation annotationField;

        private ClinicalDataSubjectDataStudyEventDataFormDataAuditRecord auditRecordField;

        private string formOIDField;

        private ClinicalDataSubjectDataStudyEventDataFormDataItemGroupData itemGroupDataField;

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataAuditRecord AuditRecord
        {
            get => auditRecordField;
            set => auditRecordField = value;
        }

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataAnnotation Annotation
        {
            get => annotationField;
            set => annotationField = value;
        }

        /// <remarks />
        public ClinicalDataSubjectDataStudyEventDataFormDataItemGroupData ItemGroupData
        {
            get => itemGroupDataField;
            set => itemGroupDataField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string FormOID
        {
            get => formOIDField;
            set => formOIDField = value;
        }
    }
}