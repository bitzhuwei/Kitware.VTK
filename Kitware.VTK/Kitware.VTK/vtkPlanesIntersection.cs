using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlanesIntersection : vtkPlanes
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlanesIntersection";

		public new static readonly string MRClassNameKey;

		static vtkPlanesIntersection()
		{
			vtkPlanesIntersection.MRClassNameKey = "class vtkPlanesIntersection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlanesIntersection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlanesIntersection"));
		}

		public vtkPlanesIntersection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanesIntersection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlanesIntersection New()
		{
			vtkPlanesIntersection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlanesIntersection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlanesIntersection.vtkPlanesIntersection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanesIntersection_Convert3DCell_01(HandleRef cell, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkPlanesIntersection Convert3DCell(vtkCell cell)
		{
			vtkPlanesIntersection vtkPlanesIntersection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_Convert3DCell_01((cell == null) ? default(HandleRef) : cell.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanesIntersection = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanesIntersection.Register(null);
				}
			}
			return vtkPlanesIntersection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPlanesIntersection_GetNumRegionVertices_02(HandleRef pThis);

		public int GetNumRegionVertices()
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetNumRegionVertices_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPlanesIntersection_GetRegionVertices_03(HandleRef pThis, IntPtr v, int nvertices);

		public int GetRegionVertices(IntPtr v, int nvertices)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_GetRegionVertices_03(base.GetCppThis(), v, nvertices);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPlanesIntersection_IntersectsRegion_04(HandleRef pThis, HandleRef R);

		public int IntersectsRegion(vtkPoints R)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_IntersectsRegion_04(base.GetCppThis(), (R == null) ? default(HandleRef) : R.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPlanesIntersection_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPlanesIntersection_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanesIntersection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlanesIntersection NewInstance()
		{
			vtkPlanesIntersection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPlanesIntersection_PolygonIntersectsBBox_09(IntPtr bounds, HandleRef pts);

		public static int PolygonIntersectsBBox(IntPtr bounds, vtkPoints pts)
		{
			return vtkPlanesIntersection.vtkPlanesIntersection_PolygonIntersectsBBox_09(bounds, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPlanesIntersection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlanesIntersection SafeDownCast(vtkObjectBase o)
		{
			vtkPlanesIntersection vtkPlanesIntersection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlanesIntersection.vtkPlanesIntersection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanesIntersection = (vtkPlanesIntersection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanesIntersection.Register(null);
				}
			}
			return vtkPlanesIntersection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPlanesIntersection_SetRegionVertices_11(HandleRef pThis, HandleRef pts);

		public void SetRegionVertices(vtkPoints pts)
		{
			vtkPlanesIntersection.vtkPlanesIntersection_SetRegionVertices_11(base.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPlanesIntersection_SetRegionVertices_12(HandleRef pThis, IntPtr v, int nvertices);

		public void SetRegionVertices(IntPtr v, int nvertices)
		{
			vtkPlanesIntersection.vtkPlanesIntersection_SetRegionVertices_12(base.GetCppThis(), v, nvertices);
		}
	}
}
