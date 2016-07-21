using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTubeFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTubeFilter";

		public new static readonly string MRClassNameKey;

		static vtkTubeFilter()
		{
			vtkTubeFilter.MRClassNameKey = "class vtkTubeFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTubeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTubeFilter"));
		}

		public vtkTubeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTubeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTubeFilter New()
		{
			vtkTubeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTubeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTubeFilter.vtkTubeFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkTubeFilter.vtkTubeFilter_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkTubeFilter.vtkTubeFilter_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetCapping_03(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkTubeFilter.vtkTubeFilter_GetCapping_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTubeFilter_GetDefaultNormal_04(HandleRef pThis);

		public virtual double[] GetDefaultNormal()
		{
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_GetDefaultNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_GetDefaultNormal_05(HandleRef pThis, IntPtr data);

		public virtual void GetDefaultNormal(IntPtr data)
		{
			vtkTubeFilter.vtkTubeFilter_GetDefaultNormal_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetGenerateTCoords_06(HandleRef pThis);

		public virtual int GetGenerateTCoords()
		{
			return vtkTubeFilter.vtkTubeFilter_GetGenerateTCoords_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTubeFilter_GetGenerateTCoordsAsString_07(HandleRef pThis);

		public string GetGenerateTCoordsAsString()
		{
			return Marshal.PtrToStringAnsi(vtkTubeFilter.vtkTubeFilter_GetGenerateTCoordsAsString_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetGenerateTCoordsMaxValue_08(HandleRef pThis);

		public virtual int GetGenerateTCoordsMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetGenerateTCoordsMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetGenerateTCoordsMinValue_09(HandleRef pThis);

		public virtual int GetGenerateTCoordsMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetGenerateTCoordsMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetNumberOfSides_10(HandleRef pThis);

		public virtual int GetNumberOfSides()
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfSides_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetNumberOfSidesMaxValue_11(HandleRef pThis);

		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfSidesMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetNumberOfSidesMinValue_12(HandleRef pThis);

		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetNumberOfSidesMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetOffset_13(HandleRef pThis);

		public virtual int GetOffset()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOffset_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetOffsetMaxValue_14(HandleRef pThis);

		public virtual int GetOffsetMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOffsetMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetOffsetMinValue_15(HandleRef pThis);

		public virtual int GetOffsetMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOffsetMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetOnRatio_16(HandleRef pThis);

		public virtual int GetOnRatio()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOnRatio_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetOnRatioMaxValue_17(HandleRef pThis);

		public virtual int GetOnRatioMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOnRatioMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetOnRatioMinValue_18(HandleRef pThis);

		public virtual int GetOnRatioMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetOnRatioMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetRadius_19(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadius_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetRadiusFactor_20(HandleRef pThis);

		public virtual double GetRadiusFactor()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadiusFactor_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetRadiusMaxValue_21(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadiusMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetRadiusMinValue_22(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetRadiusMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetSidesShareVertices_23(HandleRef pThis);

		public virtual int GetSidesShareVertices()
		{
			return vtkTubeFilter.vtkTubeFilter_GetSidesShareVertices_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetTextureLength_24(HandleRef pThis);

		public virtual double GetTextureLength()
		{
			return vtkTubeFilter.vtkTubeFilter_GetTextureLength_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetTextureLengthMaxValue_25(HandleRef pThis);

		public virtual double GetTextureLengthMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetTextureLengthMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkTubeFilter_GetTextureLengthMinValue_26(HandleRef pThis);

		public virtual double GetTextureLengthMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetTextureLengthMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetUseDefaultNormal_27(HandleRef pThis);

		public virtual int GetUseDefaultNormal()
		{
			return vtkTubeFilter.vtkTubeFilter_GetUseDefaultNormal_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetVaryRadius_28(HandleRef pThis);

		public virtual int GetVaryRadius()
		{
			return vtkTubeFilter.vtkTubeFilter_GetVaryRadius_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTubeFilter_GetVaryRadiusAsString_29(HandleRef pThis);

		public string GetVaryRadiusAsString()
		{
			return Marshal.PtrToStringAnsi(vtkTubeFilter.vtkTubeFilter_GetVaryRadiusAsString_29(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetVaryRadiusMaxValue_30(HandleRef pThis);

		public virtual int GetVaryRadiusMaxValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetVaryRadiusMaxValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_GetVaryRadiusMinValue_31(HandleRef pThis);

		public virtual int GetVaryRadiusMinValue()
		{
			return vtkTubeFilter.vtkTubeFilter_GetVaryRadiusMinValue_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_IsA_32(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTubeFilter.vtkTubeFilter_IsA_32(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTubeFilter_IsTypeOf_33(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTubeFilter.vtkTubeFilter_IsTypeOf_33(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTubeFilter_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTubeFilter NewInstance()
		{
			vtkTubeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTubeFilter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTubeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTubeFilter vtkTubeFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTubeFilter.vtkTubeFilter_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTubeFilter = (vtkTubeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTubeFilter.Register(null);
				}
			}
			return vtkTubeFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetCapping_37(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetCapping_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetDefaultNormal_38(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDefaultNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkTubeFilter.vtkTubeFilter_SetDefaultNormal_38(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetDefaultNormal_39(HandleRef pThis, IntPtr _arg);

		public virtual void SetDefaultNormal(IntPtr _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetDefaultNormal_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetGenerateTCoords_40(HandleRef pThis, int _arg);

		public virtual void SetGenerateTCoords(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoords_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToNormalizedLength_41(HandleRef pThis);

		public void SetGenerateTCoordsToNormalizedLength()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToNormalizedLength_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToOff_42(HandleRef pThis);

		public void SetGenerateTCoordsToOff()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToUseLength_43(HandleRef pThis);

		public void SetGenerateTCoordsToUseLength()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToUseLength_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetGenerateTCoordsToUseScalars_44(HandleRef pThis);

		public void SetGenerateTCoordsToUseScalars()
		{
			vtkTubeFilter.vtkTubeFilter_SetGenerateTCoordsToUseScalars_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetNumberOfSides_45(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSides(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetNumberOfSides_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetOffset_46(HandleRef pThis, int _arg);

		public virtual void SetOffset(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetOffset_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetOnRatio_47(HandleRef pThis, int _arg);

		public virtual void SetOnRatio(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetOnRatio_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetRadius_48(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetRadius_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetRadiusFactor_49(HandleRef pThis, double _arg);

		public virtual void SetRadiusFactor(double _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetRadiusFactor_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetSidesShareVertices_50(HandleRef pThis, int _arg);

		public virtual void SetSidesShareVertices(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetSidesShareVertices_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetTextureLength_51(HandleRef pThis, double _arg);

		public virtual void SetTextureLength(double _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetTextureLength_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetUseDefaultNormal_52(HandleRef pThis, int _arg);

		public virtual void SetUseDefaultNormal(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetUseDefaultNormal_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetVaryRadius_53(HandleRef pThis, int _arg);

		public virtual void SetVaryRadius(int _arg)
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadius_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByAbsoluteScalar_54(HandleRef pThis);

		public void SetVaryRadiusToVaryRadiusByAbsoluteScalar()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByAbsoluteScalar_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByScalar_55(HandleRef pThis);

		public void SetVaryRadiusToVaryRadiusByScalar()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByScalar_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusByVector_56(HandleRef pThis);

		public void SetVaryRadiusToVaryRadiusByVector()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusByVector_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SetVaryRadiusToVaryRadiusOff_57(HandleRef pThis);

		public void SetVaryRadiusToVaryRadiusOff()
		{
			vtkTubeFilter.vtkTubeFilter_SetVaryRadiusToVaryRadiusOff_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SidesShareVerticesOff_58(HandleRef pThis);

		public virtual void SidesShareVerticesOff()
		{
			vtkTubeFilter.vtkTubeFilter_SidesShareVerticesOff_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_SidesShareVerticesOn_59(HandleRef pThis);

		public virtual void SidesShareVerticesOn()
		{
			vtkTubeFilter.vtkTubeFilter_SidesShareVerticesOn_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_UseDefaultNormalOff_60(HandleRef pThis);

		public virtual void UseDefaultNormalOff()
		{
			vtkTubeFilter.vtkTubeFilter_UseDefaultNormalOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTubeFilter_UseDefaultNormalOn_61(HandleRef pThis);

		public virtual void UseDefaultNormalOn()
		{
			vtkTubeFilter.vtkTubeFilter_UseDefaultNormalOn_61(base.GetCppThis());
		}
	}
}
