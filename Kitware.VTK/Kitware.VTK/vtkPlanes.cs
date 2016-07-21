using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlanes : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlanes";

		public new static readonly string MRClassNameKey;

		static vtkPlanes()
		{
			vtkPlanes.MRClassNameKey = "class vtkPlanes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlanes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlanes"));
		}

		public vtkPlanes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlanes New()
		{
			vtkPlanes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanes.vtkPlanes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlanes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlanes.vtkPlanes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlanes_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkPlanes.vtkPlanes_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPlanes_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkPlanes.vtkPlanes_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkPlanes.vtkPlanes_EvaluateGradient_03(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanes_GetNormals_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetNormals()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanes.vtkPlanes_GetNormals_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlanes_GetNumberOfPlanes_05(HandleRef pThis);

		public int GetNumberOfPlanes()
		{
			return vtkPlanes.vtkPlanes_GetNumberOfPlanes_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanes_GetPlane_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPlane GetPlane(int i)
		{
			vtkPlane vtkPlane = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanes.vtkPlanes_GetPlane_06(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlane = (vtkPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlane.Register(null);
				}
			}
			return vtkPlane;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_GetPlane_07(HandleRef pThis, int i, HandleRef plane);

		public void GetPlane(int i, vtkPlane plane)
		{
			vtkPlanes.vtkPlanes_GetPlane_07(base.GetCppThis(), i, (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanes_GetPoints_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanes.vtkPlanes_GetPoints_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlanes_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlanes.vtkPlanes_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPlanes_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlanes.vtkPlanes_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanes_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlanes NewInstance()
		{
			vtkPlanes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanes.vtkPlanes_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanes_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlanes SafeDownCast(vtkObjectBase o)
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanes.vtkPlanes_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_SetBounds_14(HandleRef pThis, IntPtr bounds);

		public void SetBounds(IntPtr bounds)
		{
			vtkPlanes.vtkPlanes_SetBounds_14(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_SetBounds_15(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkPlanes.vtkPlanes_SetBounds_15(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_SetFrustumPlanes_16(HandleRef pThis, IntPtr planes);

		public void SetFrustumPlanes(IntPtr planes)
		{
			vtkPlanes.vtkPlanes_SetFrustumPlanes_16(base.GetCppThis(), planes);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_SetNormals_17(HandleRef pThis, HandleRef normals);

		public void SetNormals(vtkDataArray normals)
		{
			vtkPlanes.vtkPlanes_SetNormals_17(base.GetCppThis(), (normals == null) ? default(HandleRef) : normals.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPlanes_SetPoints_18(HandleRef pThis, HandleRef arg0);

		public virtual void SetPoints(vtkPoints arg0)
		{
			vtkPlanes.vtkPlanes_SetPoints_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
