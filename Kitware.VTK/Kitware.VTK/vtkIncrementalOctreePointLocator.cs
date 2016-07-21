using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIncrementalOctreePointLocator : vtkIncrementalPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalOctreePointLocator";

		public new static readonly string MRClassNameKey;

		static vtkIncrementalOctreePointLocator()
		{
			vtkIncrementalOctreePointLocator.MRClassNameKey = "class vtkIncrementalOctreePointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalOctreePointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalOctreePointLocator"));
		}

		public vtkIncrementalOctreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIncrementalOctreePointLocator New()
		{
			vtkIncrementalOctreePointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIncrementalOctreePointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_BuildCubicOctreeOff_01(HandleRef pThis);

		public virtual void BuildCubicOctreeOff()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_BuildCubicOctreeOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_BuildCubicOctreeOn_02(HandleRef pThis);

		public virtual void BuildCubicOctreeOn()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_BuildCubicOctreeOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_BuildLocator_03(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_BuildLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestInsertedPoint_04(HandleRef pThis, IntPtr x);

		public override long FindClosestInsertedPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestInsertedPoint_04(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_FindClosestNPoints_05(HandleRef pThis, int N, IntPtr x, HandleRef result);

		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestNPoints_05(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_06(HandleRef pThis, IntPtr x);

		public override long FindClosestPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_06(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_07(HandleRef pThis, double x, double y, double z);

		public new virtual long FindClosestPoint(double x, double y, double z)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_07(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_08(HandleRef pThis, IntPtr x, IntPtr miniDist2);

		public virtual long FindClosestPoint(IntPtr x, IntPtr miniDist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_08(base.GetCppThis(), x, miniDist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPoint_09(HandleRef pThis, double x, double y, double z, IntPtr miniDist2);

		public virtual long FindClosestPoint(double x, double y, double z, IntPtr miniDist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPoint_09(base.GetCppThis(), x, y, z, miniDist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPointWithinRadius_10(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPointWithinRadius_10(base.GetCppThis(), radius, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_FindClosestPointWithinSquaredRadius_11(HandleRef pThis, double radius2, IntPtr x, ref double dist2);

		public long FindClosestPointWithinSquaredRadius(double radius2, IntPtr x, ref double dist2)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindClosestPointWithinSquaredRadius_11(base.GetCppThis(), radius2, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_FindPointsWithinRadius_12(HandleRef pThis, double R, IntPtr x, HandleRef result);

		public override void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindPointsWithinRadius_12(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_FindPointsWithinSquaredRadius_13(HandleRef pThis, double R2, IntPtr x, HandleRef result);

		public void FindPointsWithinSquaredRadius(double R2, IntPtr x, vtkIdList result)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FindPointsWithinSquaredRadius_13(base.GetCppThis(), R2, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_FreeSearchStructure_14(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_FreeSearchStructure_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_GenerateRepresentation_15(HandleRef pThis, int nodeLevel, HandleRef polysData);

		public override void GenerateRepresentation(int nodeLevel, vtkPolyData polysData)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GenerateRepresentation_15(base.GetCppThis(), nodeLevel, (polysData == null) ? default(HandleRef) : polysData.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_GetBounds_16(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetBounds_16(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_GetBounds_17(HandleRef pThis);

		public override IntPtr GetBounds()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetBounds_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_GetBuildCubicOctree_18(HandleRef pThis);

		public virtual int GetBuildCubicOctree()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetBuildCubicOctree_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_GetLocatorPoints_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetLocatorPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetLocatorPoints_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_GetMaxPointsPerLeaf_20(HandleRef pThis);

		public virtual int GetMaxPointsPerLeaf()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetMaxPointsPerLeaf_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_GetMaxPointsPerLeafMaxValue_21(HandleRef pThis);

		public virtual int GetMaxPointsPerLeafMaxValue()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetMaxPointsPerLeafMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_GetMaxPointsPerLeafMinValue_22(HandleRef pThis);

		public virtual int GetMaxPointsPerLeafMinValue()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetMaxPointsPerLeafMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_GetNumberOfPoints_23(HandleRef pThis);

		public int GetNumberOfPoints()
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_GetNumberOfPoints_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_InitPointInsertion_24(HandleRef pThis, HandleRef points, IntPtr bounds);

		public override int InitPointInsertion(vtkPoints points, IntPtr bounds)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InitPointInsertion_24(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_InitPointInsertion_25(HandleRef pThis, HandleRef points, IntPtr bounds, long estSize);

		public override int InitPointInsertion(vtkPoints points, IntPtr bounds, long estSize)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InitPointInsertion_25(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), bounds, estSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_Initialize_26(HandleRef pThis);

		public override void Initialize()
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_Initialize_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_InsertNextPoint_27(HandleRef pThis, IntPtr x);

		public override long InsertNextPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertNextPoint_27(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_InsertPoint_28(HandleRef pThis, long ptId, IntPtr x);

		public override void InsertPoint(long ptId, IntPtr x)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertPoint_28(base.GetCppThis(), ptId, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_InsertPointWithoutChecking_29(HandleRef pThis, IntPtr point, ref long pntId, int insert);

		public void InsertPointWithoutChecking(IntPtr point, ref long pntId, int insert)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertPointWithoutChecking_29(base.GetCppThis(), point, ref pntId, insert);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_InsertUniquePoint_30(HandleRef pThis, IntPtr point, ref long pntId);

		public override int InsertUniquePoint(IntPtr point, ref long pntId)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_InsertUniquePoint_30(base.GetCppThis(), point, ref pntId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_IsInsertedPoint_32(HandleRef pThis, IntPtr x);

		public override long IsInsertedPoint(IntPtr x)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsInsertedPoint_32(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkIncrementalOctreePointLocator_IsInsertedPoint_33(HandleRef pThis, double x, double y, double z);

		public override long IsInsertedPoint(double x, double y, double z)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsInsertedPoint_33(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreePointLocator_IsTypeOf_34(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_IsTypeOf_34(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIncrementalOctreePointLocator NewInstance()
		{
			vtkIncrementalOctreePointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_NewInstance_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreePointLocator_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIncrementalOctreePointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalOctreePointLocator vtkIncrementalOctreePointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalOctreePointLocator = (vtkIncrementalOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalOctreePointLocator.Register(null);
				}
			}
			return vtkIncrementalOctreePointLocator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_SetBuildCubicOctree_38(HandleRef pThis, int _arg);

		public virtual void SetBuildCubicOctree(int _arg)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_SetBuildCubicOctree_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreePointLocator_SetMaxPointsPerLeaf_39(HandleRef pThis, int _arg);

		public virtual void SetMaxPointsPerLeaf(int _arg)
		{
			vtkIncrementalOctreePointLocator.vtkIncrementalOctreePointLocator_SetMaxPointsPerLeaf_39(base.GetCppThis(), _arg);
		}
	}
}
