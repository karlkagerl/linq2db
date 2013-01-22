﻿using System;

using LinqToDB.Data;
using LinqToDB.ServiceModel;

namespace Tests.Model
{
	public static class Extensions
	{
		public static void BeginTransaction(this ITestDataContext context)
		{
			if (context is DataConnection)
				((DataConnection)context).BeginTransaction();
			//else if (context is ServiceModelDataContext)
			//	((ServiceModelDataContext)context).BeginBatch();
		}
	}
}
