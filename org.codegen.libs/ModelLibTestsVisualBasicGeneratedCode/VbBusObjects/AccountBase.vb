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
' Class autogenerated on 06-Sep-15 11:44:06 AM by ModelGenerator
' Extends base model object class
' *** DO NOT change code in this class.  
'     It will be re-generated and 
'     overwritten by the code generator ****
' Instead, change code in the extender class Account
'
'************************************************************
'</comments>
Namespace VbBusObjects
<Table(Name := "Account")><SelectObject("Account")><KeyFieldName("accountid")> _
<DefaultMapperAttr(GetType(AccountDBMapper)), DataContract, _
ComVisible(False),Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)> _
partial class Account
		Inherits ModelObject
		Implements IEquatable(Of Account),IAuditable 

#Region "Constructor"
    
    Friend sub New()
		Me.addValidator(New AccountRequiredFieldsValidator)
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
			if me._BankAccountInfo isNot Nothing Then
				AddHandler me.IDChanged, AddressOf me._BankAccountInfo.handleParentIdChanged
			End If

		me.IsObjectLoading = false
		me.isDirty = true
    End Sub

	Public Overrides sub loadObjectHierarchy()
				LoadPrBankAccountInfo()

	End Sub

	Public Overrides Function getChildren() As List(Of ModelObject) 
		Dim ret as New List(Of ModelObject)()
			if  Me._BankAccountInfo isNot Nothing then
		ret.Add(me.PrBankAccountInfo)
	End If

		return ret
	End Function
	
	Public Overrides Function getParents() As List(Of ModelObject)
		Dim ret as New List(Of ModelObject)()
		
		return ret
	End Function

