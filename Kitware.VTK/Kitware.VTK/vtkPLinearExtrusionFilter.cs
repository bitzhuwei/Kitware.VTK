using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPLinearExtrusionFilter : vtkLinearExtrusionFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPLinearExtrusionFilter";

		public new static readonly string MRClassNameKey;

		static vtkPLinearExtrusionFilter()
		{
			vtkPLinearExtrusionFilter.MRClassNameKey = "class vtkPLinearExtrusionFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLinearExtrusionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLinearExtrusionFilter"));
		}

		public vtkPLinearExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPLinearExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLinearExtrusionFilter New()
		{
			vtkPLinearExtrusionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPLinearExtrusionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPLinearExtrusionFilter_GetPieceInvariant_01(HandleRef pThis);

		public virtual int GetPieceInvariant()
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_GetPieceInvariant_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPLinearExtrusionFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPLinearExtrusionFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPLinearExtrusionFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPLinearExtrusionFilter NewInstance()
		{
			vtkPLinearExtrusionFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPLinearExtrusionFilter_PieceInvariantOff_06(HandleRef pThis);

		public virtual void PieceInvariantOff()
		{
			vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_PieceInvariantOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPLinearExtrusionFilter_PieceInvariantOn_07(HandleRef pThis);

		public virtual void PieceInvariantOn()
		{
			vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_PieceInvariantOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPLinearExtrusionFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLinearExtrusionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPLinearExtrusionFilter vtkPLinearExtrusionFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLinearExtrusionFilter = (vtkPLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLinearExtrusionFilter.Register(null);
				}
			}
			return vtkPLinearExtrusionFilter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPLinearExtrusionFilter_SetPieceInvariant_09(HandleRef pThis, int _arg);

		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_SetPieceInvariant_09(base.GetCppThis(), _arg);
		}
	}
}
