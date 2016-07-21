using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOutlineCornerFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineCornerFilter";

		public new static readonly string MRClassNameKey;

		static vtkOutlineCornerFilter()
		{
			vtkOutlineCornerFilter.MRClassNameKey = "class vtkOutlineCornerFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutlineCornerFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineCornerFilter"));
		}

		public vtkOutlineCornerFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineCornerFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineCornerFilter New()
		{
			vtkOutlineCornerFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineCornerFilter.vtkOutlineCornerFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOutlineCornerFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOutlineCornerFilter.vtkOutlineCornerFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkOutlineCornerFilter_GetCornerFactor_01(HandleRef pThis);

		public virtual double GetCornerFactor()
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetCornerFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkOutlineCornerFilter_GetCornerFactorMaxValue_02(HandleRef pThis);

		public virtual double GetCornerFactorMaxValue()
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetCornerFactorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkOutlineCornerFilter_GetCornerFactorMinValue_03(HandleRef pThis);

		public virtual double GetCornerFactorMinValue()
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_GetCornerFactorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineCornerFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOutlineCornerFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOutlineCornerFilter.vtkOutlineCornerFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineCornerFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOutlineCornerFilter NewInstance()
		{
			vtkOutlineCornerFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineCornerFilter.vtkOutlineCornerFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOutlineCornerFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutlineCornerFilter SafeDownCast(vtkObjectBase o)
		{
			vtkOutlineCornerFilter vtkOutlineCornerFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutlineCornerFilter.vtkOutlineCornerFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutlineCornerFilter = (vtkOutlineCornerFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutlineCornerFilter.Register(null);
				}
			}
			return vtkOutlineCornerFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOutlineCornerFilter_SetCornerFactor_09(HandleRef pThis, double _arg);

		public virtual void SetCornerFactor(double _arg)
		{
			vtkOutlineCornerFilter.vtkOutlineCornerFilter_SetCornerFactor_09(base.GetCppThis(), _arg);
		}
	}
}
