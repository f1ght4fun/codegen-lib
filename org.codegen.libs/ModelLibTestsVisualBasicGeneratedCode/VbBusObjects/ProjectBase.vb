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
' Class autogenerated on 12/07/2015 11:21:30 AM by ModelGenerator
' Extends base model object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class Project
'
'************************************************************
'</comments>
Namespace VbBusObjects
<Table(Name := "Project")><SelectObject("Project")><KeyFieldName("ProjectId")> _
<DefaultMapperAttr(GetType(ProjectDBMapper)), DataContract, _
ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
partial class Project
		Inherits ModelObject
		Implements IEquatable(Of Project) 

#Region "Constructor"
    
    Friend sub New()
		Me.addValidator(New ProjectRequiredFieldsValidator)
		Me.Id = ModelObjectKeyGen.nextId()
    End Sub

#End Region

#Region "Children and Parents"
	
	public Overrides sub loadObjectHierarchy()
				LoadPrEmployeeProjects()

	End Sub

	Public Overrides Function getChildren() As List(Of ModelObject) 
		Dim ret as New List(Of ModelObject)()
			if  Me.EmployeeProjectsLoaded Then 'check if loaded first!
		Dim lp As List(Of ModelObject) = Me._EmployeeProjects.ConvertAll( _
				New Converter(Of VbBusObjects.EmployeeProject, ModelObject)(
			Function(pf As VbBusObjects.EmployeeProject)
				Return DirectCast(pf, ModelObject)
			End Function))
		ret.AddRange(lp)
	End If

		return ret
	End Function
	
	Public Overrides Function getParents() As List(Of ModelObject)
		Dim ret as New List(Of ModelObject)()
		
		return ret
	End Function

#End Region
#Region "Field CONSTANTS"

			public Const STR_FLD_PROJECTID as String = "ProjectId"
			public Const STR_FLD_PROJECTNAME as String = "ProjectName"
			public Const STR_FLD_ISACTIVE as String = "IsActive"
			public Const STR_FLD_PROJECTTYPEID as String = "ProjectTypeId"


		public Const FLD_PROJECTID as Integer = 0
		public Const FLD_PROJECTNAME as Integer = 1
		public Const FLD_ISACTIVE as Integer = 2
		public Const FLD_PROJECTTYPEID as Integer = 3



        '''<summary>Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_PROJECTID,STR_FLD_PROJECTNAME,STR_FLD_ISACTIVE,STR_FLD_PROJECTTYPEID}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _ProjectId as System.Int64
	Private _ProjectName as System.String
	Private _IsActive as System.Int64?
	Private _ProjectTypeId as System.Int64? = Nothing

	' *****************************************
	' ****** CHILD OBJECTS ********************
	private _EmployeeProjects as List(Of VbBusObjects.EmployeeProject) = nothing '' initialize to nothing, for lazy load logic below !!!
	private _deletedEmployeeProjects as List(Of VbBusObjects.EmployeeProject) = new List(Of VbBusObjects.EmployeeProject)''''' initialize to empty list !!!

	' *****************************************
	' ****** END CHILD OBJECTS ********************


#end Region

