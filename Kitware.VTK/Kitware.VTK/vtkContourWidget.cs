using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkContourWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourWidget";

		public new static readonly string MRClassNameKey;

		static vtkContourWidget()
		{
			vtkContourWidget.MRClassNameKey = "class vtkContourWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourWidget"));
		}

		public vtkContourWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourWidget New()
		{
			vtkContourWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkContourWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkContourWidget.vtkContourWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_AllowNodePickingOff_01(HandleRef pThis);

		public virtual void AllowNodePickingOff()
		{
			vtkContourWidget.vtkContourWidget_AllowNodePickingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_AllowNodePickingOn_02(HandleRef pThis);

		public virtual void AllowNodePickingOn()
		{
			vtkContourWidget.vtkContourWidget_AllowNodePickingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_CloseLoop_03(HandleRef pThis);

		public void CloseLoop()
		{
			vtkContourWidget.vtkContourWidget_CloseLoop_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_ContinuousDrawOff_04(HandleRef pThis);

		public virtual void ContinuousDrawOff()
		{
			vtkContourWidget.vtkContourWidget_ContinuousDrawOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_ContinuousDrawOn_05(HandleRef pThis);

		public virtual void ContinuousDrawOn()
		{
			vtkContourWidget.vtkContourWidget_ContinuousDrawOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_CreateDefaultRepresentation_06(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkContourWidget.vtkContourWidget_CreateDefaultRepresentation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_FollowCursorOff_07(HandleRef pThis);

		public virtual void FollowCursorOff()
		{
			vtkContourWidget.vtkContourWidget_FollowCursorOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_FollowCursorOn_08(HandleRef pThis);

		public virtual void FollowCursorOn()
		{
			vtkContourWidget.vtkContourWidget_FollowCursorOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourWidget_GetAllowNodePicking_09(HandleRef pThis);

		public virtual int GetAllowNodePicking()
		{
			return vtkContourWidget.vtkContourWidget_GetAllowNodePicking_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourWidget_GetContinuousDraw_10(HandleRef pThis);

		public virtual int GetContinuousDraw()
		{
			return vtkContourWidget.vtkContourWidget_GetContinuousDraw_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourWidget_GetContourRepresentation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkContourRepresentation GetContourRepresentation()
		{
			vtkContourRepresentation vtkContourRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_GetContourRepresentation_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkContourWidget_GetFollowCursor_12(HandleRef pThis);

		public virtual int GetFollowCursor()
		{
			return vtkContourWidget.vtkContourWidget_GetFollowCursor_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourWidget_GetWidgetState_13(HandleRef pThis);

		public virtual int GetWidgetState()
		{
			return vtkContourWidget.vtkContourWidget_GetWidgetState_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_Initialize_14(HandleRef pThis, HandleRef poly, int state);

		public virtual void Initialize(vtkPolyData poly, int state)
		{
			vtkContourWidget.vtkContourWidget_Initialize_14(base.GetCppThis(), (poly == null) ? default(HandleRef) : poly.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_Initialize_15(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkContourWidget.vtkContourWidget_Initialize_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourWidget_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContourWidget.vtkContourWidget_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourWidget_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContourWidget.vtkContourWidget_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourWidget_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContourWidget NewInstance()
		{
			vtkContourWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourWidget_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourWidget SafeDownCast(vtkObjectBase o)
		{
			vtkContourWidget vtkContourWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourWidget.vtkContourWidget_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourWidget = (vtkContourWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourWidget.Register(null);
				}
			}
			return vtkContourWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_SetAllowNodePicking_21(HandleRef pThis, int arg0);

		public void SetAllowNodePicking(int arg0)
		{
			vtkContourWidget.vtkContourWidget_SetAllowNodePicking_21(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_SetContinuousDraw_22(HandleRef pThis, int _arg);

		public virtual void SetContinuousDraw(int _arg)
		{
			vtkContourWidget.vtkContourWidget_SetContinuousDraw_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_SetEnabled_23(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkContourWidget.vtkContourWidget_SetEnabled_23(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_SetFollowCursor_24(HandleRef pThis, int _arg);

		public virtual void SetFollowCursor(int _arg)
		{
			vtkContourWidget.vtkContourWidget_SetFollowCursor_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_SetRepresentation_25(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkContourRepresentation r)
		{
			vtkContourWidget.vtkContourWidget_SetRepresentation_25(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourWidget_SetWidgetState_26(HandleRef pThis, int _arg);

		public virtual void SetWidgetState(int _arg)
		{
			vtkContourWidget.vtkContourWidget_SetWidgetState_26(base.GetCppThis(), _arg);
		}
	}
}
