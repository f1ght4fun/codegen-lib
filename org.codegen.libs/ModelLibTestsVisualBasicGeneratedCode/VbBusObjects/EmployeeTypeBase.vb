﻿
'NOTE: DO NOT ADD REFERENCES TO COM.NETU.LIB HERE, INSTEAD ADD
'THE IMPORT ON THE REFERENCES OF THE PROJECT
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

'<comments>
'************************************************************
' Temnplate: ModelBase2.visualBasic.txt
' Class autogenerated on 19-May-15 2:43:51 PM by ModelGenerator
' Extends base model object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class EmployeeType
'
'************************************************************
'</comments>
Namespace VbBusObjects

#Region "Interface"
<System.Runtime.InteropServices.ComVisible(False)> _
	Public Interface IEmployeeType: Inherits IModelObject
	Property PrEmployeeTypeCode as System.String
	Property PrEmployeeType as System.String
End Interface
#End region 

	<DefaultMapperAttr(GetType(EmployeeTypeDBMapper)), DataContract, _
	 ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
	Public class EmployeeTypeBase
		Inherits ModelObject
		Implements IEquatable(Of EmployeeTypeBase),
		IEmployeeType 

#Region "Constructor"
    
    public sub New()
		Me.addValidator(New EmployeeTypeRequiredFieldsValidator)
    End Sub

#End Region

#Region "Children and Parents"
	
	public Overrides sub loadObjectHierarchy()
		
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

			public Const STR_FLD_EMPLOYEETYPECODE as String = "EmployeeTypeCode"
			public Const STR_FLD_EMPLOYEETYPE as String = "EmployeeType"


		public Const FLD_EMPLOYEETYPECODE as Integer = 0
		public Const FLD_EMPLOYEETYPE as Integer = 1



        '''<summary> Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_EMPLOYEETYPECODE,STR_FLD_EMPLOYEETYPE}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _EmployeeTypeCode as System.String
	Private _EmployeeType as System.String


#END Region

#Region "Field Properties"

<DataMember>	 Overridable Property PrEmployeeTypeCode as System.String _ 
		Implements IEmployeeType.PrEmployeeTypeCode
	Get 
		return _EmployeeTypeCode
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_EmployeeTypeCode, value) then
		if value isNot Nothing andAlso value.Length > 10 Then
			Throw new ModelObjectFieldTooLongException("EmployeeTypeCode")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EMPLOYEETYPECODE)
			End If
			me._EmployeeTypeCode=value

			me.raiseBroadcastIdChange()

		End if
	End Set 
	End Property 
<DataMember>	 Overridable Property PrEmployeeType as System.String _ 
		Implements IEmployeeType.PrEmployeeType
	Get 
		return _EmployeeType
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_EmployeeType, value) then
		if value isNot Nothing andAlso value.Length > 50 Then
			Throw new ModelObjectFieldTooLongException("EmployeeType")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EMPLOYEETYPE)
			End If
			me._EmployeeType=value

		End if
	End Set 
	End Property 

#End Region

#Region "Getters/Setters of values by field index/name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_EMPLOYEETYPECODE
			return me.PrEmployeeTypeCode
		case FLD_EMPLOYEETYPE
			return me.PrEmployeeType
		case else
			return nothing
		end select


    End Function

    Public Overloads Overrides Function getAttribute(ByVal fieldKey As String) As Object
		fieldKey = fieldKey.ToLower

		if fieldKey=STR_FLD_EMPLOYEETYPECODE.ToLower() Then
			return me.PrEmployeeTypeCode
		else if fieldKey=STR_FLD_EMPLOYEETYPE.ToLower() Then
			return me.PrEmployeeType
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		
		Select Case fieldKey
		case FLD_EMPLOYEETYPECODE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeTypeCode = Nothing
			Else
				Me.PrEmployeeTypeCode=CType(val,System.String)
			End If
			return
		case FLD_EMPLOYEETYPE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeType = Nothing
			Else
				Me.PrEmployeeType=CType(val,System.String)
			End If
			return
		case else
			return
		end select


    End Sub

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As String, ByVal val As Object)
		
		fieldKey = fieldKey.ToLower
		
		if  fieldKey=STR_FLD_EMPLOYEETYPECODE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeTypeCode = Nothing
			Else
				Me.PrEmployeeTypeCode=CType(val,System.String)
			End If
			return
		else if  fieldKey=STR_FLD_EMPLOYEETYPE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeType = Nothing
			Else
				Me.PrEmployeeType=CType(val,System.String)
			End If
			return
		end If

    End Sub

#End Region
#Region "Overrides of GetHashCode and Equals "
	Public Overloads Function Equals(ByVal other As EmployeeTypeBase) As Boolean _     
		Implements System.IEquatable(Of EmployeeTypeBase).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrEmployeeTypeCode= other.PrEmployeeTypeCode _
				AndAlso me.PrEmployeeType= other.PrEmployeeType
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.getStringHashCode(Me.PrEmployeeTypeCode) _
				Xor me.getStringHashCode(Me.PrEmployeeType) 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, EmployeeTypeBase)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As EmployeeTypeBase, ByVal obj2 As EmployeeTypeBase) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As EmployeeTypeBase, ByVal obj2 As EmployeeTypeBase) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a copy
		
		'NOTE: we can't cast from EmployeeTypeBase to EmployeeType, so below we 
        'instantiate a EmployeeType, NOT a EmployeeTypeBase object
        Dim ret as EmployeeType = EmployeeTypeFactory.Create()
            
				ret.PrEmployeeTypeCode = me.PrEmployeeTypeCode
		ret.PrEmployeeType = me.PrEmployeeType

		
		return ret
		
	End Function
	
#End Region



#Region "ID Property"
	
    <DataMember>Public Overrides Property Id() As object 
        Get
            return me._EmployeeTypeCode
        End Get
        Set(ByVal value As object)
             me._EmployeeTypeCode = CStr(value)
             me.raiseBroadcastIdChange()
        End Set
    End Property
#End Region
	
#Region "Extra Code"
	
#End Region
	
	End Class

#Region "Req Fields validator"
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class EmployeeTypeRequiredFieldsValidator
        Implements IModelObjectValidator

        Public Sub validate(ByVal imo As org.model.lib.Model.IModelObject) _
                    Implements org.model.lib.IModelObjectValidator.validate

            Dim mo As EmployeeType = CType(imo, EmployeeType)
			if String.isNullOrEmpty( mo.PrEmployeeType) Then
		Throw new ModelObjectRequiredFieldException("EmployeeType")
End if 

			
        End Sub

    End Class
#End Region

End Namespace

