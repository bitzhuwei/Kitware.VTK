using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLiteDatabase : vtkSQLDatabase
	{
		public enum CREATE_WrapperEnum
		{
			CREATE = 3,
			CREATE_OR_CLEAR = 2,
			USE_EXISTING = 0,
			USE_EXISTING_OR_CREATE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteDatabase";

		public new static readonly string MRClassNameKey;

		static vtkSQLiteDatabase()
		{
			vtkSQLiteDatabase.MRClassNameKey = "class vtkSQLiteDatabase";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLiteDatabase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteDatabase"));
		}

		public vtkSQLiteDatabase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLiteDatabase New()
		{
			vtkSQLiteDatabase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLiteDatabase() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLiteDatabase.vtkSQLiteDatabase_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLiteDatabase_Close_01(HandleRef pThis);

		public override void Close()
		{
			vtkSQLiteDatabase.vtkSQLiteDatabase_Close_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_GetDatabaseFileName_02(HandleRef pThis);

		public virtual string GetDatabaseFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSQLiteDatabase.vtkSQLiteDatabase_GetDatabaseFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_GetDatabaseType_03(HandleRef pThis);

		public override string GetDatabaseType()
		{
			return Marshal.PtrToStringAnsi(vtkSQLiteDatabase.vtkSQLiteDatabase_GetDatabaseType_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_GetLastErrorText_04(HandleRef pThis);

		public override string GetLastErrorText()
		{
			return Marshal.PtrToStringAnsi(vtkSQLiteDatabase.vtkSQLiteDatabase_GetLastErrorText_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_GetQueryInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkSQLQuery GetQueryInstance()
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_GetQueryInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLQuery = (vtkSQLQuery)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLQuery.Register(null);
				}
			}
			return vtkSQLQuery;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_GetRecord_06(HandleRef pThis, string table, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkStringArray GetRecord(string table)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_GetRecord_06(base.GetCppThis(), table, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_GetTables_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkStringArray GetTables()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_GetTables_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteDatabase_HasError_08(HandleRef pThis);

		public override bool HasError()
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_HasError_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteDatabase_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteDatabase_IsOpen_10(HandleRef pThis);

		public override bool IsOpen()
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsOpen_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteDatabase_IsSupported_11(HandleRef pThis, int feature);

		public override bool IsSupported(int feature)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsSupported_11(base.GetCppThis(), feature) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteDatabase_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLiteDatabase NewInstance()
		{
			vtkSQLiteDatabase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteDatabase_Open_15(HandleRef pThis, string password);

		public override bool Open(string password)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_Open_15(base.GetCppThis(), password) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLiteDatabase_Open_16(HandleRef pThis, string password, int mode);

		public bool Open(string password, int mode)
		{
			return vtkSQLiteDatabase.vtkSQLiteDatabase_Open_16(base.GetCppThis(), password, mode) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteDatabase_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLiteDatabase SafeDownCast(vtkObjectBase o)
		{
			vtkSQLiteDatabase vtkSQLiteDatabase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteDatabase.vtkSQLiteDatabase_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLiteDatabase = (vtkSQLiteDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLiteDatabase.Register(null);
				}
			}
			return vtkSQLiteDatabase;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLiteDatabase_SetDatabaseFileName_18(HandleRef pThis, string _arg);

		public virtual void SetDatabaseFileName(string _arg)
		{
			vtkSQLiteDatabase.vtkSQLiteDatabase_SetDatabaseFileName_18(base.GetCppThis(), _arg);
		}
	}
}
