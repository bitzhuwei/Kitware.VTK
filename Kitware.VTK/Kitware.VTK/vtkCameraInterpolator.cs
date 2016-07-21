using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCameraInterpolator : vtkObject
	{
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			INTERPOLATION_TYPE_LINEAR,
			INTERPOLATION_TYPE_MANUAL = 2,
			INTERPOLATION_TYPE_SPLINE = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkCameraInterpolator()
		{
			vtkCameraInterpolator.MRClassNameKey = "class vtkCameraInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraInterpolator"));
		}

		public vtkCameraInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraInterpolator New()
		{
			vtkCameraInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCameraInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCameraInterpolator.vtkCameraInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_AddCamera_01(HandleRef pThis, double t, HandleRef camera);

		public void AddCamera(double t, vtkCamera camera)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_AddCamera_01(base.GetCppThis(), t, (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_GetClippingRangeInterpolator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetClippingRangeInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetClippingRangeInterpolator_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_GetFocalPointInterpolator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetFocalPointInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetFocalPointInterpolator_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraInterpolator_GetInterpolationType_04(HandleRef pThis);

		public virtual int GetInterpolationType()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetInterpolationType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraInterpolator_GetInterpolationTypeMaxValue_05(HandleRef pThis);

		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetInterpolationTypeMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraInterpolator_GetInterpolationTypeMinValue_06(HandleRef pThis);

		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetInterpolationTypeMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkCameraInterpolator_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCameraInterpolator_GetMaximumT_08(HandleRef pThis);

		public double GetMaximumT()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetMaximumT_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCameraInterpolator_GetMinimumT_09(HandleRef pThis);

		public double GetMinimumT()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetMinimumT_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraInterpolator_GetNumberOfCameras_10(HandleRef pThis);

		public int GetNumberOfCameras()
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_GetNumberOfCameras_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_GetParallelScaleInterpolator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetParallelScaleInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetParallelScaleInterpolator_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_GetPositionInterpolator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetPositionInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetPositionInterpolator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_GetViewAngleInterpolator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetViewAngleInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetViewAngleInterpolator_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_GetViewUpInterpolator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetViewUpInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_GetViewUpInterpolator_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTupleInterpolator = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTupleInterpolator.Register(null);
				}
			}
			return vtkTupleInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_Initialize_15(HandleRef pThis);

		public void Initialize()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_Initialize_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_InterpolateCamera_16(HandleRef pThis, double t, HandleRef camera);

		public void InterpolateCamera(double t, vtkCamera camera)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_InterpolateCamera_16(base.GetCppThis(), t, (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraInterpolator_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraInterpolator_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCameraInterpolator.vtkCameraInterpolator_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCameraInterpolator NewInstance()
		{
			vtkCameraInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_RemoveCamera_21(HandleRef pThis, double t);

		public void RemoveCamera(double t)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_RemoveCamera_21(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraInterpolator_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkCameraInterpolator vtkCameraInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraInterpolator.vtkCameraInterpolator_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraInterpolator = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraInterpolator.Register(null);
				}
			}
			return vtkCameraInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetClippingRangeInterpolator_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetClippingRangeInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetClippingRangeInterpolator_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetFocalPointInterpolator_24(HandleRef pThis, HandleRef arg0);

		public virtual void SetFocalPointInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetFocalPointInterpolator_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetInterpolationType_25(HandleRef pThis, int _arg);

		public virtual void SetInterpolationType(int _arg)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationType_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetInterpolationTypeToLinear_26(HandleRef pThis);

		public void SetInterpolationTypeToLinear()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationTypeToLinear_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetInterpolationTypeToManual_27(HandleRef pThis);

		public void SetInterpolationTypeToManual()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationTypeToManual_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetInterpolationTypeToSpline_28(HandleRef pThis);

		public void SetInterpolationTypeToSpline()
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetInterpolationTypeToSpline_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetParallelScaleInterpolator_29(HandleRef pThis, HandleRef arg0);

		public virtual void SetParallelScaleInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetParallelScaleInterpolator_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetPositionInterpolator_30(HandleRef pThis, HandleRef arg0);

		public virtual void SetPositionInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetPositionInterpolator_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetViewAngleInterpolator_31(HandleRef pThis, HandleRef arg0);

		public virtual void SetViewAngleInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetViewAngleInterpolator_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraInterpolator_SetViewUpInterpolator_32(HandleRef pThis, HandleRef arg0);

		public virtual void SetViewUpInterpolator(vtkTupleInterpolator arg0)
		{
			vtkCameraInterpolator.vtkCameraInterpolator_SetViewUpInterpolator_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
