using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeometricErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeometricErrorMetric";

		public new static readonly string MRClassNameKey;

		static vtkGeometricErrorMetric()
		{
			vtkGeometricErrorMetric.MRClassNameKey = "class vtkGeometricErrorMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeometricErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeometricErrorMetric"));
		}

		public vtkGeometricErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometricErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeometricErrorMetric New()
		{
			vtkGeometricErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometricErrorMetric.vtkGeometricErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeometricErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeometricErrorMetric.vtkGeometricErrorMetric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGeometricErrorMetric_GetAbsoluteGeometricTolerance_01(HandleRef pThis);

		public virtual double GetAbsoluteGeometricTolerance()
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetAbsoluteGeometricTolerance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGeometricErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetError_02(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGeometricErrorMetric_GetRelative_03(HandleRef pThis);

		public int GetRelative()
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_GetRelative_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGeometricErrorMetric_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGeometricErrorMetric_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometricErrorMetric_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeometricErrorMetric NewInstance()
		{
			vtkGeometricErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometricErrorMetric.vtkGeometricErrorMetric_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGeometricErrorMetric_RequiresEdgeSubdivision_08(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkGeometricErrorMetric.vtkGeometricErrorMetric_RequiresEdgeSubdivision_08(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometricErrorMetric_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeometricErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkGeometricErrorMetric vtkGeometricErrorMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometricErrorMetric.vtkGeometricErrorMetric_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeometricErrorMetric = (vtkGeometricErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeometricErrorMetric.Register(null);
				}
			}
			return vtkGeometricErrorMetric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGeometricErrorMetric_SetAbsoluteGeometricTolerance_10(HandleRef pThis, double value);

		public void SetAbsoluteGeometricTolerance(double value)
		{
			vtkGeometricErrorMetric.vtkGeometricErrorMetric_SetAbsoluteGeometricTolerance_10(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGeometricErrorMetric_SetRelativeGeometricTolerance_11(HandleRef pThis, double value, HandleRef ds);

		public void SetRelativeGeometricTolerance(double value, vtkGenericDataSet ds)
		{
			vtkGeometricErrorMetric.vtkGeometricErrorMetric_SetRelativeGeometricTolerance_11(base.GetCppThis(), value, (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}
	}
}
