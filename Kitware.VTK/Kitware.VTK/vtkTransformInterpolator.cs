using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransformInterpolator : vtkObject
	{
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			INTERPOLATION_TYPE_LINEAR,
			INTERPOLATION_TYPE_MANUAL = 2,
			INTERPOLATION_TYPE_SPLINE = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTransformInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkTransformInterpolator()
		{
			vtkTransformInterpolator.MRClassNameKey = "class vtkTransformInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransformInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransformInterpolator"));
		}

		public vtkTransformInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformInterpolator New()
		{
			vtkTransformInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransformInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransformInterpolator.vtkTransformInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_AddTransform_01(HandleRef pThis, double t, HandleRef xform);

		public void AddTransform(double t, vtkTransform xform)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_AddTransform_01(base.GetCppThis(), t, (xform == null) ? default(HandleRef) : xform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_AddTransform_02(HandleRef pThis, double t, HandleRef matrix);

		public void AddTransform(double t, vtkMatrix4x4 matrix)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_AddTransform_02(base.GetCppThis(), t, (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_AddTransform_03(HandleRef pThis, double t, HandleRef prop3D);

		public void AddTransform(double t, vtkProp3D prop3D)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_AddTransform_03(base.GetCppThis(), t, (prop3D == null) ? default(HandleRef) : prop3D.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTransformInterpolator_GetInterpolationType_04(HandleRef pThis);

		public virtual int GetInterpolationType()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetInterpolationType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTransformInterpolator_GetInterpolationTypeMaxValue_05(HandleRef pThis);

		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetInterpolationTypeMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTransformInterpolator_GetInterpolationTypeMinValue_06(HandleRef pThis);

		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetInterpolationTypeMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTransformInterpolator_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTransformInterpolator_GetMaximumT_08(HandleRef pThis);

		public double GetMaximumT()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetMaximumT_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTransformInterpolator_GetMinimumT_09(HandleRef pThis);

		public double GetMinimumT()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetMinimumT_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTransformInterpolator_GetNumberOfTransforms_10(HandleRef pThis);

		public int GetNumberOfTransforms()
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_GetNumberOfTransforms_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformInterpolator_GetPositionInterpolator_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetPositionInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_GetPositionInterpolator_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTransformInterpolator_GetRotationInterpolator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkQuaternionInterpolator GetRotationInterpolator()
		{
			vtkQuaternionInterpolator vtkQuaternionInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_GetRotationInterpolator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuaternionInterpolator = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuaternionInterpolator.Register(null);
				}
			}
			return vtkQuaternionInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformInterpolator_GetScaleInterpolator_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTupleInterpolator GetScaleInterpolator()
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_GetScaleInterpolator_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkTransformInterpolator_Initialize_14(HandleRef pThis);

		public void Initialize()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_Initialize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_InterpolateTransform_15(HandleRef pThis, double t, HandleRef xform);

		public void InterpolateTransform(double t, vtkTransform xform)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_InterpolateTransform_15(base.GetCppThis(), t, (xform == null) ? default(HandleRef) : xform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTransformInterpolator_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTransformInterpolator_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransformInterpolator.vtkTransformInterpolator_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformInterpolator_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransformInterpolator NewInstance()
		{
			vtkTransformInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_RemoveTransform_20(HandleRef pThis, double t);

		public void RemoveTransform(double t)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_RemoveTransform_20(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTransformInterpolator_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransformInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTransformInterpolator vtkTransformInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransformInterpolator.vtkTransformInterpolator_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransformInterpolator = (vtkTransformInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransformInterpolator.Register(null);
				}
			}
			return vtkTransformInterpolator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetInterpolationType_22(HandleRef pThis, int _arg);

		public virtual void SetInterpolationType(int _arg)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationType_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetInterpolationTypeToLinear_23(HandleRef pThis);

		public void SetInterpolationTypeToLinear()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationTypeToLinear_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetInterpolationTypeToManual_24(HandleRef pThis);

		public void SetInterpolationTypeToManual()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationTypeToManual_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetInterpolationTypeToSpline_25(HandleRef pThis);

		public void SetInterpolationTypeToSpline()
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetInterpolationTypeToSpline_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetPositionInterpolator_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetPositionInterpolator(vtkTupleInterpolator arg0)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetPositionInterpolator_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetRotationInterpolator_27(HandleRef pThis, HandleRef arg0);

		public virtual void SetRotationInterpolator(vtkQuaternionInterpolator arg0)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetRotationInterpolator_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTransformInterpolator_SetScaleInterpolator_28(HandleRef pThis, HandleRef arg0);

		public virtual void SetScaleInterpolator(vtkTupleInterpolator arg0)
		{
			vtkTransformInterpolator.vtkTransformInterpolator_SetScaleInterpolator_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
