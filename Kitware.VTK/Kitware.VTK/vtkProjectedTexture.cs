using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProjectedTexture : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTexture";

		public new static readonly string MRClassNameKey;

		static vtkProjectedTexture()
		{
			vtkProjectedTexture.MRClassNameKey = "class vtkProjectedTexture";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTexture"));
		}

		public vtkProjectedTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedTexture New()
		{
			vtkProjectedTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProjectedTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProjectedTexture.vtkProjectedTexture_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetAspectRatio_01(HandleRef pThis);

		public virtual double[] GetAspectRatio()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetAspectRatio_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetAspectRatio_02(HandleRef pThis, IntPtr data);

		public virtual void GetAspectRatio(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetAspectRatio_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProjectedTexture_GetCameraMode_03(HandleRef pThis);

		public virtual int GetCameraMode()
		{
			return vtkProjectedTexture.vtkProjectedTexture_GetCameraMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetFocalPoint_04(HandleRef pThis);

		public virtual double[] GetFocalPoint()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetFocalPoint_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetFocalPoint_05(HandleRef pThis, IntPtr data);

		public virtual void GetFocalPoint(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetFocalPoint_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkProjectedTexture_GetMirrorSeparation_06(HandleRef pThis);

		public virtual double GetMirrorSeparation()
		{
			return vtkProjectedTexture.vtkProjectedTexture_GetMirrorSeparation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetOrientation_07(HandleRef pThis);

		public virtual double[] GetOrientation()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetOrientation_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetOrientation_08(HandleRef pThis, IntPtr data);

		public virtual void GetOrientation(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetOrientation_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetPosition_09(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetPosition_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetPosition_10(HandleRef pThis, IntPtr data);

		public virtual void GetPosition(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetPosition_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetSRange_11(HandleRef pThis);

		public virtual double[] GetSRange()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetSRange_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetSRange_12(HandleRef pThis, IntPtr data);

		public virtual void GetSRange(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetSRange_12(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetTRange_13(HandleRef pThis);

		public virtual double[] GetTRange()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetTRange_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetTRange_14(HandleRef pThis, IntPtr data);

		public virtual void GetTRange(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetTRange_14(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_GetUp_15(HandleRef pThis);

		public virtual double[] GetUp()
		{
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_GetUp_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_GetUp_16(HandleRef pThis, IntPtr data);

		public virtual void GetUp(IntPtr data)
		{
			vtkProjectedTexture.vtkProjectedTexture_GetUp_16(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProjectedTexture_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProjectedTexture.vtkProjectedTexture_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkProjectedTexture_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProjectedTexture.vtkProjectedTexture_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProjectedTexture NewInstance()
		{
			vtkProjectedTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTexture_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedTexture SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedTexture vtkProjectedTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTexture.vtkProjectedTexture_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTexture = (vtkProjectedTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTexture.Register(null);
				}
			}
			return vtkProjectedTexture;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetAspectRatio_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAspectRatio(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetAspectRatio_22(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetAspectRatio_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetAspectRatio(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetAspectRatio_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetCameraMode_24(HandleRef pThis, int _arg);

		public virtual void SetCameraMode(int _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetCameraMode_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetCameraModeToPinhole_25(HandleRef pThis);

		public void SetCameraModeToPinhole()
		{
			vtkProjectedTexture.vtkProjectedTexture_SetCameraModeToPinhole_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetCameraModeToTwoMirror_26(HandleRef pThis);

		public void SetCameraModeToTwoMirror()
		{
			vtkProjectedTexture.vtkProjectedTexture_SetCameraModeToTwoMirror_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetFocalPoint_27(HandleRef pThis, IntPtr focalPoint);

		public void SetFocalPoint(IntPtr focalPoint)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetFocalPoint_27(base.GetCppThis(), focalPoint);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetFocalPoint_28(HandleRef pThis, double x, double y, double z);

		public void SetFocalPoint(double x, double y, double z)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetFocalPoint_28(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetMirrorSeparation_29(HandleRef pThis, double _arg);

		public virtual void SetMirrorSeparation(double _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetMirrorSeparation_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetPosition_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetPosition_30(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetPosition_31(HandleRef pThis, IntPtr _arg);

		public virtual void SetPosition(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetPosition_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetSRange_32(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetSRange(double _arg1, double _arg2)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetSRange_32(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetSRange_33(HandleRef pThis, IntPtr _arg);

		public void SetSRange(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetSRange_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetTRange_34(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetTRange(double _arg1, double _arg2)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetTRange_34(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetTRange_35(HandleRef pThis, IntPtr _arg);

		public void SetTRange(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetTRange_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetUp_36(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetUp(double _arg1, double _arg2, double _arg3)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetUp_36(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkProjectedTexture_SetUp_37(HandleRef pThis, IntPtr _arg);

		public virtual void SetUp(IntPtr _arg)
		{
			vtkProjectedTexture.vtkProjectedTexture_SetUp_37(base.GetCppThis(), _arg);
		}
	}
}
