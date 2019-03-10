﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace SybaseDataContext
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : dbhost2,5000
	/// Server Version : 16.0.2
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<dbo_AllType>           AllTypes            { get { return this.GetTable<dbo_AllType>(); } }
		public ITable<dbo_Child>             Children            { get { return this.GetTable<dbo_Child>(); } }
		public ITable<dbo_Doctor>            Doctors             { get { return this.GetTable<dbo_Doctor>(); } }
		public ITable<dbo_GrandChild>        GrandChildren       { get { return this.GetTable<dbo_GrandChild>(); } }
		public ITable<dbo_InheritanceChild>  InheritanceChildren { get { return this.GetTable<dbo_InheritanceChild>(); } }
		public ITable<dbo_InheritanceParent> InheritanceParents  { get { return this.GetTable<dbo_InheritanceParent>(); } }
		public ITable<dbo_LinqDataType>      LinqDataTypes       { get { return this.GetTable<dbo_LinqDataType>(); } }
		public ITable<dbo_Parent>            Parents             { get { return this.GetTable<dbo_Parent>(); } }
		public ITable<dbo_Patient>           Patients            { get { return this.GetTable<dbo_Patient>(); } }
		public ITable<dbo_Person>            People              { get { return this.GetTable<dbo_Person>(); } }
		public ITable<SysObject>             SysObjects          { get { return this.GetTable<SysObject>(); } }
		public ITable<dbo_Sysquerymetric>    Sysquerymetrics     { get { return this.GetTable<dbo_Sysquerymetric>(); } }
		public ITable<dbo_TestIdentity>      TestIdentities      { get { return this.GetTable<dbo_TestIdentity>(); } }
		public ITable<dbo_TestMerge1>        TestMerge1          { get { return this.GetTable<dbo_TestMerge1>(); } }
		public ITable<dbo_TestMerge2>        TestMerge2          { get { return this.GetTable<dbo_TestMerge2>(); } }
		public ITable<dbo_TestMergeIdentity> TestMergeIdentities { get { return this.GetTable<dbo_TestMergeIdentity>(); } }

		public void InitMappingSchema()
		{
		}

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext();
	}

	[Table(Schema="dbo", Name="AllTypes")]
	public partial class dbo_AllType
	{
		[Column(),                                                              Identity   ] public int       ID                    { get; set; } // int
		[Column("bigintDataType"),                                                 Nullable] public long?     BigintDataType        { get; set; } // bigint
		[Column("uBigintDataType"),                                                Nullable] public object    UBigintDataType       { get; set; } // ubigint
		[Column("numericDataType"),                                                Nullable] public decimal?  NumericDataType       { get; set; } // numeric(18, 0)
		[Column("bitDataType"),                                                 NotNull    ] public bool      BitDataType           { get; set; } // bit
		[Column("smallintDataType"),                                               Nullable] public short?    SmallintDataType      { get; set; } // smallint
		[Column("uSmallintDataType"),                                              Nullable] public object    USmallintDataType     { get; set; } // usmallint
		[Column("decimalDataType"),                                                Nullable] public decimal?  DecimalDataType       { get; set; } // decimal(18, 0)
		[Column("smallmoneyDataType"),                                             Nullable] public decimal?  SmallmoneyDataType    { get; set; } // smallmoney
		[Column("intDataType"),                                                    Nullable] public int?      IntDataType           { get; set; } // int
		[Column("uIntDataType"),                                                   Nullable] public object    UIntDataType          { get; set; } // uint
		[Column("tinyintDataType"),                                                Nullable] public sbyte?    TinyintDataType       { get; set; } // tinyint
		[Column("moneyDataType"),                                                  Nullable] public decimal?  MoneyDataType         { get; set; } // money
		[Column("floatDataType"),                                                  Nullable] public double?   FloatDataType         { get; set; } // float
		[Column("realDataType"),                                                   Nullable] public float?    RealDataType          { get; set; } // real
		[Column("datetimeDataType"),                                               Nullable] public DateTime? DatetimeDataType      { get; set; } // datetime
		[Column("smalldatetimeDataType"),                                          Nullable] public DateTime? SmalldatetimeDataType { get; set; } // smalldatetime
		[Column("dateDataType"),                                                   Nullable] public object    DateDataType          { get; set; } // date
		[Column("timeDataType"),                                                   Nullable] public object    TimeDataType          { get; set; } // time
		[Column("charDataType"),                                                   Nullable] public char?     CharDataType          { get; set; } // char(1)
		[Column("char20DataType"),                                                 Nullable] public string    Char20DataType        { get; set; } // char(20)
		[Column("varcharDataType"),                                                Nullable] public string    VarcharDataType       { get; set; } // varchar(20)
		[Column("textDataType"),                                                   Nullable] public string    TextDataType          { get; set; } // text
		[Column("ncharDataType"),                                                  Nullable] public string    NcharDataType         { get; set; } // nchar(60)
		[Column("nvarcharDataType"),                                               Nullable] public string    NvarcharDataType      { get; set; } // nvarchar(60)
		[Column("ntextDataType"),                                                  Nullable] public object    NtextDataType         { get; set; } // unitext
		[Column("binaryDataType"),                                                 Nullable] public byte[]    BinaryDataType        { get; set; } // binary(1)
		[Column("varbinaryDataType"),                                              Nullable] public char?     VarbinaryDataType     { get; set; } // varbinary(1)
		[Column("imageDataType"),                                                  Nullable] public byte[]    ImageDataType         { get; set; } // image
		[Column("timestampDataType",     SkipOnInsert=true, SkipOnUpdate=true),    Nullable] public byte[]    TimestampDataType     { get; set; } // timestamp
	}

	[Table(Schema="dbo", Name="Child")]
	public partial class dbo_Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? ChildID  { get; set; } // int
	}

	[Table(Schema="dbo", Name="Doctor")]
	public partial class dbo_Doctor
	{
		[PrimaryKey, NotNull] public int    PersonID { get; set; } // int
		[Column,     NotNull] public string Taxonomy { get; set; } // nvarchar(150)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_Doctor_Person", BackReferenceName="Doctor")]
		public dbo_Person Person { get; set; }

		#endregion
	}

	[Table(Schema="dbo", Name="GrandChild")]
	public partial class dbo_GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // int
		[Column, Nullable] public int? ChildID      { get; set; } // int
		[Column, Nullable] public int? GrandChildID { get; set; } // int
	}

	[Table(Schema="dbo", Name="InheritanceChild")]
	public partial class dbo_InheritanceChild
	{
		[PrimaryKey, NotNull    ] public int    InheritanceChildId  { get; set; } // int
		[Column,     NotNull    ] public int    InheritanceParentId { get; set; } // int
		[Column,        Nullable] public int?   TypeDiscriminator   { get; set; } // int
		[Column,        Nullable] public string Name                { get; set; } // nvarchar(150)
	}

	[Table(Schema="dbo", Name="InheritanceParent")]
	public partial class dbo_InheritanceParent
	{
		[PrimaryKey, NotNull    ] public int    InheritanceParentId { get; set; } // int
		[Column,        Nullable] public int?   TypeDiscriminator   { get; set; } // int
		[Column,        Nullable] public string Name                { get; set; } // nvarchar(150)
	}

	[Table(Schema="dbo", Name="LinqDataTypes")]
	public partial class dbo_LinqDataType
	{
		[Column, NotNull    ] public int       ID             { get; set; } // int
		[Column,    Nullable] public decimal?  MoneyValue     { get; set; } // decimal(10, 4)
		[Column,    Nullable] public DateTime? DateTimeValue  { get; set; } // datetime
		[Column,    Nullable] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Column, NotNull    ] public bool      BoolValue      { get; set; } // bit
		[Column,    Nullable] public string    GuidValue      { get; set; } // char(36)
		[Column,    Nullable] public byte[]    BinaryValue    { get; set; } // binary(500)
		[Column,    Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column,    Nullable] public int?      IntValue       { get; set; } // int
		[Column,    Nullable] public long?     BigIntValue    { get; set; } // bigint
		[Column,    Nullable] public string    StringValue    { get; set; } // nvarchar(150)
	}

	[Table(Schema="dbo", Name="Parent")]
	public partial class dbo_Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // int
		[Column, Nullable] public int? Value1   { get; set; } // int
	}

	[Table(Schema="dbo", Name="Patient")]
	public partial class dbo_Patient
	{
		[PrimaryKey, NotNull] public int    PersonID  { get; set; } // int
		[Column,     NotNull] public string Diagnosis { get; set; } // nvarchar(768)

		#region Associations

		/// <summary>
		/// FK_Patient_Person
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, Relationship=Relationship.OneToOne, KeyName="FK_Patient_Person", BackReferenceName="Patient")]
		public dbo_Person Person { get; set; }

		#endregion
	}

	[Table(Schema="dbo", Name="Person")]
	public partial class dbo_Person
	{
		[PrimaryKey, Identity   ] public int    PersonID   { get; set; } // int
		[Column,     NotNull    ] public string FirstName  { get; set; } // nvarchar(150)
		[Column,     NotNull    ] public string LastName   { get; set; } // nvarchar(150)
		[Column,        Nullable] public string MiddleName { get; set; } // nvarchar(150)
		[Column,     NotNull    ] public char   Gender     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_Doctor_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public dbo_Doctor Doctor { get; set; }

		/// <summary>
		/// FK_Patient_Person_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, Relationship=Relationship.OneToOne, IsBackReference=true)]
		public dbo_Patient Patient { get; set; }

		#endregion
	}

	[Table("sysobjects")]
	public partial class SysObject
	{
		[Column, NotNull    ] public string   name      { get; set; } // varchar
		[Column, NotNull    ] public int      id        { get; set; } // int
		[Column, NotNull    ] public int      uid       { get; set; } // int
		[Column, NotNull    ] public string   type      { get; set; } // char
		[Column, NotNull    ] public short    userstat  { get; set; } // smallint
		[Column, NotNull    ] public short    sysstat   { get; set; } // smallint
		[Column, NotNull    ] public short    indexdel  { get; set; } // smallint
		[Column, NotNull    ] public short    schemacnt { get; set; } // smallint
		[Column, NotNull    ] public int      sysstat2  { get; set; } // int
		[Column, NotNull    ] public DateTime crdate    { get; set; } // datetime
		[Column, NotNull    ] public DateTime expdate   { get; set; } // datetime
		[Column, NotNull    ] public int      deltrig   { get; set; } // int
		[Column, NotNull    ] public int      instrig   { get; set; } // int
		[Column, NotNull    ] public int      updtrig   { get; set; } // int
		[Column, NotNull    ] public int      seltrig   { get; set; } // int
		[Column, NotNull    ] public int      ckfirst   { get; set; } // int
		[Column, NotNull    ] public short    cache     { get; set; } // smallint
		[Column,    Nullable] public int      audflags  { get; set; } // int
		[Column, NotNull    ] public int      objspare  { get; set; } // int
		[Column,    Nullable] public byte[]   versionts { get; set; } // binary
		[Column, NotNull    ] public string   loginame  { get; set; } // varchar
	}

	[Table(Schema="dbo", Name="sysquerymetrics", IsView=true)]
	public partial class dbo_Sysquerymetric
	{
		[Column("uid"),       NotNull    ] public int    Uid      { get; set; } // int
		[Column("gid"),       NotNull    ] public int    Gid      { get; set; } // int
		[Column("hashkey"),   NotNull    ] public int    Hashkey  { get; set; } // int
		[Column("id"),        NotNull    ] public int    Id       { get; set; } // int
		[Column("sequence"),  NotNull    ] public short  Sequence { get; set; } // smallint
		[Column("exec_min"),     Nullable] public object ExecMin  { get; set; } // ubigint
		[Column("exec_max"),     Nullable] public object ExecMax  { get; set; } // ubigint
		[Column("exec_avg"),     Nullable] public object ExecAvg  { get; set; } // ubigint
		[Column("elap_min"),     Nullable] public object ElapMin  { get; set; } // ubigint
		[Column("elap_max"),     Nullable] public object ElapMax  { get; set; } // ubigint
		[Column("elap_avg"),     Nullable] public object ElapAvg  { get; set; } // ubigint
		[Column("lio_min"),      Nullable] public object LioMin   { get; set; } // ubigint
		[Column("lio_max"),      Nullable] public object LioMax   { get; set; } // ubigint
		[Column("lio_avg"),      Nullable] public object LioAvg   { get; set; } // ubigint
		[Column("pio_min"),      Nullable] public object PioMin   { get; set; } // ubigint
		[Column("pio_max"),      Nullable] public object PioMax   { get; set; } // ubigint
		[Column("pio_avg"),      Nullable] public object PioAvg   { get; set; } // ubigint
		[Column("cnt"),          Nullable] public object Cnt      { get; set; } // ubigint
		[Column("abort_cnt"),    Nullable] public object AbortCnt { get; set; } // ubigint
		[Column("qtext"),        Nullable] public string Qtext    { get; set; } // varchar(510)
	}

	[Table(Schema="dbo", Name="TestIdentity")]
	public partial class dbo_TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // int
	}

	[Table(Schema="dbo", Name="TestMerge1")]
	public partial class dbo_TestMerge1
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int
		[Column,        Nullable] public int?      Field1          { get; set; } // int
		[Column,        Nullable] public int?      Field2          { get; set; } // int
		[Column,        Nullable] public int?      Field3          { get; set; } // int
		[Column,        Nullable] public int?      Field4          { get; set; } // int
		[Column,        Nullable] public int?      Field5          { get; set; } // int
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,        Nullable] public string    FieldString     { get; set; } // varchar(20)
		[Column,        Nullable] public string    FieldNString    { get; set; } // nvarchar(60)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,        Nullable] public string    FieldNChar      { get; set; } // nchar(3)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // real
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public string    FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public string    FieldGuid       { get; set; } // char(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // decimal(24, 10)
		[Column,        Nullable] public object    FieldDate       { get; set; } // date
		[Column,        Nullable] public object    FieldTime       { get; set; } // time
		[Column,        Nullable] public string    FieldEnumString { get; set; } // varchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table(Schema="dbo", Name="TestMerge2")]
	public partial class dbo_TestMerge2
	{
		[PrimaryKey, NotNull    ] public int       Id              { get; set; } // int
		[Column,        Nullable] public int?      Field1          { get; set; } // int
		[Column,        Nullable] public int?      Field2          { get; set; } // int
		[Column,        Nullable] public int?      Field3          { get; set; } // int
		[Column,        Nullable] public int?      Field4          { get; set; } // int
		[Column,        Nullable] public int?      Field5          { get; set; } // int
		[Column,        Nullable] public long?     FieldInt64      { get; set; } // bigint
		[Column,        Nullable] public string    FieldString     { get; set; } // varchar(20)
		[Column,        Nullable] public string    FieldNString    { get; set; } // nvarchar(60)
		[Column,        Nullable] public char?     FieldChar       { get; set; } // char(1)
		[Column,        Nullable] public string    FieldNChar      { get; set; } // nchar(3)
		[Column,        Nullable] public float?    FieldFloat      { get; set; } // real
		[Column,        Nullable] public double?   FieldDouble     { get; set; } // float
		[Column,        Nullable] public DateTime? FieldDateTime   { get; set; } // datetime
		[Column,        Nullable] public string    FieldBinary     { get; set; } // varbinary(20)
		[Column,        Nullable] public string    FieldGuid       { get; set; } // char(36)
		[Column,        Nullable] public decimal?  FieldDecimal    { get; set; } // decimal(24, 10)
		[Column,        Nullable] public object    FieldDate       { get; set; } // date
		[Column,        Nullable] public object    FieldTime       { get; set; } // time
		[Column,        Nullable] public string    FieldEnumString { get; set; } // varchar(20)
		[Column,        Nullable] public int?      FieldEnumNumber { get; set; } // int
	}

	[Table(Schema="dbo", Name="TestMergeIdentity")]
	public partial class dbo_TestMergeIdentity
	{
		[PrimaryKey, Identity] public int  Id    { get; set; } // int
		[Column,     Nullable] public int? Field { get; set; } // int
	}

	public static partial class TableExtensions
	{
		public static dbo_Doctor Find(this ITable<dbo_Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static dbo_InheritanceChild Find(this ITable<dbo_InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static dbo_InheritanceParent Find(this ITable<dbo_InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static dbo_Patient Find(this ITable<dbo_Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static dbo_Person Find(this ITable<dbo_Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static dbo_TestIdentity Find(this ITable<dbo_TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static dbo_TestMerge1 Find(this ITable<dbo_TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static dbo_TestMerge2 Find(this ITable<dbo_TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static dbo_TestMergeIdentity Find(this ITable<dbo_TestMergeIdentity> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}
