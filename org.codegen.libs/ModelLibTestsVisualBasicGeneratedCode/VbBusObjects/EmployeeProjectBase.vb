﻿
'NOTE: DO NOT ADD REFERENCES TO COM.NETU.LIB HERE, INSTEAD ADD
'THE IMPORT ON THE REFERENCES OF THE PROJECT
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Runtime.Serialization
Imports System.Data.Linq.Mapping
'<comments>
'************************************************************
' Temnplate: ModelBase2.visualBasic.txt
' Class autogenerated on 16-Jun-15 11:20:08 AM by ModelGenerator
' Extends base model object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class EmployeeProject
'
'************************************************************
'</comments>
Namespace VbBusObjects
<Table(Name := "EmployeeProject")>
<DefaultMapperAttr(GetType(EmployeeProjectDBMapper)), DataContract, _
ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
partial class EmployeeProject
		Inherits ModelObject
		Implements IEquatable(Of EmployeeProject) 

#Region "Constructor"
    
    Friend sub New()
		Me.addValidator(New EmployeeProjectRequiredFieldsValidator)
		Me.Id = ModelObjectKeyGen.nextId()
    End Sub

#End Region

#Region "Children and Parents"
	
	public Overrides sub loadObjectHierarchy()
				loadProject()

	End Sub

	Public Overrides Function getChildren() As List(Of ModelObject) 
		Dim ret as New List(Of ModelObject)()
		
		return ret
	End Function
	
	Public Overrides Function getParents() As List(Of ModelObject)
		Dim ret as New List(Of ModelObject)()
		if  Me._Project isNot Nothing AndAlso Me._ProjectLoaded Then
	ret.Add(me.PrProject)
End If

		return ret
	End Function

#End Region
#Region "Field CONSTANTS"

			public Const STR_FLD_EMPLOYEEPROJECTID as String = "EmployeeProjectId"
			public Const STR_FLD_EPEMPLOYEEID as String = "EPEmployeeId"
			public Const STR_FLD_EPPROJECTID as String = "EPProjectId"
			public Const STR_FLD_ASSIGNDATE as String = "AssignDate"
			public Const STR_FLD_ENDDATE as String = "EndDate"
			public Const STR_FLD_RATE as String = "Rate"


		public Const FLD_EMPLOYEEPROJECTID as Integer = 0
		public Const FLD_EPEMPLOYEEID as Integer = 1
		public Const FLD_EPPROJECTID as Integer = 2
		public Const FLD_ASSIGNDATE as Integer = 3
		public Const FLD_ENDDATE as Integer = 4
		public Const FLD_RATE as Integer = 5



        '''<summary> Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_EMPLOYEEPROJECTID,STR_FLD_EPEMPLOYEEID,STR_FLD_EPPROJECTID,STR_FLD_ASSIGNDATE,STR_FLD_ENDDATE,STR_FLD_RATE}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _EmployeeProjectId as System.Int64
	Private _EPEmployeeId as System.Int64? = Nothing
	Private _EPProjectId as System.Int64? = Nothing
	Private _AssignDate as System.DateTime? = Nothing
	Private _EndDate as System.DateTime? = Nothing
	Private _Rate as System.Decimal? = Nothing

	' *****************************************
	' ****** CHILD OBJECTS ********************
	private _Project as VbBusObjects.Project = nothing ''''' initialize to nothing, for lazy load logic below !!!

	' *****************************************
	' ****** END CHILD OBJECTS ********************


#END Region

