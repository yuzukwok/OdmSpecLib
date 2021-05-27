using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class AdminData
    {
        private string studyOIDField;

        private AdminDataUser userField;

        /// <remarks />
        public AdminDataUser User
        {
            get => userField;
            set => userField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string StudyOID
        {
            get => studyOIDField;
            set => studyOIDField = value;
        }
    }
}