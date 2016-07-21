using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGlobeSource : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlobeSource";

		public new static readonly string MRClassNameKey;

		static vtkGlobeSource()
		{
			vtkGlobeSource.MRClassNameKey = "class vtkGlobeSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlobeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlobeSource"));
		}

		public vtkGlobeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlobeSource New()
		{
			vtkGlobeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobeSource.vtkGlobeSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlobeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGlobeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGlobeSource.vtkGlobeSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_AutoCalculateCurtainHeightOff_01(HandleRef pThis);

		public virtual void AutoCalculateCurtainHeightOff()
		{
			vtkGlobeSource.vtkGlobeSource_AutoCalculateCurtainHeightOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_AutoCalculateCurtainHeightOn_02(HandleRef pThis);

		public virtual void AutoCalculateCurtainHeightOn()
		{
			vtkGlobeSource.vtkGlobeSource_AutoCalculateCurtainHeightOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_ComputeGlobePoint_03(double theta, double phi, double radius, IntPtr point, IntPtr normal);

		public static void ComputeGlobePoint(double theta, double phi, double radius, IntPtr point, IntPtr normal)
		{
			vtkGlobeSource.vtkGlobeSource_ComputeGlobePoint_03(theta, phi, radius, point, normal);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_ComputeLatitudeLongitude_04(IntPtr x, ref double theta, ref double phi);

		public static void ComputeLatitudeLongitude(IntPtr x, ref double theta, ref double phi)
		{
			vtkGlobeSource.vtkGlobeSource_ComputeLatitudeLongitude_04(x, ref theta, ref phi);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGlobeSource_GetAutoCalculateCurtainHeight_05(HandleRef pThis);

		public virtual bool GetAutoCalculateCurtainHeight()
		{
			return vtkGlobeSource.vtkGlobeSource_GetAutoCalculateCurtainHeight_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetCurtainHeight_06(HandleRef pThis);

		public virtual double GetCurtainHeight()
		{
			return vtkGlobeSource.vtkGlobeSource_GetCurtainHeight_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetCurtainHeightMaxValue_07(HandleRef pThis);

		public virtual double GetCurtainHeightMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetCurtainHeightMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetCurtainHeightMinValue_08(HandleRef pThis);

		public virtual double GetCurtainHeightMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetCurtainHeightMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetEndLatitudeMaxValue_09(HandleRef pThis);

		public virtual double GetEndLatitudeMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetEndLatitudeMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetEndLatitudeMinValue_10(HandleRef pThis);

		public virtual double GetEndLatitudeMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetEndLatitudeMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetEndLongitudeMaxValue_11(HandleRef pThis);

		public virtual double GetEndLongitudeMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetEndLongitudeMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetEndLongitudeMinValue_12(HandleRef pThis);

		public virtual double GetEndLongitudeMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetEndLongitudeMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetLatitudeResolution_13(HandleRef pThis);

		public virtual int GetLatitudeResolution()
		{
			return vtkGlobeSource.vtkGlobeSource_GetLatitudeResolution_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetLatitudeResolutionMaxValue_14(HandleRef pThis);

		public virtual int GetLatitudeResolutionMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetLatitudeResolutionMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetLatitudeResolutionMinValue_15(HandleRef pThis);

		public virtual int GetLatitudeResolutionMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetLatitudeResolutionMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetLongitudeResolution_16(HandleRef pThis);

		public virtual int GetLongitudeResolution()
		{
			return vtkGlobeSource.vtkGlobeSource_GetLongitudeResolution_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetLongitudeResolutionMaxValue_17(HandleRef pThis);

		public virtual int GetLongitudeResolutionMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetLongitudeResolutionMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetLongitudeResolutionMinValue_18(HandleRef pThis);

		public virtual int GetLongitudeResolutionMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetLongitudeResolutionMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_GetQuadrilateralTessellation_19(HandleRef pThis);

		public virtual int GetQuadrilateralTessellation()
		{
			return vtkGlobeSource.vtkGlobeSource_GetQuadrilateralTessellation_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetRadius_20(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkGlobeSource.vtkGlobeSource_GetRadius_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetRadiusMaxValue_21(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetRadiusMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetRadiusMinValue_22(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetRadiusMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetStartLatitudeMaxValue_23(HandleRef pThis);

		public virtual double GetStartLatitudeMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetStartLatitudeMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetStartLatitudeMinValue_24(HandleRef pThis);

		public virtual double GetStartLatitudeMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetStartLatitudeMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetStartLongitudeMaxValue_25(HandleRef pThis);

		public virtual double GetStartLongitudeMaxValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetStartLongitudeMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGlobeSource_GetStartLongitudeMinValue_26(HandleRef pThis);

		public virtual double GetStartLongitudeMinValue()
		{
			return vtkGlobeSource.vtkGlobeSource_GetStartLongitudeMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGlobeSource.vtkGlobeSource_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGlobeSource_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGlobeSource.vtkGlobeSource_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobeSource_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGlobeSource NewInstance()
		{
			vtkGlobeSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobeSource.vtkGlobeSource_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlobeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_QuadrilateralTessellationOff_31(HandleRef pThis);

		public virtual void QuadrilateralTessellationOff()
		{
			vtkGlobeSource.vtkGlobeSource_QuadrilateralTessellationOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_QuadrilateralTessellationOn_32(HandleRef pThis);

		public virtual void QuadrilateralTessellationOn()
		{
			vtkGlobeSource.vtkGlobeSource_QuadrilateralTessellationOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGlobeSource_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGlobeSource SafeDownCast(vtkObjectBase o)
		{
			vtkGlobeSource vtkGlobeSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGlobeSource.vtkGlobeSource_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlobeSource = (vtkGlobeSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlobeSource.Register(null);
				}
			}
			return vtkGlobeSource;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetAutoCalculateCurtainHeight_34(HandleRef pThis, byte _arg);

		public virtual void SetAutoCalculateCurtainHeight(bool _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetAutoCalculateCurtainHeight_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetCurtainHeight_35(HandleRef pThis, double _arg);

		public virtual void SetCurtainHeight(double _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetCurtainHeight_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetEndLatitude_36(HandleRef pThis, double _arg);

		public virtual void SetEndLatitude(double _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetEndLatitude_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetEndLongitude_37(HandleRef pThis, double _arg);

		public virtual void SetEndLongitude(double _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetEndLongitude_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetLatitudeResolution_38(HandleRef pThis, int _arg);

		public virtual void SetLatitudeResolution(int _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetLatitudeResolution_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetLongitudeResolution_39(HandleRef pThis, int _arg);

		public virtual void SetLongitudeResolution(int _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetLongitudeResolution_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetOrigin_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkGlobeSource.vtkGlobeSource_SetOrigin_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetOrigin_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetOrigin_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetQuadrilateralTessellation_42(HandleRef pThis, int _arg);

		public virtual void SetQuadrilateralTessellation(int _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetQuadrilateralTessellation_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetRadius_43(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetRadius_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetStartLatitude_44(HandleRef pThis, double _arg);

		public virtual void SetStartLatitude(double _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetStartLatitude_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGlobeSource_SetStartLongitude_45(HandleRef pThis, double _arg);

		public virtual void SetStartLongitude(double _arg)
		{
			vtkGlobeSource.vtkGlobeSource_SetStartLongitude_45(base.GetCppThis(), _arg);
		}
	}
}
