using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class AdminDataUser
    {
        private string firstNameField;

        private string lastNameField;

        private string oIDField;

        /// <remarks />
        public string FirstName
        {
            get => firstNameField;
            set => firstNameField = value;
        }

        /// <remarks />
        public string LastName
        {
            get => lastNameField;
            set => lastNameField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string OID
        {
            get => oIDField;
            set => oIDField = value;
        }
    }
}