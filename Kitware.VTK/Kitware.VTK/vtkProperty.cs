using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProperty : vtkObject
	{
		public enum VTKTextureUnit
		{
			VTK_TEXTURE_UNIT_0,
			VTK_TEXTURE_UNIT_1,
			VTK_TEXTURE_UNIT_2,
			VTK_TEXTURE_UNIT_3,
			VTK_TEXTURE_UNIT_4,
			VTK_TEXTURE_UNIT_5,
			VTK_TEXTURE_UNIT_6,
			VTK_TEXTURE_UNIT_7
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkProperty";

		public new static readonly string MRClassNameKey;

		static vtkProperty()
		{
			vtkProperty.MRClassNameKey = "class vtkProperty";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProperty"));
		}

		public vtkProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProperty New()
		{
			vtkProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProperty.vtkProperty_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_01(HandleRef pThis, string name, int numVars, IntPtr x);

		public virtual void AddShaderVariable(string name, int numVars, IntPtr x)
		{
			vtkProperty.vtkProperty_AddShaderVariable_01(base.GetCppThis(), name, numVars, x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_02(HandleRef pThis, string name, int v);

		public void AddShaderVariable(string name, int v)
		{
			vtkProperty.vtkProperty_AddShaderVariable_02(base.GetCppThis(), name, v);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_03(HandleRef pThis, string name, float v);

		public void AddShaderVariable(string name, float v)
		{
			vtkProperty.vtkProperty_AddShaderVariable_03(base.GetCppThis(), name, v);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_04(HandleRef pThis, string name, double v);

		public void AddShaderVariable(string name, double v)
		{
			vtkProperty.vtkProperty_AddShaderVariable_04(base.GetCppThis(), name, v);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_05(HandleRef pThis, string name, int v1, int v2);

		public void AddShaderVariable(string name, int v1, int v2)
		{
			vtkProperty.vtkProperty_AddShaderVariable_05(base.GetCppThis(), name, v1, v2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_06(HandleRef pThis, string name, float v1, float v2);

		public void AddShaderVariable(string name, float v1, float v2)
		{
			vtkProperty.vtkProperty_AddShaderVariable_06(base.GetCppThis(), name, v1, v2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_07(HandleRef pThis, string name, double v1, double v2);

		public void AddShaderVariable(string name, double v1, double v2)
		{
			vtkProperty.vtkProperty_AddShaderVariable_07(base.GetCppThis(), name, v1, v2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_08(HandleRef pThis, string name, int v1, int v2, int v3);

		public void AddShaderVariable(string name, int v1, int v2, int v3)
		{
			vtkProperty.vtkProperty_AddShaderVariable_08(base.GetCppThis(), name, v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_09(HandleRef pThis, string name, float v1, float v2, float v3);

		public void AddShaderVariable(string name, float v1, float v2, float v3)
		{
			vtkProperty.vtkProperty_AddShaderVariable_09(base.GetCppThis(), name, v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_AddShaderVariable_10(HandleRef pThis, string name, double v1, double v2, double v3);

		public void AddShaderVariable(string name, double v1, double v2, double v3)
		{
			vtkProperty.vtkProperty_AddShaderVariable_10(base.GetCppThis(), name, v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_BackfaceCullingOff_11(HandleRef pThis);

		public virtual void BackfaceCullingOff()
		{
			vtkProperty.vtkProperty_BackfaceCullingOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_BackfaceCullingOn_12(HandleRef pThis);

		public virtual void BackfaceCullingOn()
		{
			vtkProperty.vtkProperty_BackfaceCullingOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_BackfaceRender_13(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void BackfaceRender(vtkActor arg0, vtkRenderer arg1)
		{
			vtkProperty.vtkProperty_BackfaceRender_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_DeepCopy_14(HandleRef pThis, HandleRef p);

		public void DeepCopy(vtkProperty p)
		{
			vtkProperty.vtkProperty_DeepCopy_14(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_EdgeVisibilityOff_15(HandleRef pThis);

		public virtual void EdgeVisibilityOff()
		{
			vtkProperty.vtkProperty_EdgeVisibilityOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_EdgeVisibilityOn_16(HandleRef pThis);

		public virtual void EdgeVisibilityOn()
		{
			vtkProperty.vtkProperty_EdgeVisibilityOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_FrontfaceCullingOff_17(HandleRef pThis);

		public virtual void FrontfaceCullingOff()
		{
			vtkProperty.vtkProperty_FrontfaceCullingOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_FrontfaceCullingOn_18(HandleRef pThis);

		public virtual void FrontfaceCullingOn()
		{
			vtkProperty.vtkProperty_FrontfaceCullingOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetAmbient_19(HandleRef pThis);

		public virtual double GetAmbient()
		{
			return vtkProperty.vtkProperty_GetAmbient_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetAmbientColor_20(HandleRef pThis);

		public virtual double[] GetAmbientColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetAmbientColor_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetAmbientColor_21(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetAmbientColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetAmbientColor_21(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetAmbientColor_22(HandleRef pThis, IntPtr _arg);

		public virtual void GetAmbientColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetAmbientColor_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetAmbientMaxValue_23(HandleRef pThis);

		public virtual double GetAmbientMaxValue()
		{
			return vtkProperty.vtkProperty_GetAmbientMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetAmbientMinValue_24(HandleRef pThis);

		public virtual double GetAmbientMinValue()
		{
			return vtkProperty.vtkProperty_GetAmbientMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetBackfaceCulling_25(HandleRef pThis);

		public virtual int GetBackfaceCulling()
		{
			return vtkProperty.vtkProperty_GetBackfaceCulling_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetColor_26(HandleRef pThis);

		public double[] GetColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetColor_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetColor_27(HandleRef pThis, IntPtr rgb);

		public void GetColor(IntPtr rgb)
		{
			vtkProperty.vtkProperty_GetColor_27(base.GetCppThis(), rgb);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetColor_28(HandleRef pThis, ref double r, ref double g, ref double b);

		public void GetColor(ref double r, ref double g, ref double b)
		{
			vtkProperty.vtkProperty_GetColor_28(base.GetCppThis(), ref r, ref g, ref b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetDiffuse_29(HandleRef pThis);

		public virtual double GetDiffuse()
		{
			return vtkProperty.vtkProperty_GetDiffuse_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetDiffuseColor_30(HandleRef pThis);

		public virtual double[] GetDiffuseColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetDiffuseColor_30(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetDiffuseColor_31(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDiffuseColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetDiffuseColor_31(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetDiffuseColor_32(HandleRef pThis, IntPtr _arg);

		public virtual void GetDiffuseColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetDiffuseColor_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetDiffuseMaxValue_33(HandleRef pThis);

		public virtual double GetDiffuseMaxValue()
		{
			return vtkProperty.vtkProperty_GetDiffuseMaxValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetDiffuseMinValue_34(HandleRef pThis);

		public virtual double GetDiffuseMinValue()
		{
			return vtkProperty.vtkProperty_GetDiffuseMinValue_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetEdgeColor_35(HandleRef pThis);

		public virtual double[] GetEdgeColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetEdgeColor_35(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetEdgeColor_36(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetEdgeColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetEdgeColor_36(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetEdgeColor_37(HandleRef pThis, IntPtr _arg);

		public virtual void GetEdgeColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetEdgeColor_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetEdgeVisibility_38(HandleRef pThis);

		public virtual int GetEdgeVisibility()
		{
			return vtkProperty.vtkProperty_GetEdgeVisibility_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetFrontfaceCulling_39(HandleRef pThis);

		public virtual int GetFrontfaceCulling()
		{
			return vtkProperty.vtkProperty_GetFrontfaceCulling_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetInterpolation_40(HandleRef pThis);

		public virtual int GetInterpolation()
		{
			return vtkProperty.vtkProperty_GetInterpolation_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetInterpolationAsString_41(HandleRef pThis);

		public string GetInterpolationAsString()
		{
			return Marshal.PtrToStringAnsi(vtkProperty.vtkProperty_GetInterpolationAsString_41(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetInterpolationMaxValue_42(HandleRef pThis);

		public virtual int GetInterpolationMaxValue()
		{
			return vtkProperty.vtkProperty_GetInterpolationMaxValue_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetInterpolationMinValue_43(HandleRef pThis);

		public virtual int GetInterpolationMinValue()
		{
			return vtkProperty.vtkProperty_GetInterpolationMinValue_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkProperty_GetLighting_44(HandleRef pThis);

		public virtual bool GetLighting()
		{
			return vtkProperty.vtkProperty_GetLighting_44(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetLineStipplePattern_45(HandleRef pThis);

		public virtual int GetLineStipplePattern()
		{
			return vtkProperty.vtkProperty_GetLineStipplePattern_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetLineStippleRepeatFactor_46(HandleRef pThis);

		public virtual int GetLineStippleRepeatFactor()
		{
			return vtkProperty.vtkProperty_GetLineStippleRepeatFactor_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetLineStippleRepeatFactorMaxValue_47(HandleRef pThis);

		public virtual int GetLineStippleRepeatFactorMaxValue()
		{
			return vtkProperty.vtkProperty_GetLineStippleRepeatFactorMaxValue_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetLineStippleRepeatFactorMinValue_48(HandleRef pThis);

		public virtual int GetLineStippleRepeatFactorMinValue()
		{
			return vtkProperty.vtkProperty_GetLineStippleRepeatFactorMinValue_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkProperty_GetLineWidth_49(HandleRef pThis);

		public virtual float GetLineWidth()
		{
			return vtkProperty.vtkProperty_GetLineWidth_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkProperty_GetLineWidthMaxValue_50(HandleRef pThis);

		public virtual float GetLineWidthMaxValue()
		{
			return vtkProperty.vtkProperty_GetLineWidthMaxValue_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkProperty_GetLineWidthMinValue_51(HandleRef pThis);

		public virtual float GetLineWidthMinValue()
		{
			return vtkProperty.vtkProperty_GetLineWidthMinValue_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetMaterial_52(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkXMLMaterial GetMaterial()
		{
			vtkXMLMaterial vtkXMLMaterial = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_GetMaterial_52(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMaterial = (vtkXMLMaterial)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMaterial.Register(null);
				}
			}
			return vtkXMLMaterial;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetMaterialName_53(HandleRef pThis);

		public virtual string GetMaterialName()
		{
			return Marshal.PtrToStringAnsi(vtkProperty.vtkProperty_GetMaterialName_53(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetNumberOfTextures_54(HandleRef pThis);

		public int GetNumberOfTextures()
		{
			return vtkProperty.vtkProperty_GetNumberOfTextures_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetOpacity_55(HandleRef pThis);

		public virtual double GetOpacity()
		{
			return vtkProperty.vtkProperty_GetOpacity_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetOpacityMaxValue_56(HandleRef pThis);

		public virtual double GetOpacityMaxValue()
		{
			return vtkProperty.vtkProperty_GetOpacityMaxValue_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetOpacityMinValue_57(HandleRef pThis);

		public virtual double GetOpacityMinValue()
		{
			return vtkProperty.vtkProperty_GetOpacityMinValue_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkProperty_GetPointSize_58(HandleRef pThis);

		public virtual float GetPointSize()
		{
			return vtkProperty.vtkProperty_GetPointSize_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkProperty_GetPointSizeMaxValue_59(HandleRef pThis);

		public virtual float GetPointSizeMaxValue()
		{
			return vtkProperty.vtkProperty_GetPointSizeMaxValue_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkProperty_GetPointSizeMinValue_60(HandleRef pThis);

		public virtual float GetPointSizeMinValue()
		{
			return vtkProperty.vtkProperty_GetPointSizeMinValue_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetRepresentation_61(HandleRef pThis);

		public virtual int GetRepresentation()
		{
			return vtkProperty.vtkProperty_GetRepresentation_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetRepresentationAsString_62(HandleRef pThis);

		public string GetRepresentationAsString()
		{
			return Marshal.PtrToStringAnsi(vtkProperty.vtkProperty_GetRepresentationAsString_62(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetRepresentationMaxValue_63(HandleRef pThis);

		public virtual int GetRepresentationMaxValue()
		{
			return vtkProperty.vtkProperty_GetRepresentationMaxValue_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetRepresentationMinValue_64(HandleRef pThis);

		public virtual int GetRepresentationMinValue()
		{
			return vtkProperty.vtkProperty_GetRepresentationMinValue_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetShaderProgram_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkShaderProgram GetShaderProgram()
		{
			vtkShaderProgram vtkShaderProgram = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_GetShaderProgram_65(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProgram = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProgram.Register(null);
				}
			}
			return vtkShaderProgram;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_GetShading_66(HandleRef pThis);

		public virtual int GetShading()
		{
			return vtkProperty.vtkProperty_GetShading_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetSpecular_67(HandleRef pThis);

		public virtual double GetSpecular()
		{
			return vtkProperty.vtkProperty_GetSpecular_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetSpecularColor_68(HandleRef pThis);

		public virtual double[] GetSpecularColor()
		{
			IntPtr intPtr = vtkProperty.vtkProperty_GetSpecularColor_68(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetSpecularColor_69(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSpecularColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkProperty.vtkProperty_GetSpecularColor_69(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_GetSpecularColor_70(HandleRef pThis, IntPtr _arg);

		public virtual void GetSpecularColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_GetSpecularColor_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetSpecularMaxValue_71(HandleRef pThis);

		public virtual double GetSpecularMaxValue()
		{
			return vtkProperty.vtkProperty_GetSpecularMaxValue_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetSpecularMinValue_72(HandleRef pThis);

		public virtual double GetSpecularMinValue()
		{
			return vtkProperty.vtkProperty_GetSpecularMinValue_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetSpecularPower_73(HandleRef pThis);

		public virtual double GetSpecularPower()
		{
			return vtkProperty.vtkProperty_GetSpecularPower_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetSpecularPowerMaxValue_74(HandleRef pThis);

		public virtual double GetSpecularPowerMaxValue()
		{
			return vtkProperty.vtkProperty_GetSpecularPowerMaxValue_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProperty_GetSpecularPowerMinValue_75(HandleRef pThis);

		public virtual double GetSpecularPowerMinValue()
		{
			return vtkProperty.vtkProperty_GetSpecularPowerMinValue_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetTexture_76(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTexture GetTexture(string name)
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_GetTexture_76(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_GetTexture_77(HandleRef pThis, int unit, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTexture GetTexture(int unit)
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_GetTexture_77(base.GetCppThis(), unit, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_IsA_78(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProperty.vtkProperty_IsA_78(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProperty_IsTypeOf_79(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProperty.vtkProperty_IsTypeOf_79(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_LightingOff_80(HandleRef pThis);

		public virtual void LightingOff()
		{
			vtkProperty.vtkProperty_LightingOff_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_LightingOn_81(HandleRef pThis);

		public virtual void LightingOn()
		{
			vtkProperty.vtkProperty_LightingOn_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_LoadMaterial_82(HandleRef pThis, string name);

		public void LoadMaterial(string name)
		{
			vtkProperty.vtkProperty_LoadMaterial_82(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_LoadMaterial_83(HandleRef pThis, HandleRef arg0);

		public void LoadMaterial(vtkXMLMaterial arg0)
		{
			vtkProperty.vtkProperty_LoadMaterial_83(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_LoadMaterialFromString_84(HandleRef pThis, string materialxml);

		public void LoadMaterialFromString(string materialxml)
		{
			vtkProperty.vtkProperty_LoadMaterialFromString_84(base.GetCppThis(), materialxml);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_NewInstance_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProperty NewInstance()
		{
			vtkProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_NewInstance_86(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_PostRender_87(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void PostRender(vtkActor arg0, vtkRenderer arg1)
		{
			vtkProperty.vtkProperty_PostRender_87(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_ReleaseGraphicsResources_88(HandleRef pThis, HandleRef win);

		public virtual void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkProperty.vtkProperty_ReleaseGraphicsResources_88(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_RemoveAllTextures_89(HandleRef pThis);

		public void RemoveAllTextures()
		{
			vtkProperty.vtkProperty_RemoveAllTextures_89(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_RemoveTexture_90(HandleRef pThis, int unit);

		public void RemoveTexture(int unit)
		{
			vtkProperty.vtkProperty_RemoveTexture_90(base.GetCppThis(), unit);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_RemoveTexture_91(HandleRef pThis, string name);

		public void RemoveTexture(string name)
		{
			vtkProperty.vtkProperty_RemoveTexture_91(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_Render_92(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void Render(vtkActor arg0, vtkRenderer arg1)
		{
			vtkProperty.vtkProperty_Render_92(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProperty_SafeDownCast_93(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProperty SafeDownCast(vtkObjectBase o)
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProperty.vtkProperty_SafeDownCast_93((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetAmbient_94(HandleRef pThis, double _arg);

		public virtual void SetAmbient(double _arg)
		{
			vtkProperty.vtkProperty_SetAmbient_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetAmbientColor_95(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetAmbientColor_95(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetAmbientColor_96(HandleRef pThis, IntPtr _arg);

		public virtual void SetAmbientColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetAmbientColor_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetBackfaceCulling_97(HandleRef pThis, int _arg);

		public virtual void SetBackfaceCulling(int _arg)
		{
			vtkProperty.vtkProperty_SetBackfaceCulling_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetColor_98(HandleRef pThis, double r, double g, double b);

		public void SetColor(double r, double g, double b)
		{
			vtkProperty.vtkProperty_SetColor_98(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetColor_99(HandleRef pThis, IntPtr a);

		public void SetColor(IntPtr a)
		{
			vtkProperty.vtkProperty_SetColor_99(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetDiffuse_100(HandleRef pThis, double _arg);

		public virtual void SetDiffuse(double _arg)
		{
			vtkProperty.vtkProperty_SetDiffuse_100(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetDiffuseColor_101(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetDiffuseColor_101(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetDiffuseColor_102(HandleRef pThis, IntPtr _arg);

		public virtual void SetDiffuseColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetDiffuseColor_102(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetEdgeColor_103(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetEdgeColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetEdgeColor_103(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetEdgeColor_104(HandleRef pThis, IntPtr _arg);

		public virtual void SetEdgeColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetEdgeColor_104(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetEdgeVisibility_105(HandleRef pThis, int _arg);

		public virtual void SetEdgeVisibility(int _arg)
		{
			vtkProperty.vtkProperty_SetEdgeVisibility_105(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetFrontfaceCulling_106(HandleRef pThis, int _arg);

		public virtual void SetFrontfaceCulling(int _arg)
		{
			vtkProperty.vtkProperty_SetFrontfaceCulling_106(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetInterpolation_107(HandleRef pThis, int _arg);

		public virtual void SetInterpolation(int _arg)
		{
			vtkProperty.vtkProperty_SetInterpolation_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetInterpolationToFlat_108(HandleRef pThis);

		public void SetInterpolationToFlat()
		{
			vtkProperty.vtkProperty_SetInterpolationToFlat_108(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetInterpolationToGouraud_109(HandleRef pThis);

		public void SetInterpolationToGouraud()
		{
			vtkProperty.vtkProperty_SetInterpolationToGouraud_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetInterpolationToPhong_110(HandleRef pThis);

		public void SetInterpolationToPhong()
		{
			vtkProperty.vtkProperty_SetInterpolationToPhong_110(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetLighting_111(HandleRef pThis, byte _arg);

		public virtual void SetLighting(bool _arg)
		{
			vtkProperty.vtkProperty_SetLighting_111(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetLineStipplePattern_112(HandleRef pThis, int _arg);

		public virtual void SetLineStipplePattern(int _arg)
		{
			vtkProperty.vtkProperty_SetLineStipplePattern_112(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetLineStippleRepeatFactor_113(HandleRef pThis, int _arg);

		public virtual void SetLineStippleRepeatFactor(int _arg)
		{
			vtkProperty.vtkProperty_SetLineStippleRepeatFactor_113(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetLineWidth_114(HandleRef pThis, float _arg);

		public virtual void SetLineWidth(float _arg)
		{
			vtkProperty.vtkProperty_SetLineWidth_114(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetOpacity_115(HandleRef pThis, double _arg);

		public virtual void SetOpacity(double _arg)
		{
			vtkProperty.vtkProperty_SetOpacity_115(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetPointSize_116(HandleRef pThis, float _arg);

		public virtual void SetPointSize(float _arg)
		{
			vtkProperty.vtkProperty_SetPointSize_116(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetRepresentation_117(HandleRef pThis, int _arg);

		public virtual void SetRepresentation(int _arg)
		{
			vtkProperty.vtkProperty_SetRepresentation_117(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetRepresentationToPoints_118(HandleRef pThis);

		public void SetRepresentationToPoints()
		{
			vtkProperty.vtkProperty_SetRepresentationToPoints_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetRepresentationToSurface_119(HandleRef pThis);

		public void SetRepresentationToSurface()
		{
			vtkProperty.vtkProperty_SetRepresentationToSurface_119(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetRepresentationToWireframe_120(HandleRef pThis);

		public void SetRepresentationToWireframe()
		{
			vtkProperty.vtkProperty_SetRepresentationToWireframe_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetShading_121(HandleRef pThis, int _arg);

		public virtual void SetShading(int _arg)
		{
			vtkProperty.vtkProperty_SetShading_121(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetSpecular_122(HandleRef pThis, double _arg);

		public virtual void SetSpecular(double _arg)
		{
			vtkProperty.vtkProperty_SetSpecular_122(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetSpecularColor_123(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
		{
			vtkProperty.vtkProperty_SetSpecularColor_123(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetSpecularColor_124(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpecularColor(IntPtr _arg)
		{
			vtkProperty.vtkProperty_SetSpecularColor_124(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetSpecularPower_125(HandleRef pThis, double _arg);

		public virtual void SetSpecularPower(double _arg)
		{
			vtkProperty.vtkProperty_SetSpecularPower_125(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetTexture_126(HandleRef pThis, string name, HandleRef texture);

		public void SetTexture(string name, vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetTexture_126(base.GetCppThis(), name, (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_SetTexture_127(HandleRef pThis, int unit, HandleRef texture);

		public void SetTexture(int unit, vtkTexture texture)
		{
			vtkProperty.vtkProperty_SetTexture_127(base.GetCppThis(), unit, (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_ShadingOff_128(HandleRef pThis);

		public virtual void ShadingOff()
		{
			vtkProperty.vtkProperty_ShadingOff_128(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProperty_ShadingOn_129(HandleRef pThis);

		public virtual void ShadingOn()
		{
			vtkProperty.vtkProperty_ShadingOn_129(base.GetCppThis());
		}
	}
}
