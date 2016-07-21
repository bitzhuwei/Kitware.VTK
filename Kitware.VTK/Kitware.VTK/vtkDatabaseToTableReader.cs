using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDatabaseToTableReader : vtkTableReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDatabaseToTableReader";

		public new static readonly string MRClassNameKey;

		static vtkDatabaseToTableReader()
		{
			vtkDatabaseToTableReader.MRClassNameKey = "class vtkDatabaseToTableReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDatabaseToTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDatabaseToTableReader"));
		}

		public vtkDatabaseToTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkDatabaseToTableReader_CheckIfTableExists_01(HandleRef pThis);

		public bool CheckIfTableExists()
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_CheckIfTableExists_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDatabaseToTableReader_GetDatabase_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSQLDatabase GetDatabase()
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDatabaseToTableReader.vtkDatabaseToTableReader_GetDatabase_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDatabaseToTableReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDatabaseToTableReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDatabaseToTableReader_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDatabaseToTableReader NewInstance()
		{
			vtkDatabaseToTableReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDatabaseToTableReader.vtkDatabaseToTableReader_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDatabaseToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDatabaseToTableReader_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDatabaseToTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkDatabaseToTableReader vtkDatabaseToTableReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDatabaseToTableReader.vtkDatabaseToTableReader_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDatabaseToTableReader = (vtkDatabaseToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDatabaseToTableReader.Register(null);
				}
			}
			return vtkDatabaseToTableReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkDatabaseToTableReader_SetDatabase_07(HandleRef pThis, HandleRef db);

		public bool SetDatabase(vtkSQLDatabase db)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_SetDatabase_07(base.GetCppThis(), (db == null) ? default(HandleRef) : db.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkDatabaseToTableReader_SetTableName_08(HandleRef pThis, string name);

		public bool SetTableName(string name)
		{
			return vtkDatabaseToTableReader.vtkDatabaseToTableReader_SetTableName_08(base.GetCppThis(), name) != 0;
		}
	}
}
