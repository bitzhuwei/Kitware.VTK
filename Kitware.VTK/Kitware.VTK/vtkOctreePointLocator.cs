using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOctreePointLocator : vtkAbstractPointLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOctreePointLocator";

		public new static readonly string MRClassNameKey;

		static vtkOctreePointLocator()
		{
			vtkOctreePointLocator.MRClassNameKey = "class vtkOctreePointLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOctreePointLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreePointLocator"));
		}

		public vtkOctreePointLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOctreePointLocator New()
		{
			vtkOctreePointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOctreePointLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOctreePointLocator.vtkOctreePointLocator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkOctreePointLocator.vtkOctreePointLocator_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_FindClosestNPoints_02(HandleRef pThis, int N, IntPtr x, HandleRef result);

		public override void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FindClosestNPoints_02(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOctreePointLocator_FindClosestPoint_03(HandleRef pThis, IntPtr x);

		public override long FindClosestPoint(IntPtr x)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPoint_03(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOctreePointLocator_FindClosestPoint_04(HandleRef pThis, double x, double y, double z, ref double dist2);

		public long FindClosestPoint(double x, double y, double z, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPoint_04(base.GetCppThis(), x, y, z, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOctreePointLocator_FindClosestPointInRegion_05(HandleRef pThis, int regionId, IntPtr x, ref double dist2);

		public long FindClosestPointInRegion(int regionId, IntPtr x, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPointInRegion_05(base.GetCppThis(), regionId, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOctreePointLocator_FindClosestPointInRegion_06(HandleRef pThis, int regionId, double x, double y, double z, ref double dist2);

		public long FindClosestPointInRegion(int regionId, double x, double y, double z, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPointInRegion_06(base.GetCppThis(), regionId, x, y, z, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOctreePointLocator_FindClosestPointWithinRadius_07(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		public override long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_FindClosestPointWithinRadius_07(base.GetCppThis(), radius, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_FindPointsInArea_08(HandleRef pThis, IntPtr area, HandleRef ids, byte clearArray);

		public void FindPointsInArea(IntPtr area, vtkIdTypeArray ids, bool clearArray)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FindPointsInArea_08(base.GetCppThis(), area, (ids == null) ? default(HandleRef) : ids.GetCppThis(), clearArray ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_FindPointsWithinRadius_09(HandleRef pThis, double radius, IntPtr x, HandleRef result);

		public override void FindPointsWithinRadius(double radius, IntPtr x, vtkIdList result)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FindPointsWithinRadius_09(base.GetCppThis(), radius, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_FreeSearchStructure_10(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkOctreePointLocator.vtkOctreePointLocator_FreeSearchStructure_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_GenerateRepresentation_11(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GenerateRepresentation_11(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocator_GetBounds_12(HandleRef pThis);

		public override IntPtr GetBounds()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetBounds_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_GetBounds_13(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GetBounds_13(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocator_GetCreateCubicOctants_14(HandleRef pThis);

		public virtual int GetCreateCubicOctants()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetCreateCubicOctants_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkOctreePointLocator_GetFudgeFactor_15(HandleRef pThis);

		public virtual double GetFudgeFactor()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetFudgeFactor_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocator_GetMaximumPointsPerRegion_16(HandleRef pThis);

		public virtual int GetMaximumPointsPerRegion()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetMaximumPointsPerRegion_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocator_GetNumberOfLeafNodes_17(HandleRef pThis);

		public virtual int GetNumberOfLeafNodes()
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetNumberOfLeafNodes_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocator_GetPointsInRegion_18(HandleRef pThis, int leafNodeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetPointsInRegion(int leafNodeId)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_GetPointsInRegion_18(base.GetCppThis(), leafNodeId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_GetRegionBounds_19(HandleRef pThis, int regionID, IntPtr bounds);

		public void GetRegionBounds(int regionID, IntPtr bounds)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GetRegionBounds_19(base.GetCppThis(), regionID, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocator_GetRegionContainingPoint_20(HandleRef pThis, double x, double y, double z);

		public int GetRegionContainingPoint(double x, double y, double z)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_GetRegionContainingPoint_20(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_GetRegionDataBounds_21(HandleRef pThis, int leafNodeID, IntPtr bounds);

		public void GetRegionDataBounds(int leafNodeID, IntPtr bounds)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_GetRegionDataBounds_21(base.GetCppThis(), leafNodeID, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocator_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocator_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOctreePointLocator.vtkOctreePointLocator_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocator_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOctreePointLocator NewInstance()
		{
			vtkOctreePointLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocator_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOctreePointLocator SafeDownCast(vtkObjectBase o)
		{
			vtkOctreePointLocator vtkOctreePointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocator.vtkOctreePointLocator_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreePointLocator = (vtkOctreePointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreePointLocator.Register(null);
				}
			}
			return vtkOctreePointLocator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_SetCreateCubicOctants_27(HandleRef pThis, int _arg);

		public virtual void SetCreateCubicOctants(int _arg)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_SetCreateCubicOctants_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_SetFudgeFactor_28(HandleRef pThis, double _arg);

		public virtual void SetFudgeFactor(double _arg)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_SetFudgeFactor_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocator_SetMaximumPointsPerRegion_29(HandleRef pThis, int _arg);

		public virtual void SetMaximumPointsPerRegion(int _arg)
		{
			vtkOctreePointLocator.vtkOctreePointLocator_SetMaximumPointsPerRegion_29(base.GetCppThis(), _arg);
		}
	}
}
