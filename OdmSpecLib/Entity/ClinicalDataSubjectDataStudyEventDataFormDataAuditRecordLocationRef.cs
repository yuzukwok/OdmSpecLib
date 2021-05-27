using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataStudyEventDataFormDataAuditRecordLocationRef
    {
        private string locationOIDField;

        /// <remarks />
        [XmlAttribute]
        public string LocationOID
        {
            get => locationOIDField;
            set => locationOIDField = value;
        }
    }
}