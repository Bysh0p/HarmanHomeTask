﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ezt a kódot eszköz generálta.
//     Futásidejű verzió:4.0.30319.42000
//
//     Ennek a fájlnak a módosítása helytelen viselkedést eredményezhet, és elvész, ha
//     a kódot újragenerálják.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute("HMI-XML-FILEGENERATIONPROTOCOL", Namespace="", IsNullable=false)]
public partial class HMIXMLFILEGENERATIONPROTOCOL {
    
    private HMIXMLFILEGENERATIONPROTOCOLPACKET[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PACKET", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public HMIXMLFILEGENERATIONPROTOCOLPACKET[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HMIXMLFILEGENERATIONPROTOCOLPACKET {
    
    private HMIXMLFILEGENERATIONPROTOCOLPACKETFILE[] fILEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FILE", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public HMIXMLFILEGENERATIONPROTOCOLPACKETFILE[] FILE {
        get {
            return this.fILEField;
        }
        set {
            this.fILEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HMIXMLFILEGENERATIONPROTOCOLPACKETFILE {
    
    private string fILENAMEField;
    
    private string cHECKSUMField;
    
    private string bYTESIZEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FILENAME {
        get {
            return this.fILENAMEField;
        }
        set {
            this.fILENAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CHECKSUM {
        get {
            return this.cHECKSUMField;
        }
        set {
            this.cHECKSUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BYTESIZE {
        get {
            return this.bYTESIZEField;
        }
        set {
            this.bYTESIZEField = value;
        }
    }
}