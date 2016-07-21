using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHull : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHull";

		public new static readonly string MRClassNameKey;

		static vtkHull()
		{
			vtkHull.MRClassNameKey = "class vtkHull";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHull.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHull"));
		}

		public vtkHull(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHull_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHull New()
		{
			vtkHull result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHull.vtkHull_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHull() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHull.vtkHull_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_AddCubeEdgePlanes_01(HandleRef pThis);

		public void AddCubeEdgePlanes()
		{
			vtkHull.vtkHull_AddCubeEdgePlanes_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_AddCubeFacePlanes_02(HandleRef pThis);

		public void AddCubeFacePlanes()
		{
			vtkHull.vtkHull_AddCubeFacePlanes_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_AddCubeVertexPlanes_03(HandleRef pThis);

		public void AddCubeVertexPlanes()
		{
			vtkHull.vtkHull_AddCubeVertexPlanes_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_AddPlane_04(HandleRef pThis, double A, double B, double C);

		public int AddPlane(double A, double B, double C)
		{
			return vtkHull.vtkHull_AddPlane_04(base.GetCppThis(), A, B, C);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_AddPlane_05(HandleRef pThis, IntPtr plane);

		public int AddPlane(IntPtr plane)
		{
			return vtkHull.vtkHull_AddPlane_05(base.GetCppThis(), plane);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_AddPlane_06(HandleRef pThis, double A, double B, double C, double D);

		public int AddPlane(double A, double B, double C, double D)
		{
			return vtkHull.vtkHull_AddPlane_06(base.GetCppThis(), A, B, C, D);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_AddPlane_07(HandleRef pThis, IntPtr plane, double D);

		public int AddPlane(IntPtr plane, double D)
		{
			return vtkHull.vtkHull_AddPlane_07(base.GetCppThis(), plane, D);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_AddRecursiveSpherePlanes_08(HandleRef pThis, int level);

		public void AddRecursiveSpherePlanes(int level)
		{
			vtkHull.vtkHull_AddRecursiveSpherePlanes_08(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_GenerateHull_09(HandleRef pThis, HandleRef pd, IntPtr bounds);

		public void GenerateHull(vtkPolyData pd, IntPtr bounds)
		{
			vtkHull.vtkHull_GenerateHull_09(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_GenerateHull_10(HandleRef pThis, HandleRef pd, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void GenerateHull(vtkPolyData pd, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkHull.vtkHull_GenerateHull_10(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_GetNumberOfPlanes_11(HandleRef pThis);

		public virtual int GetNumberOfPlanes()
		{
			return vtkHull.vtkHull_GetNumberOfPlanes_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHull.vtkHull_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHull_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHull.vtkHull_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHull_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHull NewInstance()
		{
			vtkHull result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHull.vtkHull_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_RemoveAllPlanes_16(HandleRef pThis);

		public void RemoveAllPlanes()
		{
			vtkHull.vtkHull_RemoveAllPlanes_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHull_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHull SafeDownCast(vtkObjectBase o)
		{
			vtkHull vtkHull = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHull.vtkHull_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHull = (vtkHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHull.Register(null);
				}
			}
			return vtkHull;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_SetPlane_18(HandleRef pThis, int i, double A, double B, double C);

		public void SetPlane(int i, double A, double B, double C)
		{
			vtkHull.vtkHull_SetPlane_18(base.GetCppThis(), i, A, B, C);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_SetPlane_19(HandleRef pThis, int i, IntPtr plane);

		public void SetPlane(int i, IntPtr plane)
		{
			vtkHull.vtkHull_SetPlane_19(base.GetCppThis(), i, plane);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_SetPlane_20(HandleRef pThis, int i, double A, double B, double C, double D);

		public void SetPlane(int i, double A, double B, double C, double D)
		{
			vtkHull.vtkHull_SetPlane_20(base.GetCppThis(), i, A, B, C, D);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_SetPlane_21(HandleRef pThis, int i, IntPtr plane, double D);

		public void SetPlane(int i, IntPtr plane, double D)
		{
			vtkHull.vtkHull_SetPlane_21(base.GetCppThis(), i, plane, D);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHull_SetPlanes_22(HandleRef pThis, HandleRef planes);

		public void SetPlanes(vtkPlanes planes)
		{
			vtkHull.vtkHull_SetPlanes_22(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}
	}
}
