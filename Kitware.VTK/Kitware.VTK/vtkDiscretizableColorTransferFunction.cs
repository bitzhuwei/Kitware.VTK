using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDiscretizableColorTransferFunction : vtkColorTransferFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscretizableColorTransferFunction";

		public new static readonly string MRClassNameKey;

		static vtkDiscretizableColorTransferFunction()
		{
			vtkDiscretizableColorTransferFunction.MRClassNameKey = "class vtkDiscretizableColorTransferFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscretizableColorTransferFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscretizableColorTransferFunction"));
		}

		public vtkDiscretizableColorTransferFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiscretizableColorTransferFunction New()
		{
			vtkDiscretizableColorTransferFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDiscretizableColorTransferFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_Build_01(HandleRef pThis);

		public override void Build()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_Build_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_DiscretizeOff_02(HandleRef pThis);

		public virtual void DiscretizeOff()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_DiscretizeOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_DiscretizeOn_03(HandleRef pThis);

		public virtual void DiscretizeOn()
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_DiscretizeOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_GetColor_04(HandleRef pThis, double v, IntPtr rgb);

		public override void GetColor(double v, IntPtr rgb)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetColor_04(base.GetCppThis(), v, rgb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDiscretizableColorTransferFunction_GetDiscretize_05(HandleRef pThis);

		public virtual int GetDiscretize()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetDiscretize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfAvailableColors_06(HandleRef pThis);

		public override long GetNumberOfAvailableColors()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfAvailableColors_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkDiscretizableColorTransferFunction_GetNumberOfValues_07(HandleRef pThis);

		public virtual long GetNumberOfValues()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetNumberOfValues_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_GetRGBPoints_08(HandleRef pThis);

		public IntPtr GetRGBPoints()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetRGBPoints_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDiscretizableColorTransferFunction_GetUseLogScale_09(HandleRef pThis);

		public virtual int GetUseLogScale()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_GetUseLogScale_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDiscretizableColorTransferFunction_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDiscretizableColorTransferFunction_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_MapScalars_12(HandleRef pThis, HandleRef scalars, int colorMode, int component, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkUnsignedCharArray MapScalars(vtkDataArray scalars, int colorMode, int component)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_MapScalars_12(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), colorMode, component, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_MapValue_13(HandleRef pThis, double v);

		public override IntPtr MapValue(double v)
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_MapValue_13(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDiscretizableColorTransferFunction NewInstance()
		{
			vtkDiscretizableColorTransferFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDiscretizableColorTransferFunction_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDiscretizableColorTransferFunction SafeDownCast(vtkObjectBase o)
		{
			vtkDiscretizableColorTransferFunction vtkDiscretizableColorTransferFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscretizableColorTransferFunction = (vtkDiscretizableColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscretizableColorTransferFunction.Register(null);
				}
			}
			return vtkDiscretizableColorTransferFunction;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_SetAlpha_17(HandleRef pThis, double alpha);

		public override void SetAlpha(double alpha)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetAlpha_17(base.GetCppThis(), alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_SetDiscretize_18(HandleRef pThis, int _arg);

		public virtual void SetDiscretize(int _arg)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetDiscretize_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNanColor_19(HandleRef pThis, double r, double g, double b);

		public override void SetNanColor(double r, double g, double b)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNanColor_19(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNanColor_20(HandleRef pThis, IntPtr rgb);

		public override void SetNanColor(IntPtr rgb)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNanColor_20(base.GetCppThis(), rgb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_SetNumberOfValues_21(HandleRef pThis, long number);

		public void SetNumberOfValues(long number)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetNumberOfValues_21(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDiscretizableColorTransferFunction_SetUseLogScale_22(HandleRef pThis, int useLogScale);

		public virtual void SetUseLogScale(int useLogScale)
		{
			vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_SetUseLogScale_22(base.GetCppThis(), useLogScale);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDiscretizableColorTransferFunction_UsingLogScale_23(HandleRef pThis);

		public override int UsingLogScale()
		{
			return vtkDiscretizableColorTransferFunction.vtkDiscretizableColorTransferFunction_UsingLogScale_23(base.GetCppThis());
		}
	}
}
