using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOBBTree : vtkAbstractCellLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOBBTree";

		public new static readonly string MRClassNameKey;

		static vtkOBBTree()
		{
			vtkOBBTree.MRClassNameKey = "class vtkOBBTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOBBTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOBBTree"));
		}

		public vtkOBBTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOBBTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOBBTree New()
		{
			vtkOBBTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOBBTree.vtkOBBTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOBBTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOBBTree.vtkOBBTree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkOBBTree.vtkOBBTree_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_ComputeOBB_02(HandleRef pts, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size);

		public static void ComputeOBB(vtkPoints pts, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size)
		{
			vtkOBBTree.vtkOBBTree_ComputeOBB_02((pts == null) ? default(HandleRef) : pts.GetCppThis(), corner, max, mid, min, size);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_ComputeOBB_03(HandleRef pThis, HandleRef input, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size);

		public void ComputeOBB(vtkDataSet input, IntPtr corner, IntPtr max, IntPtr mid, IntPtr min, IntPtr size)
		{
			vtkOBBTree.vtkOBBTree_ComputeOBB_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), corner, max, mid, min, size);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_FindClosestPoint_04(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			vtkOBBTree.vtkOBBTree_FindClosestPoint_04(base.GetCppThis(), x, closestPoint, ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_FindClosestPoint_05(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkOBBTree.vtkOBBTree_FindClosestPoint_05(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkOBBTree_FindClosestPointWithinRadius_06(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkOBBTree.vtkOBBTree_FindClosestPointWithinRadius_06(base.GetCppThis(), x, radius, closestPoint, ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkOBBTree_FindClosestPointWithinRadius_07(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkOBBTree.vtkOBBTree_FindClosestPointWithinRadius_07(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkOBBTree_FindClosestPointWithinRadius_08(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkOBBTree.vtkOBBTree_FindClosestPointWithinRadius_08(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_FreeSearchStructure_09(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkOBBTree.vtkOBBTree_FreeSearchStructure_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkOBBTree_GenerateRepresentation_10(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkOBBTree.vtkOBBTree_GenerateRepresentation_10(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_InsideOrOutside_11(HandleRef pThis, IntPtr point);

		public int InsideOrOutside(IntPtr point)
		{
			return vtkOBBTree.vtkOBBTree_InsideOrOutside_11(base.GetCppThis(), point);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_IntersectWithLine_12(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkOBBTree.vtkOBBTree_IntersectWithLine_12(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_IntersectWithLine_13(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId)
		{
			return vtkOBBTree.vtkOBBTree_IntersectWithLine_13(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_IntersectWithLine_14(HandleRef pThis, IntPtr a0, IntPtr a1, HandleRef points, HandleRef cellIds);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, vtkPoints points, vtkIdList cellIds)
		{
			return vtkOBBTree.vtkOBBTree_IntersectWithLine_14(base.GetCppThis(), a0, a1, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_IntersectWithLine_15(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkOBBTree.vtkOBBTree_IntersectWithLine_15(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOBBTree.vtkOBBTree_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkOBBTree_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOBBTree.vtkOBBTree_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOBBTree_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOBBTree NewInstance()
		{
			vtkOBBTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOBBTree.vtkOBBTree_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkOBBTree_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOBBTree SafeDownCast(vtkObjectBase o)
		{
			vtkOBBTree vtkOBBTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOBBTree.vtkOBBTree_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOBBTree = (vtkOBBTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOBBTree.Register(null);
				}
			}
			return vtkOBBTree;
		}
	}
}
