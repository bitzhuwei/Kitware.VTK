using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLiteToTableReader : vtkDatabaseToTableReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteToTableReader";

		public new static readonly string MRClassNameKey;

		static vtkSQLiteToTableReader()
		{
			vtkSQLiteToTableReader.MRClassNameKey = "class vtkSQLiteToTableReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLiteToTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteToTableReader"));
		}

		public vtkSQLiteToTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteToTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLiteToTableReader New()
		{
			vtkSQLiteToTableReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteToTableReader.vtkSQLiteToTableReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLiteToTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLiteToTableReader.vtkSQLiteToTableReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteToTableReader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLiteToTableReader.vtkSQLiteToTableReader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSQLiteToTableReader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLiteToTableReader.vtkSQLiteToTableReader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteToTableReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLiteToTableReader NewInstance()
		{
			vtkSQLiteToTableReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteToTableReader.vtkSQLiteToTableReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLiteToTableReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLiteToTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkSQLiteToTableReader vtkSQLiteToTableReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLiteToTableReader.vtkSQLiteToTableReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLiteToTableReader = (vtkSQLiteToTableReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLiteToTableReader.Register(null);
				}
			}
			return vtkSQLiteToTableReader;
		}
	}
}
