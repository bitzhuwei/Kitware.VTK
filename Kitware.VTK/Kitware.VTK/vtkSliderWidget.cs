using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSliderWidget : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderWidget";

		public new static readonly string MRClassNameKey;

		static vtkSliderWidget()
		{
			vtkSliderWidget.MRClassNameKey = "class vtkSliderWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderWidget"));
		}

		public vtkSliderWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliderWidget New()
		{
			vtkSliderWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSliderWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSliderWidget.vtkSliderWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkSliderWidget.vtkSliderWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_GetAnimationMode_02(HandleRef pThis);

		public virtual int GetAnimationMode()
		{
			return vtkSliderWidget.vtkSliderWidget_GetAnimationMode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_GetAnimationModeMaxValue_03(HandleRef pThis);

		public virtual int GetAnimationModeMaxValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetAnimationModeMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_GetAnimationModeMinValue_04(HandleRef pThis);

		public virtual int GetAnimationModeMinValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetAnimationModeMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_GetNumberOfAnimationSteps_05(HandleRef pThis);

		public virtual int GetNumberOfAnimationSteps()
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfAnimationSteps_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_GetNumberOfAnimationStepsMaxValue_06(HandleRef pThis);

		public virtual int GetNumberOfAnimationStepsMaxValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfAnimationStepsMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_GetNumberOfAnimationStepsMinValue_07(HandleRef pThis);

		public virtual int GetNumberOfAnimationStepsMinValue()
		{
			return vtkSliderWidget.vtkSliderWidget_GetNumberOfAnimationStepsMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderWidget_GetSliderRepresentation_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSliderRepresentation GetSliderRepresentation()
		{
			vtkSliderRepresentation vtkSliderRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_GetSliderRepresentation_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation = (vtkSliderRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation.Register(null);
				}
			}
			return vtkSliderRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSliderWidget.vtkSliderWidget_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderWidget_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSliderWidget.vtkSliderWidget_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderWidget_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSliderWidget NewInstance()
		{
			vtkSliderWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderWidget_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliderWidget SafeDownCast(vtkObjectBase o)
		{
			vtkSliderWidget vtkSliderWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderWidget.vtkSliderWidget_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderWidget = (vtkSliderWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderWidget.Register(null);
				}
			}
			return vtkSliderWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_SetAnimationMode_14(HandleRef pThis, int _arg);

		public virtual void SetAnimationMode(int _arg)
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationMode_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_SetAnimationModeToAnimate_15(HandleRef pThis);

		public void SetAnimationModeToAnimate()
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationModeToAnimate_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_SetAnimationModeToJump_16(HandleRef pThis);

		public void SetAnimationModeToJump()
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationModeToJump_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_SetAnimationModeToOff_17(HandleRef pThis);

		public void SetAnimationModeToOff()
		{
			vtkSliderWidget.vtkSliderWidget_SetAnimationModeToOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_SetNumberOfAnimationSteps_18(HandleRef pThis, int _arg);

		public virtual void SetNumberOfAnimationSteps(int _arg)
		{
			vtkSliderWidget.vtkSliderWidget_SetNumberOfAnimationSteps_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderWidget_SetRepresentation_19(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkSliderRepresentation r)
		{
			vtkSliderWidget.vtkSliderWidget_SetRepresentation_19(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}
	}
}
