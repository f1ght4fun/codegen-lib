﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using org.model.lib;
using org.model.lib.Model;
using org.model.lib.db;

using System.Linq;
using CsModelObjects;
using System.Data.Linq.Mapping;

//<comments>
// Template: DBMapperBase.csharp.txt
//************************************************************
// 
// Class autogenerated on11/07/2015 12:52:19 PM by ModelGenerator
// Extends base DBMapperBase object class
// *** DO NOT change code in this class.  
//     It will be re-generated and 
//     overwritten by the code generator ****
// Instead, change code in the extender class AccountBankInfoDBMapper
//
//************************************************************
//</comments>

namespace CsModelMappers {

	[System.Runtime.InteropServices.ComVisible(false)]
	[Table(Name = "AccountInfo")]
	[SelectObject("AccountInfo")][KeyFieldName("AccInfoId")]
	public class AccountBankInfoDBMapper : DBMapper {

		#region "Constructors "
		public AccountBankInfoDBMapper(DBUtils _dbConn) : base(_dbConn) {
		}


		public AccountBankInfoDBMapper() : base() {
		}
		#endregion

		#region "Overloaded Functions"

		public new AccountBankInfo findWhere(string sWhereClause, params object[] @params) {

			return (AccountBankInfo)base.findWhere(sWhereClause, @params);
		}


		public void saveAccountBankInfo(AccountBankInfo mo) {
			base.save(mo);
		}

		public new AccountBankInfo findByKey(object keyval) {

			return (AccountBankInfo)base.findByKey(keyval);

		}

		#endregion


