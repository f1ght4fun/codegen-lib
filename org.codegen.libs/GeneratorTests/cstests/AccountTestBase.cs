﻿
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.model.lib.Model;
using System.Data.Linq;
using System.Linq;
using org.model.lib.db;
using Newtonsoft.Json;
using CsModelObjects;

///<comments>
/// Template: TestTemplate.csharp.txt
///************************************************************
/// Class autogenerated on 11/07/2015 12:52:19 PM by ModelGenerator
/// DO NOT MODIFY CODE IN THIS CLASS!!
///************************************************************
///</comments>
[TestClass()] public class AccountTestBase {

    ///<summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext {get;set;}
    

#region "Additional test attributes"
    ///
    /// You can use the following additional attributes as you write your tests:
    ///
    /// Use ClassInitialize to run code before running the first test in the class
    [ClassInitialize()] public static void MyClassInitialize(TestContext testContext ) {
        ModelContext.newForUnitTests();
    }
    
    /// Use ClassCleanup to run code after all tests in a class have run
    [ClassCleanup()] public static void MyClassCleanup() {
        ModelContext.release();
    }


    //Use TestInitialize to run code before running each test
    [TestInitialize()]
    public void MyTestInitialize() {
    }
    
    // Use TestCleanup to run code after each test has run
    [TestCleanup()] public void MyTestCleanup() {
    
	}
    
#endregion


    [TestMethod()] public void TestLoadAndSaveAccount() {
		
		ModelContext.beginTrans();
		try {
			
			CsModelMappers.AccountDBMapper pdb = new CsModelMappers.AccountDBMapper();
			
		    long count = pdb.RecordCount();
			
			if (pdb.SelectFromObjectName != pdb.ManagedTableName) {
				long countFromSelectObject = pdb.dbConn.getLngValue("select count(*) from " + pdb.SelectFromObjectName);
				Assert.AreEqual(count, countFromSelectObject, 
					"Count of records in managedTableName {0} and SelectFromObjectName {1} should be equal, as there needs to be exactly 1 to 1 match between records in managed table and selectFromObject.", 
					pdb.ManagedTableName, pdb.SelectFromObjectName);
			}

			if (count == 0) {
				Assert.Inconclusive("No Account in database, table is empty");
			} else {
				/**
				using (DataContext ctx = DBUtils.Current().dbContext()) {

					var query = ctx.ExecuteQuery<Account>(@"SELECT * FROM " + pdb.SelectFromObjectName ).Skip(1).Take(1);
					var lst = query.ToList();

					Assert.AreEqual(lst.Count, 1, "Expected to receive 1 record, got: " + lst.Count);
					
				}
				todo: fix boolean fields by generating properties of original fields
				**/
				object pid  = ModelContext.CurrentDBUtils.getObjectValue("select top 1 accountid from Account");
				
				Account p = pdb.findByKey(pid);
				Account p2 = (Account)p.copy();

				//Test equality and hash codes
				Assert.AreEqual(p.GetHashCode(), p2.GetHashCode());
				Assert.AreEqual(p, p2);
						
				p.isDirty = true ; // force save
				pdb.save(p);
			
				// now reload object from database
				p = null;
				p = pdb.findByKey(pid);
            
				//test fields to be equal before and after save
						Assert.IsTrue(p.PrAccountid == p2.PrAccountid,"Expected Field Accountid to be equal");
		Assert.IsTrue(p.PrAccount == p2.PrAccount,"Expected Field Account to be equal");
		Assert.IsTrue(p.PrAccountTypeid.GetValueOrDefault() == p2.PrAccountTypeid.GetValueOrDefault(),"Expected Field AccountTypeid to be equal");
		Assert.IsTrue(p.PrBankaccnumber == p2.PrBankaccnumber,"Expected Field Bankaccnumber to be equal");
		Assert.IsTrue(p.PrNextCheckNumber == p2.PrNextCheckNumber,"Expected Field NextCheckNumber to be equal");
		Assert.IsTrue(p.PrDescription == p2.PrDescription,"Expected Field Description to be equal");
		Assert.IsTrue(p.CreateDate.GetValueOrDefault() == p2.CreateDate.GetValueOrDefault(),"Expected Field Createdate to be equal");
		Assert.IsFalse(p.UpdateDate.GetValueOrDefault() == p2.UpdateDate.GetValueOrDefault(),"Expected Field Updatedate NOT to be equal");
		// skip update user!
		Assert.IsTrue(p.CreateUser == p2.CreateUser,"Expected Field Createuser to be equal");

					Assert.IsTrue(p.PrBankAccountInfo != null);

				
				p.isDirty = true; //to force save
				ModelContext.Current.saveModelObject(p);

				p = ModelContext.Current.loadModelObject< Account >(p.Id);
				p.loadObjectHierarchy();
				string output = JsonConvert.SerializeObject(p);
				
			}

		} finally {
            ModelContext.rollbackTrans(); // 'Nothing should be saved to the database!
        }

   }

}

