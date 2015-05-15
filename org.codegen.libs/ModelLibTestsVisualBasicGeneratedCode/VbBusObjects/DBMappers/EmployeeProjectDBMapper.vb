﻿'NOTE: DO NOT ADD REFERENCES TO COM.NETU.LIB HERE, INSTEAD ADD
'THE IMPORT ON THE REFERENCES OF THE PROJECT

'<comments>
'Template: DBMapperBase.visualBasic.txt
'************************************************************
' Class autogenerated on 5/14/2015 8:19:20 PM by ModelGenerator
' Extends base DBMapperBase object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class EmployeeProjectDBMapper
'
'************************************************************
'</comments>

Namespace VbBusObjects.DBMappers
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class EmployeeProjectDBMapper
        Inherits DBMapper
		
#Region "Constructors "
        Public Sub New(ByVal _dbConn As DBUtils)
            MyBase.new(_dbConn)
        End Sub
        
        
        Public Sub New()
            MyBase.new()
        End Sub
#End Region

#Region "Overloaded Functions"
		
		Public Shadows Function findWhere(ByVal sWhereClause As String, _
                                          ByVal ParamArray params() As Object)  As EmployeeProject
		
            return DirectCast(MyBase.findWhere(sWhereClause, params), EmployeeProject)
        End Function
        

		Public Sub saveEmployeeProject(ByVal mo As EmployeeProject)
            MyBase.save(mo)
        End Sub
        
        Public Shadows Function findByKey(ByVal keyval As object) As EmployeeProject

            Return DirectCast(MyBase.findByKey(keyval), EmployeeProject)

        End Function
        
#End Region

#Region "getUpdateDBCommand"
        Public Overrides Function getUpdateDBCommand(ByVal modelObj As IModelObject, _
                                                     ByVal sql As String) As IDbCommand

             Dim p As IDataParameter = Nothing
             Dim obj as IEmployeeProject = DirectCast(modelObj,IEmployeeProject)
             Dim stmt As IDbCommand = Me.dbConn.getCommand(sql)
				stmt.Parameters.Add(Me.dbConn.getParameter("@EPEmployeeId",obj.PrEPEmployeeId))
				stmt.Parameters.Add(Me.dbConn.getParameter("@EPProjectId",obj.PrEPProjectId))
				stmt.Parameters.Add(Me.dbConn.getParameter("@AssignDate",obj.PrAssignDate))
				stmt.Parameters.Add(Me.dbConn.getParameter("@EndDate",obj.PrEndDate))
				stmt.Parameters.Add(Me.dbConn.getParameter("@Rate",obj.PrRate))

			if obj.isNew Then
			Else
			'only add primary key if we are updating and as the last parameter
				stmt.Parameters.Add(Me.dbConn.getParameter("@EmployeeProjectId",obj.PrEmployeeProjectId))

			End if '

             return stmt

        End Function

#End Region

	public overrides sub saveParents(mo as IModelObject)

		Dim thisMo as EmployeeProject = directCast(mo, EmployeeProject)
		'*** Parent Association:project
		if (thisMo.PrProject is Nothing=false) AndAlso thisMo.PrProject().NeedsSave() Then
			Dim mappervar as VbBusObjects.DBMappers.ProjectDBMapper= new VbBusObjects.DBMappers.ProjectDBMapper(me.dbConn)
			mappervar.save(thisMo.PrProject)
			thisMo.PrEPProjectId = thisMo.PrProject.PrProjectId
		end if
		
	end sub
