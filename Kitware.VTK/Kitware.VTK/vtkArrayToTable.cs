using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrayToTable : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayToTable";

		public new static readonly string MRClassNameKey;

		static vtkArrayToTable()
		{
			vtkArrayToTable.MRClassNameKey = "class vtkArrayToTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayToTable"));
		}

		public vtkArrayToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayToTable New()
		{
			vtkArrayToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayToTable.vtkArrayToTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrayToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrayToTable.vtkArrayToTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayToTable_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayToTable.vtkArrayToTable_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkArrayToTable_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayToTable.vtkArrayToTable_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayToTable_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayToTable NewInstance()
		{
			vtkArrayToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayToTable.vtkArrayToTable_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayToTable_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayToTable SafeDownCast(vtkObjectBase o)
		{
			vtkArrayToTable vtkArrayToTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayToTable.vtkArrayToTable_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayToTable = (vtkArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayToTable.Register(null);
				}
			}
			return vtkArrayToTable;
		}
	}
}
