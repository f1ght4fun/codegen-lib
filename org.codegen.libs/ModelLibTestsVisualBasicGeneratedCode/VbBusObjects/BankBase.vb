﻿
'NOTE: DO NOT ADD REFERENCES TO COM.NETU.LIB HERE, INSTEAD ADD
'THE IMPORT ON THE REFERENCES OF THE PROJECT
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Runtime.Serialization
Imports System.Data.Linq.Mapping
Imports System.ComponentModel.DataAnnotations

'<comments>
'************************************************************
' Temnplate: ModelBase2.visualBasic.txt
' Class autogenerated on 06-Sep-15 11:40:22 AM by ModelGenerator
' Extends base model object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class Bank
'
'************************************************************
'</comments>
Namespace VbBusObjects
<Table(Name := "Bank")><SelectObject("Bank")><KeyFieldName("BANKID")> _
<DefaultMapperAttr(GetType(BankDBMapper)), DataContract, _
ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
partial class Bank
		Inherits ModelObject
		Implements IEquatable(Of Bank) 

#Region "Constructor"
    
    Friend sub New()
		Me.addValidator(New BankRequiredFieldsValidator)
		Me.Id = ModelObjectKeyGen.nextId()
    End Sub

#End Region

#Region "Children and Parents"
	<OnDeserializing>
    Public sub OnDeserializingMethod(context as StreamingContext) 
		me.IsObjectLoading = true
    End Sub

	<OnDeserialized>
    Public sub OnDeserializedMethod( context as StreamingContext)

		me.IsObjectLoading = false
		me.isDirty = true
    End Sub

	Public Overrides sub loadObjectHierarchy()
		
	End Sub

	Public Overrides Function getChildren() As List(Of ModelObject) 
		Dim ret as New List(Of ModelObject)()
		
		return ret
	End Function
	
	Public Overrides Function getParents() As List(Of ModelObject)
		Dim ret as New List(Of ModelObject)()
		
		return ret
	End Function