#Region "Find functions"		
		
		'''	<summary>Given an sql statement, it opens a result set, and for each record returned, it creates and loads a ModelObject. </summary>
		'''	<param name="sWhereClause">where clause to be applied to "selectall" statement 
		''' that returns one or more records from the database, corresponding to the ModelObject we are going to load </param>
		'''	<param name="params"> Parameter values to be passed to sql statement </param>
		'''	<returns> A List(Of EmployeeProject) object containing all objects loaded </returns>
		'''	 
		Public shadows Function findList(ByVal sWhereClause As String, _
											ByVal ParamArray params() As Object) _
											As List(Of EmployeeProject)

			dim sql as String = Me.getSqlWithWhereClause(sWhereClause)
			Dim rs As IDataReader = Nothing
			Dim molist As New List(Of EmployeeProject)
						
			Try				
				rs = dbConn.getDataReaderWithParams(sql, params)
                Me.Loader.DataSource = rs
               
				Do While rs.Read
					Dim mo As IModelObject = Me.getModelInstance
					Me.Loader.load(mo)
                    molist.Add(DirectCast(mo, EmployeeProject))
					
				Loop

				
			Finally
				Me.dbConn.closeDataReader(rs)
			End Try

			Return molist

		End Function
    
		Public Shadows Function findList(ByVal sWhereClause As String, _
           ByVal params As List(Of IDataParameter)) _
           As List(Of EmployeeProject)

            Dim sql As String = Me.getSqlWithWhereClause(sWhereClause)
            Dim rs As IDataReader = Nothing
            Dim molist As New List(Of EmployeeProject)

            Try
                rs = dbConn.getDataReader(sql, params)
                Me.Loader.DataSource = rs

                Do While rs.Read
                    Dim mo As IModelObject = Me.getModelInstance
                    Me.Loader.load(mo)
                    molist.Add(DirectCast(mo, EmployeeProject))

                Loop


            Finally
                Me.dbConn.closeDataReader(rs)
            End Try

            Return molist

        End Function
		'''    
		'''	 <summary>Returns all records from database for a coresponding ModelObject </summary>
		''' <returns>List(Of EmployeeProject) </returns>
		Public Function findAll() As List(Of EmployeeProject)
			Return Me.findList(String.Empty)
		End Function
		
		public Overrides Property Loader() As IModelObjectLoader
			Get
				if me._loader is Nothing then 
					me._loader = New EmployeeProjectDataReaderLoader
				end If
				return me._loader
            End Get
            Set(value as IModelObjectLoader)
				me._loader = value
            end Set
        End Property

#End Region
		
		Public Overrides Function getModelInstance() As IModelObject
			return EmployeeProjectFactory.Create()
        End Function
		
    End Class

#Region " EmployeeProject Loader "
	<System.Runtime.InteropServices.ComVisible(False)> _
	Public Class EmployeeProjectDataReaderLoader
		Inherits DataReaderLoader

			Public Overrides sub load(ByVal mo As IModelObject)

			Const DATAREADER_FLD_EMPLOYEEPROJECTID as Integer = 0
			Const DATAREADER_FLD_EPEMPLOYEEID as Integer = 1
			Const DATAREADER_FLD_EPPROJECTID as Integer = 2
			Const DATAREADER_FLD_ASSIGNDATE as Integer = 3
			Const DATAREADER_FLD_ENDDATE as Integer = 4
			Const DATAREADER_FLD_RATE as Integer = 5

			
            Dim obj As EmployeeProject = directCast(mo, EmployeeProject)
            obj.IsObjectLoading = True

			if me.reader.IsDBNull(DATAREADER_FLD_EMPLOYEEPROJECTID) = false Then
				obj.PrEmployeeProjectId = me.reader.GetInt32(DATAREADER_FLD_EMPLOYEEPROJECTID)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_EPEMPLOYEEID) = false Then
				obj.PrEPEmployeeId = me.reader.GetInt32(DATAREADER_FLD_EPEMPLOYEEID)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_EPPROJECTID) = false Then
				obj.PrEPProjectId = me.reader.GetInt32(DATAREADER_FLD_EPPROJECTID)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_ASSIGNDATE) = false Then
				obj.PrAssignDate = me.reader.GetDateTime(DATAREADER_FLD_ASSIGNDATE)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_ENDDATE) = false Then
				obj.PrEndDate = me.reader.GetDateTime(DATAREADER_FLD_ENDDATE)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_RATE) = false Then
				obj.PrRate = me.reader.GetDecimal(DATAREADER_FLD_RATE)
			End if

            
            obj.isNew = false ' since we've just loaded from database, we mark as "old"
            obj.isDirty = False
			obj.IsObjectLoading = False
			obj.afterLoad()

            return
            
        End sub
	
	End Class

#End Region
		
	'''<summary>
    ''' Final Class with convinience shared methods for loading/saving the EmployeeRank ModelObject. 
    '''</summary>
	<System.Runtime.InteropServices.ComVisible(False)> _
	Public NotInheritable Class EmployeeProjectDataUtils

