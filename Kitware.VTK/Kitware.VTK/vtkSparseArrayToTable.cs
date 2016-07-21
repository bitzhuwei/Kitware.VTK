using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSparseArrayToTable : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSparseArrayToTable";

		public new static readonly string MRClassNameKey;

		static vtkSparseArrayToTable()
		{
			vtkSparseArrayToTable.MRClassNameKey = "class vtkSparseArrayToTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSparseArrayToTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSparseArrayToTable"));
		}

		public vtkSparseArrayToTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSparseArrayToTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSparseArrayToTable New()
		{
			vtkSparseArrayToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSparseArrayToTable.vtkSparseArrayToTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSparseArrayToTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSparseArrayToTable.vtkSparseArrayToTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSparseArrayToTable_GetValueColumn_01(HandleRef pThis);

		public virtual string GetValueColumn()
		{
			return Marshal.PtrToStringAnsi(vtkSparseArrayToTable.vtkSparseArrayToTable_GetValueColumn_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSparseArrayToTable_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSparseArrayToTable.vtkSparseArrayToTable_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSparseArrayToTable_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSparseArrayToTable.vtkSparseArrayToTable_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSparseArrayToTable_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSparseArrayToTable NewInstance()
		{
			vtkSparseArrayToTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSparseArrayToTable.vtkSparseArrayToTable_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSparseArrayToTable_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSparseArrayToTable SafeDownCast(vtkObjectBase o)
		{
			vtkSparseArrayToTable vtkSparseArrayToTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSparseArrayToTable.vtkSparseArrayToTable_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSparseArrayToTable = (vtkSparseArrayToTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSparseArrayToTable.Register(null);
				}
			}
			return vtkSparseArrayToTable;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSparseArrayToTable_SetValueColumn_07(HandleRef pThis, string _arg);

		public virtual void SetValueColumn(string _arg)
		{
			vtkSparseArrayToTable.vtkSparseArrayToTable_SetValueColumn_07(base.GetCppThis(), _arg);
		}
	}
}
