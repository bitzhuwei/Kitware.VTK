using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkViewDependentErrorMetric : vtkGenericSubdivisionErrorMetric
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkViewDependentErrorMetric";

		public new static readonly string MRClassNameKey;

		static vtkViewDependentErrorMetric()
		{
			vtkViewDependentErrorMetric.MRClassNameKey = "class vtkViewDependentErrorMetric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkViewDependentErrorMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkViewDependentErrorMetric"));
		}

		public vtkViewDependentErrorMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewDependentErrorMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewDependentErrorMetric New()
		{
			vtkViewDependentErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkViewDependentErrorMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewDependentErrorMetric_GetError_01(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override double GetError(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetError_01(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkViewDependentErrorMetric_GetPixelTolerance_02(HandleRef pThis);

		public virtual double GetPixelTolerance()
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetPixelTolerance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewDependentErrorMetric_GetViewport_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkViewport GetViewport()
		{
			vtkViewport vtkViewport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_GetViewport_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewport = (vtkViewport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewport.Register(null);
				}
			}
			return vtkViewport;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewDependentErrorMetric_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewDependentErrorMetric_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewDependentErrorMetric_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkViewDependentErrorMetric NewInstance()
		{
			vtkViewDependentErrorMetric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkViewDependentErrorMetric_RequiresEdgeSubdivision_08(HandleRef pThis, IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha);

		public override int RequiresEdgeSubdivision(IntPtr leftPoint, IntPtr midPoint, IntPtr rightPoint, double alpha)
		{
			return vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_RequiresEdgeSubdivision_08(base.GetCppThis(), leftPoint, midPoint, rightPoint, alpha);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkViewDependentErrorMetric_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkViewDependentErrorMetric SafeDownCast(vtkObjectBase o)
		{
			vtkViewDependentErrorMetric vtkViewDependentErrorMetric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkViewDependentErrorMetric = (vtkViewDependentErrorMetric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkViewDependentErrorMetric.Register(null);
				}
			}
			return vtkViewDependentErrorMetric;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewDependentErrorMetric_SetPixelTolerance_10(HandleRef pThis, double value);

		public void SetPixelTolerance(double value)
		{
			vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_SetPixelTolerance_10(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkViewDependentErrorMetric_SetViewport_11(HandleRef pThis, HandleRef viewport);

		public void SetViewport(vtkViewport viewport)
		{
			vtkViewDependentErrorMetric.vtkViewDependentErrorMetric_SetViewport_11(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}
	}
}
