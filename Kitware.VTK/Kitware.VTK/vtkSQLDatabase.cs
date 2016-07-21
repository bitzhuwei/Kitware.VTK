using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkSQLDatabase : vtkObject
	{
		public delegate IntPtr CreateFunction(string arg0);

		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabase";

		public new static readonly string MRClassNameKey;

		static vtkSQLDatabase()
		{
			vtkSQLDatabase.MRClassNameKey = "class vtkSQLDatabase";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabase.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabase"));
		}

		public vtkSQLDatabase(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLDatabase_Close_01(HandleRef pThis);

		public virtual void Close()
		{
			vtkSQLDatabase.vtkSQLDatabase_Close_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_CreateFromURL_02(string URL, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkSQLDatabase CreateFromURL(string URL)
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_CreateFromURL_02(URL, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabase = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabase.Register(null);
				}
			}
			return vtkSQLDatabase;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_DATABASE_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationObjectBaseKey DATABASE()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_DATABASE_03(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabase_EffectSchema_04(HandleRef pThis, HandleRef arg0, byte dropIfExists);

		public virtual bool EffectSchema(vtkSQLDatabaseSchema arg0, bool dropIfExists)
		{
			return vtkSQLDatabase.vtkSQLDatabase_EffectSchema_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), dropIfExists ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_GetDatabaseType_05(HandleRef pThis);

		public virtual string GetDatabaseType()
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabase.vtkSQLDatabase_GetDatabaseType_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_GetLastErrorText_06(HandleRef pThis);

		public virtual string GetLastErrorText()
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabase.vtkSQLDatabase_GetLastErrorText_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_GetQueryInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSQLQuery GetQueryInstance()
		{
			vtkSQLQuery vtkSQLQuery = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_GetQueryInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSQLDatabase_GetRecord_08(HandleRef pThis, string table, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetRecord(string table)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_GetRecord_08(base.GetCppThis(), table, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSQLDatabase_GetTables_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetTables()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_GetTables_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkSQLDatabase_HasError_10(HandleRef pThis);

		public virtual bool HasError()
		{
			return vtkSQLDatabase.vtkSQLDatabase_HasError_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabase_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabase_IsOpen_12(HandleRef pThis);

		public virtual bool IsOpen()
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsOpen_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabase_IsSupported_13(HandleRef pThis, int arg0);

		public virtual bool IsSupported(int arg0)
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsSupported_13(base.GetCppThis(), arg0) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLDatabase_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabase.vtkSQLDatabase_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLDatabase NewInstance()
		{
			vtkSQLDatabase result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabase_Open_16(HandleRef pThis, string password);

		public virtual bool Open(string password)
		{
			return vtkSQLDatabase.vtkSQLDatabase_Open_16(base.GetCppThis(), password) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLDatabase_RegisterCreateFromURLCallback_17(vtkSQLDatabase.CreateFunction callback);

		public static void RegisterCreateFromURLCallback(vtkSQLDatabase.CreateFunction callback)
		{
			vtkSQLDatabase.vtkSQLDatabase_RegisterCreateFromURLCallback_17(callback);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabase_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabase SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabase.vtkSQLDatabase_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabase = (vtkSQLDatabase)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabase.Register(null);
				}
			}
			return vtkSQLDatabase;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLDatabase_UnRegisterAllCreateFromURLCallbacks_19();

		public static void UnRegisterAllCreateFromURLCallbacks()
		{
			vtkSQLDatabase.vtkSQLDatabase_UnRegisterAllCreateFromURLCallbacks_19();
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSQLDatabase_UnRegisterCreateFromURLCallback_20(vtkSQLDatabase.CreateFunction callback);

		public static void UnRegisterCreateFromURLCallback(vtkSQLDatabase.CreateFunction callback)
		{
			vtkSQLDatabase.vtkSQLDatabase_UnRegisterCreateFromURLCallback_20(callback);
		}
	}
}
