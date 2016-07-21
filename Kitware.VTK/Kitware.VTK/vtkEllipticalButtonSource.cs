using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEllipticalButtonSource : vtkButtonSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEllipticalButtonSource";

		public new static readonly string MRClassNameKey;

		static vtkEllipticalButtonSource()
		{
			vtkEllipticalButtonSource.MRClassNameKey = "class vtkEllipticalButtonSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEllipticalButtonSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipticalButtonSource"));
		}

		public vtkEllipticalButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEllipticalButtonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEllipticalButtonSource New()
		{
			vtkEllipticalButtonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEllipticalButtonSource.vtkEllipticalButtonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEllipticalButtonSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEllipticalButtonSource.vtkEllipticalButtonSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolution_01(HandleRef pThis);

		public virtual int GetCircumferentialResolution()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetCircumferentialResolution_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

		public virtual int GetCircumferentialResolutionMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetCircumferentialResolutionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

		public virtual int GetCircumferentialResolutionMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetCircumferentialResolutionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetDepth_04(HandleRef pThis);

		public virtual double GetDepth()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetDepth_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetDepthMaxValue_05(HandleRef pThis);

		public virtual double GetDepthMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetDepthMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetDepthMinValue_06(HandleRef pThis);

		public virtual double GetDepthMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetDepthMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetHeight_07(HandleRef pThis);

		public virtual double GetHeight()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetHeight_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetHeightMaxValue_08(HandleRef pThis);

		public virtual double GetHeightMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetHeightMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetHeightMinValue_09(HandleRef pThis);

		public virtual double GetHeightMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetHeightMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetRadialRatio_10(HandleRef pThis);

		public virtual double GetRadialRatio()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetRadialRatio_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetRadialRatioMaxValue_11(HandleRef pThis);

		public virtual double GetRadialRatioMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetRadialRatioMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetRadialRatioMinValue_12(HandleRef pThis);

		public virtual double GetRadialRatioMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetRadialRatioMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetShoulderResolution_13(HandleRef pThis);

		public virtual int GetShoulderResolution()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetShoulderResolution_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetShoulderResolutionMaxValue_14(HandleRef pThis);

		public virtual int GetShoulderResolutionMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetShoulderResolutionMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetShoulderResolutionMinValue_15(HandleRef pThis);

		public virtual int GetShoulderResolutionMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetShoulderResolutionMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetTextureResolution_16(HandleRef pThis);

		public virtual int GetTextureResolution()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetTextureResolution_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetTextureResolutionMaxValue_17(HandleRef pThis);

		public virtual int GetTextureResolutionMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetTextureResolutionMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_GetTextureResolutionMinValue_18(HandleRef pThis);

		public virtual int GetTextureResolutionMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetTextureResolutionMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetWidth_19(HandleRef pThis);

		public virtual double GetWidth()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetWidth_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetWidthMaxValue_20(HandleRef pThis);

		public virtual double GetWidthMaxValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetWidthMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkEllipticalButtonSource_GetWidthMinValue_21(HandleRef pThis);

		public virtual double GetWidthMinValue()
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_GetWidthMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkEllipticalButtonSource_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEllipticalButtonSource.vtkEllipticalButtonSource_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEllipticalButtonSource_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEllipticalButtonSource NewInstance()
		{
			vtkEllipticalButtonSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEllipticalButtonSource.vtkEllipticalButtonSource_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkEllipticalButtonSource_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEllipticalButtonSource SafeDownCast(vtkObjectBase o)
		{
			vtkEllipticalButtonSource vtkEllipticalButtonSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEllipticalButtonSource.vtkEllipticalButtonSource_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEllipticalButtonSource = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEllipticalButtonSource.Register(null);
				}
			}
			return vtkEllipticalButtonSource;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetCircumferentialResolution_27(HandleRef pThis, int _arg);

		public virtual void SetCircumferentialResolution(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetCircumferentialResolution_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetDepth_28(HandleRef pThis, double _arg);

		public virtual void SetDepth(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetDepth_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetHeight_29(HandleRef pThis, double _arg);

		public virtual void SetHeight(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetHeight_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetRadialRatio_30(HandleRef pThis, double _arg);

		public virtual void SetRadialRatio(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetRadialRatio_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetShoulderResolution_31(HandleRef pThis, int _arg);

		public virtual void SetShoulderResolution(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetShoulderResolution_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetTextureResolution_32(HandleRef pThis, int _arg);

		public virtual void SetTextureResolution(int _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetTextureResolution_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkEllipticalButtonSource_SetWidth_33(HandleRef pThis, double _arg);

		public virtual void SetWidth(double _arg)
		{
			vtkEllipticalButtonSource.vtkEllipticalButtonSource_SetWidth_33(base.GetCppThis(), _arg);
		}
	}
}
