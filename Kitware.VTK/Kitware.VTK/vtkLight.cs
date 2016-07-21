using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLight : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLight";

		public new static readonly string MRClassNameKey;

		static vtkLight()
		{
			vtkLight.MRClassNameKey = "class vtkLight";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLight.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLight"));
		}

		public vtkLight(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLight New()
		{
			vtkLight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLight.vtkLight_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLight() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLight.vtkLight_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_DeepCopy_01(HandleRef pThis, HandleRef light);

		public void DeepCopy(vtkLight light)
		{
			vtkLight.vtkLight_DeepCopy_01(base.GetCppThis(), (light == null) ? default(HandleRef) : light.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetAmbientColor_02(HandleRef pThis);

		public virtual double[] GetAmbientColor()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetAmbientColor_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetAmbientColor_03(HandleRef pThis, IntPtr data);

		public virtual void GetAmbientColor(IntPtr data)
		{
			vtkLight.vtkLight_GetAmbientColor_03(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetAttenuationValues_04(HandleRef pThis);

		public virtual double[] GetAttenuationValues()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetAttenuationValues_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetAttenuationValues_05(HandleRef pThis, IntPtr data);

		public virtual void GetAttenuationValues(IntPtr data)
		{
			vtkLight.vtkLight_GetAttenuationValues_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLight_GetConeAngle_06(HandleRef pThis);

		public virtual double GetConeAngle()
		{
			return vtkLight.vtkLight_GetConeAngle_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetDiffuseColor_07(HandleRef pThis);

		public virtual double[] GetDiffuseColor()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetDiffuseColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetDiffuseColor_08(HandleRef pThis, IntPtr data);

		public virtual void GetDiffuseColor(IntPtr data)
		{
			vtkLight.vtkLight_GetDiffuseColor_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLight_GetExponent_09(HandleRef pThis);

		public virtual double GetExponent()
		{
			return vtkLight.vtkLight_GetExponent_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLight_GetExponentMaxValue_10(HandleRef pThis);

		public virtual double GetExponentMaxValue()
		{
			return vtkLight.vtkLight_GetExponentMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLight_GetExponentMinValue_11(HandleRef pThis);

		public virtual double GetExponentMinValue()
		{
			return vtkLight.vtkLight_GetExponentMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetFocalPoint_12(HandleRef pThis);

		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetFocalPoint_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetFocalPoint_13(HandleRef pThis, IntPtr data);

		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkLight.vtkLight_GetFocalPoint_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLight_GetIntensity_14(HandleRef pThis);

		public virtual double GetIntensity()
		{
			return vtkLight.vtkLight_GetIntensity_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_GetLightType_15(HandleRef pThis);

		public virtual int GetLightType()
		{
			return vtkLight.vtkLight_GetLightType_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetPosition_16(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetPosition_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetPosition_17(HandleRef pThis, IntPtr data);

		public virtual void GetPosition(IntPtr data)
		{
			vtkLight.vtkLight_GetPosition_17(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_GetPositional_18(HandleRef pThis);

		public virtual int GetPositional()
		{
			return vtkLight.vtkLight_GetPositional_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetSpecularColor_19(HandleRef pThis);

		public virtual double[] GetSpecularColor()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetSpecularColor_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetSpecularColor_20(HandleRef pThis, IntPtr data);

		public virtual void GetSpecularColor(IntPtr data)
		{
			vtkLight.vtkLight_GetSpecularColor_20(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_GetSwitch_21(HandleRef pThis);

		public virtual int GetSwitch()
		{
			return vtkLight.vtkLight_GetSwitch_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetTransformMatrix_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLight.vtkLight_GetTransformMatrix_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetTransformedFocalPoint_23(HandleRef pThis, ref double a0, ref double a1, ref double a2);

		public void GetTransformedFocalPoint(ref double a0, ref double a1, ref double a2)
		{
			vtkLight.vtkLight_GetTransformedFocalPoint_23(base.GetCppThis(), ref a0, ref a1, ref a2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetTransformedFocalPoint_24(HandleRef pThis, IntPtr a);

		public void GetTransformedFocalPoint(IntPtr a)
		{
			vtkLight.vtkLight_GetTransformedFocalPoint_24(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetTransformedFocalPoint_25(HandleRef pThis);

		public double[] GetTransformedFocalPoint()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetTransformedFocalPoint_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetTransformedPosition_26(HandleRef pThis, ref double a0, ref double a1, ref double a2);

		public void GetTransformedPosition(ref double a0, ref double a1, ref double a2)
		{
			vtkLight.vtkLight_GetTransformedPosition_26(base.GetCppThis(), ref a0, ref a1, ref a2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_GetTransformedPosition_27(HandleRef pThis, IntPtr a);

		public void GetTransformedPosition(IntPtr a)
		{
			vtkLight.vtkLight_GetTransformedPosition_27(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_GetTransformedPosition_28(HandleRef pThis);

		public double[] GetTransformedPosition()
		{
			IntPtr intPtr = vtkLight.vtkLight_GetTransformedPosition_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_IsA_29(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLight.vtkLight_IsA_29(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_IsTypeOf_30(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLight.vtkLight_IsTypeOf_30(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_LightTypeIsCameraLight_31(HandleRef pThis);

		public int LightTypeIsCameraLight()
		{
			return vtkLight.vtkLight_LightTypeIsCameraLight_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_LightTypeIsHeadlight_32(HandleRef pThis);

		public int LightTypeIsHeadlight()
		{
			return vtkLight.vtkLight_LightTypeIsHeadlight_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLight_LightTypeIsSceneLight_33(HandleRef pThis);

		public int LightTypeIsSceneLight()
		{
			return vtkLight.vtkLight_LightTypeIsSceneLight_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLight NewInstance()
		{
			vtkLight result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLight.vtkLight_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_PositionalOff_36(HandleRef pThis);

		public virtual void PositionalOff()
		{
			vtkLight.vtkLight_PositionalOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_PositionalOn_37(HandleRef pThis);

		public virtual void PositionalOn()
		{
			vtkLight.vtkLight_PositionalOn_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_Render_38(HandleRef pThis, HandleRef arg0, int arg1);

		public virtual void Render(vtkRenderer arg0, int arg1)
		{
			vtkLight.vtkLight_Render_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLight SafeDownCast(vtkObjectBase o)
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLight.vtkLight_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetAmbientColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAmbientColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetAmbientColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetAmbientColor_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetAmbientColor(IntPtr _arg)
		{
			vtkLight.vtkLight_SetAmbientColor_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetAttenuationValues_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAttenuationValues(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetAttenuationValues_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetAttenuationValues_43(HandleRef pThis, IntPtr _arg);

		public virtual void SetAttenuationValues(IntPtr _arg)
		{
			vtkLight.vtkLight_SetAttenuationValues_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetColor_44(HandleRef pThis, double arg0, double arg1, double arg2);

		public void SetColor(double arg0, double arg1, double arg2)
		{
			vtkLight.vtkLight_SetColor_44(base.GetCppThis(), arg0, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetColor_45(HandleRef pThis, IntPtr a);

		public void SetColor(IntPtr a)
		{
			vtkLight.vtkLight_SetColor_45(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetConeAngle_46(HandleRef pThis, double _arg);

		public virtual void SetConeAngle(double _arg)
		{
			vtkLight.vtkLight_SetConeAngle_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetDiffuseColor_47(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDiffuseColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetDiffuseColor_47(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetDiffuseColor_48(HandleRef pThis, IntPtr _arg);

		public virtual void SetDiffuseColor(IntPtr _arg)
		{
			vtkLight.vtkLight_SetDiffuseColor_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetDirectionAngle_49(HandleRef pThis, double elevation, double azimuth);

		public void SetDirectionAngle(double elevation, double azimuth)
		{
			vtkLight.vtkLight_SetDirectionAngle_49(base.GetCppThis(), elevation, azimuth);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetDirectionAngle_50(HandleRef pThis, IntPtr ang);

		public void SetDirectionAngle(IntPtr ang)
		{
			vtkLight.vtkLight_SetDirectionAngle_50(base.GetCppThis(), ang);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetExponent_51(HandleRef pThis, double _arg);

		public virtual void SetExponent(double _arg)
		{
			vtkLight.vtkLight_SetExponent_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetFocalPoint_52(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetFocalPoint(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetFocalPoint_52(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetFocalPoint_53(HandleRef pThis, IntPtr _arg);

		public virtual void SetFocalPoint(IntPtr _arg)
		{
			vtkLight.vtkLight_SetFocalPoint_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetIntensity_54(HandleRef pThis, double _arg);

		public virtual void SetIntensity(double _arg)
		{
			vtkLight.vtkLight_SetIntensity_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetLightType_55(HandleRef pThis, int _arg);

		public virtual void SetLightType(int _arg)
		{
			vtkLight.vtkLight_SetLightType_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetLightTypeToCameraLight_56(HandleRef pThis);

		public void SetLightTypeToCameraLight()
		{
			vtkLight.vtkLight_SetLightTypeToCameraLight_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetLightTypeToHeadlight_57(HandleRef pThis);

		public void SetLightTypeToHeadlight()
		{
			vtkLight.vtkLight_SetLightTypeToHeadlight_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetLightTypeToSceneLight_58(HandleRef pThis);

		public void SetLightTypeToSceneLight()
		{
			vtkLight.vtkLight_SetLightTypeToSceneLight_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetPosition_59(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetPosition_59(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetPosition_60(HandleRef pThis, IntPtr _arg);

		public virtual void SetPosition(IntPtr _arg)
		{
			vtkLight.vtkLight_SetPosition_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetPositional_61(HandleRef pThis, int _arg);

		public virtual void SetPositional(int _arg)
		{
			vtkLight.vtkLight_SetPositional_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetSpecularColor_62(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSpecularColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLight.vtkLight_SetSpecularColor_62(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetSpecularColor_63(HandleRef pThis, IntPtr _arg);

		public virtual void SetSpecularColor(IntPtr _arg)
		{
			vtkLight.vtkLight_SetSpecularColor_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetSwitch_64(HandleRef pThis, int _arg);

		public virtual void SetSwitch(int _arg)
		{
			vtkLight.vtkLight_SetSwitch_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SetTransformMatrix_65(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransformMatrix(vtkMatrix4x4 arg0)
		{
			vtkLight.vtkLight_SetTransformMatrix_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLight_ShallowClone_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLight ShallowClone()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLight.vtkLight_ShallowClone_66(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SwitchOff_67(HandleRef pThis);

		public virtual void SwitchOff()
		{
			vtkLight.vtkLight_SwitchOff_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLight_SwitchOn_68(HandleRef pThis);

		public virtual void SwitchOn()
		{
			vtkLight.vtkLight_SwitchOn_68(base.GetCppThis());
		}
	}
}
