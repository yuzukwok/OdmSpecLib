using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class ClinicalDataSubjectDataAuditRecordUserRef
    {
        private string userOIDField;

        /// <remarks />
        [XmlAttribute]
        public string UserOID
        {
            get => userOIDField;
            set => userOIDField = value;
        }
    }
}