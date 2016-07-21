using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointsProjectedHull : vtkPoints
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointsProjectedHull";

		public new static readonly string MRClassNameKey;

		static vtkPointsProjectedHull()
		{
			vtkPointsProjectedHull.MRClassNameKey = "class vtkPointsProjectedHull";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointsProjectedHull.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointsProjectedHull"));
		}

		public vtkPointsProjectedHull(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointsProjectedHull_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointsProjectedHull New()
		{
			vtkPointsProjectedHull result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointsProjectedHull.vtkPointsProjectedHull_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointsProjectedHull() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointsProjectedHull.vtkPointsProjectedHull_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_GetCCWHullX_01(HandleRef pThis, IntPtr pts, int len);

		public int GetCCWHullX(IntPtr pts, int len)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetCCWHullX_01(base.GetCppThis(), pts, len);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_GetCCWHullY_02(HandleRef pThis, IntPtr pts, int len);

		public int GetCCWHullY(IntPtr pts, int len)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetCCWHullY_02(base.GetCppThis(), pts, len);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_GetCCWHullZ_03(HandleRef pThis, IntPtr pts, int len);

		public int GetCCWHullZ(IntPtr pts, int len)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetCCWHullZ_03(base.GetCppThis(), pts, len);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_GetSizeCCWHullX_04(HandleRef pThis);

		public int GetSizeCCWHullX()
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetSizeCCWHullX_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_GetSizeCCWHullY_05(HandleRef pThis);

		public int GetSizeCCWHullY()
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetSizeCCWHullY_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_GetSizeCCWHullZ_06(HandleRef pThis);

		public int GetSizeCCWHullZ()
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_GetSizeCCWHullZ_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointsProjectedHull_Initialize_07(HandleRef pThis);

		public override void Initialize()
		{
			vtkPointsProjectedHull.vtkPointsProjectedHull_Initialize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointsProjectedHull_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointsProjectedHull NewInstance()
		{
			vtkPointsProjectedHull result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointsProjectedHull.vtkPointsProjectedHull_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_12(HandleRef pThis, HandleRef R);

		public int RectangleIntersectionX(vtkPoints R)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionX_12(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_13(HandleRef pThis, float ymin, float ymax, float zmin, float zmax);

		public int RectangleIntersectionX(float ymin, float ymax, float zmin, float zmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionX_13(base.GetCppThis(), ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionX_14(HandleRef pThis, double ymin, double ymax, double zmin, double zmax);

		public int RectangleIntersectionX(double ymin, double ymax, double zmin, double zmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionX_14(base.GetCppThis(), ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_15(HandleRef pThis, HandleRef R);

		public int RectangleIntersectionY(vtkPoints R)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionY_15(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_16(HandleRef pThis, float zmin, float zmax, float xmin, float xmax);

		public int RectangleIntersectionY(float zmin, float zmax, float xmin, float xmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionY_16(base.GetCppThis(), zmin, zmax, xmin, xmax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionY_17(HandleRef pThis, double zmin, double zmax, double xmin, double xmax);

		public int RectangleIntersectionY(double zmin, double zmax, double xmin, double xmax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionY_17(base.GetCppThis(), zmin, zmax, xmin, xmax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_18(HandleRef pThis, HandleRef R);

		public int RectangleIntersectionZ(vtkPoints R)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionZ_18(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_19(HandleRef pThis, float xmin, float xmax, float ymin, float ymax);

		public int RectangleIntersectionZ(float xmin, float xmax, float ymin, float ymax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionZ_19(base.GetCppThis(), xmin, xmax, ymin, ymax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPointsProjectedHull_RectangleIntersectionZ_20(HandleRef pThis, double xmin, double xmax, double ymin, double ymax);

		public int RectangleIntersectionZ(double xmin, double xmax, double ymin, double ymax)
		{
			return vtkPointsProjectedHull.vtkPointsProjectedHull_RectangleIntersectionZ_20(base.GetCppThis(), xmin, xmax, ymin, ymax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointsProjectedHull_Reset_21(HandleRef pThis);

		public override void Reset()
		{
			vtkPointsProjectedHull.vtkPointsProjectedHull_Reset_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointsProjectedHull_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointsProjectedHull SafeDownCast(vtkObjectBase o)
		{
			vtkPointsProjectedHull vtkPointsProjectedHull = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointsProjectedHull.vtkPointsProjectedHull_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointsProjectedHull = (vtkPointsProjectedHull)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointsProjectedHull.Register(null);
				}
			}
			return vtkPointsProjectedHull;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPointsProjectedHull_Update_23(HandleRef pThis);

		public void Update()
		{
			vtkPointsProjectedHull.vtkPointsProjectedHull_Update_23(base.GetCppThis());
		}
	}
}
