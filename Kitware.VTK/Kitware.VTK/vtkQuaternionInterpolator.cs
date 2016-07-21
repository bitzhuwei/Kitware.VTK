using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuaternionInterpolator : vtkObject
	{
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			INTERPOLATION_TYPE_LINEAR,
			INTERPOLATION_TYPE_SPLINE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkQuaternionInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkQuaternionInterpolator()
		{
			vtkQuaternionInterpolator.MRClassNameKey = "class vtkQuaternionInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuaternionInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuaternionInterpolator"));
		}

		public vtkQuaternionInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuaternionInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuaternionInterpolator New()
		{
			vtkQuaternionInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuaternionInterpolator.vtkQuaternionInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuaternionInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuaternionInterpolator.vtkQuaternionInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuaternionInterpolator_AddQuaternion_01(HandleRef pThis, double t, IntPtr q);

		public void AddQuaternion(double t, IntPtr q)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_AddQuaternion_01(base.GetCppThis(), t, q);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuaternionInterpolator_GetInterpolationType_02(HandleRef pThis);

		public virtual int GetInterpolationType()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetInterpolationType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuaternionInterpolator_GetInterpolationTypeMaxValue_03(HandleRef pThis);

		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetInterpolationTypeMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuaternionInterpolator_GetInterpolationTypeMinValue_04(HandleRef pThis);

		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetInterpolationTypeMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkQuaternionInterpolator_GetMaximumT_05(HandleRef pThis);

		public double GetMaximumT()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetMaximumT_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkQuaternionInterpolator_GetMinimumT_06(HandleRef pThis);

		public double GetMinimumT()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetMinimumT_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuaternionInterpolator_GetNumberOfQuaternions_07(HandleRef pThis);

		public int GetNumberOfQuaternions()
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_GetNumberOfQuaternions_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuaternionInterpolator_Initialize_08(HandleRef pThis);

		public void Initialize()
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_Initialize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuaternionInterpolator_InterpolateQuaternion_09(HandleRef pThis, double t, IntPtr q);

		public void InterpolateQuaternion(double t, IntPtr q)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_InterpolateQuaternion_09(base.GetCppThis(), t, q);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuaternionInterpolator_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkQuaternionInterpolator_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuaternionInterpolator.vtkQuaternionInterpolator_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuaternionInterpolator_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuaternionInterpolator NewInstance()
		{
			vtkQuaternionInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuaternionInterpolator.vtkQuaternionInterpolator_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuaternionInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuaternionInterpolator_RemoveQuaternion_14(HandleRef pThis, double t);

		public void RemoveQuaternion(double t)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_RemoveQuaternion_14(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuaternionInterpolator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuaternionInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkQuaternionInterpolator vtkQuaternionInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuaternionInterpolator.vtkQuaternionInterpolator_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkQuaternionInterpolator_SetInterpolationType_16(HandleRef pThis, int _arg);

		public virtual void SetInterpolationType(int _arg)
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetInterpolationType_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuaternionInterpolator_SetInterpolationTypeToLinear_17(HandleRef pThis);

		public void SetInterpolationTypeToLinear()
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetInterpolationTypeToLinear_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkQuaternionInterpolator_SetInterpolationTypeToSpline_18(HandleRef pThis);

		public void SetInterpolationTypeToSpline()
		{
			vtkQuaternionInterpolator.vtkQuaternionInterpolator_SetInterpolationTypeToSpline_18(base.GetCppThis());
		}
	}
}
