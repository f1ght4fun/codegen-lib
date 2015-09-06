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
' Instead, change code in the extender class EmployeeEvaluation
'
'************************************************************
'</comments>
Namespace VbBusObjects
<Table(Name := "Employee_Evaluation")><SelectObject("Employee_Evaluation")><KeyFieldName("Employee_Evaluation_Id")> _
<DefaultMapperAttr(GetType(EmployeeEvaluationDBMapper)), DataContract, _
ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
partial class EmployeeEvaluation
		Inherits ModelObject
		Implements IEquatable(Of EmployeeEvaluation) 

#Region "Constructor"
    
    Friend sub New()
		Me.addValidator(New EmployeeEvaluationRequiredFieldsValidator)
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

			public Const STR_FLD_EMPLOYEE_EVALUATION_ID as String = "EmployeeEvaluationId"
			public Const STR_FLD_EVALUATOR_ID as String = "EvaluatorId"
			public Const STR_FLD_EVALUATION_DATE as String = "EvaluationDate"
			public Const STR_FLD_EMPLOYEE_ID as String = "EmployeeId"


		public Const FLD_EMPLOYEE_EVALUATION_ID as Integer = 0
		public Const FLD_EVALUATOR_ID as Integer = 1
		public Const FLD_EVALUATION_DATE as Integer = 2
		public Const FLD_EMPLOYEE_ID as Integer = 3



        '''<summary>Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_EMPLOYEE_EVALUATION_ID,STR_FLD_EVALUATOR_ID,STR_FLD_EVALUATION_DATE,STR_FLD_EMPLOYEE_ID}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _EmployeeEvaluationId as System.Int64
	Private _EvaluatorId as System.Int64? = Nothing
	Private _EvaluationDate as System.DateTime? = Nothing
	Private _EmployeeId as System.Int64? = Nothing


#end Region

#Region "Field Properties"

	<Column(Name:="Employee_Evaluation_Id",Storage:="_EmployeeEvaluationId", IsPrimaryKey:=True,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrEmployeeEvaluationId as System.Int64
	Get 
		return _EmployeeEvaluationId
	End Get 
	Set(ByVal value As System.Int64)
		if ModelObject.valueChanged(_EmployeeEvaluationId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EMPLOYEE_EVALUATION_ID)
			End If
			me._EmployeeEvaluationId = value

			me.raiseBroadcastIdChange()

		End if
	End Set 
	End Property 
	<Column(Name:="evaluator_id",Storage:="_EvaluatorId", IsPrimaryKey:=False,DbType:="int",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrEvaluatorId as System.Int64?
	Get 
		return _EvaluatorId
	End Get 
	Set(ByVal value As System.Int64?)
		if ModelObject.valueChanged(_EvaluatorId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EVALUATOR_ID)
			End If
			me._EvaluatorId = value

		End if
	End Set 
	End Property 
	<Column(Name:="evaluation_date",Storage:="_EvaluationDate", IsPrimaryKey:=False,DbType:="datetime",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrEvaluationDate as System.DateTime?
	Get 
		return _EvaluationDate
	End Get 
	Set(ByVal value As System.DateTime?)
		if ModelObject.valueChanged(_EvaluationDate, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EVALUATION_DATE)
			End If
			me._EvaluationDate = value

		End if
	End Set 
	End Property 
	<Column(Name:="employee_id",Storage:="_EmployeeId", IsPrimaryKey:=False,DbType:="int",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrEmployeeId as System.Int64?
	Get 
		return _EmployeeId
	End Get 
	Set(ByVal value As System.Int64?)
		if ModelObject.valueChanged(_EmployeeId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EMPLOYEE_ID)
			End If
			me._EmployeeId = value

		End if
	End Set 
	End Property 

#End Region

#Region "Getters/Setters of values by field index / name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_EMPLOYEE_EVALUATION_ID
			return me.PrEmployeeEvaluationId
		case FLD_EVALUATOR_ID
			return me.PrEvaluatorId
		case FLD_EVALUATION_DATE
			return me.PrEvaluationDate
		case FLD_EMPLOYEE_ID
			return me.PrEmployeeId
		case else
			return nothing
		end select


    End Function

    Public Overloads Overrides Function getAttribute(ByVal fieldKey As String) As Object
		fieldKey = fieldKey.ToLower

		if fieldKey=STR_FLD_EMPLOYEE_EVALUATION_ID.ToLower() Then
			return me.PrEmployeeEvaluationId
		else if fieldKey=STR_FLD_EVALUATOR_ID.ToLower() Then
			return me.PrEvaluatorId
		else if fieldKey=STR_FLD_EVALUATION_DATE.ToLower() Then
			return me.PrEvaluationDate
		else if fieldKey=STR_FLD_EMPLOYEE_ID.ToLower() Then
			return me.PrEmployeeId
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		Try
		Select Case fieldKey
		case FLD_EMPLOYEE_EVALUATION_ID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeEvaluationId = Nothing
			Else
				Me.PrEmployeeEvaluationId=CType(val,System.Int64)
			End If
			return
		case FLD_EVALUATOR_ID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEvaluatorId = Nothing
			Else
				Me.PrEvaluatorId=CType(val,System.Int64?)
			End If
			return
		case FLD_EVALUATION_DATE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEvaluationDate = Nothing
			Else
				Me.PrEvaluationDate=CType(val,System.DateTime?)
			End If
			return
		case FLD_EMPLOYEE_ID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeId = Nothing
			Else
				Me.PrEmployeeId=CType(val,System.Int64?)
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
		if  fieldKey=STR_FLD_EMPLOYEE_EVALUATION_ID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeEvaluationId = Nothing
			Else
				Me.PrEmployeeEvaluationId=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_EVALUATOR_ID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEvaluatorId = Nothing
			Else
				Me.PrEvaluatorId=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_EVALUATION_DATE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEvaluationDate = Nothing
			Else
				Me.PrEvaluationDate=Convert.ToDateTime(val)
			End If
			return
		else if  fieldKey=STR_FLD_EMPLOYEE_ID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeId = Nothing
			Else
				Me.PrEmployeeId=Convert.ToInt64(val)
			End If
			return
		end If
		Catch ex As Exception
			Throw New ApplicationException(String.Format("Error setting field with index {0}, value ""{1}"" : {2}", fieldKey, val, ex.Message))
		End Try

    End Sub

#End Region
#Region "Overrides of GetHashCode, Equals "
	Public Overloads Function Equals(ByVal other As EmployeeEvaluation) As Boolean _     
		Implements System.IEquatable(Of EmployeeEvaluation).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrEmployeeEvaluationId= other.PrEmployeeEvaluationId _
				AndAlso me.PrEvaluatorId.GetValueOrDefault = other.PrEvaluatorId.GetValueOrDefault _
				AndAlso me.PrEvaluationDate.GetValueOrDefault = other.PrEvaluationDate.GetValueOrDefault _
				AndAlso me.PrEmployeeId.GetValueOrDefault = other.PrEmployeeId.GetValueOrDefault
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.PrEmployeeEvaluationId.GetHashCode _
				Xor me.PrEvaluatorId.GetHashCode _
				Xor me.PrEvaluationDate.GetHashCode _
				Xor me.PrEmployeeId.GetHashCode 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, EmployeeEvaluation)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As EmployeeEvaluation, ByVal obj2 As EmployeeEvaluation) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As EmployeeEvaluation, ByVal obj2 As EmployeeEvaluation) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a shallow copy
        Dim ret as EmployeeEvaluation =  new EmployeeEvaluation()
		ret.PrEmployeeEvaluationId = me.PrEmployeeEvaluationId
		ret.PrEvaluatorId = me.PrEvaluatorId
		ret.PrEvaluationDate = me.PrEvaluationDate
		ret.PrEmployeeId = me.PrEmployeeId
		
		return ret
		
	End Function
	
#End Region



#Region "ID Property"
	
    <DataMember>Public NotOverridable Overrides Property Id() As object
        Get
            return me._EmployeeEvaluationId
        End Get
        Set(ByVal value As object)
             me._EmployeeEvaluationId = Clng(value)
             me.raiseBroadcastIdChange()
        End Set
    End Property
#End Region
	
#Region "Extra Code"
	
#End Region
	
	End Class

#Region "Req Fields validator"
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class EmployeeEvaluationRequiredFieldsValidator
        Implements IModelObjectValidator

        Public Sub validate(ByVal imo As org.model.lib.Model.IModelObject) _
                    Implements org.model.lib.IModelObjectValidator.validate

            Dim mo As EmployeeEvaluation = CType(imo, EmployeeEvaluation)
			
			
        End Sub

    End Class
#End Region

End Namespace

