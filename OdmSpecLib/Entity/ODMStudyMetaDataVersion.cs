using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OdmLib
{
    /// <remarks />
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
    public class ODMStudyMetaDataVersion
    {
        private ODMStudyMetaDataVersionCodeList[] codeListField;

        private ODMStudyMetaDataVersionConditionDef[] conditionDefField;

        private ODMStudyMetaDataVersionFormDef[] formDefField;

        private ODMStudyMetaDataVersionItemDef[] itemDefField;

        private ODMStudyMetaDataVersionItemGroupDef[] itemGroupDefField;

        private string nameField;

        private string oIDField;

        private ODMStudyMetaDataVersionStudyEventRef[] protocolField;

        private ODMStudyMetaDataVersionStudyEventDef[] studyEventDefField;

        /// <remarks />
        [XmlArrayItem("StudyEventRef", IsNullable = false)]
        public ODMStudyMetaDataVersionStudyEventRef[] Protocol
        {
            get => protocolField;
            set => protocolField = value;
        }

        /// <remarks />
        [XmlElement("StudyEventDef")]
        public ODMStudyMetaDataVersionStudyEventDef[] StudyEventDef
        {
            get => studyEventDefField;
            set => studyEventDefField = value;
        }

        /// <remarks />
        [XmlElement("FormDef")]
        public ODMStudyMetaDataVersionFormDef[] FormDef
        {
            get => formDefField;
            set => formDefField = value;
        }

        /// <remarks />
        [XmlElement("ItemGroupDef")]
        public ODMStudyMetaDataVersionItemGroupDef[] ItemGroupDef
        {
            get => itemGroupDefField;
            set => itemGroupDefField = value;
        }

        /// <remarks />
        [XmlElement("ItemDef")]
        public ODMStudyMetaDataVersionItemDef[] ItemDef
        {
            get => itemDefField;
            set => itemDefField = value;
        }

        /// <remarks />
        [XmlElement("CodeList")]
        public ODMStudyMetaDataVersionCodeList[] CodeList
        {
            get => codeListField;
            set => codeListField = value;
        }

        /// <remarks />
        [XmlElement("ConditionDef")]
        public ODMStudyMetaDataVersionConditionDef[] ConditionDef
        {
            get => conditionDefField;
            set => conditionDefField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string OID
        {
            get => oIDField;
            set => oIDField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public string Name
        {
            get => nameField;
            set => nameField = value;
        }
    }
}