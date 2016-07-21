using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkTableToDatabaseWriter : vtkTableWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToDatabaseWriter";

		public new static readonly string MRClassNameKey;

		static vtkTableToDatabaseWriter()
		{
			vtkTableToDatabaseWriter.MRClassNameKey = "class vtkTableToDatabaseWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToDatabaseWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToDatabaseWriter"));
		}

		public vtkTableToDatabaseWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToDatabaseWriter_GetDatabase_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSQLDatabase GetDatabase()
		{
			vtkSQLDatabase vtkSQLDatabase = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetDatabase_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTableToDatabaseWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToDatabaseWriter_GetInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTable GetInput(int port)
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_GetInput_03(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTableToDatabaseWriter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTableToDatabaseWriter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToDatabaseWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableToDatabaseWriter NewInstance()
		{
			vtkTableToDatabaseWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToDatabaseWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToDatabaseWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToDatabaseWriter SafeDownCast(vtkObjectBase o)
		{
			vtkTableToDatabaseWriter vtkTableToDatabaseWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToDatabaseWriter = (vtkTableToDatabaseWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToDatabaseWriter.Register(null);
				}
			}
			return vtkTableToDatabaseWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTableToDatabaseWriter_SetDatabase_08(HandleRef pThis, HandleRef db);

		public bool SetDatabase(vtkSQLDatabase db)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_SetDatabase_08(base.GetCppThis(), (db == null) ? default(HandleRef) : db.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTableToDatabaseWriter_SetTableName_09(HandleRef pThis, string name);

		public bool SetTableName(string name)
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_SetTableName_09(base.GetCppThis(), name) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkTableToDatabaseWriter_TableNameIsNew_10(HandleRef pThis);

		public bool TableNameIsNew()
		{
			return vtkTableToDatabaseWriter.vtkTableToDatabaseWriter_TableNameIsNew_10(base.GetCppThis()) != 0;
		}
	}
}
