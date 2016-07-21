using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectangularButtonSource : vtkButtonSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectangularButtonSource";

		public new static readonly string MRClassNameKey;

		static vtkRectangularButtonSource()
		{
			vtkRectangularButtonSource.MRClassNameKey = "class vtkRectangularButtonSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectangularButtonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectangularButtonSource"));
		}

		public vtkRectangularButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectangularButtonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectangularButtonSource New()
		{
			vtkRectangularButtonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectangularButtonSource.vtkRectangularButtonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectangularButtonSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectangularButtonSource.vtkRectangularButtonSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetBoxRatio_01(HandleRef pThis);

		public virtual double GetBoxRatio()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetBoxRatio_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetBoxRatioMaxValue_02(HandleRef pThis);

		public virtual double GetBoxRatioMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetBoxRatioMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetBoxRatioMinValue_03(HandleRef pThis);

		public virtual double GetBoxRatioMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetBoxRatioMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetDepth_04(HandleRef pThis);

		public virtual double GetDepth()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetDepth_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetDepthMaxValue_05(HandleRef pThis);

		public virtual double GetDepthMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetDepthMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetDepthMinValue_06(HandleRef pThis);

		public virtual double GetDepthMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetDepthMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetHeight_07(HandleRef pThis);

		public virtual double GetHeight()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetHeight_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetHeightMaxValue_08(HandleRef pThis);

		public virtual double GetHeightMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetHeightMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetHeightMinValue_09(HandleRef pThis);

		public virtual double GetHeightMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetHeightMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetTextureHeightRatio_10(HandleRef pThis);

		public virtual double GetTextureHeightRatio()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureHeightRatio_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetTextureHeightRatioMaxValue_11(HandleRef pThis);

		public virtual double GetTextureHeightRatioMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureHeightRatioMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetTextureHeightRatioMinValue_12(HandleRef pThis);

		public virtual double GetTextureHeightRatioMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureHeightRatioMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetTextureRatio_13(HandleRef pThis);

		public virtual double GetTextureRatio()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureRatio_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetTextureRatioMaxValue_14(HandleRef pThis);

		public virtual double GetTextureRatioMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureRatioMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetTextureRatioMinValue_15(HandleRef pThis);

		public virtual double GetTextureRatioMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetTextureRatioMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetWidth_16(HandleRef pThis);

		public virtual double GetWidth()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetWidth_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetWidthMaxValue_17(HandleRef pThis);

		public virtual double GetWidthMaxValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetWidthMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectangularButtonSource_GetWidthMinValue_18(HandleRef pThis);

		public virtual double GetWidthMinValue()
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_GetWidthMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectangularButtonSource_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectangularButtonSource_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectangularButtonSource.vtkRectangularButtonSource_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectangularButtonSource_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectangularButtonSource NewInstance()
		{
			vtkRectangularButtonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectangularButtonSource.vtkRectangularButtonSource_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectangularButtonSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectangularButtonSource SafeDownCast(vtkObjectBase o)
		{
			vtkRectangularButtonSource vtkRectangularButtonSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectangularButtonSource.vtkRectangularButtonSource_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectangularButtonSource = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectangularButtonSource.Register(null);
				}
			}
			return vtkRectangularButtonSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectangularButtonSource_SetBoxRatio_24(HandleRef pThis, double _arg);

		public virtual void SetBoxRatio(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetBoxRatio_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectangularButtonSource_SetDepth_25(HandleRef pThis, double _arg);

		public virtual void SetDepth(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetDepth_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectangularButtonSource_SetHeight_26(HandleRef pThis, double _arg);

		public virtual void SetHeight(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetHeight_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectangularButtonSource_SetTextureHeightRatio_27(HandleRef pThis, double _arg);

		public virtual void SetTextureHeightRatio(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetTextureHeightRatio_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectangularButtonSource_SetTextureRatio_28(HandleRef pThis, double _arg);

		public virtual void SetTextureRatio(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetTextureRatio_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectangularButtonSource_SetWidth_29(HandleRef pThis, double _arg);

		public virtual void SetWidth(double _arg)
		{
			vtkRectangularButtonSource.vtkRectangularButtonSource_SetWidth_29(base.GetCppThis(), _arg);
		}
	}
}
