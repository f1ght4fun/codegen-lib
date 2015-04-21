﻿
'NOTE: DO NOT ADD REFERENCES TO COM.NETU.LIB HERE, INSTEAD ADD
'THE IMPORT ON THE REFERENCES OF THE PROJECT
Imports System.Runtime.InteropServices
Imports System.Collections.Generic
Imports System.Xml.Serialization
'<comments>
'************************************************************
' Temnplate: ModelBase2.visualBasic.txt
' Class autogenerated on 14-04-2015 11:05:50 by ModelGenerator
' Extends base model object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class Project
'
'************************************************************
'</comments>
Namespace VbBusObjects

#Region "Interface"
<System.Runtime.InteropServices.ComVisible(False)> _
	Public Interface IProject: Inherits IModelObject
	Property PrProjectId as System.Int64
	Property PrProjectName as System.String
	Property PrIsActive as Nullable (of System.Boolean)
	Property PrEmployeeProjects as IEnumerable(Of VbBusObjects.EmployeeProject)
		Sub EmployeeProjectAdd(val as VbBusObjects.EmployeeProject)
		Sub EmployeeProjectRemove(val as VbBusObjects.EmployeeProject)
		Function EmployeeProjectsGetDeleted() as IEnumerable(Of VbBusObjects.EmployeeProject)
		Function EmployeeProjectGetAt(ByVal i As Integer) as VbBusObjects.EmployeeProject

End Interface
#End region 

	<DefaultMapperAttr(GetType(ProjectDBMapper)), _
	 ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
	Public class ProjectBase
		Inherits ModelObject
		Implements IEquatable(Of ProjectBase),
		IProject 

#Region "Constructor"
    
    public sub New()
		Me.addValidator(New ProjectRequiredFieldsValidator)
    End Sub

#End Region

