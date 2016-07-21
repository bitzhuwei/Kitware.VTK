using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIncrementalOctreeNode : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalOctreeNode";

		public new static readonly string MRClassNameKey;

		static vtkIncrementalOctreeNode()
		{
			vtkIncrementalOctreeNode.MRClassNameKey = "class vtkIncrementalOctreeNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIncrementalOctreeNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalOctreeNode"));
		}

		public vtkIncrementalOctreeNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIncrementalOctreeNode New()
		{
			vtkIncrementalOctreeNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIncrementalOctreeNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_ContainsPoint_01(HandleRef pThis, IntPtr pnt);

		public int ContainsPoint(IntPtr pnt)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ContainsPoint_01(base.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_ContainsPointByData_02(HandleRef pThis, IntPtr pnt);

		public int ContainsPointByData(IntPtr pnt)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ContainsPointByData_02(base.GetCppThis(), pnt);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_DeleteChildNodes_03(HandleRef pThis);

		public void DeleteChildNodes()
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_DeleteChildNodes_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_ExportAllPointIdsByDirectSet_04(HandleRef pThis, IntPtr pntIdx, HandleRef idList);

		public void ExportAllPointIdsByDirectSet(IntPtr pntIdx, vtkIdList idList)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ExportAllPointIdsByDirectSet_04(base.GetCppThis(), pntIdx, (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_ExportAllPointIdsByInsertion_05(HandleRef pThis, HandleRef idList);

		public void ExportAllPointIdsByInsertion(vtkIdList idList)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_ExportAllPointIdsByInsertion_05(base.GetCppThis(), (idList == null) ? default(HandleRef) : idList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_GetBounds_06(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetBounds_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetChild_07(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIncrementalOctreeNode GetChild(int i)
		{
			vtkIncrementalOctreeNode vtkIncrementalOctreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetChild_07(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalOctreeNode = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalOctreeNode.Register(null);
				}
			}
			return vtkIncrementalOctreeNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_GetChildIndex_08(HandleRef pThis, IntPtr point);

		public int GetChildIndex(IntPtr point)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetChildIndex_08(base.GetCppThis(), point);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkIncrementalOctreeNode_GetDistance2ToBoundary_09(HandleRef pThis, IntPtr point, HandleRef rootNode, int checkData);

		public double GetDistance2ToBoundary(IntPtr point, vtkIncrementalOctreeNode rootNode, int checkData)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetDistance2ToBoundary_09(base.GetCppThis(), point, (rootNode == null) ? default(HandleRef) : rootNode.GetCppThis(), checkData);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkIncrementalOctreeNode_GetDistance2ToBoundary_10(HandleRef pThis, IntPtr point, IntPtr closest, HandleRef rootNode, int checkData);

		public double GetDistance2ToBoundary(IntPtr point, IntPtr closest, vtkIncrementalOctreeNode rootNode, int checkData)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetDistance2ToBoundary_10(base.GetCppThis(), point, closest, (rootNode == null) ? default(HandleRef) : rootNode.GetCppThis(), checkData);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkIncrementalOctreeNode_GetDistance2ToInnerBoundary_11(HandleRef pThis, IntPtr point, HandleRef rootNode);

		public double GetDistance2ToInnerBoundary(IntPtr point, vtkIncrementalOctreeNode rootNode)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetDistance2ToInnerBoundary_11(base.GetCppThis(), point, (rootNode == null) ? default(HandleRef) : rootNode.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMaxBounds_12(HandleRef pThis);

		public virtual double[] GetMaxBounds()
		{
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxBounds_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_GetMaxBounds_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMaxBounds(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxBounds_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_GetMaxBounds_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetMaxBounds(IntPtr _arg)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxBounds_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMaxDataBounds_15(HandleRef pThis);

		public IntPtr GetMaxDataBounds()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMaxDataBounds_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMinBounds_16(HandleRef pThis);

		public virtual double[] GetMinBounds()
		{
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinBounds_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_GetMinBounds_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMinBounds(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinBounds_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_GetMinBounds_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetMinBounds(IntPtr _arg)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinBounds_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetMinDataBounds_19(HandleRef pThis);

		public IntPtr GetMinDataBounds()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetMinDataBounds_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_GetNumberOfPoints_20(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetNumberOfPoints_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_GetPointIdSet_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdList GetPointIdSet()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_GetPointIdSet_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_InsertPoint_22(HandleRef pThis, HandleRef points, IntPtr newPnt, int maxPts, IntPtr pntId, int ptMode);

		public int InsertPoint(vtkPoints points, IntPtr newPnt, int maxPts, IntPtr pntId, int ptMode)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_InsertPoint_22(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), newPnt, maxPts, pntId, ptMode);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_IsLeaf_24(HandleRef pThis);

		public int IsLeaf()
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_IsLeaf_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkIncrementalOctreeNode_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIncrementalOctreeNode NewInstance()
		{
			vtkIncrementalOctreeNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkIncrementalOctreeNode_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIncrementalOctreeNode SafeDownCast(vtkObjectBase o)
		{
			vtkIncrementalOctreeNode vtkIncrementalOctreeNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalOctreeNode = (vtkIncrementalOctreeNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalOctreeNode.Register(null);
				}
			}
			return vtkIncrementalOctreeNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkIncrementalOctreeNode_SetBounds_29(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

		public void SetBounds(double x1, double x2, double y1, double y2, double z1, double z2)
		{
			vtkIncrementalOctreeNode.vtkIncrementalOctreeNode_SetBounds_29(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}
	}
}
