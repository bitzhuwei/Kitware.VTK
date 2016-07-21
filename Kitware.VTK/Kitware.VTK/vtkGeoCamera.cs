using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoCamera : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoCamera";

		public new static readonly string MRClassNameKey;

		static vtkGeoCamera()
		{
			vtkGeoCamera.MRClassNameKey = "class vtkGeoCamera";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoCamera"));
		}

		public vtkGeoCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoCamera New()
		{
			vtkGeoCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoCamera.vtkGeoCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoCamera.vtkGeoCamera_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetDistance_01(HandleRef pThis);

		public virtual double GetDistance()
		{
			return vtkGeoCamera.vtkGeoCamera_GetDistance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetHeading_02(HandleRef pThis);

		public virtual double GetHeading()
		{
			return vtkGeoCamera.vtkGeoCamera_GetHeading_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetLatitude_03(HandleRef pThis);

		public virtual double GetLatitude()
		{
			return vtkGeoCamera.vtkGeoCamera_GetLatitude_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoCamera_GetLockHeading_04(HandleRef pThis);

		public virtual bool GetLockHeading()
		{
			return vtkGeoCamera.vtkGeoCamera_GetLockHeading_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetLongitude_05(HandleRef pThis);

		public virtual double GetLongitude()
		{
			return vtkGeoCamera.vtkGeoCamera_GetLongitude_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetNodeCoverage_06(HandleRef pThis, HandleRef node);

		public double GetNodeCoverage(vtkGeoTerrainNode node)
		{
			return vtkGeoCamera.vtkGeoCamera_GetNodeCoverage_06(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoCamera_GetOrigin_07(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkGeoCamera.vtkGeoCamera_GetOrigin_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_GetOrigin_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoCamera.vtkGeoCamera_GetOrigin_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_GetOrigin_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkGeoCamera.vtkGeoCamera_GetOrigin_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetOriginLatitude_10(HandleRef pThis);

		public virtual double GetOriginLatitude()
		{
			return vtkGeoCamera.vtkGeoCamera_GetOriginLatitude_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetOriginLongitude_11(HandleRef pThis);

		public virtual double GetOriginLongitude()
		{
			return vtkGeoCamera.vtkGeoCamera_GetOriginLongitude_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoCamera_GetPosition_12(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkGeoCamera.vtkGeoCamera_GetPosition_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_GetPosition_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoCamera.vtkGeoCamera_GetPosition_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_GetPosition_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetPosition(IntPtr _arg)
		{
			vtkGeoCamera.vtkGeoCamera_GetPosition_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoCamera_GetTilt_15(HandleRef pThis);

		public virtual double GetTilt()
		{
			return vtkGeoCamera.vtkGeoCamera_GetTilt_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoCamera_GetVTKCamera_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCamera GetVTKCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoCamera.vtkGeoCamera_GetVTKCamera_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_InitializeNodeAnalysis_17(HandleRef pThis, IntPtr rendererSize);

		public void InitializeNodeAnalysis(IntPtr rendererSize)
		{
			vtkGeoCamera.vtkGeoCamera_InitializeNodeAnalysis_17(base.GetCppThis(), rendererSize);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoCamera_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoCamera.vtkGeoCamera_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoCamera_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoCamera.vtkGeoCamera_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_LockHeadingOff_20(HandleRef pThis);

		public virtual void LockHeadingOff()
		{
			vtkGeoCamera.vtkGeoCamera_LockHeadingOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_LockHeadingOn_21(HandleRef pThis);

		public virtual void LockHeadingOn()
		{
			vtkGeoCamera.vtkGeoCamera_LockHeadingOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoCamera_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoCamera NewInstance()
		{
			vtkGeoCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoCamera.vtkGeoCamera_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoCamera_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoCamera SafeDownCast(vtkObjectBase o)
		{
			vtkGeoCamera vtkGeoCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoCamera.vtkGeoCamera_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoCamera = (vtkGeoCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoCamera.Register(null);
				}
			}
			return vtkGeoCamera;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetDistance_25(HandleRef pThis, double Distance);

		public void SetDistance(double Distance)
		{
			vtkGeoCamera.vtkGeoCamera_SetDistance_25(base.GetCppThis(), Distance);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetHeading_26(HandleRef pThis, double heading);

		public void SetHeading(double heading)
		{
			vtkGeoCamera.vtkGeoCamera_SetHeading_26(base.GetCppThis(), heading);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetLatitude_27(HandleRef pThis, double latitude);

		public void SetLatitude(double latitude)
		{
			vtkGeoCamera.vtkGeoCamera_SetLatitude_27(base.GetCppThis(), latitude);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetLockHeading_28(HandleRef pThis, byte _arg);

		public virtual void SetLockHeading(bool _arg)
		{
			vtkGeoCamera.vtkGeoCamera_SetLockHeading_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetLongitude_29(HandleRef pThis, double longitude);

		public void SetLongitude(double longitude)
		{
			vtkGeoCamera.vtkGeoCamera_SetLongitude_29(base.GetCppThis(), longitude);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetOrigin_30(HandleRef pThis, double ox, double oy, double oz);

		public void SetOrigin(double ox, double oy, double oz)
		{
			vtkGeoCamera.vtkGeoCamera_SetOrigin_30(base.GetCppThis(), ox, oy, oz);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetOriginLatitude_31(HandleRef pThis, double oLat);

		public void SetOriginLatitude(double oLat)
		{
			vtkGeoCamera.vtkGeoCamera_SetOriginLatitude_31(base.GetCppThis(), oLat);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetOriginLongitude_32(HandleRef pThis, double oLat);

		public void SetOriginLongitude(double oLat)
		{
			vtkGeoCamera.vtkGeoCamera_SetOriginLongitude_32(base.GetCppThis(), oLat);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoCamera_SetTilt_33(HandleRef pThis, double tilt);

		public void SetTilt(double tilt)
		{
			vtkGeoCamera.vtkGeoCamera_SetTilt_33(base.GetCppThis(), tilt);
		}
	}
}
