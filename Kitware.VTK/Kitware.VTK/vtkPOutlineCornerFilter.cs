using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPOutlineCornerFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOutlineCornerFilter";

		public new static readonly string MRClassNameKey;

		static vtkPOutlineCornerFilter()
		{
			vtkPOutlineCornerFilter.MRClassNameKey = "class vtkPOutlineCornerFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOutlineCornerFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOutlineCornerFilter"));
		}

		public vtkPOutlineCornerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOutlineCornerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOutlineCornerFilter New()
		{
			vtkPOutlineCornerFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPOutlineCornerFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOutlineCornerFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkPOutlineCornerFilter_GetCornerFactor_02(HandleRef pThis);

		public virtual double GetCornerFactor()
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetCornerFactor_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkPOutlineCornerFilter_GetCornerFactorMaxValue_03(HandleRef pThis);

		public virtual double GetCornerFactorMaxValue()
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetCornerFactorMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkPOutlineCornerFilter_GetCornerFactorMinValue_04(HandleRef pThis);

		public virtual double GetCornerFactorMinValue()
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_GetCornerFactorMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOutlineCornerFilter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOutlineCornerFilter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOutlineCornerFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPOutlineCornerFilter NewInstance()
		{
			vtkPOutlineCornerFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOutlineCornerFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOutlineCornerFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPOutlineCornerFilter vtkPOutlineCornerFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOutlineCornerFilter = (vtkPOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOutlineCornerFilter.Register(null);
				}
			}
			return vtkPOutlineCornerFilter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOutlineCornerFilter_SetController_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_SetController_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOutlineCornerFilter_SetCornerFactor_11(HandleRef pThis, double _arg);

		public virtual void SetCornerFactor(double _arg)
		{
			vtkPOutlineCornerFilter.vtkPOutlineCornerFilter_SetCornerFactor_11(base.GetCppThis(), _arg);
		}
	}
}