#End Region
#Region "Field CONSTANTS"

			public Const STR_FLD_ACCOUNTID as String = "Accountid"
			public Const STR_FLD_ACCOUNT as String = "Account"
			public Const STR_FLD_ACCOUNTTYPEID as String = "AccountTypeid"
			public Const STR_FLD_BANKACCNUMBER as String = "Bankaccnumber"
			public Const STR_FLD_NEXTCHECKNUMBER as String = "NextCheckNumber"
			public Const STR_FLD_DESCRIPTION as String = "Description"
			public Const STR_FLD_CREATEDATE as String = "Createdate"
			public Const STR_FLD_UPDATEDATE as String = "Updatedate"
			public Const STR_FLD_UPDATEUSER as String = "Updateuser"
			public Const STR_FLD_CREATEUSER as String = "Createuser"


		public Const FLD_ACCOUNTID as Integer = 0
		public Const FLD_ACCOUNT as Integer = 1
		public Const FLD_ACCOUNTTYPEID as Integer = 2
		public Const FLD_BANKACCNUMBER as Integer = 3
		public Const FLD_NEXTCHECKNUMBER as Integer = 4
		public Const FLD_DESCRIPTION as Integer = 5
		public Const FLD_CREATEDATE as Integer = 6
		public Const FLD_UPDATEDATE as Integer = 7
		public Const FLD_UPDATEUSER as Integer = 8
		public Const FLD_CREATEUSER as Integer = 9



        '''<summary>Returns the names of fields in the object as a string array.
        ''' Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
        ''' <returns> string array </returns>	 
        Public Overrides Function getFieldList() As String()
            Return New String() {STR_FLD_ACCOUNTID,STR_FLD_ACCOUNT,STR_FLD_ACCOUNTTYPEID,STR_FLD_BANKACCNUMBER,STR_FLD_NEXTCHECKNUMBER,STR_FLD_DESCRIPTION,STR_FLD_CREATEDATE,STR_FLD_UPDATEDATE,STR_FLD_UPDATEUSER,STR_FLD_CREATEUSER}
        End Function
        
#END Region

#Region "Field Declarations"


	Private _Accountid as System.Int64
	Private _Account as System.String
	Private _AccountTypeid as System.Int64? = Nothing
	Private _Bankaccnumber as System.String
	Private _NextCheckNumber as System.String
	Private _Description as System.String
	Private _Createdate as System.DateTime? = Nothing
	Private _Updatedate as System.DateTime? = Nothing
	Private _Updateuser as System.String
	Private _Createuser as System.String

	' *****************************************
	' ****** CHILD OBJECTS ********************
	<DataMember(Name:="PrBankAccountInfo")>
	private _BankAccountInfo as VbBusObjects.AccountBankInfo = nothing '' initialize to nothing, for lazy load logic below !!!

	' *****************************************
	' ****** END CHILD OBJECTS ********************


#end Region

#Region "Field Properties"

	<Column(Name:="accountid",Storage:="_Accountid", IsPrimaryKey:=True,DbType:="int NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property PrAccountid as System.Int64
	Get 
		return _Accountid
	End Get 
	Set(ByVal value As System.Int64)
		if ModelObject.valueChanged(_Accountid, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ACCOUNTID)
			End If
			me._Accountid = value

			me.raiseBroadcastIdChange()

		End if
	End Set 
	End Property 
	<Column(Name:="account",Storage:="_Account", IsPrimaryKey:=False,DbType:="nvarchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrAccount as System.String
	Get 
		return _Account
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_Account, value) then
		if value isNot Nothing andAlso value.Length > 50 Then
			Throw new ModelObjectFieldTooLongException("account")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ACCOUNT)
			End If
			me._Account = value

		End if
	End Set 
	End Property 
	<Column(Name:="accountTypeid",Storage:="_AccountTypeid", IsPrimaryKey:=False,DbType:="int",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrAccountTypeid as System.Int64?
	Get 
		return _AccountTypeid
	End Get 
	Set(ByVal value As System.Int64?)
		if ModelObject.valueChanged(_AccountTypeid, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_ACCOUNTTYPEID)
			End If
			me._AccountTypeid = value

		End if
	End Set 
	End Property 
	<Column(Name:="bankaccnumber",Storage:="_Bankaccnumber", IsPrimaryKey:=False,DbType:="nvarchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrBankaccnumber as System.String
	Get 
		return _Bankaccnumber
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_Bankaccnumber, value) then
		if value isNot Nothing andAlso value.Length > 100 Then
			Throw new ModelObjectFieldTooLongException("bankaccnumber")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_BANKACCNUMBER)
			End If
			me._Bankaccnumber = value

		End if
	End Set 
	End Property 
	<Column(Name:="nextCheckNumber",Storage:="_NextCheckNumber", IsPrimaryKey:=False,DbType:="nvarchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrNextCheckNumber as System.String
	Get 
		return _NextCheckNumber
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_NextCheckNumber, value) then
		if value isNot Nothing andAlso value.Length > 50 Then
			Throw new ModelObjectFieldTooLongException("nextCheckNumber")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_NEXTCHECKNUMBER)
			End If
			me._NextCheckNumber = value

		End if
	End Set 
	End Property 
	<Column(Name:="Description",Storage:="_Description", IsPrimaryKey:=False,DbType:="nvarchar",CanBeNull:=True )> _
<DataMember>	 Overridable Property PrDescription as System.String
	Get 
		return _Description
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_Description, value) then
		if value isNot Nothing andAlso value.Length > 255 Then
			Throw new ModelObjectFieldTooLongException("Description")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_DESCRIPTION)
			End If
			me._Description = value

		End if
	End Set 
	End Property 
	<Column(Name:="createdate",Storage:="_Createdate", IsPrimaryKey:=False,DbType:="datetime NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property Createdate as System.DateTime? _ 
		Implements IAuditable.CreateDate
	Get 
		return _Createdate
	End Get 
	Set(ByVal value As System.DateTime?)
		if ModelObject.valueChanged(_Createdate, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_CREATEDATE)
			End If
			me._Createdate = value

		End if
	End Set 
	End Property 
	<Column(Name:="updatedate",Storage:="_Updatedate", IsPrimaryKey:=False,DbType:="datetime NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property Updatedate as System.DateTime? _ 
		Implements IAuditable.UpdateDate
	Get 
		return _Updatedate
	End Get 
	Set(ByVal value As System.DateTime?)
		if ModelObject.valueChanged(_Updatedate, value) then
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_UPDATEDATE)
			End If
			me._Updatedate = value

		End if
	End Set 
	End Property 
	<Column(Name:="updateuser",Storage:="_Updateuser", IsPrimaryKey:=False,DbType:="varchar NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property Updateuser as System.String _ 
		Implements IAuditable.UpdateUser
	Get 
		return _Updateuser
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_Updateuser, value) then
		if value isNot Nothing andAlso value.Length > 10 Then
			Throw new ModelObjectFieldTooLongException("updateuser")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_UPDATEUSER)
			End If
			me._Updateuser = value

		End if
	End Set 
	End Property 
	<Column(Name:="createuser",Storage:="_Createuser", IsPrimaryKey:=False,DbType:="varchar NOT NULL",CanBeNull:=False )> _
<DataMember>	 Overridable Property Createuser as System.String _ 
		Implements IAuditable.CreateUser
	Get 
		return _Createuser
	End Get 
	Set(ByVal value As System.String)
		if ModelObject.valueChanged(_Createuser, value) then
		if value isNot Nothing andAlso value.Length > 10 Then
			Throw new ModelObjectFieldTooLongException("createuser")
		End If
			if me.IsObjectLoading = false then
				me.isDirty = true
				me.setFieldChanged(STR_FLD_CREATEUSER)
			End If
			me._Createuser = value

		End if
	End Set 
	End Property 
		#end region
		#region "Associations"
        
		'associationChildOne.txt

		<DataMember>
        friend BankAccountInfoLoaded as Boolean
		
		Public Overridable Property PrBankAccountInfo() As VbBusObjects.AccountBankInfo 

			'1-1 child association
            Set(ByVal value As VbBusObjects.AccountBankInfo)
                Me._BankAccountInfo = value
				If  Me._BankAccountInfo isnot Nothing then
					Me._BankAccountInfo.PrAccountID = me.PrAccountid
					AddHandler Me.IDChanged, AddressOf value.handleParentIdChanged
				
				End If     
            End Set


            Get
			    'LAZY LOADING! Only hit the database to get the child object if we need it
                If not  Me.BankAccountInfoLoaded Then
					Call Me.LoadPrBankAccountInfo
                End If 
								
                Return Me._BankAccountInfo
                
            End Get
        End Property
        
        ''' <summary>
        ''' Loads child object from dabatabase, if not loaded already
        ''' </summary>
        private Sub LoadPrBankAccountInfo
						
			If Me.BankAccountInfoLoaded then return

			If Me._BankAccountInfo Is Nothing Then

				'IMPORTANT:call setter here, not the private variable
				Me.PrBankAccountInfo = _ 
					new VbBusObjects.DBMappers.AccountBankInfoDBMapper().findWhere("accountid=?", Me.PrAccountid)
				
				
			End If 

			'set the loaded flag here
			me.BankAccountInfoLoaded = true
            
        End Sub

		