#End Region
#Region "Field CONSTANTS"

			public Const STR_FLD_BANKID as String = "BANKID"
			public Const STR_FLD_BANKNAME as String = "BankName"
			public Const STR_FLD_BANKCODE as String = "BankCode"
			public Const STR_FLD_BANKSWIFTCODE as String = "BankSWIFTCode"


		public Const FLD_BANKID as Integer = 0
		public Const FLD_BANKNAME as Integer = 1
		public Const FLD_BANKCODE as Integer = 2
		public Const FLD_BANKSWIFTCODE as Integer = 3



        '''<summary>Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_BANKID,STR_FLD_BANKNAME,STR_FLD_BANKCODE,STR_FLD_BANKSWIFTCODE}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _BANKID as System.Int64
	Private _BankName as System.String
	Private _BankCode as System.String
	Private _BankSWIFTCode as System.String


#end Region

#Region "Field Properties"

	<Column(Name:="BANKID",Storage:="_BANKID", IsPrimaryKey:=True,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrBANKID as System.Int64
	Get 
		return _BANKID
	End Get 
	Set(ByVal value As System.Int64)
		if ModelObject.valueChanged(_BANKID, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_BANKID)
			End If
			me._BANKID = value

			me.raiseBroadcastIdChange()

		End if
	End Set 
	End Property 
	<Column(Name:="BankName",Storage:="_BankName", IsPrimaryKey:=False,DbType:="nvarchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrBankName as System.String
	Get 
		return _BankName
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_BankName, value) then
		if value isNot Nothing andAlso value.Length > 50 Then
			Throw new ModelObjectFieldTooLongException("BankName")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_BANKNAME)
			End If
			me._BankName = value

		End if
	End Set 
	End Property 
	<Column(Name:="BankCode",Storage:="_BankCode", IsPrimaryKey:=False,DbType:="nvarchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrBankCode as System.String
	Get 
		return _BankCode
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_BankCode, value) then
		if value isNot Nothing andAlso value.Length > 20 Then
			Throw new ModelObjectFieldTooLongException("BankCode")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_BANKCODE)
			End If
			me._BankCode = value

		End if
	End Set 
	End Property 
	<Column(Name:="BankSWIFTCode",Storage:="_BankSWIFTCode", IsPrimaryKey:=False,DbType:="varchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrBankSWIFTCode as System.String
	Get 
		return _BankSWIFTCode
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_BankSWIFTCode, value) then
		if value isNot Nothing andAlso value.Length > 200 Then
			Throw new ModelObjectFieldTooLongException("BankSWIFTCode")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_BANKSWIFTCODE)
			End If
			me._BankSWIFTCode = value

		End if
	End Set 
	End Property 

#End Region

#Region "Getters/Setters of values by field index / name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_BANKID
			return me.PrBANKID
		case FLD_BANKNAME
			return me.PrBankName
		case FLD_BANKCODE
			return me.PrBankCode
		case FLD_BANKSWIFTCODE
			return me.PrBankSWIFTCode
		case else
			return nothing
		end select


    End Function

    Public Overloads Overrides Function getAttribute(ByVal fieldKey As String) As Object
		fieldKey = fieldKey.ToLower

		if fieldKey=STR_FLD_BANKID.ToLower() Then
			return me.PrBANKID
		else if fieldKey=STR_FLD_BANKNAME.ToLower() Then
			return me.PrBankName
		else if fieldKey=STR_FLD_BANKCODE.ToLower() Then
			return me.PrBankCode
		else if fieldKey=STR_FLD_BANKSWIFTCODE.ToLower() Then
			return me.PrBankSWIFTCode
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		Try
		Select Case fieldKey
		case FLD_BANKID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBANKID = Nothing
			Else
				Me.PrBANKID=CType(val,System.Int64)
			End If
			return
		case FLD_BANKNAME
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankName = Nothing
			Else
				Me.PrBankName=CType(val,System.String)
			End If
			return
		case FLD_BANKCODE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankCode = Nothing
			Else
				Me.PrBankCode=CType(val,System.String)
			End If
			return
		case FLD_BANKSWIFTCODE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankSWIFTCode = Nothing
			Else
				Me.PrBankSWIFTCode=CType(val,System.String)
			End If
			return
		case else
			return
		end select

		Catch ex As Exception
			Throw New ApplicationException(String.Format("Error setting field with index {0}, value ""{1}"" : {2}", fieldKey, val, ex.Message))
		End Try
    End Sub

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As String, ByVal val As Object)
		
		fieldKey = fieldKey.ToLower
		Try
		if  fieldKey=STR_FLD_BANKID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBANKID = Nothing
			Else
				Me.PrBANKID=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_BANKNAME.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankName = Nothing
			Else
				Me.PrBankName=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_BANKCODE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankCode = Nothing
			Else
				Me.PrBankCode=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_BANKSWIFTCODE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankSWIFTCode = Nothing
			Else
				Me.PrBankSWIFTCode=Convert.ToString(val)
			End If
			return
		end If
		Catch ex As Exception
			Throw New ApplicationException(String.Format("Error setting field with index {0}, value ""{1}"" : {2}", fieldKey, val, ex.Message))
		End Try

    End Sub

#End Region
#Region "Overrides of GetHashCode, Equals "
	Public Overloads Function Equals(ByVal other As Bank) As Boolean _     
		Implements System.IEquatable(Of Bank).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrBANKID= other.PrBANKID _
				AndAlso me.PrBankName= other.PrBankName _
				AndAlso me.PrBankCode= other.PrBankCode _
				AndAlso me.PrBankSWIFTCode= other.PrBankSWIFTCode
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.PrBANKID.GetHashCode _
				Xor me.getStringHashCode(Me.PrBankName) _
				Xor me.getStringHashCode(Me.PrBankCode) _
				Xor me.getStringHashCode(Me.PrBankSWIFTCode) 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, Bank)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As Bank, ByVal obj2 As Bank) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As Bank, ByVal obj2 As Bank) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a shallow copy
        Dim ret as Bank =  new Bank()
		ret.PrBANKID = me.PrBANKID
		ret.PrBankName = me.PrBankName
		ret.PrBankCode = me.PrBankCode
		ret.PrBankSWIFTCode = me.PrBankSWIFTCode
		
		return ret
		
	End Function
	
#End Region



#Region "ID Property"
	
    <DataMember>Public NotOverridable Overrides Property Id() As object
        Get
            return me._BANKID
        End Get
        Set(ByVal value As object)
             me._BANKID = Clng(value)
             me.raiseBroadcastIdChange()
        End Set
    End Property
#End Region
	
#Region "Extra Code"
	
#End Region
	
	End Class

#Region "Req Fields validator"
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class BankRequiredFieldsValidator
        Implements IModelObjectValidator

        Public Sub validate(ByVal imo As org.model.lib.Model.IModelObject) _
                    Implements org.model.lib.IModelObjectValidator.validate

            Dim mo As Bank = CType(imo, Bank)
			
			
        End Sub

    End Class
#End Region

End Namespace