#Region "Children and Parents"
	
	public Overrides sub loadObjectHierarchy()
				loadEmployeeProjects()

	End Sub

	Public Overrides Function getChildren() As List(Of ModelObject) 
		Dim ret as New List(Of ModelObject)()
			if  Me._EmployeeProjectsLoaded Then ' check if loaded first!
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


		public Const FLD_PROJECTID as Integer = 0
		public Const FLD_PROJECTNAME as Integer = 1
		public Const FLD_ISACTIVE as Integer = 2



        '''<summary> Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_PROJECTID,STR_FLD_PROJECTNAME,STR_FLD_ISACTIVE}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _ProjectId as System.Int64
	Private _ProjectName as System.String = Nothing
	Private _IsActive as Nullable (of System.Int64) = Nothing

	' *****************************************
	' ****** CHILD OBJECTS ********************
	private _EmployeeProjects as List(Of VbBusObjects.EmployeeProject) = nothing ''''' initialize to nothing, for lazy load logic below !!!
	private _deletedEmployeeProjects as List(Of VbBusObjects.EmployeeProject) = new List(Of VbBusObjects.EmployeeProject)''''' initialize to empty list !!!

	' *****************************************
	' ****** END CHILD OBJECTS ********************


#END Region

#Region "Field Properties"

	Public Overridable Property PrProjectId as System.Int64 _ 
		Implements IProject.PrProjectId
	Get 
		return _ProjectId
	End Get 
	Set
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
Public Sub setProjectId(ByVal val As String)
	If IsNumeric(val) Then
		Me.PrProjectId = CType(val, System.Int64)
	ElseIf String.IsNullOrEmpty(val) Then
		Me.PrProjectId = Nothing
	Else
		Throw new ApplicationException("Invalid Integer Number, field:ProjectId, value:" & val)
	End If
End Sub
	Public Overridable Property PrProjectName as System.String _ 
		Implements IProject.PrProjectName
	Get 
		return _ProjectName
	End Get 
	Set
		if value isNot Nothing andAlso value.Length > 250 Then
			Throw new ModelObjectFieldTooLongException("ProjectName")
		End If
		if ModelObject.valueChanged(_ProjectName, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_PROJECTNAME)
			End If
			me._ProjectName = value

		End if
	End Set 
	End Property 
Public Sub setProjectName(ByVal val As String)
	If not String.isNullOrEmpty(val) Then
		Me.PrProjectName = val
	Else
		Me.PrProjectName = Nothing
	End If
End Sub
	Public Overridable Property PrIsActive as Nullable (of System.Boolean) _ 
		Implements IProject.PrIsActive
	Get 
		if _IsActive.hasValue then
			return  CType( _IsActive,System.Boolean)
		Else
			return False
		End if 'end customized check
	End Get 
	Set(ByVal value As Nullable (of System.Boolean))
		if ModelObject.valueChanged(_IsActive, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ISACTIVE)
			End If
			me._IsActive = CInt(IIf(value.HasValue AndAlso value.Value, 1, 0))

		End if
	End Set 
	End Property 
Public Sub setIsActive(ByVal val As String)
	If String.IsNullOrEmpty(val) Then
		Me.PrIsActive = Nothing
	Else
	    Dim newval As Boolean
	    Dim success As Boolean = Boolean.TryParse(val, newval)
	    If (Not success) Then
		    Throw new ApplicationException("Invalid Integer Number, field:IsActive, value:" & val)
	    End If
	    Me.PrIsActive = newval
	End If
End Sub

		' ASSOCIATIONS GETTERS/SETTERS BELOW!
		
		#Region "Association EmployeeProjects"
		'associationChildMany.txt
		friend _EmployeeProjectsLoaded as Boolean

		Public Overridable Function EmployeeProjectGetAt(ByVal i As Integer) As VbBusObjects.EmployeeProject _
				implements IProject.EmployeeProjectGetAt

            me.loadEmployeeProjects
            If Me._EmployeeProjects.Count >= (i - 1) Then
                Return Me._EmployeeProjects.Item(i)
            End If
            Return Nothing

        End Function        
		
		Public Overridable Sub EmployeeProjectAdd(val As VbBusObjects.EmployeeProject) _
				implements IProject.EmployeeProjectAdd
			'1-Many , add a single item!
			me.loadEmployeeProjects
			val.PrEPProjectId = me.PrProjectId
			AddHandler Me.IDChanged, AddressOf val.handleParentIdChanged
			me._EmployeeProjects.add(val)

        End Sub

		 Public Overridable Sub EmployeeProjectsClear()

            Me.loadEmployeeProjects()
            Me._deletedEmployeeProjects.AddRange(Me._EmployeeProjects)
            Me._EmployeeProjects.Clear()

        End Sub

		Public Overridable Sub EmployeeProjectRemove( _ 
					val As VbBusObjects.EmployeeProject) _
					implements IProject.EmployeeProjectRemove
			
			me.loadEmployeeProjects
			me._deletedEmployeeProjects.add(val)
			me._EmployeeProjects.remove(val)

        End Sub

		
		Public Overridable Function EmployeeProjectsGetDeleted() As IEnumerable(Of VbBusObjects.EmployeeProject) _
					implements IProject.EmployeeProjectsGetDeleted
			
			return me._deletedEmployeeProjects

        End Function

        Public Overridable Property PrEmployeeProjects() _ 
					As IEnumerable(Of VbBusObjects.EmployeeProject) _
					implements IProject.PrEmployeeProjects

            Get
				'1 to many relation
                'LAZY LOADING! Only hit the database to get the child object if we need it
                If Me._EmployeeProjects Is Nothing Then
                    me.loadEmployeeProjects
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
        Public Overridable Sub loadEmployeeProjects
			
			if me._EmployeeProjectsLoaded then return
			'init list
			Me._EmployeeProjects = New List(Of VbBusObjects.EmployeeProject)

			If Not Me.isNew Then
                
                Me.addToEmployeeProjectsList( new VbBusObjects.DBMappers.EmployeeProjectDBMapper().findList( _ 
																		"EPProjectId={0}", Me.PrProjectId))
            End If
            
			me._EmployeeProjectsLoaded = true
        End Sub
		#End Region


#End Region

#Region "Getters/Setters of values by field index/name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_PROJECTID
			return me.PrProjectId
		case FLD_PROJECTNAME
			return me.PrProjectName
		case FLD_ISACTIVE
			return me.PrIsActive
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
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		
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
				Me.PrIsActive = Nothing
			Else
				Me.PrIsActive=CType(val,System.Boolean)
			End If
			return
		case else
			return
		end select


    End Sub

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As String, ByVal val As Object)
		
		fieldKey = fieldKey.ToLower
		
		if  fieldKey=STR_FLD_PROJECTID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectId = Nothing
			Else
				Me.PrProjectId=CType(val,System.Int64)
			End If
			return
		else if  fieldKey=STR_FLD_PROJECTNAME.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrProjectName = Nothing
			Else
				Me.PrProjectName=CType(val,System.String)
			End If
			return
		else if  fieldKey=STR_FLD_ISACTIVE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrIsActive = Nothing
			Else
				Me.PrIsActive=CType(val,System.Boolean)
			End If
			return
		end If

    End Sub

#End Region
#Region "Overrides of GetHashCode and Equals "
	Public Overloads Function Equals(ByVal other As ProjectBase) As Boolean _     
		Implements System.IEquatable(Of ProjectBase).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrProjectId= other.PrProjectId _
				AndAlso me.PrProjectName= other.PrProjectName _
				AndAlso me.PrIsActive.GetValueOrDefault = other.PrIsActive.GetValueOrDefault
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.PrProjectId.GetHashCode _
				Xor me.getStringHashCode(Me.PrProjectName) _
				Xor me.PrIsActive.GetHashCode 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, ProjectBase)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As ProjectBase, ByVal obj2 As ProjectBase) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As ProjectBase, ByVal obj2 As ProjectBase) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a copy
		
		'NOTE: we can't cast from ProjectBase to Project, so below we 
        'instantiate a Project, NOT a ProjectBase object
        Dim ret as Project = ProjectFactory.Create()
            
				ret.PrProjectId = me.PrProjectId
		ret.PrProjectName = me.PrProjectName
		ret.PrIsActive = me.PrIsActive

		
		return ret
		
	End Function
	
	Public Overrides Sub merge(other as IModelObject)
		'merges this Project model object (me) with the "other" instance 
		
		Dim o as Project = CType(other, Project)
		If not String.isNullOrEmpty(o.PrProjectName) AndAlso _
		 String.isNullOrEmpty(me.PrProjectName) Then 
		me.PrProjectName = o.PrProjectName
End If
If not o.PrIsActive is Nothing AndAlso _
		 me.PrIsActive is Nothing Then 
		me.PrIsActive = o.PrIsActive
End If

		
	End Sub

	
	
#End Region



#Region "ID Property"
	
    Public Overrides Property Id() As object 
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
if mo.PrIsActive is Nothing then
		Throw new ModelObjectRequiredFieldException("IsActive")
End if 

			
        End Sub

    End Class
#End Region

End Namespace