#End Region

#Region "Getters/Setters of values by field index / name"
    Public Overloads Overrides Function getAttribute(ByVal fieldKey As Integer) As Object
		

		select case fieldKey
		case FLD_ACCOUNTID
			return me.PrAccountid
		case FLD_ACCOUNT
			return me.PrAccount
		case FLD_ACCOUNTTYPEID
			return me.PrAccountTypeid
		case FLD_BANKACCNUMBER
			return me.PrBankaccnumber
		case FLD_NEXTCHECKNUMBER
			return me.PrNextCheckNumber
		case FLD_DESCRIPTION
			return me.PrDescription
		case FLD_CREATEDATE
			return me.CreateDate
		case FLD_UPDATEDATE
			return me.UpdateDate
		case FLD_UPDATEUSER
			return me.UpdateUser
		case FLD_CREATEUSER
			return me.CreateUser
		case else
			return nothing
		end select


    End Function

    Public Overloads Overrides Function getAttribute(ByVal fieldKey As String) As Object
		fieldKey = fieldKey.ToLower

		if fieldKey=STR_FLD_ACCOUNTID.ToLower() Then
			return me.PrAccountid
		else if fieldKey=STR_FLD_ACCOUNT.ToLower() Then
			return me.PrAccount
		else if fieldKey=STR_FLD_ACCOUNTTYPEID.ToLower() Then
			return me.PrAccountTypeid
		else if fieldKey=STR_FLD_BANKACCNUMBER.ToLower() Then
			return me.PrBankaccnumber
		else if fieldKey=STR_FLD_NEXTCHECKNUMBER.ToLower() Then
			return me.PrNextCheckNumber
		else if fieldKey=STR_FLD_DESCRIPTION.ToLower() Then
			return me.PrDescription
		else if fieldKey=STR_FLD_CREATEDATE.ToLower() Then
			return me.CreateDate
		else if fieldKey=STR_FLD_UPDATEDATE.ToLower() Then
			return me.UpdateDate
		else if fieldKey=STR_FLD_UPDATEUSER.ToLower() Then
			return me.UpdateUser
		else if fieldKey=STR_FLD_CREATEUSER.ToLower() Then
			return me.CreateUser
		else
			return nothing
		end If
    End Function

    Public Overloads Overrides Sub setAttribute(ByVal fieldKey As Integer, ByVal val As Object)
		Try
		Select Case fieldKey
		case FLD_ACCOUNTID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAccountid = Nothing
			Else
				Me.PrAccountid=CType(val,System.Int64)
			End If
			return
		case FLD_ACCOUNT
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAccount = Nothing
			Else
				Me.PrAccount=CType(val,System.String)
			End If
			return
		case FLD_ACCOUNTTYPEID
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAccountTypeid = Nothing
			Else
				Me.PrAccountTypeid=CType(val,System.Int64?)
			End If
			return
		case FLD_BANKACCNUMBER
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankaccnumber = Nothing
			Else
				Me.PrBankaccnumber=CType(val,System.String)
			End If
			return
		case FLD_NEXTCHECKNUMBER
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrNextCheckNumber = Nothing
			Else
				Me.PrNextCheckNumber=CType(val,System.String)
			End If
			return
		case FLD_DESCRIPTION
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrDescription = Nothing
			Else
				Me.PrDescription=CType(val,System.String)
			End If
			return
		case FLD_CREATEDATE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.CreateDate = Nothing
			Else
				Me.CreateDate=CType(val,System.DateTime?)
			End If
			return
		case FLD_UPDATEDATE
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.UpdateDate = Nothing
			Else
				Me.UpdateDate=CType(val,System.DateTime?)
			End If
			return
		case FLD_UPDATEUSER
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.UpdateUser = Nothing
			Else
				Me.UpdateUser=CType(val,System.String)
			End If
			return
		case FLD_CREATEUSER
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.CreateUser = Nothing
			Else
				Me.CreateUser=CType(val,System.String)
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
		if  fieldKey=STR_FLD_ACCOUNTID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAccountid = Nothing
			Else
				Me.PrAccountid=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_ACCOUNT.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAccount = Nothing
			Else
				Me.PrAccount=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_ACCOUNTTYPEID.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrAccountTypeid = Nothing
			Else
				Me.PrAccountTypeid=Convert.ToInt64(val)
			End If
			return
		else if  fieldKey=STR_FLD_BANKACCNUMBER.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrBankaccnumber = Nothing
			Else
				Me.PrBankaccnumber=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_NEXTCHECKNUMBER.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrNextCheckNumber = Nothing
			Else
				Me.PrNextCheckNumber=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_DESCRIPTION.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.PrDescription = Nothing
			Else
				Me.PrDescription=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_CREATEDATE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.CreateDate = Nothing
			Else
				Me.CreateDate=Convert.ToDateTime(val)
			End If
			return
		else if  fieldKey=STR_FLD_UPDATEDATE.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.UpdateDate = Nothing
			Else
				Me.UpdateDate=Convert.ToDateTime(val)
			End If
			return
		else if  fieldKey=STR_FLD_UPDATEUSER.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.UpdateUser = Nothing
			Else
				Me.UpdateUser=Convert.ToString(val)
			End If
			return
		else if  fieldKey=STR_FLD_CREATEUSER.ToLower() Then
			If Val Is DBNull.Value OrElse Val Is Nothing Then
				Me.CreateUser = Nothing
			Else
				Me.CreateUser=Convert.ToString(val)
			End If
			return
		end If
		Catch ex As Exception
			Throw New ApplicationException(String.Format("Error setting field with index {0}, value ""{1}"" : {2}", fieldKey, val, ex.Message))
		End Try

    End Sub

