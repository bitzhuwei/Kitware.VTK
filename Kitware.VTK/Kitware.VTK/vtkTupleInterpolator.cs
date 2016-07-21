using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTupleInterpolator : vtkObject
	{
		public enum INTERPOLATION_TYPE_LINEAR_WrapperEnum
		{
			INTERPOLATION_TYPE_LINEAR,
			INTERPOLATION_TYPE_SPLINE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTupleInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkTupleInterpolator()
		{
			vtkTupleInterpolator.MRClassNameKey = "class vtkTupleInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTupleInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTupleInterpolator"));
		}

		public vtkTupleInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTupleInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTupleInterpolator New()
		{
			vtkTupleInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTupleInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTupleInterpolator.vtkTupleInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_AddTuple_01(HandleRef pThis, double t, IntPtr tuple);

		public void AddTuple(double t, IntPtr tuple)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_AddTuple_01(base.GetCppThis(), t, tuple);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTupleInterpolator_GetInterpolatingSpline_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSpline GetInterpolatingSpline()
		{
			vtkSpline vtkSpline = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_GetInterpolatingSpline_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpline = (vtkSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpline.Register(null);
				}
			}
			return vtkSpline;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTupleInterpolator_GetInterpolationType_03(HandleRef pThis);

		public virtual int GetInterpolationType()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetInterpolationType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTupleInterpolator_GetMaximumT_04(HandleRef pThis);

		public double GetMaximumT()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetMaximumT_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTupleInterpolator_GetMinimumT_05(HandleRef pThis);

		public double GetMinimumT()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetMinimumT_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTupleInterpolator_GetNumberOfComponents_06(HandleRef pThis);

		public virtual int GetNumberOfComponents()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetNumberOfComponents_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTupleInterpolator_GetNumberOfTuples_07(HandleRef pThis);

		public int GetNumberOfTuples()
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_GetNumberOfTuples_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_Initialize_08(HandleRef pThis);

		public void Initialize()
		{
			vtkTupleInterpolator.vtkTupleInterpolator_Initialize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_InterpolateTuple_09(HandleRef pThis, double t, IntPtr tuple);

		public void InterpolateTuple(double t, IntPtr tuple)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_InterpolateTuple_09(base.GetCppThis(), t, tuple);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTupleInterpolator_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTupleInterpolator_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTupleInterpolator.vtkTupleInterpolator_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTupleInterpolator_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTupleInterpolator NewInstance()
		{
			vtkTupleInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTupleInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_RemoveTuple_14(HandleRef pThis, double t);

		public void RemoveTuple(double t)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_RemoveTuple_14(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTupleInterpolator_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTupleInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkTupleInterpolator vtkTupleInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTupleInterpolator.vtkTupleInterpolator_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkTupleInterpolator_SetInterpolatingSpline_16(HandleRef pThis, HandleRef arg0);

		public void SetInterpolatingSpline(vtkSpline arg0)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolatingSpline_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_SetInterpolationType_17(HandleRef pThis, int type);

		public void SetInterpolationType(int type)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolationType_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_SetInterpolationTypeToLinear_18(HandleRef pThis);

		public void SetInterpolationTypeToLinear()
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolationTypeToLinear_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_SetInterpolationTypeToSpline_19(HandleRef pThis);

		public void SetInterpolationTypeToSpline()
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetInterpolationTypeToSpline_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTupleInterpolator_SetNumberOfComponents_20(HandleRef pThis, int numComp);

		public void SetNumberOfComponents(int numComp)
		{
			vtkTupleInterpolator.vtkTupleInterpolator_SetNumberOfComponents_20(base.GetCppThis(), numComp);
		}
	}
}
