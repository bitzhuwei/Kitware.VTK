using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAttributesErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributesErrorMetric";

		public new static readonly string MRClassNameKey;

		static vtkAttributesErrorMetric()
		{
			vtkAttributesErrorMetric.MRClassNameKey = "class vtkAttributesErrorMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributesErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributesErrorMetric"));
		}

		public vtkAttributesErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributesErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAttributesErrorMetric New()
		{
			vtkAttributesErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributesErrorMetric.vtkAttributesErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAttributesErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAttributesErrorMetric.vtkAttributesErrorMetric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAttributesErrorMetric_GetAbsoluteAttributeTolerance_01(HandleRef pThis);

		public virtual double GetAbsoluteAttributeTolerance()
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetAbsoluteAttributeTolerance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAttributesErrorMetric_GetAttributeTolerance_02(HandleRef pThis);

		public virtual double GetAttributeTolerance()
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetAttributeTolerance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAttributesErrorMetric_GetError_03(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_GetError_03(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAttributesErrorMetric_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAttributesErrorMetric_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributesErrorMetric_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAttributesErrorMetric NewInstance()
		{
			vtkAttributesErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributesErrorMetric.vtkAttributesErrorMetric_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAttributesErrorMetric_RequiresEdgeSubdivision_08(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkAttributesErrorMetric.vtkAttributesErrorMetric_RequiresEdgeSubdivision_08(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributesErrorMetric_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAttributesErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkAttributesErrorMetric vtkAttributesErrorMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributesErrorMetric.vtkAttributesErrorMetric_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributesErrorMetric = (vtkAttributesErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributesErrorMetric.Register(null);
				}
			}
			return vtkAttributesErrorMetric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAttributesErrorMetric_SetAbsoluteAttributeTolerance_10(HandleRef pThis, double value);

		public void SetAbsoluteAttributeTolerance(double value)
		{
			vtkAttributesErrorMetric.vtkAttributesErrorMetric_SetAbsoluteAttributeTolerance_10(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAttributesErrorMetric_SetAttributeTolerance_11(HandleRef pThis, double value);

		public void SetAttributeTolerance(double value)
		{
			vtkAttributesErrorMetric.vtkAttributesErrorMetric_SetAttributeTolerance_11(base.GetCppThis(), value);
		}
	}
}
