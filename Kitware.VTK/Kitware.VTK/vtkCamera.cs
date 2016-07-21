using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCamera : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCamera";

		public new static readonly string MRClassNameKey;

		static vtkCamera()
		{
			vtkCamera.MRClassNameKey = "class vtkCamera";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCamera"));
		}

		public vtkCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCamera New()
		{
			vtkCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCamera.vtkCamera_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ApplyTransform_01(HandleRef pThis, HandleRef t);

		public void ApplyTransform(vtkTransform t)
		{
			vtkCamera.vtkCamera_ApplyTransform_01(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Azimuth_02(HandleRef pThis, double angle);

		public void Azimuth(double angle)
		{
			vtkCamera.vtkCamera_Azimuth_02(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ComputeProjAndViewParams_03(HandleRef pThis);

		public void ComputeProjAndViewParams()
		{
			vtkCamera.vtkCamera_ComputeProjAndViewParams_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ComputeViewPlaneNormal_04(HandleRef pThis);

		public void ComputeViewPlaneNormal()
		{
			vtkCamera.vtkCamera_ComputeViewPlaneNormal_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_DeepCopy_05(HandleRef pThis, HandleRef source);

		public void DeepCopy(vtkCamera source)
		{
			vtkCamera.vtkCamera_DeepCopy_05(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Dolly_06(HandleRef pThis, double value);

		public void Dolly(double value)
		{
			vtkCamera.vtkCamera_Dolly_06(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Elevation_07(HandleRef pThis, double angle);

		public void Elevation(double angle)
		{
			vtkCamera.vtkCamera_Elevation_07(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetCameraLightTransformMatrix_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMatrix4x4 GetCameraLightTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetCameraLightTransformMatrix_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCamera_GetClippingRange_09(HandleRef pThis);

		public virtual double[] GetClippingRange()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetClippingRange_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetClippingRange_10(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetClippingRange(ref double _arg1, ref double _arg2)
		{
			vtkCamera.vtkCamera_GetClippingRange_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetClippingRange_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetClippingRange(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetClippingRange_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetCompositeProjectionTransformMatrix_12(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetCompositeProjectionTransformMatrix(double aspect, double nearz, double farz)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetCompositeProjectionTransformMatrix_12(base.GetCppThis(), aspect, nearz, farz, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCamera_GetDirectionOfProjection_13(HandleRef pThis);

		public virtual double[] GetDirectionOfProjection()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetDirectionOfProjection_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetDirectionOfProjection_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDirectionOfProjection(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetDirectionOfProjection_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetDirectionOfProjection_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetDirectionOfProjection(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetDirectionOfProjection_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetDistance_16(HandleRef pThis);

		public virtual double GetDistance()
		{
			return vtkCamera.vtkCamera_GetDistance_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetEyeAngle_17(HandleRef pThis);

		public virtual double GetEyeAngle()
		{
			return vtkCamera.vtkCamera_GetEyeAngle_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetFocalDisk_18(HandleRef pThis);

		public virtual double GetFocalDisk()
		{
			return vtkCamera.vtkCamera_GetFocalDisk_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetFocalPoint_19(HandleRef pThis);

		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetFocalPoint_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetFocalPoint_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetFocalPoint(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetFocalPoint_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetFocalPoint_21(HandleRef pThis, IntPtr _arg);

		public virtual void GetFocalPoint(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetFocalPoint_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetFrustumPlanes_22(HandleRef pThis, double aspect, IntPtr planes);

		public virtual void GetFrustumPlanes(double aspect, IntPtr planes)
		{
			vtkCamera.vtkCamera_GetFrustumPlanes_22(base.GetCppThis(), aspect, planes);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCamera_GetHeadTracked_23(HandleRef pThis);

		public virtual int GetHeadTracked()
		{
			return vtkCamera.vtkCamera_GetHeadTracked_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCamera_GetLeftEye_24(HandleRef pThis);

		public virtual int GetLeftEye()
		{
			return vtkCamera.vtkCamera_GetLeftEye_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetOrientation_25(HandleRef pThis);

		public double[] GetOrientation()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetOrientation_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetOrientationWXYZ_26(HandleRef pThis);

		public double[] GetOrientationWXYZ()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetOrientationWXYZ_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCamera_GetParallelProjection_27(HandleRef pThis);

		public virtual int GetParallelProjection()
		{
			return vtkCamera.vtkCamera_GetParallelProjection_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetParallelScale_28(HandleRef pThis);

		public virtual double GetParallelScale()
		{
			return vtkCamera.vtkCamera_GetParallelScale_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetPosition_29(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetPosition_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetPosition_30(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetPosition_30(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetPosition_31(HandleRef pThis, IntPtr _arg);

		public virtual void GetPosition(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetPosition_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetProjectionTransformMatrix_32(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetProjectionTransformMatrix(double aspect, double nearz, double farz)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetProjectionTransformMatrix_32(base.GetCppThis(), aspect, nearz, farz, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCamera_GetProjectionTransformObject_33(HandleRef pThis, double aspect, double nearz, double farz, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPerspectiveTransform GetProjectionTransformObject(double aspect, double nearz, double farz)
		{
			vtkPerspectiveTransform vtkPerspectiveTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetProjectionTransformObject_33(base.GetCppThis(), aspect, nearz, farz, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerspectiveTransform = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerspectiveTransform.Register(null);
				}
			}
			return vtkPerspectiveTransform;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetRoll_34(HandleRef pThis);

		public double GetRoll()
		{
			return vtkCamera.vtkCamera_GetRoll_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetThickness_35(HandleRef pThis);

		public virtual double GetThickness()
		{
			return vtkCamera.vtkCamera_GetThickness_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCamera_GetUseHorizontalViewAngle_36(HandleRef pThis);

		public virtual int GetUseHorizontalViewAngle()
		{
			return vtkCamera.vtkCamera_GetUseHorizontalViewAngle_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetUserTransform_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHomogeneousTransform GetUserTransform()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetUserTransform_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetUserViewTransform_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHomogeneousTransform GetUserViewTransform()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetUserViewTransform_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCamera_GetViewAngle_39(HandleRef pThis);

		public virtual double GetViewAngle()
		{
			return vtkCamera.vtkCamera_GetViewAngle_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetViewPlaneNormal_40(HandleRef pThis);

		public virtual double[] GetViewPlaneNormal()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewPlaneNormal_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetViewPlaneNormal_41(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetViewPlaneNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetViewPlaneNormal_41(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetViewPlaneNormal_42(HandleRef pThis, IntPtr _arg);

		public virtual void GetViewPlaneNormal(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetViewPlaneNormal_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetViewShear_43(HandleRef pThis);

		public virtual double[] GetViewShear()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewShear_43(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetViewShear_44(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetViewShear(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetViewShear_44(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetViewShear_45(HandleRef pThis, IntPtr _arg);

		public virtual void GetViewShear(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetViewShear_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetViewTransformMatrix_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetViewTransformMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewTransformMatrix_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCamera_GetViewTransformObject_47(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform GetViewTransformObject()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewTransformObject_47(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetViewUp_48(HandleRef pThis);

		public virtual double[] GetViewUp()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetViewUp_48(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetViewUp_49(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetViewUp(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCamera.vtkCamera_GetViewUp_49(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetViewUp_50(HandleRef pThis, IntPtr _arg);

		public virtual void GetViewUp(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetViewUp_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkCamera_GetViewingRaysMTime_51(HandleRef pThis);

		public uint GetViewingRaysMTime()
		{
			return vtkCamera.vtkCamera_GetViewingRaysMTime_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_GetWindowCenter_52(HandleRef pThis);

		public virtual double[] GetWindowCenter()
		{
			IntPtr intPtr = vtkCamera.vtkCamera_GetWindowCenter_52(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetWindowCenter_53(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetWindowCenter(ref double _arg1, ref double _arg2)
		{
			vtkCamera.vtkCamera_GetWindowCenter_53(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_GetWindowCenter_54(HandleRef pThis, IntPtr _arg);

		public virtual void GetWindowCenter(IntPtr _arg)
		{
			vtkCamera.vtkCamera_GetWindowCenter_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCamera_IsA_55(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCamera.vtkCamera_IsA_55(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCamera_IsTypeOf_56(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCamera.vtkCamera_IsTypeOf_56(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_NewInstance_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCamera NewInstance()
		{
			vtkCamera result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_NewInstance_58(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_OrthogonalizeViewUp_59(HandleRef pThis);

		public void OrthogonalizeViewUp()
		{
			vtkCamera.vtkCamera_OrthogonalizeViewUp_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ParallelProjectionOff_60(HandleRef pThis);

		public virtual void ParallelProjectionOff()
		{
			vtkCamera.vtkCamera_ParallelProjectionOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ParallelProjectionOn_61(HandleRef pThis);

		public virtual void ParallelProjectionOn()
		{
			vtkCamera.vtkCamera_ParallelProjectionOn_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Pitch_62(HandleRef pThis, double angle);

		public void Pitch(double angle)
		{
			vtkCamera.vtkCamera_Pitch_62(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Render_63(HandleRef pThis, HandleRef arg0);

		public virtual void Render(vtkRenderer arg0)
		{
			vtkCamera.vtkCamera_Render_63(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Roll_64(HandleRef pThis, double angle);

		public void Roll(double angle)
		{
			vtkCamera.vtkCamera_Roll_64(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCamera_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCamera SafeDownCast(vtkObjectBase o)
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCamera.vtkCamera_SafeDownCast_65((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetClippingRange_66(HandleRef pThis, double dNear, double dFar);

		public void SetClippingRange(double dNear, double dFar)
		{
			vtkCamera.vtkCamera_SetClippingRange_66(base.GetCppThis(), dNear, dFar);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetClippingRange_67(HandleRef pThis, IntPtr a);

		public void SetClippingRange(IntPtr a)
		{
			vtkCamera.vtkCamera_SetClippingRange_67(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetConfigParams_68(HandleRef pThis, double o2screen, double o2right, double o2left, double o2top, double o2bottom, double interOccDist, double scale, HandleRef surfaceRot);

		public void SetConfigParams(double o2screen, double o2right, double o2left, double o2top, double o2bottom, double interOccDist, double scale, vtkMatrix4x4 surfaceRot)
		{
			vtkCamera.vtkCamera_SetConfigParams_68(base.GetCppThis(), o2screen, o2right, o2left, o2top, o2bottom, interOccDist, scale, (surfaceRot == null) ? default(HandleRef) : surfaceRot.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetDistance_69(HandleRef pThis, double arg0);

		public void SetDistance(double arg0)
		{
			vtkCamera.vtkCamera_SetDistance_69(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetEyeAngle_70(HandleRef pThis, double _arg);

		public virtual void SetEyeAngle(double _arg)
		{
			vtkCamera.vtkCamera_SetEyeAngle_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetFocalDisk_71(HandleRef pThis, double _arg);

		public virtual void SetFocalDisk(double _arg)
		{
			vtkCamera.vtkCamera_SetFocalDisk_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetFocalPoint_72(HandleRef pThis, double x, double y, double z);

		public void SetFocalPoint(double x, double y, double z)
		{
			vtkCamera.vtkCamera_SetFocalPoint_72(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetFocalPoint_73(HandleRef pThis, IntPtr a);

		public void SetFocalPoint(IntPtr a)
		{
			vtkCamera.vtkCamera_SetFocalPoint_73(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetHeadPose_74(HandleRef pThis, double x00, double x01, double x02, double x03, double x10, double x11, double x12, double x13, double x20, double x21, double x22, double x23, double x30, double x31, double x32, double x33);

		public void SetHeadPose(double x00, double x01, double x02, double x03, double x10, double x11, double x12, double x13, double x20, double x21, double x22, double x23, double x30, double x31, double x32, double x33)
		{
			vtkCamera.vtkCamera_SetHeadPose_74(base.GetCppThis(), x00, x01, x02, x03, x10, x11, x12, x13, x20, x21, x22, x23, x30, x31, x32, x33);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetHeadTracked_75(HandleRef pThis, int _arg);

		public virtual void SetHeadTracked(int _arg)
		{
			vtkCamera.vtkCamera_SetHeadTracked_75(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetLeftEye_76(HandleRef pThis, int _arg);

		public virtual void SetLeftEye(int _arg)
		{
			vtkCamera.vtkCamera_SetLeftEye_76(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetObliqueAngles_77(HandleRef pThis, double alpha, double beta);

		public void SetObliqueAngles(double alpha, double beta)
		{
			vtkCamera.vtkCamera_SetObliqueAngles_77(base.GetCppThis(), alpha, beta);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetParallelProjection_78(HandleRef pThis, int flag);

		public void SetParallelProjection(int flag)
		{
			vtkCamera.vtkCamera_SetParallelProjection_78(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetParallelScale_79(HandleRef pThis, double scale);

		public void SetParallelScale(double scale)
		{
			vtkCamera.vtkCamera_SetParallelScale_79(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetPosition_80(HandleRef pThis, double x, double y, double z);

		public void SetPosition(double x, double y, double z)
		{
			vtkCamera.vtkCamera_SetPosition_80(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetPosition_81(HandleRef pThis, IntPtr a);

		public void SetPosition(IntPtr a)
		{
			vtkCamera.vtkCamera_SetPosition_81(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetRoll_82(HandleRef pThis, double angle);

		public void SetRoll(double angle)
		{
			vtkCamera.vtkCamera_SetRoll_82(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetThickness_83(HandleRef pThis, double arg0);

		public void SetThickness(double arg0)
		{
			vtkCamera.vtkCamera_SetThickness_83(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetUseHorizontalViewAngle_84(HandleRef pThis, int flag);

		public void SetUseHorizontalViewAngle(int flag)
		{
			vtkCamera.vtkCamera_SetUseHorizontalViewAngle_84(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetUserTransform_85(HandleRef pThis, HandleRef transform);

		public void SetUserTransform(vtkHomogeneousTransform transform)
		{
			vtkCamera.vtkCamera_SetUserTransform_85(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetUserViewTransform_86(HandleRef pThis, HandleRef transform);

		public void SetUserViewTransform(vtkHomogeneousTransform transform)
		{
			vtkCamera.vtkCamera_SetUserViewTransform_86(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetViewAngle_87(HandleRef pThis, double angle);

		public void SetViewAngle(double angle)
		{
			vtkCamera.vtkCamera_SetViewAngle_87(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetViewShear_88(HandleRef pThis, double dxdz, double dydz, double center);

		public void SetViewShear(double dxdz, double dydz, double center)
		{
			vtkCamera.vtkCamera_SetViewShear_88(base.GetCppThis(), dxdz, dydz, center);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetViewShear_89(HandleRef pThis, IntPtr d);

		public void SetViewShear(IntPtr d)
		{
			vtkCamera.vtkCamera_SetViewShear_89(base.GetCppThis(), d);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetViewUp_90(HandleRef pThis, double vx, double vy, double vz);

		public void SetViewUp(double vx, double vy, double vz)
		{
			vtkCamera.vtkCamera_SetViewUp_90(base.GetCppThis(), vx, vy, vz);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetViewUp_91(HandleRef pThis, IntPtr a);

		public void SetViewUp(IntPtr a)
		{
			vtkCamera.vtkCamera_SetViewUp_91(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_SetWindowCenter_92(HandleRef pThis, double x, double y);

		public void SetWindowCenter(double x, double y)
		{
			vtkCamera.vtkCamera_SetWindowCenter_92(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ShallowCopy_93(HandleRef pThis, HandleRef source);

		public void ShallowCopy(vtkCamera source)
		{
			vtkCamera.vtkCamera_ShallowCopy_93(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_UpdateViewport_94(HandleRef pThis, HandleRef arg0);

		public virtual void UpdateViewport(vtkRenderer arg0)
		{
			vtkCamera.vtkCamera_UpdateViewport_94(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_UseHorizontalViewAngleOff_95(HandleRef pThis);

		public virtual void UseHorizontalViewAngleOff()
		{
			vtkCamera.vtkCamera_UseHorizontalViewAngleOff_95(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_UseHorizontalViewAngleOn_96(HandleRef pThis);

		public virtual void UseHorizontalViewAngleOn()
		{
			vtkCamera.vtkCamera_UseHorizontalViewAngleOn_96(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_ViewingRaysModified_97(HandleRef pThis);

		public void ViewingRaysModified()
		{
			vtkCamera.vtkCamera_ViewingRaysModified_97(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Yaw_98(HandleRef pThis, double angle);

		public void Yaw(double angle)
		{
			vtkCamera.vtkCamera_Yaw_98(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCamera_Zoom_99(HandleRef pThis, double factor);

		public void Zoom(double factor)
		{
			vtkCamera.vtkCamera_Zoom_99(base.GetCppThis(), factor);
		}
	}
}
