﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;
using org.model.lib.Model;
using org.model.lib;

using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

//<comments>
//************************************************************
// Template: ModelBase2.csharp.txt
// Class autogenerated on 09/06/2013 8:02:57 AM by ModelGenerator
// Extends base model object class
// *** DO NOT change code in this class.  
//     It will be re-generated and 
//     overwritten by the code generator ****
// Instead, change code in the extender class Account
//
//************************************************************
//</comments>
namespace CsModelObjects {

	[Table(Name = "Account")]
	[DataContract][SelectObject("Account")][KeyFieldName("accountid")]
	[DefaultMapperAttr(typeof(CsModelMappers.AccountDBMapper)), ComVisible(false), Serializable(), System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	partial class Account:ModelObject,IEquatable<Account> ,IAuditable {

		#region "Constructor"

		public Account() {
			this.Id = ModelObjectKeyGen.nextId();
			this.addValidator(new AccountRequiredFieldsValidator());
		}

		#endregion

		#region "Children and Parents"
		
		public override void loadObjectHierarchy() {
		LoadPrBankAccountInfo();

		}

		/// <summary>
		/// Returns the **loaded** children of this model object.
		/// Any records that are not loaded (ie the getter method was not called) are not returned.
		/// To get all child records tied to this object, call loadObjectHierarchy() method
		/// </summary>
		public override List<ModelObject> getChildren() {
			List<ModelObject> ret = new List<ModelObject>();
				if  (this._BankAccountInfo!=null) {
		ret.Add(this.PrBankAccountInfo);
	}

			return ret;
		}

		/// <summary>
		/// Returns the **loaded** parent objects of this model object.
		/// Any records are not loaded (ie the getter method was not called) are not returned.
		/// To get all parent records tied to this object, call loadObjectHierarchy() method
		/// </summary>
		public override List<ModelObject> getParents() {
			List<ModelObject> ret = new List<ModelObject>();
			
			return ret;
		}

		#endregion
		#region "Field CONSTANTS"

					public const String STR_FLD_ACCOUNTID = "Accountid";
			public const String STR_FLD_ACCOUNT = "Account";
			public const String STR_FLD_ACCOUNTTYPEID = "AccountTypeid";
			public const String STR_FLD_BANKACCNUMBER = "Bankaccnumber";
			public const String STR_FLD_NEXTCHECKNUMBER = "NextCheckNumber";
			public const String STR_FLD_DESCRIPTION = "Description";
			public const String STR_FLD_CREATEDATE = "Createdate";
			public const String STR_FLD_UPDATEDATE = "Updatedate";
			public const String STR_FLD_UPDATEUSER = "Updateuser";
			public const String STR_FLD_CREATEUSER = "Createuser";


				public const int FLD_ACCOUNTID = 0;
		public const int FLD_ACCOUNT = 1;
		public const int FLD_ACCOUNTTYPEID = 2;
		public const int FLD_BANKACCNUMBER = 3;
		public const int FLD_NEXTCHECKNUMBER = 4;
		public const int FLD_DESCRIPTION = 5;
		public const int FLD_CREATEDATE = 6;
		public const int FLD_UPDATEDATE = 7;
		public const int FLD_UPDATEUSER = 8;
		public const int FLD_CREATEUSER = 9;



		///<summary> Returns the names of fields in the object as a string array.
		/// Useful in automatically setting/getting values from UI objects (windows or web Form)</summary>
		/// <returns> string array </returns>	 
		public override string[] getFieldList()
		{
			return new string[] {
				STR_FLD_ACCOUNTID,STR_FLD_ACCOUNT,STR_FLD_ACCOUNTTYPEID,STR_FLD_BANKACCNUMBER,STR_FLD_NEXTCHECKNUMBER,STR_FLD_DESCRIPTION,STR_FLD_CREATEDATE,STR_FLD_UPDATEDATE,STR_FLD_UPDATEUSER,STR_FLD_CREATEUSER
			};
		}

		#endregion

		#region "Field Declarations"

	private System.Int64 _Accountid;
	private System.String _Account;
	private System.Int64? _AccountTypeid = null;
	private System.String _Bankaccnumber;
	private System.String _NextCheckNumber;
	private System.String _Description;
	private System.DateTime? _Createdate = null;
	private System.DateTime? _Updatedate = null;
	private System.String _Updateuser;
	private System.String _Createuser;
	// ****** CHILD OBJECTS ********************
	private CsModelObjects.AccountBankInfo _BankAccountInfo = null;  //initialize to nothing, for lazy load logic below !!!

	// *****************************************
	// ****** END CHILD OBJECTS ********************

		#endregion

		#region "Field Properties"

		//Field accountid
	[Required][Column(Name="accountid",Storage = "_Accountid", IsPrimaryKey=true,DbType = "int NOT NULL",CanBeNull = false)]
	[DataMember]public virtual System.Int64 PrAccountid{
	get{
		return _Accountid;
	}
	set {
		if (ModelObject.valueChanged(_Accountid, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_ACCOUNTID);
			}
		this._Accountid = value;

			this.raiseBroadcastIdChange();

		}
		}
	}
		//Field account
	[Key][StringLength(50, ErrorMessage="account must be 50 characters or less")][Column(Name="account",Storage = "_Account", IsPrimaryKey=false,DbType = "nvarchar",CanBeNull = true)]
	[DataMember]public virtual System.String PrAccount{
	get{
		return _Account;
	}
	set {
		if (ModelObject.valueChanged(_Account, value)){
		if (value != null && value.Length > 50){
			throw new ModelObjectFieldTooLongException("account");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_ACCOUNT);
			}
		this._Account = value;

		}
		}
	}
		//Field accountTypeid
	[Key][Column(Name="accountTypeid",Storage = "_AccountTypeid", IsPrimaryKey=false,DbType = "int",CanBeNull = true)]
	[DataMember]public virtual System.Int64? PrAccountTypeid{
	get{
		return _AccountTypeid;
	}
	set {
		if (ModelObject.valueChanged(_AccountTypeid, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_ACCOUNTTYPEID);
			}
		this._AccountTypeid = value;

		}
		}
	}
		//Field bankaccnumber
	[Key][StringLength(100, ErrorMessage="bankaccnumber must be 100 characters or less")][Column(Name="bankaccnumber",Storage = "_Bankaccnumber", IsPrimaryKey=false,DbType = "nvarchar",CanBeNull = true)]
	[DataMember]public virtual System.String PrBankaccnumber{
	get{
		return _Bankaccnumber;
	}
	set {
		if (ModelObject.valueChanged(_Bankaccnumber, value)){
		if (value != null && value.Length > 100){
			throw new ModelObjectFieldTooLongException("bankaccnumber");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_BANKACCNUMBER);
			}
		this._Bankaccnumber = value;

		}
		}
	}
		//Field nextCheckNumber
	[Key][StringLength(50, ErrorMessage="nextCheckNumber must be 50 characters or less")][Column(Name="nextCheckNumber",Storage = "_NextCheckNumber", IsPrimaryKey=false,DbType = "nvarchar",CanBeNull = true)]
	[DataMember]public virtual System.String PrNextCheckNumber{
	get{
		return _NextCheckNumber;
	}
	set {
		if (ModelObject.valueChanged(_NextCheckNumber, value)){
		if (value != null && value.Length > 50){
			throw new ModelObjectFieldTooLongException("nextCheckNumber");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_NEXTCHECKNUMBER);
			}
		this._NextCheckNumber = value;

		}
		}
	}
		//Field Description
	[Key][StringLength(255, ErrorMessage="Description must be 255 characters or less")][Column(Name="Description",Storage = "_Description", IsPrimaryKey=false,DbType = "nvarchar",CanBeNull = true)]
	[DataMember]public virtual System.String PrDescription{
	get{
		return _Description;
	}
	set {
		if (ModelObject.valueChanged(_Description, value)){
		if (value != null && value.Length > 255){
			throw new ModelObjectFieldTooLongException("Description");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_DESCRIPTION);
			}
		this._Description = value;

		}
		}
	}
		//Field createdate
	[Key][Required][Column(Name="createdate",Storage = "_Createdate", IsPrimaryKey=false,DbType = "datetime NOT NULL",CanBeNull = false)]
	[DataMember]public virtual System.DateTime? CreateDate{
	get{
		return _Createdate;
	}
	set {
		if (ModelObject.valueChanged(_Createdate, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_CREATEDATE);
			}
		this._Createdate = value;

		}
		}
	}
		//Field updatedate
	[Key][Required][Column(Name="updatedate",Storage = "_Updatedate", IsPrimaryKey=false,DbType = "datetime NOT NULL",CanBeNull = false)]
	[DataMember]public virtual System.DateTime? UpdateDate{
	get{
		return _Updatedate;
	}
	set {
		if (ModelObject.valueChanged(_Updatedate, value)){
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_UPDATEDATE);
			}
		this._Updatedate = value;

		}
		}
	}
		//Field updateuser
	[Key][Required][StringLength(10, ErrorMessage="updateuser must be 10 characters or less")][Column(Name="updateuser",Storage = "_Updateuser", IsPrimaryKey=false,DbType = "varchar NOT NULL",CanBeNull = false)]
	[DataMember]public virtual System.String UpdateUser{
	get{
		return _Updateuser;
	}
	set {
		if (ModelObject.valueChanged(_Updateuser, value)){
		if (value != null && value.Length > 10){
			throw new ModelObjectFieldTooLongException("updateuser");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_UPDATEUSER);
			}
		this._Updateuser = value;

		}
		}
	}
		//Field createuser
	[Key][Required][StringLength(10, ErrorMessage="createuser must be 10 characters or less")][Column(Name="createuser",Storage = "_Createuser", IsPrimaryKey=false,DbType = "varchar NOT NULL",CanBeNull = false)]
	[DataMember]public virtual System.String CreateUser{
	get{
		return _Createuser;
	}
	set {
		if (ModelObject.valueChanged(_Createuser, value)){
		if (value != null && value.Length > 10){
			throw new ModelObjectFieldTooLongException("createuser");
		}
			if (!this.IsObjectLoading) {
				this.isDirty = true;
				this.setFieldChanged(STR_FLD_CREATEUSER);
			}
		this._Createuser = value;

		}
		}
	}

		// ASSOCIATIONS GETTERS/SETTERS BELOW!
        //associationChildOneCSharp.txt
        public bool BankAccountInfoLoaded {get; private set;}

		public virtual CsModelObjects.AccountBankInfo PrBankAccountInfo {
			//1-1 child association
            set {
                this._BankAccountInfo = value;
				if (  this._BankAccountInfo != null) {
					this._BankAccountInfo.PrAccountID = this.PrAccountid;
					this._BankAccountInfo.IDChanged += this.handleParentIdChanged;
				}     
            }
            get {
			    //LAZY LOADING! Only hit the database to get the child object if we need it
                if (! this.BankAccountInfoLoaded) {
					this.LoadPrBankAccountInfo();
                } 
                return this._BankAccountInfo;
            } 
        }
        
        /// <summary>
        /// Loads child object from dabatabase, if not loaded already
        /// <//summary>
        private void LoadPrBankAccountInfo() {
						
			if ( this.BankAccountInfoLoaded) { return; }

			if ( this._BankAccountInfo == null )  {
				//IMPORTANT: call setter here, not the private variable
				this.PrBankAccountInfo = new CsModelMappers.AccountBankInfoDBMapper().findWhere("accountid=?", this.PrAccountid);
				
			} 

			//set the loaded flag here
			this.BankAccountInfoLoaded = true;
            
        } //End Sub

		


		#endregion

		#region "Getters/Setters of values by field index/name"
		public override object getAttribute(int fieldKey){

		switch (fieldKey) {
		case FLD_ACCOUNTID:
			return this.PrAccountid;
		case FLD_ACCOUNT:
			return this.PrAccount;
		case FLD_ACCOUNTTYPEID:
			return this.PrAccountTypeid;
		case FLD_BANKACCNUMBER:
			return this.PrBankaccnumber;
		case FLD_NEXTCHECKNUMBER:
			return this.PrNextCheckNumber;
		case FLD_DESCRIPTION:
			return this.PrDescription;
		case FLD_CREATEDATE:
			return this.CreateDate;
		case FLD_UPDATEDATE:
			return this.UpdateDate;
		case FLD_UPDATEUSER:
			return this.UpdateUser;
		case FLD_CREATEUSER:
			return this.CreateUser;
		default:
			return null;
		} //end switch

		}

		public override object getAttribute(string fieldKey) {
			fieldKey = fieldKey.ToLower();

		if (fieldKey==STR_FLD_ACCOUNTID.ToLower() ) {
			return this.PrAccountid;
		} else if (fieldKey==STR_FLD_ACCOUNT.ToLower() ) {
			return this.PrAccount;
		} else if (fieldKey==STR_FLD_ACCOUNTTYPEID.ToLower() ) {
			return this.PrAccountTypeid;
		} else if (fieldKey==STR_FLD_BANKACCNUMBER.ToLower() ) {
			return this.PrBankaccnumber;
		} else if (fieldKey==STR_FLD_NEXTCHECKNUMBER.ToLower() ) {
			return this.PrNextCheckNumber;
		} else if (fieldKey==STR_FLD_DESCRIPTION.ToLower() ) {
			return this.PrDescription;
		} else if (fieldKey==STR_FLD_CREATEDATE.ToLower() ) {
			return this.CreateDate;
		} else if (fieldKey==STR_FLD_UPDATEDATE.ToLower() ) {
			return this.UpdateDate;
		} else if (fieldKey==STR_FLD_UPDATEUSER.ToLower() ) {
			return this.UpdateUser;
		} else if (fieldKey==STR_FLD_CREATEUSER.ToLower() ) {
			return this.CreateUser;
		} else {
			return null;
		}
		}

		public override void setAttribute(int fieldKey, object val){
			try {
		switch (fieldKey) {
		case FLD_ACCOUNTID:
			if (val == DBNull.Value || val == null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrAccountid=(System.Int64)val;
			} //
			return;
		case FLD_ACCOUNT:
			if (val == DBNull.Value || val == null ){
				this.PrAccount = null;
			} else {
				this.PrAccount=(System.String)val;
			} //
			return;
		case FLD_ACCOUNTTYPEID:
			if (val == DBNull.Value || val == null ){
				this.PrAccountTypeid = null;
			} else {
				this.PrAccountTypeid=(System.Int64?)val;
			} //
			return;
		case FLD_BANKACCNUMBER:
			if (val == DBNull.Value || val == null ){
				this.PrBankaccnumber = null;
			} else {
				this.PrBankaccnumber=(System.String)val;
			} //
			return;
		case FLD_NEXTCHECKNUMBER:
			if (val == DBNull.Value || val == null ){
				this.PrNextCheckNumber = null;
			} else {
				this.PrNextCheckNumber=(System.String)val;
			} //
			return;
		case FLD_DESCRIPTION:
			if (val == DBNull.Value || val == null ){
				this.PrDescription = null;
			} else {
				this.PrDescription=(System.String)val;
			} //
			return;
		case FLD_CREATEDATE:
			if (val == DBNull.Value || val == null ){
				this.CreateDate = null;
			} else {
				this.CreateDate=(System.DateTime?)val;
			} //
			return;
		case FLD_UPDATEDATE:
			if (val == DBNull.Value || val == null ){
				this.UpdateDate = null;
			} else {
				this.UpdateDate=(System.DateTime?)val;
			} //
			return;
		case FLD_UPDATEUSER:
			if (val == DBNull.Value || val == null ){
				this.UpdateUser = null;
			} else {
				this.UpdateUser=(System.String)val;
			} //
			return;
		case FLD_CREATEUSER:
			if (val == DBNull.Value || val == null ){
				this.CreateUser = null;
			} else {
				this.CreateUser=(System.String)val;
			} //
			return;
		default:
			return;
		}

			} catch ( Exception ex ) {
				throw new ApplicationException(
						String.Format("Error setting field with index {0}, value \"{1}\" : {2}", 
								fieldKey, val, ex.Message));
			}
		}

		public override void setAttribute(string fieldKey, object val) {
			fieldKey = fieldKey.ToLower();
			try {
		if ( fieldKey==STR_FLD_ACCOUNTID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				throw new ApplicationException("Can't set Primary Key to null");
			} else {
				this.PrAccountid=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_ACCOUNT.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrAccount = null;
			} else {
				this.PrAccount=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_ACCOUNTTYPEID.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrAccountTypeid = null;
			} else {
				this.PrAccountTypeid=Convert.ToInt64(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_BANKACCNUMBER.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrBankaccnumber = null;
			} else {
				this.PrBankaccnumber=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_NEXTCHECKNUMBER.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrNextCheckNumber = null;
			} else {
				this.PrNextCheckNumber=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_DESCRIPTION.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.PrDescription = null;
			} else {
				this.PrDescription=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_CREATEDATE.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.CreateDate = null;
			} else {
				this.CreateDate=Convert.ToDateTime(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_UPDATEDATE.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.UpdateDate = null;
			} else {
				this.UpdateDate=Convert.ToDateTime(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_UPDATEUSER.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.UpdateUser = null;
			} else {
				this.UpdateUser=Convert.ToString(val);
			}
			return;
		} else if ( fieldKey==STR_FLD_CREATEUSER.ToLower()){
			if (val == DBNull.Value || val ==null ){
				this.CreateUser = null;
			} else {
				this.CreateUser=Convert.ToString(val);
			}
			return;
		}
			} catch ( Exception ex ) {
				throw new ApplicationException(
					String.Format("Error setting field with index {0}, value \"{1}\" : {2}", 
							fieldKey, val, ex.Message));
			}
		}

		#endregion
		#region "Overrides of GetHashCode and Equals "
		public bool Equals(Account other)
		{

			//typesafe equals, checks for equality of fields
			if (other == null)
				return false;
			if (object.ReferenceEquals(other, this))
				return true;

			return this.PrAccountid == other.PrAccountid
				&& this.PrAccount == other.PrAccount
				&& this.PrAccountTypeid.GetValueOrDefault() == other.PrAccountTypeid.GetValueOrDefault()
				&& this.PrBankaccnumber == other.PrBankaccnumber
				&& this.PrNextCheckNumber == other.PrNextCheckNumber
				&& this.PrDescription == other.PrDescription
				&& this.CreateDate.GetValueOrDefault() == other.CreateDate.GetValueOrDefault()
				&& this.UpdateDate.GetValueOrDefault() == other.UpdateDate.GetValueOrDefault()
				&& this.UpdateUser == other.UpdateUser
				&& this.CreateUser == other.CreateUser;;

		}

		public override int GetHashCode()
		{
			//using Xor has the advantage of not overflowing the integer.
			return this.PrAccountid.GetHashCode()
				 ^ this.getStringHashCode(this.PrAccount)
				 ^ this.PrAccountTypeid.GetHashCode()
				 ^ this.getStringHashCode(this.PrBankaccnumber)
				 ^ this.getStringHashCode(this.PrNextCheckNumber)
				 ^ this.getStringHashCode(this.PrDescription)
				 ^ this.CreateDate.GetHashCode()
				 ^ this.UpdateDate.GetHashCode()
				 ^ this.getStringHashCode(this.UpdateUser)
				 ^ this.getStringHashCode(this.CreateUser);;

		}

		public override bool Equals(object Obj) {

			if (Obj != null && Obj is Account) {

				return this.Equals((Account)Obj);

			} else {
				return false;
			}

		}

		public static bool operator ==(Account obj1, Account obj2)
		{
			return object.Equals(obj1, obj2);
		}

		public static bool operator !=(Account obj1, Account obj2) {
			return !(obj1 == obj2);
		}

		#endregion

		#region "Copy and sort"

		public override IModelObject copy() {
			//creates a copy
			Account ret = new Account();
		ret.PrAccountid = this.PrAccountid;
		ret.PrAccount = this.PrAccount;
		ret.PrAccountTypeid = this.PrAccountTypeid;
		ret.PrBankaccnumber = this.PrBankaccnumber;
		ret.PrNextCheckNumber = this.PrNextCheckNumber;
		ret.PrDescription = this.PrDescription;
		ret.CreateDate = this.CreateDate;
		ret.UpdateDate = this.UpdateDate;
		ret.UpdateUser = this.UpdateUser;
		ret.CreateUser = this.CreateUser;

			return ret;

		}

		#endregion




		#region "ID Property"

		[DataMember]public sealed override object Id {
			get { return this._Accountid; }
			set {
				this._Accountid = Convert.ToInt64(value);
				this.raiseBroadcastIdChange();
			}
		}
		#endregion

		#region "Extra Code"

		#endregion

	}

	#region "Req Fields validator"
	[System.Runtime.InteropServices.ComVisible(false)]
	public class AccountRequiredFieldsValidator : IModelObjectValidator
	{


		public void validate(org.model.lib.Model.IModelObject imo) {
			Account mo = (Account)imo;
if (mo.CreateDate == null ) {
		throw new ModelObjectRequiredFieldException("Createdate");
}
if (mo.UpdateDate == null ) {
		throw new ModelObjectRequiredFieldException("Updatedate");
}
if (string.IsNullOrEmpty( mo.UpdateUser)) {
		throw new ModelObjectRequiredFieldException("Updateuser");
}
if (string.IsNullOrEmpty( mo.CreateUser)) {
		throw new ModelObjectRequiredFieldException("Createuser");
}

		}

	}
	#endregion

}