#End Region
#Region "Overrides of GetHashCode, Equals "
	Public Overloads Function Equals(ByVal other As Account) As Boolean _     
		Implements System.IEquatable(Of Account).Equals       
		
			'typesafe equals, checks for equality of fields
			If other Is Nothing Then Return False       
			If other Is Me Then Return True
		
			Return me.PrAccountid= other.PrAccountid _
				AndAlso me.PrAccount= other.PrAccount _
				AndAlso me.PrAccountTypeid.GetValueOrDefault = other.PrAccountTypeid.GetValueOrDefault _
				AndAlso me.PrBankaccnumber= other.PrBankaccnumber _
				AndAlso me.PrNextCheckNumber= other.PrNextCheckNumber _
				AndAlso me.PrDescription= other.PrDescription _
				AndAlso me.CreateDate.GetValueOrDefault = other.CreateDate.GetValueOrDefault _
				AndAlso me.UpdateDate.GetValueOrDefault = other.UpdateDate.GetValueOrDefault _
				AndAlso me.UpdateUser= other.UpdateUser _
				AndAlso me.CreateUser= other.CreateUser
				
	End Function
	
	Public Overrides Function GetHashCode() As Integer
        'using Xor has the advantage of not overflowing the integer.
        Return me.PrAccountid.GetHashCode _
				Xor me.getStringHashCode(Me.PrAccount) _
				Xor me.PrAccountTypeid.GetHashCode _
				Xor me.getStringHashCode(Me.PrBankaccnumber) _
				Xor me.getStringHashCode(Me.PrNextCheckNumber) _
				Xor me.getStringHashCode(Me.PrDescription) _
				Xor me.CreateDate.GetHashCode _
				Xor me.UpdateDate.GetHashCode _
				Xor me.getStringHashCode(Me.UpdateUser) _
				Xor me.getStringHashCode(Me.CreateUser) 
    
    End Function
    
    Public Overloads Overrides Function Equals(ByVal Obj As Object) As Boolean
		
		Dim temp = TryCast(obj, Account)       
		If temp IsNot Nothing Then 
			Return Me.Equals(temp)
		Else
			Return False
		End If

    End Function
	
	Public Shared Operator =(ByVal obj1 As Account, ByVal obj2 As Account) As Boolean       
		Return Object.Equals(obj1 ,obj2)    
	End Operator    
	
	Public Shared Operator <>(ByVal obj1 As Account, ByVal obj2 As Account) As Boolean       
		Return Not (obj1 = obj2)    
	End Operator

