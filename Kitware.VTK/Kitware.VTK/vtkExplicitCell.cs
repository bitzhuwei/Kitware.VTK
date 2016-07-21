using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkExplicitCell : vtkNonLinearCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitCell";

		public new static readonly string MRClassNameKey;

		static vtkExplicitCell()
		{
			vtkExplicitCell.MRClassNameKey = "class vtkExplicitCell";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExplicitCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitCell"));
		}

		public vtkExplicitCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkExplicitCell_GetCellId_01(HandleRef pThis);

		public virtual long GetCellId()
		{
			return vtkExplicitCell.vtkExplicitCell_GetCellId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExplicitCell_GetDataSet_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExplicitCell.vtkExplicitCell_GetDataSet_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExplicitCell_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExplicitCell.vtkExplicitCell_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExplicitCell_IsExplicitCell_04(HandleRef pThis);

		public override int IsExplicitCell()
		{
			return vtkExplicitCell.vtkExplicitCell_IsExplicitCell_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkExplicitCell_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExplicitCell.vtkExplicitCell_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExplicitCell_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExplicitCell NewInstance()
		{
			vtkExplicitCell result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExplicitCell.vtkExplicitCell_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkExplicitCell_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExplicitCell SafeDownCast(vtkObjectBase o)
		{
			vtkExplicitCell vtkExplicitCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExplicitCell.vtkExplicitCell_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitCell = (vtkExplicitCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitCell.Register(null);
				}
			}
			return vtkExplicitCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExplicitCell_SetCellId_08(HandleRef pThis, long _arg);

		public virtual void SetCellId(long _arg)
		{
			vtkExplicitCell.vtkExplicitCell_SetCellId_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkExplicitCell_SetDataSet_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkExplicitCell.vtkExplicitCell_SetDataSet_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
