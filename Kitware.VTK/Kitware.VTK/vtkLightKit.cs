using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLightKit : vtkObject
	{
		public enum LightKitSubType
		{
			Azimuth = 3,
			Elevation = 2,
			Intensity = 1,
			KBRatio = 5,
			KFRatio = 4,
			KHRatio = 6,
			Warmth = 0
		}

		public enum LightKitType
		{
			TBackLight = 2,
			TFillLight = 1,
			THeadLight = 3,
			TKeyLight = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLightKit";

		public new static readonly string MRClassNameKey;

		static vtkLightKit()
		{
			vtkLightKit.MRClassNameKey = "class vtkLightKit";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightKit.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightKit"));
		}

		public vtkLightKit(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLightKit New()
		{
			vtkLightKit result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightKit.vtkLightKit_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLightKit() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLightKit.vtkLightKit_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_AddLightsToRenderer_01(HandleRef pThis, HandleRef renderer);

		public void AddLightsToRenderer(vtkRenderer renderer)
		{
			vtkLightKit.vtkLightKit_AddLightsToRenderer_01(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_DeepCopy_02(HandleRef pThis, HandleRef kit);

		public void DeepCopy(vtkLightKit kit)
		{
			vtkLightKit.vtkLightKit_DeepCopy_02(base.GetCppThis(), (kit == null) ? default(HandleRef) : kit.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetBackLightAngle_03(HandleRef pThis);

		public virtual double[] GetBackLightAngle()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetBackLightAngle_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetBackLightAngle_04(HandleRef pThis, IntPtr data);

		public virtual void GetBackLightAngle(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetBackLightAngle_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetBackLightAzimuth_05(HandleRef pThis);

		public double GetBackLightAzimuth()
		{
			return vtkLightKit.vtkLightKit_GetBackLightAzimuth_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetBackLightColor_06(HandleRef pThis);

		public virtual double[] GetBackLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetBackLightColor_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetBackLightColor_07(HandleRef pThis, IntPtr data);

		public virtual void GetBackLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetBackLightColor_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetBackLightElevation_08(HandleRef pThis);

		public double GetBackLightElevation()
		{
			return vtkLightKit.vtkLightKit_GetBackLightElevation_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetBackLightWarmth_09(HandleRef pThis);

		public virtual double GetBackLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetBackLightWarmth_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetFillLightAngle_10(HandleRef pThis);

		public virtual double[] GetFillLightAngle()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetFillLightAngle_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetFillLightAngle_11(HandleRef pThis, IntPtr data);

		public virtual void GetFillLightAngle(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetFillLightAngle_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetFillLightAzimuth_12(HandleRef pThis);

		public double GetFillLightAzimuth()
		{
			return vtkLightKit.vtkLightKit_GetFillLightAzimuth_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetFillLightColor_13(HandleRef pThis);

		public virtual double[] GetFillLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetFillLightColor_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetFillLightColor_14(HandleRef pThis, IntPtr data);

		public virtual void GetFillLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetFillLightColor_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetFillLightElevation_15(HandleRef pThis);

		public double GetFillLightElevation()
		{
			return vtkLightKit.vtkLightKit_GetFillLightElevation_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetFillLightWarmth_16(HandleRef pThis);

		public virtual double GetFillLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetFillLightWarmth_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetHeadLightColor_17(HandleRef pThis);

		public virtual double[] GetHeadLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetHeadLightColor_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetHeadLightColor_18(HandleRef pThis, IntPtr data);

		public virtual void GetHeadLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetHeadLightColor_18(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetHeadLightWarmth_19(HandleRef pThis);

		public virtual double GetHeadLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetHeadLightWarmth_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetKeyLightAngle_20(HandleRef pThis);

		public virtual double[] GetKeyLightAngle()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetKeyLightAngle_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetKeyLightAngle_21(HandleRef pThis, IntPtr data);

		public virtual void GetKeyLightAngle(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetKeyLightAngle_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyLightAzimuth_22(HandleRef pThis);

		public double GetKeyLightAzimuth()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightAzimuth_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetKeyLightColor_23(HandleRef pThis);

		public virtual double[] GetKeyLightColor()
		{
			IntPtr intPtr = vtkLightKit.vtkLightKit_GetKeyLightColor_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_GetKeyLightColor_24(HandleRef pThis, IntPtr data);

		public virtual void GetKeyLightColor(IntPtr data)
		{
			vtkLightKit.vtkLightKit_GetKeyLightColor_24(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyLightElevation_25(HandleRef pThis);

		public double GetKeyLightElevation()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightElevation_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyLightIntensity_26(HandleRef pThis);

		public virtual double GetKeyLightIntensity()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightIntensity_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyLightWarmth_27(HandleRef pThis);

		public virtual double GetKeyLightWarmth()
		{
			return vtkLightKit.vtkLightKit_GetKeyLightWarmth_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToBackRatio_28(HandleRef pThis);

		public virtual double GetKeyToBackRatio()
		{
			return vtkLightKit.vtkLightKit_GetKeyToBackRatio_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToBackRatioMaxValue_29(HandleRef pThis);

		public virtual double GetKeyToBackRatioMaxValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToBackRatioMaxValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToBackRatioMinValue_30(HandleRef pThis);

		public virtual double GetKeyToBackRatioMinValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToBackRatioMinValue_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToFillRatio_31(HandleRef pThis);

		public virtual double GetKeyToFillRatio()
		{
			return vtkLightKit.vtkLightKit_GetKeyToFillRatio_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToFillRatioMaxValue_32(HandleRef pThis);

		public virtual double GetKeyToFillRatioMaxValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToFillRatioMaxValue_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToFillRatioMinValue_33(HandleRef pThis);

		public virtual double GetKeyToFillRatioMinValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToFillRatioMinValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToHeadRatio_34(HandleRef pThis);

		public virtual double GetKeyToHeadRatio()
		{
			return vtkLightKit.vtkLightKit_GetKeyToHeadRatio_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToHeadRatioMaxValue_35(HandleRef pThis);

		public virtual double GetKeyToHeadRatioMaxValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToHeadRatioMaxValue_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLightKit_GetKeyToHeadRatioMinValue_36(HandleRef pThis);

		public virtual double GetKeyToHeadRatioMinValue()
		{
			return vtkLightKit.vtkLightKit_GetKeyToHeadRatioMinValue_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightKit_GetMaintainLuminance_37(HandleRef pThis);

		public virtual int GetMaintainLuminance()
		{
			return vtkLightKit.vtkLightKit_GetMaintainLuminance_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetShortStringFromSubType_38(int subtype);

		public static string GetShortStringFromSubType(int subtype)
		{
			return Marshal.PtrToStringAnsi(vtkLightKit.vtkLightKit_GetShortStringFromSubType_38(subtype));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetStringFromSubType_39(int type);

		public static string GetStringFromSubType(int type)
		{
			return Marshal.PtrToStringAnsi(vtkLightKit.vtkLightKit_GetStringFromSubType_39(type));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_GetStringFromType_40(int type);

		public static string GetStringFromType(int type)
		{
			return Marshal.PtrToStringAnsi(vtkLightKit.vtkLightKit_GetStringFromType_40(type));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern vtkLightKit.LightKitSubType vtkLightKit_GetSubType_41(vtkLightKit.LightKitType type, int i);

		public static vtkLightKit.LightKitSubType GetSubType(vtkLightKit.LightKitType type, int i)
		{
			return vtkLightKit.vtkLightKit_GetSubType_41(type, i);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightKit_IsA_42(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLightKit.vtkLightKit_IsA_42(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightKit_IsTypeOf_43(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLightKit.vtkLightKit_IsTypeOf_43(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_MaintainLuminanceOff_44(HandleRef pThis);

		public virtual void MaintainLuminanceOff()
		{
			vtkLightKit.vtkLightKit_MaintainLuminanceOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_MaintainLuminanceOn_45(HandleRef pThis);

		public virtual void MaintainLuminanceOn()
		{
			vtkLightKit.vtkLightKit_MaintainLuminanceOn_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_Modified_46(HandleRef pThis);

		public override void Modified()
		{
			vtkLightKit.vtkLightKit_Modified_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLightKit NewInstance()
		{
			vtkLightKit result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightKit.vtkLightKit_NewInstance_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_RemoveLightsFromRenderer_49(HandleRef pThis, HandleRef renderer);

		public void RemoveLightsFromRenderer(vtkRenderer renderer)
		{
			vtkLightKit.vtkLightKit_RemoveLightsFromRenderer_49(base.GetCppThis(), (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightKit_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLightKit SafeDownCast(vtkObjectBase o)
		{
			vtkLightKit vtkLightKit = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightKit.vtkLightKit_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightKit = (vtkLightKit)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightKit.Register(null);
				}
			}
			return vtkLightKit;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetBackLightAngle_51(HandleRef pThis, double elevation, double azimuth);

		public void SetBackLightAngle(double elevation, double azimuth)
		{
			vtkLightKit.vtkLightKit_SetBackLightAngle_51(base.GetCppThis(), elevation, azimuth);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetBackLightAngle_52(HandleRef pThis, IntPtr angle);

		public void SetBackLightAngle(IntPtr angle)
		{
			vtkLightKit.vtkLightKit_SetBackLightAngle_52(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetBackLightAzimuth_53(HandleRef pThis, double x);

		public void SetBackLightAzimuth(double x)
		{
			vtkLightKit.vtkLightKit_SetBackLightAzimuth_53(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetBackLightElevation_54(HandleRef pThis, double x);

		public void SetBackLightElevation(double x)
		{
			vtkLightKit.vtkLightKit_SetBackLightElevation_54(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetBackLightWarmth_55(HandleRef pThis, double _arg);

		public virtual void SetBackLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetBackLightWarmth_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetFillLightAngle_56(HandleRef pThis, double elevation, double azimuth);

		public void SetFillLightAngle(double elevation, double azimuth)
		{
			vtkLightKit.vtkLightKit_SetFillLightAngle_56(base.GetCppThis(), elevation, azimuth);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetFillLightAngle_57(HandleRef pThis, IntPtr angle);

		public void SetFillLightAngle(IntPtr angle)
		{
			vtkLightKit.vtkLightKit_SetFillLightAngle_57(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetFillLightAzimuth_58(HandleRef pThis, double x);

		public void SetFillLightAzimuth(double x)
		{
			vtkLightKit.vtkLightKit_SetFillLightAzimuth_58(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetFillLightElevation_59(HandleRef pThis, double x);

		public void SetFillLightElevation(double x)
		{
			vtkLightKit.vtkLightKit_SetFillLightElevation_59(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetFillLightWarmth_60(HandleRef pThis, double _arg);

		public virtual void SetFillLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetFillLightWarmth_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetHeadLightWarmth_61(HandleRef pThis, double _arg);

		public virtual void SetHeadLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetHeadLightWarmth_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyLightAngle_62(HandleRef pThis, double elevation, double azimuth);

		public void SetKeyLightAngle(double elevation, double azimuth)
		{
			vtkLightKit.vtkLightKit_SetKeyLightAngle_62(base.GetCppThis(), elevation, azimuth);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyLightAngle_63(HandleRef pThis, IntPtr angle);

		public void SetKeyLightAngle(IntPtr angle)
		{
			vtkLightKit.vtkLightKit_SetKeyLightAngle_63(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyLightAzimuth_64(HandleRef pThis, double x);

		public void SetKeyLightAzimuth(double x)
		{
			vtkLightKit.vtkLightKit_SetKeyLightAzimuth_64(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyLightElevation_65(HandleRef pThis, double x);

		public void SetKeyLightElevation(double x)
		{
			vtkLightKit.vtkLightKit_SetKeyLightElevation_65(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyLightIntensity_66(HandleRef pThis, double _arg);

		public virtual void SetKeyLightIntensity(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyLightIntensity_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyLightWarmth_67(HandleRef pThis, double _arg);

		public virtual void SetKeyLightWarmth(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyLightWarmth_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyToBackRatio_68(HandleRef pThis, double _arg);

		public virtual void SetKeyToBackRatio(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyToBackRatio_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyToFillRatio_69(HandleRef pThis, double _arg);

		public virtual void SetKeyToFillRatio(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyToFillRatio_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetKeyToHeadRatio_70(HandleRef pThis, double _arg);

		public virtual void SetKeyToHeadRatio(double _arg)
		{
			vtkLightKit.vtkLightKit_SetKeyToHeadRatio_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_SetMaintainLuminance_71(HandleRef pThis, int _arg);

		public virtual void SetMaintainLuminance(int _arg)
		{
			vtkLightKit.vtkLightKit_SetMaintainLuminance_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightKit_Update_72(HandleRef pThis);

		public void Update()
		{
			vtkLightKit.vtkLightKit_Update_72(base.GetCppThis());
		}
	}
}