		#region "getUpdateDBCommand"
		public override IDbCommand getUpdateDBCommand(IModelObject modelObj, string sql) {
			AccountBankInfo obj = (AccountBankInfo)modelObj;
			IDbCommand stmt = this.dbConn.getCommand(sql);
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_CONTACTNAME,obj.PrContactName));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_CONTACTPHONE,obj.PrContactPhone));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_CONTACTFAX,obj.PrContactFax));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_ACCOUNTID,obj.PrAccountID));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_SIGNEEEMPLOYEE,obj.PrSigneeEmployee));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_COMPANYNAME,obj.PrCompanyName));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_COMPANYBANKCODE,obj.PrCompanyBankCode));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_BANKID,obj.PrBankId));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_COOPCODE,obj.PrCOOPCode));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_CREATEDATE,obj.CreateDate));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_UPDATEDATE,obj.UpdateDate));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_UPDATEUSER,obj.UpdateUser));
			stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_CREATEUSER,obj.CreateUser));

			if (obj.isNew){
			} else {
			//only add primary key if we are updating and as the last parameter
				stmt.Parameters.Add(this.dbConn.getParameter(AccountBankInfo.STR_FLD_ACCINFOID,obj.PrAccInfoId));
			}

			return stmt;
		}
		#endregion

	public override void saveParents(IModelObject mo ){

		AccountBankInfo thisMo  = ( AccountBankInfo)mo;
		//**** Parent Association:bank
		if ((thisMo.PrBank!=null) && (thisMo.PrBank.NeedsSave)) {
			CsModelMappers.BankDBMapper mappervar = new CsModelMappers.BankDBMapper(this.dbConn);
			mappervar.save(thisMo.PrBank);
			thisMo.PrBankId = thisMo.PrBank.PrBANKID;
		}
		
	}

		#region "Find functions"

		///	<summary>Given an sql statement, it opens a result set, and for each record returned, 
		///	it creates and loads a ModelObject. 
		/// </summary>
		///	<param name="sWhereClause">where clause to be applied to "selectall" statement 
		/// that returns one or more records from the database, corresponding to the ModelObject we are going to load </param>
		///	<param name="params"> Parameter values to be passed to sql statement </param>
		///	<returns> A List(Of AccountBankInfo) object containing all objects loaded </returns>
		///	 
		public new List<AccountBankInfo> findList(string sWhereClause, params object[] @params) {

			string sql = this.getSqlWithWhereClause(sWhereClause);
			IDataReader rs = null;
			List<AccountBankInfo> molist = new List<AccountBankInfo>();

			try {
				rs = dbConn.getDataReaderWithParams(sql, @params);
				this.Loader.DataSource = rs;

				while (rs.Read()) {
					IModelObject mo = this.getModelInstance();
					this.Loader.load(mo);
					molist.Add((AccountBankInfo)mo);

				}


			} finally {
				this.dbConn.closeDataReader(rs);
			}

			return molist;

		}

		///	<summary>Given an sql statement, it opens a result set, and for each record returned, 
		///	it creates and loads a ModelObject. </summary>
		///	<param name="sWhereClause">where clause to be applied to "selectall" statement 
		/// that returns one or more records from the database, corresponding to the ModelObject we are going to load </param>
		///	<param name="params"> List of IDataParameters to be passed to sql statement </param>
		///	<returns> A List(Of AccountBankInfo) object containing all objects loaded </returns>
		///	 
		public List<AccountBankInfo> findList(string sWhereClause, List<IDataParameter> @params) {

			string sql = this.getSqlWithWhereClause(sWhereClause);
			IDataReader rs = null;
			List<AccountBankInfo> molist = new List<AccountBankInfo>();

			try {
				rs = dbConn.getDataReader(sql, @params);
				this.Loader.DataSource = rs;

				while (rs.Read()) {
					IModelObject mo = this.getModelInstance();
					this.Loader.load(mo);
					molist.Add((AccountBankInfo)mo);

				}


			} finally {
				this.dbConn.closeDataReader(rs);
			}

			return molist;

		}


		///    
		///	 <summary>Returns all records from database for a coresponding ModelObject </summary>
		/// <returns>List(Of AccountBankInfo) </returns>
		public List<AccountBankInfo> findAll()
		{
			return this.findList(string.Empty);
		}

		public override IModelObjectLoader Loader {
			get {
				if (this._loader == null) {
					this._loader = new AccountBankInfoDataReaderLoader();
				}
				return this._loader;
			}
			set { this._loader = value; }
		}

		#endregion

		public override IModelObject getModelInstance() {
			return new AccountBankInfo();
		}

	}

	#region " AccountBankInfo Loader "
	[System.Runtime.InteropServices.ComVisible(false)]
	public class AccountBankInfoDataReaderLoader : DataReaderLoader {
		public override void load(IModelObject mo) {
			const int DATAREADER_FLD_ACCINFOID = 0;
			const int DATAREADER_FLD_CONTACTNAME = 1;
			const int DATAREADER_FLD_CONTACTPHONE = 2;
			const int DATAREADER_FLD_CONTACTFAX = 3;
			const int DATAREADER_FLD_ACCOUNTID = 4;
			const int DATAREADER_FLD_SIGNEEEMPLOYEE = 5;
			const int DATAREADER_FLD_COMPANYNAME = 6;
			const int DATAREADER_FLD_COMPANYBANKCODE = 7;
			const int DATAREADER_FLD_BANKID = 8;
			const int DATAREADER_FLD_COOPCODE = 9;
			const int DATAREADER_FLD_CREATEDATE = 10;
			const int DATAREADER_FLD_UPDATEDATE = 11;
			const int DATAREADER_FLD_UPDATEUSER = 12;
			const int DATAREADER_FLD_CREATEUSER = 13;

			AccountBankInfo obj = (AccountBankInfo)mo;
			obj.IsObjectLoading = true;

			if (!this.reader.IsDBNull(DATAREADER_FLD_ACCINFOID) ) {
				obj.PrAccInfoId = Convert.ToInt64(this.reader.GetInt32(DATAREADER_FLD_ACCINFOID));
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_CONTACTNAME) ) {
				obj.PrContactName = this.reader.GetString(DATAREADER_FLD_CONTACTNAME);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_CONTACTPHONE) ) {
				obj.PrContactPhone = this.reader.GetString(DATAREADER_FLD_CONTACTPHONE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_CONTACTFAX) ) {
				obj.PrContactFax = this.reader.GetString(DATAREADER_FLD_CONTACTFAX);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_ACCOUNTID) ) {
				obj.PrAccountID = Convert.ToInt64(this.reader.GetInt32(DATAREADER_FLD_ACCOUNTID));
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_SIGNEEEMPLOYEE) ) {
				obj.PrSigneeEmployee = this.reader.GetString(DATAREADER_FLD_SIGNEEEMPLOYEE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_COMPANYNAME) ) {
				obj.PrCompanyName = this.reader.GetString(DATAREADER_FLD_COMPANYNAME);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_COMPANYBANKCODE) ) {
				obj.PrCompanyBankCode = this.reader.GetString(DATAREADER_FLD_COMPANYBANKCODE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_BANKID) ) {
				obj.PrBankId = Convert.ToInt64(this.reader.GetInt32(DATAREADER_FLD_BANKID));
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_COOPCODE) ) {
				obj.PrCOOPCode = this.reader.GetString(DATAREADER_FLD_COOPCODE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_CREATEDATE) ) {
				obj.CreateDate = this.reader.GetDateTime(DATAREADER_FLD_CREATEDATE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_UPDATEDATE) ) {
				obj.UpdateDate = this.reader.GetDateTime(DATAREADER_FLD_UPDATEDATE);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_UPDATEUSER) ) {
				obj.UpdateUser = this.reader.GetString(DATAREADER_FLD_UPDATEUSER);
			}
			if (!this.reader.IsDBNull(DATAREADER_FLD_CREATEUSER) ) {
				obj.CreateUser = this.reader.GetString(DATAREADER_FLD_CREATEUSER);
			}


			obj.isNew = false;
			// since we've just loaded from database, we mark as "old"
			obj.isDirty = false;
			obj.IsObjectLoading = false;
			obj.afterLoad();

			return;

		}

	}

	#endregion

	///<summary>
	/// Final Class with convinience shared methods for loading/saving the AccountBankInfoRank ModelObject. 
	///</summary>
	[System.Runtime.InteropServices.ComVisible(false)]
	public sealed class AccountBankInfoDataUtils {

		#region "Shared ""get"" Functions "

		public static List<AccountBankInfo> findList(string @where, params object[] @params) {

			AccountBankInfoDBMapper dbm = new AccountBankInfoDBMapper();
			return dbm.findList(@where, @params);

		}

		public static List<AccountBankInfo> findList(string @where, List<IDataParameter> listOfIParams) {

			AccountBankInfoDBMapper dbm = new AccountBankInfoDBMapper();
			return dbm.findList(@where,listOfIParams);

		}

		public static AccountBankInfo findOne(string @where, params object[] @params) {

			AccountBankInfoDBMapper dbm = new AccountBankInfoDBMapper();
			return (AccountBankInfo)dbm.findWhere(@where, @params);

		}

		public static List<AccountBankInfo> findList(){

			return new AccountBankInfoDBMapper().findAll();

		}

		public static AccountBankInfo findByKey(object id) {

			return (AccountBankInfo)new AccountBankInfoDBMapper().findByKey(id);

		}

		/// <summary>
		/// Reload the AccountBankInfo from the database
		/// </summary>
		/// <remarks>
		/// use this method when you want to relad the AccountBankInfo 
		/// from the database, discarding any changes
		/// </remarks>
		public static void reload(ref AccountBankInfo mo) {

			if (mo == null) {
				throw new System.ArgumentNullException("null object past to reload function");
			}

			mo = (AccountBankInfo)new AccountBankInfoDBMapper().findByKey(mo.Id);

		}

		#endregion

		#region "Shared Save and Delete Functions"
		/// <summary>
		/// Convinience method to save a AccountBankInfo Object.
		/// Important note: DO NOT CALL THIS IN A LOOP!
		/// </summary>
		/// <param name="AccountBankInfoObj"></param>
		/// <remarks>
		/// Important note: DO NOT CALL THIS IN A LOOP!  
		/// This method simply instantiates a AccountBankInfoDBMapper and calls the save method
		/// </remarks>
		public static void saveAccountBankInfo(params AccountBankInfo[] AccountBankInfoObj)
		{

			AccountBankInfoDBMapper dbm = new AccountBankInfoDBMapper();
			dbm.saveList(AccountBankInfoObj.ToList());


		}


		public static void deleteAccountBankInfo(AccountBankInfo AccountBankInfoObj)
		{

			AccountBankInfoDBMapper dbm = new AccountBankInfoDBMapper();
			dbm.delete(AccountBankInfoObj);

		}
		#endregion

		#region "Data Table and data row load/save "

		public static void saveAccountBankInfo(DataRow dr, ref AccountBankInfo mo) {
			if (mo == null) {
				mo = new AccountBankInfo();
			}

			foreach (DataColumn dc in dr.Table.Columns) {
				mo.setAttribute(dc.ColumnName, dr[dc.ColumnName]);
			}

			saveAccountBankInfo(mo);

		}

		public static void saveAccountBankInfo(DataTable dt, ref AccountBankInfo mo) {
			foreach (DataRow dr in dt.Rows) {
				saveAccountBankInfo(dr, ref mo);
			}

		}

		public static AccountBankInfo loadFromDataRow(DataRow r) {

			DataRowLoader a = new DataRowLoader();
			IModelObject mo = new AccountBankInfo();
			a.DataSource = r;
			a.load(mo);
			return (AccountBankInfo)mo;

		}

		#endregion

	}

}


