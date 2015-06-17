﻿
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.model.lib.Model;
using OracleModel;

///<comments>
/// Template: TestTemplate.csharp.txt
///************************************************************
/// Class autogenerated on 16-Jun-15 4:16:25 PM by ModelGenerator
/// DO NOT MODIFY CODE IN THIS CLASS!!
///************************************************************
///</comments>
[TestClass()] public class CountryTestBase {

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


    [TestMethod()] public void TestLoadAndSaveCountry() {
		
		ModelContext.beginTrans();
		try {

			object pid  = ModelContext.CurrentDBUtils.getObjectValue("select top 1 COUNTRY_ID from COUNTRIES");
			if (pid == null) {
				Assert.Inconclusive("No Country in database, table is empty");
			} else {

				OracleMappers.CountryDBMapper pdb = new OracleMappers.CountryDBMapper();
				Country p = pdb.findByKey(pid);
				Country p2 = (Country)p.copy();

				//Test equality and hash codes
				Assert.AreEqual(p.GetHashCode(), p2.GetHashCode());
				Assert.AreEqual(p, p2);
						
				p.isDirty = true ; // force save
				pdb.save(p);
			
				// now reload object from database
				p = null;
				p = pdb.findByKey(pid);
            
				//test fields to be equal before and after save
						Assert.IsTrue(p.PrCountryId == p2.PrCountryId,"Expected Field CountryId to be equal");
		Assert.IsTrue(p.PrCountryName == p2.PrCountryName,"Expected Field CountryName to be equal");
		Assert.IsTrue(p.PrRegionId.GetValueOrDefault() == p2.PrRegionId.GetValueOrDefault(),"Expected Field RegionId to be equal");
		Assert.IsTrue(p.PrSkipField == p2.PrSkipField,"Expected Field SkipField to be equal");
		Assert.IsTrue(p.PrLongFld.GetValueOrDefault() == p2.PrLongFld.GetValueOrDefault(),"Expected Field LongFld to be equal");
		Assert.IsTrue(p.PrLongFld2.GetValueOrDefault() == p2.PrLongFld2.GetValueOrDefault(),"Expected Field LongFld2 to be equal");

				
				
				p.isDirty = true; //to force save
				ModelContext.Current.saveModelObject(p);

				p = ModelContext.Current.loadModelObject< Country >(p.Id);
				p.loadObjectHierarchy();
			}

		} finally {
            ModelContext.rollbackTrans(); // 'Nothing should be saved to the database!
        }

   }

}

