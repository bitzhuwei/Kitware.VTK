using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLDatabaseSchema : vtkObject
	{
		public enum DatabaseColumnType
		{
			BIGINT = 3,
			BLOB = 8,
			DATE = 10,
			DOUBLE = 7,
			INTEGER = 2,
			REAL = 6,
			SERIAL = 0,
			SMALLINT,
			TEXT = 5,
			TIME = 9,
			TIMESTAMP = 11,
			VARCHAR = 4
		}

		public enum DatabaseIndexType
		{
			INDEX,
			PRIMARY_KEY = 2,
			UNIQUE = 1
		}

		public enum DatabaseTriggerType
		{
			AFTER_DELETE = 5,
			AFTER_INSERT = 1,
			AFTER_UPDATE = 3,
			BEFORE_DELETE,
			BEFORE_INSERT = 0,
			BEFORE_UPDATE = 2
		}

		public enum VarargTokens
		{
			COLUMN_TOKEN = 58,
			END_INDEX_TOKEN = 75,
			END_TABLE_TOKEN = 99,
			INDEX_COLUMN_TOKEN = 65,
			INDEX_TOKEN = 63,
			OPTION_TOKEN = 86,
			TRIGGER_TOKEN = 81
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseSchema";

		public new static readonly string MRClassNameKey;

		static vtkSQLDatabaseSchema()
		{
			vtkSQLDatabaseSchema.MRClassNameKey = "class vtkSQLDatabaseSchema";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabaseSchema.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseSchema"));
		}

		public vtkSQLDatabaseSchema(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabaseSchema New()
		{
			vtkSQLDatabaseSchema result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLDatabaseSchema() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToIndex_01(HandleRef pThis, int tblHandle, int idxHandle, int colHandle);

		public virtual int AddColumnToIndex(int tblHandle, int idxHandle, int colHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToIndex_01(base.GetCppThis(), tblHandle, idxHandle, colHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToIndex_02(HandleRef pThis, string tblName, string idxName, string colName);

		public virtual int AddColumnToIndex(string tblName, string idxName, string colName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToIndex_02(base.GetCppThis(), tblName, idxName, colName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToTable_03(HandleRef pThis, int tblHandle, int colType, string colName, int colSize, string colAttribs);

		public virtual int AddColumnToTable(int tblHandle, int colType, string colName, int colSize, string colAttribs)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToTable_03(base.GetCppThis(), tblHandle, colType, colName, colSize, colAttribs);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddColumnToTable_04(HandleRef pThis, string tblName, int colType, string colName, int colSize, string colAttribs);

		public virtual int AddColumnToTable(string tblName, int colType, string colName, int colSize, string colAttribs)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddColumnToTable_04(base.GetCppThis(), tblName, colType, colName, colSize, colAttribs);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddIndexToTable_05(HandleRef pThis, int tblHandle, int idxType, string idxName);

		public virtual int AddIndexToTable(int tblHandle, int idxType, string idxName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddIndexToTable_05(base.GetCppThis(), tblHandle, idxType, idxName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddIndexToTable_06(HandleRef pThis, string tblName, int idxType, string idxName);

		public virtual int AddIndexToTable(string tblName, int idxType, string idxName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddIndexToTable_06(base.GetCppThis(), tblName, idxType, idxName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddOptionToTable_07(HandleRef pThis, int tblHandle, string optStr, string optBackend);

		public virtual int AddOptionToTable(int tblHandle, string optStr, string optBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddOptionToTable_07(base.GetCppThis(), tblHandle, optStr, optBackend);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddOptionToTable_08(HandleRef pThis, string tblName, string optStr, string optBackend);

		public virtual int AddOptionToTable(string tblName, string optStr, string optBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddOptionToTable_08(base.GetCppThis(), tblName, optStr, optBackend);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddPreamble_09(HandleRef pThis, string preName, string preAction, string preBackend);

		public virtual int AddPreamble(string preName, string preAction, string preBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddPreamble_09(base.GetCppThis(), preName, preAction, preBackend);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddTable_10(HandleRef pThis, string tblName);

		public virtual int AddTable(string tblName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTable_10(base.GetCppThis(), tblName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddTableMultipleArguments_11(HandleRef pThis, string tblName);

		public int AddTableMultipleArguments(string tblName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTableMultipleArguments_11(base.GetCppThis(), tblName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddTriggerToTable_12(HandleRef pThis, int tblHandle, int trgType, string trgName, string trgAction, string trgBackend);

		public virtual int AddTriggerToTable(int tblHandle, int trgType, string trgName, string trgAction, string trgBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTriggerToTable_12(base.GetCppThis(), tblHandle, trgType, trgName, trgAction, trgBackend);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_AddTriggerToTable_13(HandleRef pThis, string tblName, int trgType, string trgName, string trgAction, string trgBackend);

		public virtual int AddTriggerToTable(string tblName, int trgType, string trgName, string trgAction, string trgBackend)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_AddTriggerToTable_13(base.GetCppThis(), tblName, trgType, trgName, trgAction, trgBackend);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetColumnAttributesFromHandle_14(HandleRef pThis, int tblHandle, int colHandle);

		public string GetColumnAttributesFromHandle(int tblHandle, int colHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnAttributesFromHandle_14(base.GetCppThis(), tblHandle, colHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetColumnHandleFromName_15(HandleRef pThis, string tblName, string colName);

		public int GetColumnHandleFromName(string tblName, string colName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnHandleFromName_15(base.GetCppThis(), tblName, colName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetColumnNameFromHandle_16(HandleRef pThis, int tblHandle, int colHandle);

		public string GetColumnNameFromHandle(int tblHandle, int colHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnNameFromHandle_16(base.GetCppThis(), tblHandle, colHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetColumnSizeFromHandle_17(HandleRef pThis, int tblHandle, int colHandle);

		public int GetColumnSizeFromHandle(int tblHandle, int colHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnSizeFromHandle_17(base.GetCppThis(), tblHandle, colHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetColumnTypeFromHandle_18(HandleRef pThis, int tblHandle, int colHandle);

		public int GetColumnTypeFromHandle(int tblHandle, int colHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetColumnTypeFromHandle_18(base.GetCppThis(), tblHandle, colHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetIndexColumnNameFromHandle_19(HandleRef pThis, int tblHandle, int idxHandle, int cnmHandle);

		public string GetIndexColumnNameFromHandle(int tblHandle, int idxHandle, int cnmHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexColumnNameFromHandle_19(base.GetCppThis(), tblHandle, idxHandle, cnmHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetIndexHandleFromName_20(HandleRef pThis, string tblName, string idxName);

		public int GetIndexHandleFromName(string tblName, string idxName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexHandleFromName_20(base.GetCppThis(), tblName, idxName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetIndexNameFromHandle_21(HandleRef pThis, int tblHandle, int idxHandle);

		public string GetIndexNameFromHandle(int tblHandle, int idxHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexNameFromHandle_21(base.GetCppThis(), tblHandle, idxHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetIndexTypeFromHandle_22(HandleRef pThis, int tblHandle, int idxHandle);

		public int GetIndexTypeFromHandle(int tblHandle, int idxHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetIndexTypeFromHandle_22(base.GetCppThis(), tblHandle, idxHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetName_23(HandleRef pThis);

		public virtual string GetName()
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetName_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfColumnNamesInIndex_24(HandleRef pThis, int tblHandle, int idxHandle);

		public int GetNumberOfColumnNamesInIndex(int tblHandle, int idxHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfColumnNamesInIndex_24(base.GetCppThis(), tblHandle, idxHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfColumnsInTable_25(HandleRef pThis, int tblHandle);

		public int GetNumberOfColumnsInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfColumnsInTable_25(base.GetCppThis(), tblHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfIndicesInTable_26(HandleRef pThis, int tblHandle);

		public int GetNumberOfIndicesInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfIndicesInTable_26(base.GetCppThis(), tblHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfOptionsInTable_27(HandleRef pThis, int tblHandle);

		public int GetNumberOfOptionsInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfOptionsInTable_27(base.GetCppThis(), tblHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfPreambles_28(HandleRef pThis);

		public int GetNumberOfPreambles()
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfPreambles_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfTables_29(HandleRef pThis);

		public int GetNumberOfTables()
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfTables_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetNumberOfTriggersInTable_30(HandleRef pThis, int tblHandle);

		public int GetNumberOfTriggersInTable(int tblHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetNumberOfTriggersInTable_30(base.GetCppThis(), tblHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetOptionBackendFromHandle_31(HandleRef pThis, int tblHandle, int trgHandle);

		public string GetOptionBackendFromHandle(int tblHandle, int trgHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetOptionBackendFromHandle_31(base.GetCppThis(), tblHandle, trgHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetOptionTextFromHandle_32(HandleRef pThis, int tblHandle, int optHandle);

		public string GetOptionTextFromHandle(int tblHandle, int optHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetOptionTextFromHandle_32(base.GetCppThis(), tblHandle, optHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleActionFromHandle_33(HandleRef pThis, int preHandle);

		public string GetPreambleActionFromHandle(int preHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleActionFromHandle_33(base.GetCppThis(), preHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleBackendFromHandle_34(HandleRef pThis, int preHandle);

		public string GetPreambleBackendFromHandle(int preHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleBackendFromHandle_34(base.GetCppThis(), preHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetPreambleHandleFromName_35(HandleRef pThis, string preName);

		public int GetPreambleHandleFromName(string preName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleHandleFromName_35(base.GetCppThis(), preName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetPreambleNameFromHandle_36(HandleRef pThis, int preHandle);

		public string GetPreambleNameFromHandle(int preHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetPreambleNameFromHandle_36(base.GetCppThis(), preHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetTableHandleFromName_37(HandleRef pThis, string tblName);

		public int GetTableHandleFromName(string tblName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTableHandleFromName_37(base.GetCppThis(), tblName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTableNameFromHandle_38(HandleRef pThis, int tblHandle);

		public string GetTableNameFromHandle(int tblHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTableNameFromHandle_38(base.GetCppThis(), tblHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerActionFromHandle_39(HandleRef pThis, int tblHandle, int trgHandle);

		public string GetTriggerActionFromHandle(int tblHandle, int trgHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerActionFromHandle_39(base.GetCppThis(), tblHandle, trgHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerBackendFromHandle_40(HandleRef pThis, int tblHandle, int trgHandle);

		public string GetTriggerBackendFromHandle(int tblHandle, int trgHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerBackendFromHandle_40(base.GetCppThis(), tblHandle, trgHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetTriggerHandleFromName_41(HandleRef pThis, string tblName, string trgName);

		public int GetTriggerHandleFromName(string tblName, string trgName)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerHandleFromName_41(base.GetCppThis(), tblName, trgName);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_GetTriggerNameFromHandle_42(HandleRef pThis, int tblHandle, int trgHandle);

		public string GetTriggerNameFromHandle(int tblHandle, int trgHandle)
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerNameFromHandle_42(base.GetCppThis(), tblHandle, trgHandle));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_GetTriggerTypeFromHandle_43(HandleRef pThis, int tblHandle, int trgHandle);

		public int GetTriggerTypeFromHandle(int tblHandle, int trgHandle)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_GetTriggerTypeFromHandle_43(base.GetCppThis(), tblHandle, trgHandle);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_IsA_44(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_IsA_44(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseSchema_IsTypeOf_45(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_IsTypeOf_45(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_NewInstance_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLDatabaseSchema NewInstance()
		{
			vtkSQLDatabaseSchema result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_NewInstance_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseSchema_Reset_48(HandleRef pThis);

		public void Reset()
		{
			vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_Reset_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseSchema_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabaseSchema SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabaseSchema vtkSQLDatabaseSchema = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabaseSchema = (vtkSQLDatabaseSchema)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabaseSchema.Register(null);
				}
			}
			return vtkSQLDatabaseSchema;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseSchema_SetName_50(HandleRef pThis, string _arg);

		public virtual void SetName(string _arg)
		{
			vtkSQLDatabaseSchema.vtkSQLDatabaseSchema_SetName_50(base.GetCppThis(), _arg);
		}
	}
}
