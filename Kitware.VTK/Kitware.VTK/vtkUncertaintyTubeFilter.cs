using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUncertaintyTubeFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUncertaintyTubeFilter";

		public new static readonly string MRClassNameKey;

		static vtkUncertaintyTubeFilter()
		{
			vtkUncertaintyTubeFilter.MRClassNameKey = "class vtkUncertaintyTubeFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUncertaintyTubeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUncertaintyTubeFilter"));
		}

		public vtkUncertaintyTubeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUncertaintyTubeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUncertaintyTubeFilter New()
		{
			vtkUncertaintyTubeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUncertaintyTubeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSides_01(HandleRef pThis);

		public virtual int GetNumberOfSides()
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfSides_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSidesMaxValue_02(HandleRef pThis);

		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfSidesMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUncertaintyTubeFilter_GetNumberOfSidesMinValue_03(HandleRef pThis);

		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_GetNumberOfSidesMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUncertaintyTubeFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUncertaintyTubeFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUncertaintyTubeFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUncertaintyTubeFilter NewInstance()
		{
			vtkUncertaintyTubeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUncertaintyTubeFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUncertaintyTubeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUncertaintyTubeFilter vtkUncertaintyTubeFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUncertaintyTubeFilter = (vtkUncertaintyTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUncertaintyTubeFilter.Register(null);
				}
			}
			return vtkUncertaintyTubeFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUncertaintyTubeFilter_SetNumberOfSides_09(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSides(int _arg)
		{
			vtkUncertaintyTubeFilter.vtkUncertaintyTubeFilter_SetNumberOfSides_09(base.GetCppThis(), _arg);
		}
	}
}
