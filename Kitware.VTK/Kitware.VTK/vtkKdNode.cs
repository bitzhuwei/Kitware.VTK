using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKdNode : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdNode";

		public new static readonly string MRClassNameKey;

		static vtkKdNode()
		{
			vtkKdNode.MRClassNameKey = "class vtkKdNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdNode"));
		}

		public vtkKdNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdNode New()
		{
			vtkKdNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdNode.vtkKdNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKdNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKdNode.vtkKdNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_AddChildNodes_01(HandleRef pThis, HandleRef left, HandleRef right);

		public void AddChildNodes(vtkKdNode left, vtkKdNode right)
		{
			vtkKdNode.vtkKdNode_AddChildNodes_01(base.GetCppThis(), (left == null) ? default(HandleRef) : left.GetCppThis(), (right == null) ? default(HandleRef) : right.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_ContainsBox_02(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds);

		public int ContainsBox(double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_ContainsBox_02(base.GetCppThis(), x1, x2, y1, y2, z1, z2, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_ContainsPoint_03(HandleRef pThis, double x, double y, double z, int useDataBounds);

		public int ContainsPoint(double x, double y, double z, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_ContainsPoint_03(base.GetCppThis(), x, y, z, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_DeleteChildNodes_04(HandleRef pThis);

		public void DeleteChildNodes()
		{
			vtkKdNode.vtkKdNode_DeleteChildNodes_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_GetBounds_05(HandleRef pThis, IntPtr b);

		public void GetBounds(IntPtr b)
		{
			vtkKdNode.vtkKdNode_GetBounds_05(base.GetCppThis(), b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_GetDataBounds_06(HandleRef pThis, IntPtr b);

		public void GetDataBounds(IntPtr b)
		{
			vtkKdNode.vtkKdNode_GetDataBounds_06(base.GetCppThis(), b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_GetDim_07(HandleRef pThis);

		public virtual int GetDim()
		{
			return vtkKdNode.vtkKdNode_GetDim_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKdNode_GetDistance2ToBoundary_08(HandleRef pThis, double x, double y, double z, int useDataBounds);

		public double GetDistance2ToBoundary(double x, double y, double z, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_GetDistance2ToBoundary_08(base.GetCppThis(), x, y, z, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKdNode_GetDistance2ToBoundary_09(HandleRef pThis, double x, double y, double z, IntPtr boundaryPt, int useDataBounds);

		public double GetDistance2ToBoundary(double x, double y, double z, IntPtr boundaryPt, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_GetDistance2ToBoundary_09(base.GetCppThis(), x, y, z, boundaryPt, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKdNode_GetDistance2ToInnerBoundary_10(HandleRef pThis, double x, double y, double z);

		public double GetDistance2ToInnerBoundary(double x, double y, double z)
		{
			return vtkKdNode.vtkKdNode_GetDistance2ToInnerBoundary_10(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKdNode_GetDivisionPosition_11(HandleRef pThis);

		public virtual double GetDivisionPosition()
		{
			return vtkKdNode.vtkKdNode_GetDivisionPosition_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_GetID_12(HandleRef pThis);

		public virtual int GetID()
		{
			return vtkKdNode.vtkKdNode_GetID_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetLeft_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkKdNode GetLeft()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetLeft_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetMaxBounds_14(HandleRef pThis);

		public double[] GetMaxBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMaxBounds_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetMaxDataBounds_15(HandleRef pThis);

		public double[] GetMaxDataBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMaxDataBounds_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_GetMaxID_16(HandleRef pThis);

		public virtual int GetMaxID()
		{
			return vtkKdNode.vtkKdNode_GetMaxID_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetMinBounds_17(HandleRef pThis);

		public double[] GetMinBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMinBounds_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetMinDataBounds_18(HandleRef pThis);

		public double[] GetMinDataBounds()
		{
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetMinDataBounds_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_GetMinID_19(HandleRef pThis);

		public virtual int GetMinID()
		{
			return vtkKdNode.vtkKdNode_GetMinID_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_GetNumberOfPoints_20(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkKdNode.vtkKdNode_GetNumberOfPoints_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetRight_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkKdNode GetRight()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetRight_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_GetUp_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkKdNode GetUp()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdNode.vtkKdNode_GetUp_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_IntersectsBox_23(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds);

		public int IntersectsBox(double x1, double x2, double y1, double y2, double z1, double z2, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsBox_23(base.GetCppThis(), x1, x2, y1, y2, z1, z2, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_IntersectsCell_24(HandleRef pThis, HandleRef cell, int useDataBounds, int cellRegion, IntPtr cellBounds);

		public int IntersectsCell(vtkCell cell, int useDataBounds, int cellRegion, IntPtr cellBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsCell_24(base.GetCppThis(), (cell == null) ? default(HandleRef) : cell.GetCppThis(), useDataBounds, cellRegion, cellBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_IntersectsRegion_25(HandleRef pThis, HandleRef pi, int useDataBounds);

		public int IntersectsRegion(vtkPlanesIntersection pi, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsRegion_25(base.GetCppThis(), (pi == null) ? default(HandleRef) : pi.GetCppThis(), useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_IntersectsSphere2_26(HandleRef pThis, double x, double y, double z, double rSquared, int useDataBounds);

		public int IntersectsSphere2(double x, double y, double z, double rSquared, int useDataBounds)
		{
			return vtkKdNode.vtkKdNode_IntersectsSphere2_26(base.GetCppThis(), x, y, z, rSquared, useDataBounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKdNode.vtkKdNode_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdNode_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKdNode.vtkKdNode_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKdNode NewInstance()
		{
			vtkKdNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdNode.vtkKdNode_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_PrintNode_31(HandleRef pThis, int depth);

		public void PrintNode(int depth)
		{
			vtkKdNode.vtkKdNode_PrintNode_31(base.GetCppThis(), depth);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_PrintVerboseNode_32(HandleRef pThis, int depth);

		public void PrintVerboseNode(int depth)
		{
			vtkKdNode.vtkKdNode_PrintVerboseNode_32(base.GetCppThis(), depth);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdNode_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdNode SafeDownCast(vtkObjectBase o)
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdNode.vtkKdNode_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetBounds_34(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

		public void SetBounds(double x1, double x2, double y1, double y2, double z1, double z2)
		{
			vtkKdNode.vtkKdNode_SetBounds_34(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetBounds_35(HandleRef pThis, IntPtr b);

		public void SetBounds(IntPtr b)
		{
			vtkKdNode.vtkKdNode_SetBounds_35(base.GetCppThis(), b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetDataBounds_36(HandleRef pThis, double x1, double x2, double y1, double y2, double z1, double z2);

		public void SetDataBounds(double x1, double x2, double y1, double y2, double z1, double z2)
		{
			vtkKdNode.vtkKdNode_SetDataBounds_36(base.GetCppThis(), x1, x2, y1, y2, z1, z2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetDataBounds_37(HandleRef pThis, IntPtr v);

		public void SetDataBounds(IntPtr v)
		{
			vtkKdNode.vtkKdNode_SetDataBounds_37(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetDim_38(HandleRef pThis, int _arg);

		public virtual void SetDim(int _arg)
		{
			vtkKdNode.vtkKdNode_SetDim_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetID_39(HandleRef pThis, int _arg);

		public virtual void SetID(int _arg)
		{
			vtkKdNode.vtkKdNode_SetID_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetLeft_40(HandleRef pThis, HandleRef left);

		public void SetLeft(vtkKdNode left)
		{
			vtkKdNode.vtkKdNode_SetLeft_40(base.GetCppThis(), (left == null) ? default(HandleRef) : left.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetMaxBounds_41(HandleRef pThis, IntPtr mb);

		public void SetMaxBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMaxBounds_41(base.GetCppThis(), mb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetMaxDataBounds_42(HandleRef pThis, IntPtr mb);

		public void SetMaxDataBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMaxDataBounds_42(base.GetCppThis(), mb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetMaxID_43(HandleRef pThis, int _arg);

		public virtual void SetMaxID(int _arg)
		{
			vtkKdNode.vtkKdNode_SetMaxID_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetMinBounds_44(HandleRef pThis, IntPtr mb);

		public void SetMinBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMinBounds_44(base.GetCppThis(), mb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetMinDataBounds_45(HandleRef pThis, IntPtr mb);

		public void SetMinDataBounds(IntPtr mb)
		{
			vtkKdNode.vtkKdNode_SetMinDataBounds_45(base.GetCppThis(), mb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetMinID_46(HandleRef pThis, int _arg);

		public virtual void SetMinID(int _arg)
		{
			vtkKdNode.vtkKdNode_SetMinID_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetNumberOfPoints_47(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPoints(int _arg)
		{
			vtkKdNode.vtkKdNode_SetNumberOfPoints_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetRight_48(HandleRef pThis, HandleRef right);

		public void SetRight(vtkKdNode right)
		{
			vtkKdNode.vtkKdNode_SetRight_48(base.GetCppThis(), (right == null) ? default(HandleRef) : right.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdNode_SetUp_49(HandleRef pThis, HandleRef up);

		public void SetUp(vtkKdNode up)
		{
			vtkKdNode.vtkKdNode_SetUp_49(base.GetCppThis(), (up == null) ? default(HandleRef) : up.GetCppThis());
		}
	}
}