#Region "Field Properties"

	<Column(Name:="ProjectId",Storage:="_ProjectId", IsPrimaryKey:=True,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrProjectId as System.Int64
	Get 
		return _ProjectId
	End Get 
	Set(ByVal value As System.Int64)
		if ModelObject.valueChanged(_ProjectId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_PROJECTID)
			End If
			me._ProjectId = value

			me.raiseBroadcastIdChange()

		End if
	End Set 
	End Property 
	<Column(Name:="ProjectName",Storage:="_ProjectName", IsPrimaryKey:=False,DbType:="nvarchar NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrProjectName as System.String
	Get 
		return _ProjectName
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_ProjectName, value) then
		if value isNot Nothing andAlso value.Length > 250 Then
			Throw new ModelObjectFieldTooLongException("ProjectName")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_PROJECTNAME)
			End If
			me._ProjectName = value

		End if
	End Set 
	End Property 
	<Column(Name:="isActive",Storage:="_IsActive", IsPrimaryKey:=False,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrIsActive as Boolean
	Get 
		return CBool(IIf(_IsActive.GetValueOrDefault <> 0, True, False))
	End Get 
	Set(ByVal value As Boolean)
		if ModelObject.valueChanged(_IsActive, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ISACTIVE)
			End If
			me._IsActive = CLng(IIf(value, 1, 0))

		End if
	End Set 
	End Property 
	<Column(Name:="ProjectTypeId",Storage:="_ProjectTypeId", IsPrimaryKey:=False,DbType:="int",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrProjectTypeId as EnumProjectType?
	Get 
		return CType(_ProjectTypeId, EnumProjectType?)
	End Get 
	Set(ByVal value As EnumProjectType?)
		if ModelObject.valueChanged(_ProjectTypeId, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_PROJECTTYPEID)
			End If
			Me._ProjectTypeId = CType(value, EnumProjectType?)

		End if
	End Set 
	End Property 
		#end region
		#region "Associations"
		
		#Region "Association EmployeeProjects"
		'associationChildMany.txt
		Friend EmployeeProjectsLoaded as Boolean

		Public Overridable Function PrEmployeeProjectGetAt(ByVal i As Integer) As VbBusObjects.EmployeeProject

            me.LoadPrEmployeeProjects
            If Me._EmployeeProjects.Count >= (i - 1) Then
                Return Me._EmployeeProjects.Item(i)
            End If
            Return Nothing

        End Function        
		
		Public Overridable Sub PrEmployeeProjectAdd(val As VbBusObjects.EmployeeProject) 

			'1-Many , add a single item!
			me.LoadPrEmployeeProjects
			val.PrEPProjectId = me.PrProjectId
			AddHandler Me.IDChanged, AddressOf val.handleParentIdChanged
			me._EmployeeProjects.add(val)

        End Sub

		 Public Overridable Sub PrEmployeeProjectsClear()

            Me.LoadPrEmployeeProjects
            Me._deletedEmployeeProjects.AddRange(Me._EmployeeProjects)
            Me._EmployeeProjects.Clear()

        End Sub

		Public Overridable Sub EmployeeProjectRemove(val As VbBusObjects.EmployeeProject) 
			
			me.LoadPrEmployeeProjects
			me._deletedEmployeeProjects.add(val)
			me._EmployeeProjects.remove(val)

        End Sub

		
		Public Overridable Function PrEmployeeProjectsGetDeleted() As IEnumerable(Of VbBusObjects.EmployeeProject)  
			
			return me._deletedEmployeeProjects

        End Function

		<DataMember>
        Public Overridable Property PrEmployeeProjects() As IEnumerable(Of VbBusObjects.EmployeeProject) 

            Get
				'1 to many relation
                'LAZY LOADING! Only hit the database to get the child object if we need it
                If Me._EmployeeProjects Is Nothing Then
                    me.LoadPrEmployeeProjects
                End If ' me._EmployeeProjects is Nothing
				
                Return Me._EmployeeProjects
            End Get
            
			Set(value as IEnumerable(Of VbBusObjects.EmployeeProject))
				if value is nothing then
					Me._EmployeeProjects = nothing
                Else
                    Me._EmployeeProjects = New List(Of VbBusObjects.EmployeeProject)
                    Me.addToEmployeeProjectsList(value)
                End If
			End Set

        End Property

		''' <summary>
        ''' Private method to add to the EmployeeProjects List. 
		''' The list must have aldready been initialized
        ''' </summary>
		Private Sub addToEmployeeProjectsList(ByVal value As IEnumerable(Of VbBusObjects.EmployeeProject))

			Dim enumtor As IEnumerator(Of VbBusObjects.EmployeeProject) = value.GetEnumerator
        
		    While enumtor.MoveNext
                Dim v As VbBusObjects.EmployeeProject = enumtor.Current
                AddHandler Me.IDChanged, AddressOf v.handleParentIdChanged
                Me._EmployeeProjects.Add(v)
            End While

        End Sub
        
        ''' <summary>
        ''' Loads child objects from dabatabase, if not loaded already
        ''' </summary>
        private Sub LoadPrEmployeeProjects
			
			if me.EmployeeProjectsLoaded then return
			'init list
			Me._EmployeeProjects = New List(Of VbBusObjects.EmployeeProject)

			If Not Me.isNew Then
                
                Me.addToEmployeeProjectsList( new VbBusObjects.DBMappers.EmployeeProjectDBMapper().findList( _ 
																		"EPProjectId=?", Me.PrProjectId))
            End If
            
			me.EmployeeProjectsLoaded = true
        End Sub
		#End Region


#End Region

#Region "Getters/Setters of values by field index / name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_PROJECTID
			return me.PrProjectId
		case FLD_PROJECTNAME
			return me.PrProjectName
		case FLD_ISACTIVE
			return me.PrIsActive
		case FLD_PROJECTTYPEID
			return me.PrProjectTypeId
		case else
			return nothing
		end select


    End Function

    Public Overloads Overrides Function getAttribute(ByVal fieldKey As String) As Object
		fieldKey = fieldKey.ToLower

		if fieldKey=STR_FLD_PROJECTID.ToLower() Then
			return me.PrProjectId
		else if fieldKey=STR_FLD_PROJECTNAME.ToLower() Then
			return me.PrProjectName
		else if fieldKey=STR_FLD_ISACTIVE.ToLower() Then
			return me.PrIsActive
		else if fieldKey=STR_FLD_PROJECTTYPEID.ToLower() Then
			return me.PrProjectTypeId
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		Try
		Select Case fieldKey
		case FLD_PROJECTID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectId = Nothing
			Else
				Me.PrProjectId=CType(val,System.Int64)
			End If
			return
		case FLD_PROJECTNAME
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectName = Nothing
			Else
				Me.PrProjectName=CType(val,System.String)
			End If
			return
		case FLD_ISACTIVE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrIsActive = False
			Else
				Me.PrIsActive=CType(val,Boolean)
			End If
			return
		case FLD_PROJECTTYPEID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectTypeId = Nothing
			Else
				Me.PrProjectTypeId=CType(val,EnumProjectType?)
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
		if  fieldKey=STR_FLD_PROJECTID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectId = Nothing
			Else
				Me.PrProjectId=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_PROJECTNAME.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectName = Nothing
			Else
				Me.PrProjectName=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_ISACTIVE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrIsActive = False
			Else
				Me.PrIsActive=CType(val,Boolean)
			End If
			return
		else if  fieldKey=STR_FLD_PROJECTTYPEID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectTypeId = Nothing
			Else
				Me.PrProjectTypeId=CType(val,EnumProjectType?)
			End If
			return
		end If
		Catch ex As Exception
			Throw New ApplicationException(String.Format("Error setting field with index {0}, value ""{1}"" : {2}", fieldKey, val, ex.Message))
		End Try

    End Sub

#End Region
#Region "Overrides of GetHashCode, Equals "
	Public Overloads Function Equals(ByVal other As Project) As Boolean _     
		Implements System.IEquatable(Of Project).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrProjectId= other.PrProjectId _
				AndAlso me.PrProjectName= other.PrProjectName _
				AndAlso me.PrIsActive= other.PrIsActive _
				AndAlso me.PrProjectTypeId.GetValueOrDefault = other.PrProjectTypeId.GetValueOrDefault
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.PrProjectId.GetHashCode _
				Xor me.getStringHashCode(Me.PrProjectName) _
				Xor me.PrIsActive.GetHashCode _
				Xor me.PrProjectTypeId.GetHashCode 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, Project)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As Project, ByVal obj2 As Project) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As Project, ByVal obj2 As Project) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a shallow copy
        Dim ret as Project =  new Project()
		ret.PrProjectId = me.PrProjectId
		ret.PrProjectName = me.PrProjectName
		ret.PrIsActive = me.PrIsActive
		ret.PrProjectTypeId = me.PrProjectTypeId
		
		return ret
		
	End Function
	
#End Region



#Region "ID Property"
	
    <DataMember>Public NotOverridable Overrides Property Id() As object
        Get
            return me._ProjectId
        End Get
        Set(ByVal value As object)
             me._ProjectId = Clng(value)
             me.raiseBroadcastIdChange()
        End Set
    End Property
#End Region
	
#Region "Extra Code"
	
#End Region
	
	End Class

#Region "Req Fields validator"
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class ProjectRequiredFieldsValidator
        Implements IModelObjectValidator

        Public Sub validate(ByVal imo As org.model.lib.Model.IModelObject) _
                    Implements org.model.lib.IModelObjectValidator.validate

            Dim mo As Project = CType(imo, Project)
			if String.isNullOrEmpty( mo.PrProjectName) Then
		Throw new ModelObjectRequiredFieldException("ProjectName")
End if 

			
        End Sub

    End Class
#End Region

End Namespace

