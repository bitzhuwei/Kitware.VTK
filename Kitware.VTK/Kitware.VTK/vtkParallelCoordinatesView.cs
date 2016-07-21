using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelCoordinatesView : vtkRenderView
	{
		public enum VTK_BRUSH_ANGLE_WrapperEnum
		{
			VTK_BRUSH_ANGLE = 1,
			VTK_BRUSH_AXISTHRESHOLD = 3,
			VTK_BRUSH_FUNCTION = 2,
			VTK_BRUSH_LASSO = 0,
			VTK_BRUSH_MODECOUNT = 4
		}

		public enum VTK_BRUSHOPERATOR_ADD_WrapperEnum
		{
			VTK_BRUSHOPERATOR_ADD,
			VTK_BRUSHOPERATOR_INTERSECT = 2,
			VTK_BRUSHOPERATOR_MODECOUNT = 4,
			VTK_BRUSHOPERATOR_REPLACE = 3,
			VTK_BRUSHOPERATOR_SUBTRACT = 1
		}

		public enum VTK_INSPECT_MANIPULATE_AXES_WrapperEnum
		{
			VTK_INSPECT_MANIPULATE_AXES,
			VTK_INSPECT_MODECOUNT = 2,
			VTK_INSPECT_SELECT_DATA = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesView";

		public new static readonly string MRClassNameKey;

		static vtkParallelCoordinatesView()
		{
			vtkParallelCoordinatesView.MRClassNameKey = "class vtkParallelCoordinatesView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesView"));
		}

		public vtkParallelCoordinatesView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesView New()
		{
			vtkParallelCoordinatesView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesView.vtkParallelCoordinatesView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelCoordinatesView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelCoordinatesView.vtkParallelCoordinatesView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_ApplyViewTheme_01(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_ApplyViewTheme_01(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_GetBrushMode_02(HandleRef pThis);

		public virtual int GetBrushMode()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetBrushMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_GetBrushOperator_03(HandleRef pThis);

		public virtual int GetBrushOperator()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetBrushOperator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_GetCurrentBrushClass_04(HandleRef pThis);

		public virtual int GetCurrentBrushClass()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetCurrentBrushClass_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_GetInspectMode_05(HandleRef pThis);

		public virtual int GetInspectMode()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetInspectMode_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_GetMaximumNumberOfBrushPoints_06(HandleRef pThis);

		public virtual int GetMaximumNumberOfBrushPoints()
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_GetMaximumNumberOfBrushPoints_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesView_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesView.vtkParallelCoordinatesView_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesView_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelCoordinatesView NewInstance()
		{
			vtkParallelCoordinatesView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesView.vtkParallelCoordinatesView_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesView_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesView SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesView vtkParallelCoordinatesView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesView.vtkParallelCoordinatesView_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesView = (vtkParallelCoordinatesView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesView.Register(null);
				}
			}
			return vtkParallelCoordinatesView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushMode_12(HandleRef pThis, int arg0);

		public void SetBrushMode(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushMode_12(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToAngle_13(HandleRef pThis);

		public void SetBrushModeToAngle()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToAngle_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToAxisThreshold_14(HandleRef pThis);

		public void SetBrushModeToAxisThreshold()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToAxisThreshold_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToFunction_15(HandleRef pThis);

		public void SetBrushModeToFunction()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToFunction_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushModeToLasso_16(HandleRef pThis);

		public void SetBrushModeToLasso()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushModeToLasso_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperator_17(HandleRef pThis, int arg0);

		public void SetBrushOperator(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperator_17(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToAdd_18(HandleRef pThis);

		public void SetBrushOperatorToAdd()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToAdd_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToIntersect_19(HandleRef pThis);

		public void SetBrushOperatorToIntersect()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToIntersect_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToReplace_20(HandleRef pThis);

		public void SetBrushOperatorToReplace()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToReplace_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetBrushOperatorToSubtract_21(HandleRef pThis);

		public void SetBrushOperatorToSubtract()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetBrushOperatorToSubtract_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetCurrentBrushClass_22(HandleRef pThis, int _arg);

		public virtual void SetCurrentBrushClass(int _arg)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetCurrentBrushClass_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetInpsectModeToSelectData_23(HandleRef pThis);

		public void SetInpsectModeToSelectData()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetInpsectModeToSelectData_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetInspectMode_24(HandleRef pThis, int arg0);

		public void SetInspectMode(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetInspectMode_24(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetInspectModeToManipulateAxes_25(HandleRef pThis);

		public void SetInspectModeToManipulateAxes()
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetInspectModeToManipulateAxes_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesView_SetMaximumNumberOfBrushPoints_26(HandleRef pThis, int arg0);

		public void SetMaximumNumberOfBrushPoints(int arg0)
		{
			vtkParallelCoordinatesView.vtkParallelCoordinatesView_SetMaximumNumberOfBrushPoints_26(base.GetCppThis(), arg0);
		}
	}
}
