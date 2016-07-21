using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTensorGlyph : vtkPolyDataAlgorithm
	{
		public enum COLOR_BY_EIGENVALUES_WrapperEnum
		{
			COLOR_BY_EIGENVALUES = 1,
			COLOR_BY_SCALARS = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTensorGlyph";

		public new static readonly string MRClassNameKey;

		static vtkTensorGlyph()
		{
			vtkTensorGlyph.MRClassNameKey = "class vtkTensorGlyph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTensorGlyph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTensorGlyph"));
		}

		public vtkTensorGlyph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorGlyph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTensorGlyph New()
		{
			vtkTensorGlyph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTensorGlyph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTensorGlyph.vtkTensorGlyph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ClampScalingOff_01(HandleRef pThis);

		public virtual void ClampScalingOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ClampScalingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ClampScalingOn_02(HandleRef pThis);

		public virtual void ClampScalingOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ClampScalingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ColorGlyphsOff_03(HandleRef pThis);

		public virtual void ColorGlyphsOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ColorGlyphsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ColorGlyphsOn_04(HandleRef pThis);

		public virtual void ColorGlyphsOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ColorGlyphsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ExtractEigenvaluesOff_05(HandleRef pThis);

		public virtual void ExtractEigenvaluesOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ExtractEigenvaluesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ExtractEigenvaluesOn_06(HandleRef pThis);

		public virtual void ExtractEigenvaluesOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ExtractEigenvaluesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetClampScaling_07(HandleRef pThis);

		public virtual int GetClampScaling()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetClampScaling_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetColorGlyphs_08(HandleRef pThis);

		public virtual int GetColorGlyphs()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorGlyphs_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetColorMode_09(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorMode_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetColorModeMaxValue_10(HandleRef pThis);

		public virtual int GetColorModeMaxValue()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorModeMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetColorModeMinValue_11(HandleRef pThis);

		public virtual int GetColorModeMinValue()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetColorModeMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetExtractEigenvalues_12(HandleRef pThis);

		public virtual int GetExtractEigenvalues()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetExtractEigenvalues_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTensorGlyph_GetLength_13(HandleRef pThis);

		public virtual double GetLength()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetLength_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTensorGlyph_GetMaxScaleFactor_14(HandleRef pThis);

		public virtual double GetMaxScaleFactor()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetMaxScaleFactor_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTensorGlyph_GetScaleFactor_15(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetScaleFactor_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetScaling_16(HandleRef pThis);

		public virtual int GetScaling()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetScaling_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorGlyph_GetSource_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_GetSource_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetSymmetric_18(HandleRef pThis);

		public virtual int GetSymmetric()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetSymmetric_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_GetThreeGlyphs_19(HandleRef pThis);

		public virtual int GetThreeGlyphs()
		{
			return vtkTensorGlyph.vtkTensorGlyph_GetThreeGlyphs_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTensorGlyph.vtkTensorGlyph_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTensorGlyph_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTensorGlyph.vtkTensorGlyph_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorGlyph_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTensorGlyph NewInstance()
		{
			vtkTensorGlyph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTensorGlyph_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTensorGlyph SafeDownCast(vtkObjectBase o)
		{
			vtkTensorGlyph vtkTensorGlyph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTensorGlyph.vtkTensorGlyph_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTensorGlyph = (vtkTensorGlyph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTensorGlyph.Register(null);
				}
			}
			return vtkTensorGlyph;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ScalingOff_25(HandleRef pThis);

		public virtual void ScalingOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ScalingOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ScalingOn_26(HandleRef pThis);

		public virtual void ScalingOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ScalingOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetClampScaling_27(HandleRef pThis, int _arg);

		public virtual void SetClampScaling(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetClampScaling_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetColorGlyphs_28(HandleRef pThis, int _arg);

		public virtual void SetColorGlyphs(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorGlyphs_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetColorMode_29(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorMode_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetColorModeToEigenvalues_30(HandleRef pThis);

		public void SetColorModeToEigenvalues()
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorModeToEigenvalues_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetColorModeToScalars_31(HandleRef pThis);

		public void SetColorModeToScalars()
		{
			vtkTensorGlyph.vtkTensorGlyph_SetColorModeToScalars_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetExtractEigenvalues_32(HandleRef pThis, int _arg);

		public virtual void SetExtractEigenvalues(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetExtractEigenvalues_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetLength_33(HandleRef pThis, double _arg);

		public virtual void SetLength(double _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetLength_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetMaxScaleFactor_34(HandleRef pThis, double _arg);

		public virtual void SetMaxScaleFactor(double _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetMaxScaleFactor_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetScaleFactor_35(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetScaleFactor_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetScaling_36(HandleRef pThis, int _arg);

		public virtual void SetScaling(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetScaling_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetSource_37(HandleRef pThis, HandleRef source);

		public void SetSource(vtkPolyData source)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSource_37(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetSourceConnection_38(HandleRef pThis, int id, HandleRef algOutput);

		public void SetSourceConnection(int id, vtkAlgorithmOutput algOutput)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSourceConnection_38(base.GetCppThis(), id, (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetSourceConnection_39(HandleRef pThis, HandleRef algOutput);

		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSourceConnection_39(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetSymmetric_40(HandleRef pThis, int _arg);

		public virtual void SetSymmetric(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetSymmetric_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SetThreeGlyphs_41(HandleRef pThis, int _arg);

		public virtual void SetThreeGlyphs(int _arg)
		{
			vtkTensorGlyph.vtkTensorGlyph_SetThreeGlyphs_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SymmetricOff_42(HandleRef pThis);

		public virtual void SymmetricOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_SymmetricOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_SymmetricOn_43(HandleRef pThis);

		public virtual void SymmetricOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_SymmetricOn_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ThreeGlyphsOff_44(HandleRef pThis);

		public virtual void ThreeGlyphsOff()
		{
			vtkTensorGlyph.vtkTensorGlyph_ThreeGlyphsOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTensorGlyph_ThreeGlyphsOn_45(HandleRef pThis);

		public virtual void ThreeGlyphsOn()
		{
			vtkTensorGlyph.vtkTensorGlyph_ThreeGlyphsOn_45(base.GetCppThis());
		}
	}
}