#Region "Shared ""get"" Functions "

		Public Shared Function findList(ByVal where As String, ByVal ParamArray params() As Object) _
					As List(Of EmployeeProject)

            dim dbm as EmployeeProjectDBMapper = new EmployeeProjectDBMapper()
            Return dbm.findList(where, params)

        End Function
		
		Public Shared Function findList(ByVal where As String, ByVal params As List(Of IDataParameter)) _
										As List(Of EmployeeProject)

            Dim dbm As EmployeeProjectDBMapper = New EmployeeProjectDBMapper()
            Return dbm.findList(where, params)

        End Function

		Public Shared Function findOne(ByVal where As String, ByVal ParamArray params() As Object) _
					As EmployeeProject

            Dim dbm As EmployeeProjectDBMapper = New EmployeeProjectDBMapper()
            Return DirectCast(dbm.findWhere(where, params), EmployeeProject)

        End Function
        
        
         Public Shared Function findList() As List(Of EmployeeProject)
			
			return new EmployeeProjectDBMapper().findAll()
			
        End Function
        
        Public Shared Function findByKey(id as object) as EmployeeProject
			
			return DirectCast( new EmployeeProjectDBMapper().findByKey(id),EmployeeProject)
                        
        end function
        
		''' <summary>
        ''' Reload the EmployeeProject from the database
        ''' </summary>
        ''' <remarks>
		''' use this method when you want to relad the EmployeeProject 
		''' from the database, discarding any changes
		''' </remarks>
		Public Shared Sub reload(ByRef mo As EmployeeProject)
			
			If mo Is Nothing Then
                Throw New System.ArgumentNullException("null object past to reload function")
            End If
            
			mo = DirectCast(New EmployeeProjectDBMapper().findByKey(mo.Id), EmployeeProject)
            
        End Sub

#End Region

#Region "Shared Save and Delete Functions"
		''' <summary>
        ''' Convinience method to save a EmployeeProject Object.
        ''' Important note: DO NOT CALL THIS IN A LOOP!
        ''' </summary>
        ''' <param name="EmployeeProjectObj"></param>
        ''' <remarks>
		''' Important note: DO NOT CALL THIS IN A LOOP!  
		''' This method simply instantiates a EmployeeProjectDBMapper and calls the save method
		''' </remarks>
		public shared sub saveEmployeeProject(ByVal ParamArray EmployeeProjectObj() As EmployeeProject)
            
            dim dbm as EmployeeProjectDBMapper = new EmployeeProjectDBMapper()
            dbm.saveList(EmployeeProjectObj.ToList)

                       
       end sub
       

       public shared sub deleteEmployeeProject(ByVal EmployeeProjectObj As EmployeeProject)
            
            dim dbm as EmployeeProjectDBMapper = new EmployeeProjectDBMapper()
            dbm.delete(EmployeeProjectObj)
            
        end sub
#End Region

#Region "Data Table and data row load/save "        
        Public Shared Sub saveEmployeeProject(ByVal dr As DataRow, _
                                                 Optional ByRef mo As EmployeeProject = Nothing)

            if mo is Nothing then 
				mo = EmployeeProjectFactory.Create()
			end if
			
            For Each dc As DataColumn In dr.Table.Columns
                mo.setAttribute(dc.ColumnName, dr.Item(dc.ColumnName))
            Next

            call saveEmployeeProject(mo)

        End Sub
        
         
        Public Shared Sub saveEmployeeProject(ByVal dt As DataTable, _
                                                 Optional ByRef mo As EmployeeProject = Nothing)

            For Each dr As DataRow In dt.Rows
            	call saveEmployeeProject(dr,mo)
            Next
			
        End Sub
        
		 Public Shared Function loadFromDataRow(ByVal r As DataRow) As EmployeeProject

            Dim a As New DataRowLoader
            Dim mo As IModelObject = EmployeeProjectFactory.Create
            a.DataSource = r
            a.load(mo)
            Return DirectCast(mo, EmployeeProject)

        End Function

#End Region

    End Class
	
End Namespace

