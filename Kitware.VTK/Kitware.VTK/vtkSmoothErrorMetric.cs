using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSmoothErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSmoothErrorMetric";

		public new static readonly string MRClassNameKey;

		static vtkSmoothErrorMetric()
		{
			vtkSmoothErrorMetric.MRClassNameKey = "class vtkSmoothErrorMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSmoothErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSmoothErrorMetric"));
		}

		public vtkSmoothErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSmoothErrorMetric New()
		{
			vtkSmoothErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothErrorMetric.vtkSmoothErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSmoothErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSmoothErrorMetric.vtkSmoothErrorMetric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSmoothErrorMetric_GetAngleTolerance_01(HandleRef pThis);

		public double GetAngleTolerance()
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_GetAngleTolerance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkSmoothErrorMetric_GetError_02(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_GetError_02(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSmoothErrorMetric_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSmoothErrorMetric_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothErrorMetric_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSmoothErrorMetric NewInstance()
		{
			vtkSmoothErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothErrorMetric.vtkSmoothErrorMetric_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSmoothErrorMetric_RequiresEdgeSubdivision_07(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkSmoothErrorMetric.vtkSmoothErrorMetric_RequiresEdgeSubdivision_07(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSmoothErrorMetric_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSmoothErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkSmoothErrorMetric vtkSmoothErrorMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSmoothErrorMetric.vtkSmoothErrorMetric_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSmoothErrorMetric = (vtkSmoothErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSmoothErrorMetric.Register(null);
				}
			}
			return vtkSmoothErrorMetric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkSmoothErrorMetric_SetAngleTolerance_09(HandleRef pThis, double value);

		public void SetAngleTolerance(double value)
		{
			vtkSmoothErrorMetric.vtkSmoothErrorMetric_SetAngleTolerance_09(base.GetCppThis(), value);
		}
	}
}
