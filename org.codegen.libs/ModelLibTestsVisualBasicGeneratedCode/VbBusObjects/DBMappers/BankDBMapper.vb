﻿'NOTE: DO NOT ADD REFERENCES TO COM.NETU.LIB HERE, INSTEAD ADD
'THE IMPORT ON THE REFERENCES OF THE PROJECT

Imports System.Data.Linq.Mapping

'<comments>
'Template: DBMapperBase.visualBasic.txt
'************************************************************
' Class autogenerated on 11/07/2015 12:50:33 PM by ModelGenerator
' Extends base DBMapperBase object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class BankDBMapper
'
'************************************************************
'</comments>
''
Namespace VbBusObjects.DBMappers
	<System.Runtime.InteropServices.ComVisible(False)>
	<Table(Name := "Bank")> _
	<SelectObject("Bank")><KeyFieldName("BANKID")> _
    public Class BankDBMapper
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
                                        ByVal ParamArray params() As Object)  As Bank
		
        return DirectCast(MyBase.findWhere(sWhereClause, params), Bank)
    End Function
        

	Public Sub saveBank(ByVal mo As Bank)
        MyBase.save(mo)
    End Sub
        
    Public Shadows Function findByKey(ByVal keyval As object) As Bank

        Return DirectCast(MyBase.findByKey(keyval), Bank)

    End Function
        
#End Region

#Region "getUpdateDBCommand"
        Public Overrides Function getUpdateDBCommand(ByVal modelObj As IModelObject, ByVal sql As String) As IDbCommand

             Dim p As IDataParameter = Nothing
             Dim obj as Bank = DirectCast(modelObj,Bank)
             Dim stmt As IDbCommand = Me.dbConn.getCommand(sql)
			stmt.Parameters.Add(Me.dbConn.getParameter(Bank.STR_FLD_BANKNAME,obj.PrBankName))
			stmt.Parameters.Add(Me.dbConn.getParameter(Bank.STR_FLD_BANKCODE,obj.PrBankCode))
			stmt.Parameters.Add(Me.dbConn.getParameter(Bank.STR_FLD_BANKSWIFTCODE,obj.PrBankSWIFTCode))

			If (obj.isNew) Then
			Else
			'only add primary key if we are updating and as the last parameter
				stmt.Parameters.Add(Me.dbConn.getParameter(Bank.STR_FLD_BANKID,obj.PrBANKID))
			End if

             return stmt

        End Function

#End Region

