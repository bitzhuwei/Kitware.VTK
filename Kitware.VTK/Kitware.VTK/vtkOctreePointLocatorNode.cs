using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOctreePointLocatorNode : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOctreePointLocatorNode";

		public new static readonly string MRClassNameKey;

		static vtkOctreePointLocatorNode()
		{
			vtkOctreePointLocatorNode.MRClassNameKey = "class vtkOctreePointLocatorNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOctreePointLocatorNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOctreePointLocatorNode"));
		}

		public vtkOctreePointLocatorNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOctreePointLocatorNode New()
		{
			vtkOctreePointLocatorNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOctreePointLocatorNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_ComputeOctreeNodeInformation_01(HandleRef pThis, HandleRef Parent, ref int NextLeafId, ref int NextMinId, IntPtr coordinates);

		public void ComputeOctreeNodeInformation(vtkOctreePointLocatorNode Parent, ref int NextLeafId, ref int NextMinId, IntPtr coordinates)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_ComputeOctreeNodeInformation_01(base.GetCppThis(), (Parent == null) ? default(HandleRef) : Parent.GetCppThis(), ref NextLeafId, ref NextMinId, coordinates);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_ContainsPoint_02(HandleRef pThis, double x, double y, double z, int useDataBounds);

		public int ContainsPoint(double x, double y, double z, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_ContainsPoint_02(base.GetCppThis(), x, y, z, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_CreateChildNodes_03(HandleRef pThis);

		public void CreateChildNodes()
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_CreateChildNodes_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_DeleteChildNodes_04(HandleRef pThis);

		public void DeleteChildNodes()
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_DeleteChildNodes_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_GetBounds_05(HandleRef pThis, IntPtr b);

		public void GetBounds(IntPtr b)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetBounds_05(base.GetCppThis(), b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetChild_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkOctreePointLocatorNode GetChild(int i)
		{
			vtkOctreePointLocatorNode vtkOctreePointLocatorNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetChild_06(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreePointLocatorNode = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreePointLocatorNode.Register(null);
				}
			}
			return vtkOctreePointLocatorNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_GetDataBounds_07(HandleRef pThis, IntPtr b);

		public void GetDataBounds(IntPtr b)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDataBounds_07(base.GetCppThis(), b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkOctreePointLocatorNode_GetDistance2ToBoundary_08(HandleRef pThis, double x, double y, double z, HandleRef top, int useDataBounds);

		public double GetDistance2ToBoundary(double x, double y, double z, vtkOctreePointLocatorNode top, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDistance2ToBoundary_08(base.GetCppThis(), x, y, z, (top == null) ? default(HandleRef) : top.GetCppThis(), useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkOctreePointLocatorNode_GetDistance2ToBoundary_09(HandleRef pThis, double x, double y, double z, IntPtr boundaryPt, HandleRef top, int useDataBounds);

		public double GetDistance2ToBoundary(double x, double y, double z, IntPtr boundaryPt, vtkOctreePointLocatorNode top, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDistance2ToBoundary_09(base.GetCppThis(), x, y, z, boundaryPt, (top == null) ? default(HandleRef) : top.GetCppThis(), useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkOctreePointLocatorNode_GetDistance2ToInnerBoundary_10(HandleRef pThis, double x, double y, double z, HandleRef top);

		public double GetDistance2ToInnerBoundary(double x, double y, double z, vtkOctreePointLocatorNode top)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetDistance2ToInnerBoundary_10(base.GetCppThis(), x, y, z, (top == null) ? default(HandleRef) : top.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_GetID_11(HandleRef pThis);

		public virtual int GetID()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetID_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMaxBounds_12(HandleRef pThis);

		public virtual IntPtr GetMaxBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMaxBounds_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMaxDataBounds_13(HandleRef pThis);

		public virtual IntPtr GetMaxDataBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMaxDataBounds_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMinBounds_14(HandleRef pThis);

		public virtual IntPtr GetMinBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMinBounds_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_GetMinDataBounds_15(HandleRef pThis);

		public virtual IntPtr GetMinDataBounds()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMinDataBounds_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_GetMinID_16(HandleRef pThis);

		public virtual int GetMinID()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetMinID_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_GetNumberOfPoints_17(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetNumberOfPoints_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_GetSubOctantIndex_18(HandleRef pThis, IntPtr point, int CheckContainment);

		public int GetSubOctantIndex(IntPtr point, int CheckContainment)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_GetSubOctantIndex_18(base.GetCppThis(), point, CheckContainment);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_IntersectsRegion_19(HandleRef pThis, HandleRef pi, int useDataBounds);

		public int IntersectsRegion(vtkPlanesIntersection pi, int useDataBounds)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_IntersectsRegion_19(base.GetCppThis(), (pi == null) ? default(HandleRef) : pi.GetCppThis(), useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOctreePointLocatorNode_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOctreePointLocatorNode NewInstance()
		{
			vtkOctreePointLocatorNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOctreePointLocatorNode_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOctreePointLocatorNode SafeDownCast(vtkObjectBase o)
		{
			vtkOctreePointLocatorNode vtkOctreePointLocatorNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOctreePointLocatorNode = (vtkOctreePointLocatorNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOctreePointLocatorNode.Register(null);
				}
			}
			return vtkOctreePointLocatorNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetBounds_25(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetBounds_25(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetBounds_26(HandleRef pThis, IntPtr b);

		public void SetBounds(IntPtr b)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetBounds_26(base.GetCppThis(), b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetDataBounds_27(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetDataBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetDataBounds_27(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetMaxBounds_28(HandleRef pThis, IntPtr maxBounds);

		public void SetMaxBounds(IntPtr maxBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMaxBounds_28(base.GetCppThis(), maxBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetMaxDataBounds_29(HandleRef pThis, IntPtr maxDataBounds);

		public void SetMaxDataBounds(IntPtr maxDataBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMaxDataBounds_29(base.GetCppThis(), maxDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetMinBounds_30(HandleRef pThis, IntPtr minBounds);

		public void SetMinBounds(IntPtr minBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMinBounds_30(base.GetCppThis(), minBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetMinDataBounds_31(HandleRef pThis, IntPtr minDataBounds);

		public void SetMinDataBounds(IntPtr minDataBounds)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetMinDataBounds_31(base.GetCppThis(), minDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOctreePointLocatorNode_SetNumberOfPoints_32(HandleRef pThis, int numberOfPoints);

		public void SetNumberOfPoints(int numberOfPoints)
		{
			vtkOctreePointLocatorNode.vtkOctreePointLocatorNode_SetNumberOfPoints_32(base.GetCppThis(), numberOfPoints);
		}
	}
}
