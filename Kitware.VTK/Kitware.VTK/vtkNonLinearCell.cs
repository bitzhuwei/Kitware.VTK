using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkNonLinearCell : vtkCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkNonLinearCell";

		public new static readonly string MRClassNameKey;

		static vtkNonLinearCell()
		{
			vtkNonLinearCell.MRClassNameKey = "class vtkNonLinearCell";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNonLinearCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNonLinearCell"));
		}

		public vtkNonLinearCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkNonLinearCell_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkNonLinearCell.vtkNonLinearCell_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkNonLinearCell_IsLinear_02(HandleRef pThis);

		public override int IsLinear()
		{
			return vtkNonLinearCell.vtkNonLinearCell_IsLinear_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkNonLinearCell_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkNonLinearCell.vtkNonLinearCell_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkNonLinearCell_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkNonLinearCell NewInstance()
		{
			vtkNonLinearCell result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNonLinearCell.vtkNonLinearCell_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNonLinearCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkNonLinearCell_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkNonLinearCell SafeDownCast(vtkObjectBase o)
		{
			vtkNonLinearCell vtkNonLinearCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkNonLinearCell.vtkNonLinearCell_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNonLinearCell = (vtkNonLinearCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNonLinearCell.Register(null);
				}
			}
			return vtkNonLinearCell;
		}
	}
}