#Region "Find functions"

	'''	<summary>Given an sql statement, it opens a result set, and for each record returned, it creates and loads a ModelObject. </summary>
	'''	<param name="sWhereClause">where clause to be applied to "selectall" statement 
	''' that returns one or more records from the database, corresponding to the ModelObject we are going to load </param>
	'''	<param name="params"> Parameter values to be passed to sql statement </param>
	'''	<returns> A List(Of Bank) object containing all objects loaded </returns>
	'''	 
	Public shadows Function findList(ByVal sWhereClause As String, _
										ByVal ParamArray params() As Object) _
										As List(Of Bank)

		dim sql as String = Me.getSqlWithWhereClause(sWhereClause)
		Dim rs As IDataReader = Nothing
		Dim molist As New List(Of Bank)
						
		Try				
			rs = dbConn.getDataReaderWithParams(sql, params)
            Me.Loader.DataSource = rs
               
			Do While rs.Read
				Dim mo As IModelObject = Me.getModelInstance
				Me.Loader.load(mo)
                molist.Add(DirectCast(mo, Bank))
					
			Loop

				
		Finally
			Me.dbConn.closeDataReader(rs)
		End Try

		Return molist

	End Function
    
	Public Shadows Function findList(ByVal sWhereClause As String, _
        ByVal params As List(Of IDataParameter)) _
        As List(Of Bank)

        Dim sql As String = Me.getSqlWithWhereClause(sWhereClause)
        Dim rs As IDataReader = Nothing
        Dim molist As New List(Of Bank)

        Try
            rs = dbConn.getDataReader(sql, params)
            Me.Loader.DataSource = rs

            Do While rs.Read
                Dim mo As IModelObject = Me.getModelInstance
                Me.Loader.load(mo)
                molist.Add(DirectCast(mo, Bank))

            Loop


        Finally
            Me.dbConn.closeDataReader(rs)
        End Try

        Return molist

    End Function

	'''    
	'''	 <summary>Returns all records from database for a coresponding ModelObject </summary>
	''' <returns>List(Of Bank) </returns>
	Public Function findAll() As List(Of Bank)
		Return Me.findList(String.Empty)
	End Function
		
	public Overrides Property Loader() As IModelObjectLoader
		Get
			if me._loader is Nothing then 
				me._loader = New BankDataReaderLoader
			end If
			return me._loader
        End Get
        Set(value as IModelObjectLoader)
			me._loader = value
        end Set
    End Property

#End Region
		
	Public Overrides Function getModelInstance() As IModelObject
		return new Bank()
    End Function
		
End Class

#Region " Bank Loader "
	<System.Runtime.InteropServices.ComVisible(False)> _
	Public Class BankDataReaderLoader
		Inherits DataReaderLoader

			Public Overrides sub load(ByVal mo As IModelObject)

			Const DATAREADER_FLD_BANKID as Integer = 0
			Const DATAREADER_FLD_BANKNAME as Integer = 1
			Const DATAREADER_FLD_BANKCODE as Integer = 2
			Const DATAREADER_FLD_BANKSWIFTCODE as Integer = 3

			
            Dim obj As Bank = directCast(mo, Bank)
            obj.IsObjectLoading = True

			if me.reader.IsDBNull(DATAREADER_FLD_BANKID) = false Then
				obj.PrBANKID = Convert.ToInt64(me.reader.GetInt32(DATAREADER_FLD_BANKID))
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_BANKNAME) = false Then
				obj.PrBankName = me.reader.GetString(DATAREADER_FLD_BANKNAME)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_BANKCODE) = false Then
				obj.PrBankCode = me.reader.GetString(DATAREADER_FLD_BANKCODE)
			End if
			if me.reader.IsDBNull(DATAREADER_FLD_BANKSWIFTCODE) = false Then
				obj.PrBankSWIFTCode = me.reader.GetString(DATAREADER_FLD_BANKSWIFTCODE)
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
	Public NotInheritable Class BankDataUtils

#Region "Shared ""get"" Functions "

		Public Shared Function findList(ByVal where As String, ByVal ParamArray params() As Object) _
					As List(Of Bank)

            dim dbm as BankDBMapper = new BankDBMapper()
            Return dbm.findList(where, params)

        End Function
		
		Public Shared Function findList(ByVal where As String, ByVal params As List(Of IDataParameter)) _
										As List(Of Bank)

            Dim dbm As BankDBMapper = New BankDBMapper()
            Return dbm.findList(where, params)

        End Function

		Public Shared Function findOne(ByVal where As String, ByVal ParamArray params() As Object) _
					As Bank

            Dim dbm As BankDBMapper = New BankDBMapper()
            Return DirectCast(dbm.findWhere(where, params), Bank)

        End Function
        
        
         Public Shared Function findList() As List(Of Bank)
			
			return new BankDBMapper().findAll()
			
        End Function
        
        Public Shared Function findByKey(id as object) as Bank
			
			return DirectCast( new BankDBMapper().findByKey(id),Bank)
                        
        end function
        
		''' <summary>
        ''' Reload the Bank from the database
        ''' </summary>
        ''' <remarks>
		''' use this method when you want to relad the Bank 
		''' from the database, discarding any changes
		''' </remarks>
		Public Shared Sub reload(ByRef mo As Bank)
			
			If mo Is Nothing Then
                Throw New System.ArgumentNullException("null object past to reload function")
            End If
            
			mo = DirectCast(New BankDBMapper().findByKey(mo.Id), Bank)
            
        End Sub

#End Region

#Region "Shared Save and Delete Functions"
		''' <summary>
        ''' Convinience method to save a Bank Object.
        ''' Important note: DO NOT CALL THIS IN A LOOP!
        ''' </summary>
        ''' <param name="BankObj"></param>
        ''' <remarks>
		''' Important note: DO NOT CALL THIS IN A LOOP!  
		''' This method simply instantiates a BankDBMapper and calls the save method
		''' </remarks>
		public shared sub saveBank(ByVal ParamArray BankObj() As Bank)
            
            dim dbm as BankDBMapper = new BankDBMapper()
            dbm.saveList(BankObj.ToList)

                       
       end sub
       

       public shared sub deleteBank(ByVal BankObj As Bank)
            
            dim dbm as BankDBMapper = new BankDBMapper()
            dbm.delete(BankObj)
            
        end sub
#End Region

#Region "Data Table and data row load/save "        
        Public Shared Sub saveBank(ByVal dr As DataRow, _
                                                 Optional ByRef mo As Bank = Nothing)

            if mo is Nothing then 
				mo = new Bank()
			end if
			
            For Each dc As DataColumn In dr.Table.Columns
                mo.setAttribute(dc.ColumnName, dr.Item(dc.ColumnName))
            Next

            call saveBank(mo)

        End Sub
        
         
        Public Shared Sub saveBank(ByVal dt As DataTable, _
                                                 Optional ByRef mo As Bank = Nothing)

            For Each dr As DataRow In dt.Rows
            	call saveBank(dr,mo)
            Next
			
        End Sub
        
		 Public Shared Function loadFromDataRow(ByVal r As DataRow) As Bank

            Dim a As New DataRowLoader
            Dim mo As IModelObject = new Bank()
            a.DataSource = r
            a.load(mo)
            Return DirectCast(mo, Bank)

        End Function

#End Region

    End Class
	
End Namespace

