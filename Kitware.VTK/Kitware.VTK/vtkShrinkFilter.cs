using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkShrinkFilter : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShrinkFilter";

		public new static readonly string MRClassNameKey;

		static vtkShrinkFilter()
		{
			vtkShrinkFilter.MRClassNameKey = "class vtkShrinkFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShrinkFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShrinkFilter"));
		}

		public vtkShrinkFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkShrinkFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShrinkFilter New()
		{
			vtkShrinkFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShrinkFilter.vtkShrinkFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkShrinkFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkShrinkFilter.vtkShrinkFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkShrinkFilter_GetShrinkFactor_01(HandleRef pThis);

		public virtual double GetShrinkFactor()
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetShrinkFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkShrinkFilter_GetShrinkFactorMaxValue_02(HandleRef pThis);

		public virtual double GetShrinkFactorMaxValue()
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetShrinkFactorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkShrinkFilter_GetShrinkFactorMinValue_03(HandleRef pThis);

		public virtual double GetShrinkFactorMinValue()
		{
			return vtkShrinkFilter.vtkShrinkFilter_GetShrinkFactorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkShrinkFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShrinkFilter.vtkShrinkFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkShrinkFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShrinkFilter.vtkShrinkFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkShrinkFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShrinkFilter NewInstance()
		{
			vtkShrinkFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShrinkFilter.vtkShrinkFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkShrinkFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShrinkFilter SafeDownCast(vtkObjectBase o)
		{
			vtkShrinkFilter vtkShrinkFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShrinkFilter.vtkShrinkFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShrinkFilter = (vtkShrinkFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShrinkFilter.Register(null);
				}
			}
			return vtkShrinkFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkShrinkFilter_SetShrinkFactor_09(HandleRef pThis, double _arg);

		public virtual void SetShrinkFactor(double _arg)
		{
			vtkShrinkFilter.vtkShrinkFilter_SetShrinkFactor_09(base.GetCppThis(), _arg);
		}
	}
}
