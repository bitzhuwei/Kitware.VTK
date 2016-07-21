using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkControlPointsItem : vtkPlot
	{
		public enum CurrentPointChangedEvent_WrapperEnum
		{
			CurrentPointChangedEvent = 1000,
			CurrentPointEditEvent
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkControlPointsItem";

		public new static readonly string MRClassNameKey;

		static vtkControlPointsItem()
		{
			vtkControlPointsItem.MRClassNameKey = "class vtkControlPointsItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkControlPointsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkControlPointsItem"));
		}

		public vtkControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

		public virtual long AddPoint(IntPtr newPos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_AddPoint_01(base.GetCppThis(), newPos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_DeselectAllPoints_02(HandleRef pThis);

		public void DeselectAllPoints()
		{
			vtkControlPointsItem.vtkControlPointsItem_DeselectAllPoints_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_DeselectPoint_03(HandleRef pThis, long pointId);

		public void DeselectPoint(long pointId)
		{
			vtkControlPointsItem.vtkControlPointsItem_DeselectPoint_03(base.GetCppThis(), pointId);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_DeselectPoint_04(HandleRef pThis, IntPtr currentPoint);

		public void DeselectPoint(IntPtr currentPoint)
		{
			vtkControlPointsItem.vtkControlPointsItem_DeselectPoint_04(base.GetCppThis(), currentPoint);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkControlPointsItem_FindPoint_05(HandleRef pThis, IntPtr pos);

		public long FindPoint(IntPtr pos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_FindPoint_05(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_GetBounds_06(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetBounds_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_GetControlPoint_07(HandleRef pThis, long index, IntPtr point);

		public virtual void GetControlPoint(long index, IntPtr point)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetControlPoint_07(base.GetCppThis(), index, point);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkControlPointsItem_GetControlPointId_08(HandleRef pThis, IntPtr pos);

		public long GetControlPointId(IntPtr pos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetControlPointId_08(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkControlPointsItem_GetCurrentPoint_09(HandleRef pThis);

		public long GetCurrentPoint()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetCurrentPoint_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkControlPointsItem_GetNumberOfPoints_10(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetNumberOfPoints_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkControlPointsItem_GetStrokeMode_11(HandleRef pThis);

		public virtual bool GetStrokeMode()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetStrokeMode_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkControlPointsItem_GetSwitchPointsMode_12(HandleRef pThis);

		public virtual bool GetSwitchPointsMode()
		{
			return vtkControlPointsItem.vtkControlPointsItem_GetSwitchPointsMode_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkControlPointsItem_GetUserBounds_13(HandleRef pThis);

		public virtual double[] GetUserBounds()
		{
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_GetUserBounds_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_GetUserBounds_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetUserBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetUserBounds_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_GetUserBounds_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetUserBounds(IntPtr _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_GetUserBounds_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkControlPointsItem_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkControlPointsItem.vtkControlPointsItem_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkControlPointsItem_IsOverPoint_17(HandleRef pThis, IntPtr pos, long pointId);

		public bool IsOverPoint(IntPtr pos, long pointId)
		{
			return vtkControlPointsItem.vtkControlPointsItem_IsOverPoint_17(base.GetCppThis(), pos, pointId) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkControlPointsItem_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkControlPointsItem.vtkControlPointsItem_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkControlPointsItem_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkControlPointsItem NewInstance()
		{
			vtkControlPointsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkControlPointsItem_Paint_20(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkControlPointsItem.vtkControlPointsItem_Paint_20(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkControlPointsItem_RemovePoint_21(HandleRef pThis, IntPtr pos);

		public virtual long RemovePoint(IntPtr pos)
		{
			return vtkControlPointsItem.vtkControlPointsItem_RemovePoint_21(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_ResetBounds_22(HandleRef pThis);

		public void ResetBounds()
		{
			vtkControlPointsItem.vtkControlPointsItem_ResetBounds_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkControlPointsItem_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkControlPointsItem SafeDownCast(vtkObjectBase o)
		{
			vtkControlPointsItem vtkControlPointsItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkControlPointsItem.vtkControlPointsItem_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkControlPointsItem = (vtkControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkControlPointsItem.Register(null);
				}
			}
			return vtkControlPointsItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SelectAllPoints_24(HandleRef pThis);

		public void SelectAllPoints()
		{
			vtkControlPointsItem.vtkControlPointsItem_SelectAllPoints_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SelectPoint_25(HandleRef pThis, long pointId);

		public void SelectPoint(long pointId)
		{
			vtkControlPointsItem.vtkControlPointsItem_SelectPoint_25(base.GetCppThis(), pointId);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SelectPoint_26(HandleRef pThis, IntPtr currentPoint);

		public void SelectPoint(IntPtr currentPoint)
		{
			vtkControlPointsItem.vtkControlPointsItem_SelectPoint_26(base.GetCppThis(), currentPoint);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SetControlPoint_27(HandleRef pThis, long index, IntPtr point);

		public virtual void SetControlPoint(long index, IntPtr point)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetControlPoint_27(base.GetCppThis(), index, point);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SetCurrentPoint_28(HandleRef pThis, long index);

		public void SetCurrentPoint(long index)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetCurrentPoint_28(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SetSwitchPointsMode_29(HandleRef pThis, byte _arg);

		public virtual void SetSwitchPointsMode(bool _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetSwitchPointsMode_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SetUserBounds_30(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetUserBounds(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetUserBounds_30(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_SetUserBounds_31(HandleRef pThis, IntPtr _arg);

		public virtual void SetUserBounds(IntPtr _arg)
		{
			vtkControlPointsItem.vtkControlPointsItem_SetUserBounds_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_ToggleSelectPoint_32(HandleRef pThis, long pointId);

		public void ToggleSelectPoint(long pointId)
		{
			vtkControlPointsItem.vtkControlPointsItem_ToggleSelectPoint_32(base.GetCppThis(), pointId);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkControlPointsItem_ToggleSelectPoint_33(HandleRef pThis, IntPtr currentPoint);

		public void ToggleSelectPoint(IntPtr currentPoint)
		{
			vtkControlPointsItem.vtkControlPointsItem_ToggleSelectPoint_33(base.GetCppThis(), currentPoint);
		}
	}
}
