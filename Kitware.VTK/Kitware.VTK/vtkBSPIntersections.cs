using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBSPIntersections : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBSPIntersections";

		public new static readonly string MRClassNameKey;

		static vtkBSPIntersections()
		{
			vtkBSPIntersections.MRClassNameKey = "class vtkBSPIntersections";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBSPIntersections.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSPIntersections"));
		}

		public vtkBSPIntersections(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPIntersections_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBSPIntersections New()
		{
			vtkBSPIntersections result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBSPIntersections() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBSPIntersections.vtkBSPIntersections_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOff_01(HandleRef pThis);

		public void ComputeIntersectionsUsingDataBoundsOff()
		{
			vtkBSPIntersections.vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOn_02(HandleRef pThis);

		public void ComputeIntersectionsUsingDataBoundsOn()
		{
			vtkBSPIntersections.vtkBSPIntersections_ComputeIntersectionsUsingDataBoundsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_GetBounds_03(HandleRef pThis, IntPtr bounds);

		public int GetBounds(IntPtr bounds)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetBounds_03(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_GetComputeIntersectionsUsingDataBounds_04(HandleRef pThis);

		public virtual int GetComputeIntersectionsUsingDataBounds()
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetComputeIntersectionsUsingDataBounds_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPIntersections_GetCuts_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkBSPCuts GetCuts()
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_GetCuts_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_GetNumberOfRegions_06(HandleRef pThis);

		public int GetNumberOfRegions()
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetNumberOfRegions_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_GetRegionBounds_07(HandleRef pThis, int regionID, IntPtr bounds);

		public int GetRegionBounds(int regionID, IntPtr bounds)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetRegionBounds_07(base.GetCppThis(), regionID, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_GetRegionDataBounds_08(HandleRef pThis, int regionID, IntPtr bounds);

		public int GetRegionDataBounds(int regionID, IntPtr bounds)
		{
			return vtkBSPIntersections.vtkBSPIntersections_GetRegionDataBounds_08(base.GetCppThis(), regionID, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsBox_09(HandleRef pThis, int regionId, IntPtr x);

		public int IntersectsBox(int regionId, IntPtr x)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_09(base.GetCppThis(), regionId, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsBox_10(HandleRef pThis, int regionId, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public int IntersectsBox(int regionId, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_10(base.GetCppThis(), regionId, xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsBox_11(HandleRef pThis, IntPtr ids, int len, IntPtr x);

		public int IntersectsBox(IntPtr ids, int len, IntPtr x)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_11(base.GetCppThis(), ids, len, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsBox_12(HandleRef pThis, IntPtr ids, int len, double x0, double x1, double y0, double y1, double z0, double z1);

		public int IntersectsBox(IntPtr ids, int len, double x0, double x1, double y0, double y1, double z0, double z1)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsBox_12(base.GetCppThis(), ids, len, x0, x1, y0, y1, z0, z1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsCell_13(HandleRef pThis, int regionId, HandleRef cell, int cellRegion);

		public int IntersectsCell(int regionId, vtkCell cell, int cellRegion)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsCell_13(base.GetCppThis(), regionId, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellRegion);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsCell_14(HandleRef pThis, IntPtr ids, int len, HandleRef cell, int cellRegion);

		public int IntersectsCell(IntPtr ids, int len, vtkCell cell, int cellRegion)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsCell_14(base.GetCppThis(), ids, len, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellRegion);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsSphere2_15(HandleRef pThis, int regionId, double x, double y, double z, double rSquared);

		public int IntersectsSphere2(int regionId, double x, double y, double z, double rSquared)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsSphere2_15(base.GetCppThis(), regionId, x, y, z, rSquared);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IntersectsSphere2_16(HandleRef pThis, IntPtr ids, int len, double x, double y, double z, double rSquared);

		public int IntersectsSphere2(IntPtr ids, int len, double x, double y, double z, double rSquared)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IntersectsSphere2_16(base.GetCppThis(), ids, len, x, y, z, rSquared);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPIntersections_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBSPIntersections.vtkBSPIntersections_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPIntersections_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBSPIntersections NewInstance()
		{
			vtkBSPIntersections result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPIntersections_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBSPIntersections SafeDownCast(vtkObjectBase o)
		{
			vtkBSPIntersections vtkBSPIntersections = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPIntersections.vtkBSPIntersections_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPIntersections = (vtkBSPIntersections)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPIntersections.Register(null);
				}
			}
			return vtkBSPIntersections;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPIntersections_SetComputeIntersectionsUsingDataBounds_22(HandleRef pThis, int c);

		public void SetComputeIntersectionsUsingDataBounds(int c)
		{
			vtkBSPIntersections.vtkBSPIntersections_SetComputeIntersectionsUsingDataBounds_22(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPIntersections_SetCuts_23(HandleRef pThis, HandleRef cuts);

		public void SetCuts(vtkBSPCuts cuts)
		{
			vtkBSPIntersections.vtkBSPIntersections_SetCuts_23(base.GetCppThis(), (cuts == null) ? default(HandleRef) : cuts.GetCppThis());
		}
	}
}
