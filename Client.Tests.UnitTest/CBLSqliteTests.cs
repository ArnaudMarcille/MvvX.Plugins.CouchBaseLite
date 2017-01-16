﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvvX.Plugins.CouchBaseLite.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Tests.UnitTest
{
    [TestClass]
    public class CBLSqliteTests:CBLTests
    {
        #region Construct & Dispose

        [ClassInitialize()]
        public static void InitializeClass(TestContext testContext)
        {
            dBFolderPath = Path.Combine(testContext.TestResultsDirectory, "sqliteDBFolder");
            storage = MvvX.Plugins.CouchBaseLite.Storages.StorageTypes.Sqlite;
        }

        [TestInitialize()]
        public override void Initialize()
        {
            base.Initialize();
        }

        [TestCleanup()]
        public override void Cleanup()
        {
            base.Cleanup();
        }

        #endregion

        #region Tests Methods

        [TestMethod]
        public override void CRUD()
        {
            base.CRUD();
        }

        [TestMethod]
        public override void ViewIndexUpdates()
        {
            base.ViewIndexUpdates();
        }

        [TestMethod]
        public override void VieweQueryIntField()
        {
            base.VieweQueryIntField();
        }

        [TestMethod]
        public override void ViewQueryStringField()
        {
            base.ViewQueryStringField();
        }

        #endregion
    }
}