#End Region

#Region "Copy and sort"

	Public Overrides Function copy() as IModelObject
		'creates a shallow copy
        Dim ret as Account =  new Account()
		ret.PrAccountid = me.PrAccountid
		ret.PrAccount = me.PrAccount
		ret.PrAccountTypeid = me.PrAccountTypeid
		ret.PrBankaccnumber = me.PrBankaccnumber
		ret.PrNextCheckNumber = me.PrNextCheckNumber
		ret.PrDescription = me.PrDescription
		ret.CreateDate = me.CreateDate
		ret.UpdateDate = me.UpdateDate
		ret.UpdateUser = me.UpdateUser
		ret.CreateUser = me.CreateUser
		
		return ret
		
	End Function
	
#End Region



#Region "ID Property"
	
    <DataMember>Public NotOverridable Overrides Property Id() As object
        Get
            return me._Accountid
        End Get
        Set(ByVal value As object)
             me._Accountid = Clng(value)
             me.raiseBroadcastIdChange()
        End Set
    End Property
#End Region
	
#Region "Extra Code"
	
#End Region
	
	End Class

#Region "Req Fields validator"
	<System.Runtime.InteropServices.ComVisible(False)> _
    Public Class AccountRequiredFieldsValidator
        Implements IModelObjectValidator

        Public Sub validate(ByVal imo As org.model.lib.Model.IModelObject) _
                    Implements org.model.lib.IModelObjectValidator.validate

            Dim mo As Account = CType(imo, Account)
			if mo.CreateDate is Nothing then
		Throw new ModelObjectRequiredFieldException("Createdate")
End if 
if mo.UpdateDate is Nothing then
		Throw new ModelObjectRequiredFieldException("Updatedate")
End if 
if String.isNullOrEmpty( mo.UpdateUser) Then
		Throw new ModelObjectRequiredFieldException("Updateuser")
End if 
if String.isNullOrEmpty( mo.CreateUser) Then
		Throw new ModelObjectRequiredFieldException("Createuser")
End if 

			
        End Sub

    End Class
#End Region

End Namespace

