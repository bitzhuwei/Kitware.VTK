using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkContourRepresentation : vtkWidgetRepresentation
	{
		public enum Nearby_WrapperEnum
		{
			Nearby = 1,
			Outside = 0
		}

		public enum Inactive_WrapperEnum
		{
			Inactive,
			Scale = 3,
			Shift = 2,
			Translate = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkContourRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkContourRepresentation()
		{
			vtkContourRepresentation.MRClassNameKey = "class vtkContourRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourRepresentation"));
		}

		public vtkContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_ActivateNode_01(HandleRef pThis, IntPtr displayPos);

		public virtual int ActivateNode(IntPtr displayPos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_ActivateNode_01(base.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_ActivateNode_02(HandleRef pThis, int X, int Y);

		public virtual int ActivateNode(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_ActivateNode_02(base.GetCppThis(), X, Y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddIntermediatePointWorldPosition_03(HandleRef pThis, int n, IntPtr point);

		public virtual int AddIntermediatePointWorldPosition(int n, IntPtr point)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddIntermediatePointWorldPosition_03(base.GetCppThis(), n, point);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddNodeAtDisplayPosition_04(HandleRef pThis, IntPtr displayPos);

		public virtual int AddNodeAtDisplayPosition(IntPtr displayPos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtDisplayPosition_04(base.GetCppThis(), displayPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddNodeAtDisplayPosition_05(HandleRef pThis, int X, int Y);

		public virtual int AddNodeAtDisplayPosition(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtDisplayPosition_05(base.GetCppThis(), X, Y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_06(HandleRef pThis, double x, double y, double z);

		public virtual int AddNodeAtWorldPosition(double x, double y, double z)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtWorldPosition_06(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_07(HandleRef pThis, IntPtr worldPos);

		public virtual int AddNodeAtWorldPosition(IntPtr worldPos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtWorldPosition_07(base.GetCppThis(), worldPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_08(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		public virtual int AddNodeAtWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtWorldPosition_08(base.GetCppThis(), worldPos, worldOrient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_AddNodeOnContour_09(HandleRef pThis, int X, int Y);

		public virtual int AddNodeOnContour(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeOnContour_09(base.GetCppThis(), X, Y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_BuildRepresentation_10(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkContourRepresentation.vtkContourRepresentation_BuildRepresentation_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_ClearAllNodes_11(HandleRef pThis);

		public virtual void ClearAllNodes()
		{
			vtkContourRepresentation.vtkContourRepresentation_ClearAllNodes_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_ClosedLoopOff_12(HandleRef pThis);

		public virtual void ClosedLoopOff()
		{
			vtkContourRepresentation.vtkContourRepresentation_ClosedLoopOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_ClosedLoopOn_13(HandleRef pThis);

		public virtual void ClosedLoopOn()
		{
			vtkContourRepresentation.vtkContourRepresentation_ClosedLoopOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_ComputeInteractionState_14(HandleRef pThis, int X, int Y, int modified);

		public override int ComputeInteractionState(int X, int Y, int modified)
		{
			return vtkContourRepresentation.vtkContourRepresentation_ComputeInteractionState_14(base.GetCppThis(), X, Y, modified);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_DeleteActiveNode_15(HandleRef pThis);

		public virtual int DeleteActiveNode()
		{
			return vtkContourRepresentation.vtkContourRepresentation_DeleteActiveNode_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_DeleteLastNode_16(HandleRef pThis);

		public virtual int DeleteLastNode()
		{
			return vtkContourRepresentation.vtkContourRepresentation_DeleteLastNode_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_DeleteNthNode_17(HandleRef pThis, int n);

		public virtual int DeleteNthNode(int n)
		{
			return vtkContourRepresentation.vtkContourRepresentation_DeleteNthNode_17(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetActiveNodeDisplayPosition_18(HandleRef pThis, IntPtr pos);

		public virtual int GetActiveNodeDisplayPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeDisplayPosition_18(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetActiveNodeSelected_19(HandleRef pThis);

		public virtual int GetActiveNodeSelected()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeSelected_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetActiveNodeWorldOrientation_20(HandleRef pThis, IntPtr orient);

		public virtual int GetActiveNodeWorldOrientation(IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeWorldOrientation_20(base.GetCppThis(), orient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetActiveNodeWorldPosition_21(HandleRef pThis, IntPtr pos);

		public virtual int GetActiveNodeWorldPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeWorldPosition_21(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetClosedLoop_22(HandleRef pThis);

		public virtual int GetClosedLoop()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetClosedLoop_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourRepresentation_GetContourRepresentationAsPolyData_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyData GetContourRepresentationAsPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_GetContourRepresentationAsPolyData_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetCurrentOperation_24(HandleRef pThis);

		public virtual int GetCurrentOperation()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetCurrentOperation_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetCurrentOperationMaxValue_25(HandleRef pThis);

		public virtual int GetCurrentOperationMaxValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetCurrentOperationMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetCurrentOperationMinValue_26(HandleRef pThis);

		public virtual int GetCurrentOperationMinValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetCurrentOperationMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetIntermediatePointWorldPosition_27(HandleRef pThis, int n, int idx, IntPtr point);

		public virtual int GetIntermediatePointWorldPosition(int n, int idx, IntPtr point)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetIntermediatePointWorldPosition_27(base.GetCppThis(), n, idx, point);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourRepresentation_GetLineInterpolator_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkContourLineInterpolator GetLineInterpolator()
		{
			vtkContourLineInterpolator vtkContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_GetLineInterpolator_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourLineInterpolator = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourLineInterpolator.Register(null);
				}
			}
			return vtkContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_GetNodePolyData_29(HandleRef pThis, HandleRef poly);

		public void GetNodePolyData(vtkPolyData poly)
		{
			vtkContourRepresentation.vtkContourRepresentation_GetNodePolyData_29(base.GetCppThis(), (poly == null) ? default(HandleRef) : poly.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNthNodeDisplayPosition_30(HandleRef pThis, int n, IntPtr pos);

		public virtual int GetNthNodeDisplayPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeDisplayPosition_30(base.GetCppThis(), n, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNthNodeSelected_31(HandleRef pThis, int arg0);

		public virtual int GetNthNodeSelected(int arg0)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeSelected_31(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNthNodeSlope_32(HandleRef pThis, int idx, IntPtr slope);

		public virtual int GetNthNodeSlope(int idx, IntPtr slope)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeSlope_32(base.GetCppThis(), idx, slope);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNthNodeWorldOrientation_33(HandleRef pThis, int n, IntPtr orient);

		public virtual int GetNthNodeWorldOrientation(int n, IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeWorldOrientation_33(base.GetCppThis(), n, orient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNthNodeWorldPosition_34(HandleRef pThis, int n, IntPtr pos);

		public virtual int GetNthNodeWorldPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeWorldPosition_34(base.GetCppThis(), n, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNumberOfIntermediatePoints_35(HandleRef pThis, int n);

		public virtual int GetNumberOfIntermediatePoints(int n)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNumberOfIntermediatePoints_35(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetNumberOfNodes_36(HandleRef pThis);

		public virtual int GetNumberOfNodes()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNumberOfNodes_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetPixelTolerance_37(HandleRef pThis);

		public virtual int GetPixelTolerance()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetPixelTolerance_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetPixelToleranceMaxValue_38(HandleRef pThis);

		public virtual int GetPixelToleranceMaxValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetPixelToleranceMaxValue_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetPixelToleranceMinValue_39(HandleRef pThis);

		public virtual int GetPixelToleranceMinValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetPixelToleranceMinValue_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourRepresentation_GetPointPlacer_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointPlacer GetPointPlacer()
		{
			vtkPointPlacer vtkPointPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_GetPointPlacer_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPlacer = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPlacer.Register(null);
				}
			}
			return vtkPointPlacer;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_GetShowSelectedNodes_41(HandleRef pThis);

		public virtual int GetShowSelectedNodes()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetShowSelectedNodes_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkContourRepresentation_GetWorldTolerance_42(HandleRef pThis);

		public virtual double GetWorldTolerance()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetWorldTolerance_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkContourRepresentation_GetWorldToleranceMaxValue_43(HandleRef pThis);

		public virtual double GetWorldToleranceMaxValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetWorldToleranceMaxValue_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkContourRepresentation_GetWorldToleranceMinValue_44(HandleRef pThis);

		public virtual double GetWorldToleranceMinValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetWorldToleranceMinValue_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_HasTranslucentPolygonalGeometry_45(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkContourRepresentation.vtkContourRepresentation_HasTranslucentPolygonalGeometry_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_IsA_46(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContourRepresentation.vtkContourRepresentation_IsA_46(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_IsTypeOf_47(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContourRepresentation.vtkContourRepresentation_IsTypeOf_47(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourRepresentation_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContourRepresentation NewInstance()
		{
			vtkContourRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_NewInstance_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_ReleaseGraphicsResources_49(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkContourRepresentation.vtkContourRepresentation_ReleaseGraphicsResources_49(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_RenderOpaqueGeometry_50(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkContourRepresentation.vtkContourRepresentation_RenderOpaqueGeometry_50(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_RenderOverlay_51(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkContourRepresentation.vtkContourRepresentation_RenderOverlay_51(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_RenderTranslucentPolygonalGeometry_52(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkContourRepresentation.vtkContourRepresentation_RenderTranslucentPolygonalGeometry_52(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourRepresentation_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkContourRepresentation vtkContourRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_SafeDownCast_53((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourRepresentation = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourRepresentation.Register(null);
				}
			}
			return vtkContourRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetActiveNodeToDisplayPosition_54(HandleRef pThis, IntPtr pos);

		public virtual int SetActiveNodeToDisplayPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToDisplayPosition_54(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetActiveNodeToDisplayPosition_55(HandleRef pThis, int X, int Y);

		public virtual int SetActiveNodeToDisplayPosition(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToDisplayPosition_55(base.GetCppThis(), X, Y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetActiveNodeToWorldPosition_56(HandleRef pThis, IntPtr pos);

		public virtual int SetActiveNodeToWorldPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToWorldPosition_56(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetActiveNodeToWorldPosition_57(HandleRef pThis, IntPtr pos, IntPtr orient);

		public virtual int SetActiveNodeToWorldPosition(IntPtr pos, IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToWorldPosition_57(base.GetCppThis(), pos, orient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetClosedLoop_58(HandleRef pThis, int val);

		public void SetClosedLoop(int val)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetClosedLoop_58(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetCurrentOperation_59(HandleRef pThis, int _arg);

		public virtual void SetCurrentOperation(int _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperation_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToInactive_60(HandleRef pThis);

		public void SetCurrentOperationToInactive()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToInactive_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToScale_61(HandleRef pThis);

		public void SetCurrentOperationToScale()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToScale_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToShift_62(HandleRef pThis);

		public void SetCurrentOperationToShift()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToShift_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToTranslate_63(HandleRef pThis);

		public void SetCurrentOperationToTranslate()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToTranslate_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetLineInterpolator_64(HandleRef pThis, HandleRef arg0);

		public void SetLineInterpolator(vtkContourLineInterpolator arg0)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetLineInterpolator_64(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetNthNodeDisplayPosition_65(HandleRef pThis, int n, int X, int Y);

		public virtual int SetNthNodeDisplayPosition(int n, int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeDisplayPosition_65(base.GetCppThis(), n, X, Y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetNthNodeDisplayPosition_66(HandleRef pThis, int n, IntPtr pos);

		public virtual int SetNthNodeDisplayPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeDisplayPosition_66(base.GetCppThis(), n, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetNthNodeSelected_67(HandleRef pThis, int arg0);

		public virtual int SetNthNodeSelected(int arg0)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeSelected_67(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetNthNodeWorldPosition_68(HandleRef pThis, int n, IntPtr pos);

		public virtual int SetNthNodeWorldPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeWorldPosition_68(base.GetCppThis(), n, pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_SetNthNodeWorldPosition_69(HandleRef pThis, int n, IntPtr pos, IntPtr orient);

		public virtual int SetNthNodeWorldPosition(int n, IntPtr pos, IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeWorldPosition_69(base.GetCppThis(), n, pos, orient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetPixelTolerance_70(HandleRef pThis, int _arg);

		public virtual void SetPixelTolerance(int _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetPixelTolerance_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetPointPlacer_71(HandleRef pThis, HandleRef arg0);

		public void SetPointPlacer(vtkPointPlacer arg0)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetPointPlacer_71(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetRebuildLocator_72(HandleRef pThis, byte _arg);

		public virtual void SetRebuildLocator(bool _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetRebuildLocator_72(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetShowSelectedNodes_73(HandleRef pThis, int arg0);

		public virtual void SetShowSelectedNodes(int arg0)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetShowSelectedNodes_73(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_SetWorldTolerance_74(HandleRef pThis, double _arg);

		public virtual void SetWorldTolerance(double _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetWorldTolerance_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_ShowSelectedNodesOff_75(HandleRef pThis);

		public virtual void ShowSelectedNodesOff()
		{
			vtkContourRepresentation.vtkContourRepresentation_ShowSelectedNodesOff_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_ShowSelectedNodesOn_76(HandleRef pThis);

		public virtual void ShowSelectedNodesOn()
		{
			vtkContourRepresentation.vtkContourRepresentation_ShowSelectedNodesOn_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_StartWidgetInteraction_77(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkContourRepresentation.vtkContourRepresentation_StartWidgetInteraction_77(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourRepresentation_ToggleActiveNodeSelected_78(HandleRef pThis);

		public virtual int ToggleActiveNodeSelected()
		{
			return vtkContourRepresentation.vtkContourRepresentation_ToggleActiveNodeSelected_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourRepresentation_WidgetInteraction_79(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkContourRepresentation.vtkContourRepresentation_WidgetInteraction_79(base.GetCppThis(), e);
		}
	}
}