#Region "Field Properties"

	<Column(Name:="EmployeeProjectId",Storage:="_EmployeeProjectId", IsPrimaryKey:=True,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrEmployeeProjectId as System.Int64
	Get 
		return _EmployeeProjectId
	End Get 
	Set(ByVal value As System.Int64)
		if ModelObject.valueChanged(_EmployeeProjectId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EMPLOYEEPROJECTID)
			End If
			me._EmployeeProjectId = value

			me.raiseBroadcastIdChange()

		End if
	End Set 
	End Property 
	<Column(Name:="EPEmployeeId",Storage:="_EPEmployeeId", IsPrimaryKey:=False,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrEPEmployeeId as System.Int64?
	Get 
		return _EPEmployeeId
	End Get 
	Set(ByVal value As System.Int64?)
		if ModelObject.valueChanged(_EPEmployeeId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EPEMPLOYEEID)
			End If
			me._EPEmployeeId = value

		End if
	End Set 
	End Property 
	<Column(Name:="EPProjectId",Storage:="_EPProjectId", IsPrimaryKey:=False,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrEPProjectId as System.Int64?
	Get 
		return _EPProjectId
	End Get 
	Set(ByVal value As System.Int64?)
		if ModelObject.valueChanged(_EPProjectId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_EPPROJECTID)
			End If
			me._EPProjectId = value

		End if
	End Set 
	End Property 
	<Column(Name:="AssignDate",Storage:="_AssignDate", IsPrimaryKey:=False,DbType:="date",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrAssignDate as System.DateTime?
	Get 
		return _AssignDate
	End Get 
	Set(ByVal value As System.DateTime?)
		if ModelObject.valueChanged(_AssignDate, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ASSIGNDATE)
			End If
			me._AssignDate = value

		End if
	End Set 
	End Property 
	<Column(Name:="EndDate",Storage:="_EndDate", IsPrimaryKey:=False,DbType:="date",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrEndDate as System.DateTime?
	Get 
		return _EndDate
	End Get 
	Set(ByVal value As System.DateTime?)
		if ModelObject.valueChanged(_EndDate, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ENDDATE)
			End If
			me._EndDate = value

		End if
	End Set 
	End Property 
	<Column(Name:="Rate",Storage:="_Rate", IsPrimaryKey:=False,DbType:="decimal",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrRate as System.Decimal?
	Get 
		return _Rate
	End Get 
	Set(ByVal value As System.Decimal?)
		if ModelObject.valueChanged(_Rate, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_RATE)
			End If
			me._Rate = value

		End if
	End Set 
	End Property 

		' ASSOCIATIONS GETTERS/SETTERS BELOW!
		
		'associationParent.txt
		#Region "Association Project"
		friend _ProjectLoaded as Boolean

		''' <summary>
        ''' Gets/Sets parent object
        ''' </summary>
		Public Overridable Property PrProject() As VbBusObjects.Project 

		    '1-1 parent association
            Set(ByVal value As VbBusObjects.Project)
                Me._Project = value
				If value isnot Nothing then
					me.PrEPProjectId = value.PrProjectId
					AddHandler value.IDChanged, AddressOf Me.handleParentIdChanged
                Else
					me.PrEPProjectId = Nothing
				End If

            End Set


            Get
                'LAZY LOADING! Only hit the database to get the child object if we need it
                If Me._Project Is Nothing Then
					Me.loadProject
                End If 
				
                Return Me._Project
            End Get
        End Property
        
        ''' <summary>
        ''' Loads parent object and sets the appropriate properties
        ''' </summary>x
        private Sub loadProject
			
			If me._ProjectLoaded then return
			
			'check if object is not loaded
			If Me._Project Is Nothing AndAlso _
                   Me.PrEPProjectId IsNot Nothing Then
                
				'call the setter here, not the private variable!
                Me.PrProject = new VbBusObjects.DBMappers.ProjectDBMapper().FindByKey( _ 
				                 Me.PrEPProjectId.Value)
                
            End If

            me._ProjectLoaded=true
			            
        End Sub

		#End Region


#End Region

#Region "Getters/Setters of values by field index/name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_EMPLOYEEPROJECTID
			return me.PrEmployeeProjectId
		case FLD_EPEMPLOYEEID
			return me.PrEPEmployeeId
		case FLD_EPPROJECTID
			return me.PrEPProjectId
		case FLD_ASSIGNDATE
			return me.PrAssignDate
		case FLD_ENDDATE
			return me.PrEndDate
		case FLD_RATE
			return me.PrRate
		case else
			return nothing
		end select


    End Function

    Public Overloads Overrides Function getAttribute(ByVal fieldKey As String) As Object
		fieldKey = fieldKey.ToLower

		if fieldKey=STR_FLD_EMPLOYEEPROJECTID.ToLower() Then
			return me.PrEmployeeProjectId
		else if fieldKey=STR_FLD_EPEMPLOYEEID.ToLower() Then
			return me.PrEPEmployeeId
		else if fieldKey=STR_FLD_EPPROJECTID.ToLower() Then
			return me.PrEPProjectId
		else if fieldKey=STR_FLD_ASSIGNDATE.ToLower() Then
			return me.PrAssignDate
		else if fieldKey=STR_FLD_ENDDATE.ToLower() Then
			return me.PrEndDate
		else if fieldKey=STR_FLD_RATE.ToLower() Then
			return me.PrRate
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		Try
		Select Case fieldKey
		case FLD_EMPLOYEEPROJECTID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeProjectId = Nothing
			Else
				Me.PrEmployeeProjectId=CType(val,System.Int64)
			End If
			return
		case FLD_EPEMPLOYEEID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEPEmployeeId = Nothing
			Else
				Me.PrEPEmployeeId=CType(val,System.Int64?)
			End If
			return
		case FLD_EPPROJECTID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEPProjectId = Nothing
			Else
				Me.PrEPProjectId=CType(val,System.Int64?)
			End If
			return
		case FLD_ASSIGNDATE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAssignDate = Nothing
			Else
				Me.PrAssignDate=CType(val,System.DateTime?)
			End If
			return
		case FLD_ENDDATE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEndDate = Nothing
			Else
				Me.PrEndDate=CType(val,System.DateTime?)
			End If
			return
		case FLD_RATE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrRate = Nothing
			Else
				Me.PrRate=CType(val,System.Decimal?)
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
		if  fieldKey=STR_FLD_EMPLOYEEPROJECTID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEmployeeProjectId = Nothing
			Else
				Me.PrEmployeeProjectId=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_EPEMPLOYEEID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEPEmployeeId = Nothing
			Else
				Me.PrEPEmployeeId=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_EPPROJECTID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEPProjectId = Nothing
			Else
				Me.PrEPProjectId=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_ASSIGNDATE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAssignDate = Nothing
			Else
				Me.PrAssignDate=Convert.ToDateTime(val)
			End If
			return
		else if  fieldKey=STR_FLD_ENDDATE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrEndDate = Nothing
			Else
				Me.PrEndDate=Convert.ToDateTime(val)
			End If
			return
		else if  fieldKey=STR_FLD_RATE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrRate = Nothing
			Else
				Me.PrRate=Convert.ToDecimal(val)
			End If
			return
		end If
		Catch ex As Exception
			Throw New ApplicationException(String.Format("Error setting field with index {0}, value ""{1}"" : {2}", fieldKey, val, ex.Message))
		End Try

    End Sub

#End Region
#Region "Overrides of GetHashCode and Equals "
	Public Overloads Function Equals(ByVal other As EmployeeProject) As Boolean _     
		Implements System.IEquatable(Of EmployeeProject).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrEmployeeProjectId= other.PrEmployeeProjectId _
				AndAlso me.PrEPEmployeeId.GetValueOrDefault = other.PrEPEmployeeId.GetValueOrDefault _
				AndAlso me.PrEPProjectId.GetValueOrDefault = other.PrEPProjectId.GetValueOrDefault _
				AndAlso me.PrAssignDate.GetValueOrDefault = other.PrAssignDate.GetValueOrDefault _
				AndAlso me.PrEndDate.GetValueOrDefault = other.PrEndDate.GetValueOrDefault _
				AndAlso me.PrRate.GetValueOrDefault = other.PrRate.GetValueOrDefault
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.PrEmployeeProjectId.GetHashCode _
				Xor me.PrEPEmployeeId.GetHashCode _
				Xor me.PrEPProjectId.GetHashCode _
				Xor me.PrAssignDate.GetHashCode _
				Xor me.PrEndDate.GetHashCode _
				Xor me.PrRate.GetHashCode 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, EmployeeProject)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As EmployeeProject, ByVal obj2 As EmployeeProject) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As EmployeeProject, ByVal obj2 As EmployeeProject) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a shallow copy
        Dim ret as EmployeeProject =  new EmployeeProject()
		ret.PrEmployeeProjectId = me.PrEmployeeProjectId
		ret.PrEPEmployeeId = me.PrEPEmployeeId
		ret.PrEPProjectId = me.PrEPProjectId
		ret.PrAssignDate = me.PrAssignDate
		ret.PrEndDate = me.PrEndDate
		ret.PrRate = me.PrRate
		
		return ret
		
	End Function
	
#End Region

#Region "parentIdChanged"
	'below sub is called when parentIdChanged
	public Overrides Sub handleParentIdChanged(parentMo as Object, e as IDChangedEventArgs)
		' Assocations from VbBusObjects.Employee
		if (typeof parentMo is VbBusObjects.Employee) Then
			me.PrEPEmployeeId= DirectCast(parentMo, VbBusObjects.Employee).PrEmployeeId
		End If
		' Assocations from VbBusObjects.Project
		if (typeof parentMo is VbBusObjects.Project) Then
			me.PrEPProjectId= DirectCast(parentMo, VbBusObjects.Project).PrProjectId
		End If
		' Assocations from VbBusObjects.Project
		if (typeof parentMo is VbBusObjects.Project) Then
			me.PrEPProjectId= DirectCast(parentMo, VbBusObjects.Project).PrProjectId
		End If
	End Sub
#End Region


#Region "ID Property"
	
    <DataMember>Public NotOverridable Overrides Property Id() As object
        Get
            return me._EmployeeProjectId
        End Get
        Set(ByVal value As object)
             me._EmployeeProjectId = Clng(value)
             me.raiseBroadcastIdChange()
        End Set
    End Property
#End Region
	
#Region "Extra Code"
	
#End Region
	
	End Class

#Region "Req Fields validator"
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class EmployeeProjectRequiredFieldsValidator
        Implements IModelObjectValidator

        Public Sub validate(ByVal imo As org.model.lib.Model.IModelObject) _
                    Implements org.model.lib.IModelObjectValidator.validate

            Dim mo As EmployeeProject = CType(imo, EmployeeProject)
			if mo.PrEPEmployeeId is Nothing then
		Throw new ModelObjectRequiredFieldException("EPEmployeeId")
End if 
if mo.PrEPProjectId is Nothing then
		Throw new ModelObjectRequiredFieldException("EPProjectId")
End if 

			
        End Sub

    End Class
#End Region

End Namespace

