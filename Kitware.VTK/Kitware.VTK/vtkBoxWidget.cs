using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoxWidget : vtk3DWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxWidget";

		public new static readonly string MRClassNameKey;

		static vtkBoxWidget()
		{
			vtkBoxWidget.MRClassNameKey = "class vtkBoxWidget";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxWidget"));
		}

		public vtkBoxWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxWidget New()
		{
			vtkBoxWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoxWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoxWidget.vtkBoxWidget_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_GetFaceProperty_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetFaceProperty_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_GetHandleProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetHandleProperty_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_GetInsideOut_03(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkBoxWidget.vtkBoxWidget_GetInsideOut_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_GetOutlineCursorWires_04(HandleRef pThis);

		public virtual int GetOutlineCursorWires()
		{
			return vtkBoxWidget.vtkBoxWidget_GetOutlineCursorWires_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_GetOutlineFaceWires_05(HandleRef pThis);

		public virtual int GetOutlineFaceWires()
		{
			return vtkBoxWidget.vtkBoxWidget_GetOutlineFaceWires_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_GetOutlineProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetOutlineProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_GetPlanes_07(HandleRef pThis, HandleRef planes);

		public void GetPlanes(vtkPlanes planes)
		{
			vtkBoxWidget.vtkBoxWidget_GetPlanes_07(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_GetPolyData_08(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkBoxWidget.vtkBoxWidget_GetPolyData_08(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_GetRotationEnabled_09(HandleRef pThis);

		public virtual int GetRotationEnabled()
		{
			return vtkBoxWidget.vtkBoxWidget_GetRotationEnabled_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_GetScalingEnabled_10(HandleRef pThis);

		public virtual int GetScalingEnabled()
		{
			return vtkBoxWidget.vtkBoxWidget_GetScalingEnabled_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_GetSelectedFaceProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetSelectedFaceProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_GetSelectedHandleProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetSelectedHandleProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_GetSelectedOutlineProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_GetSelectedOutlineProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_GetTransform_14(HandleRef pThis, HandleRef t);

		public virtual void GetTransform(vtkTransform t)
		{
			vtkBoxWidget.vtkBoxWidget_GetTransform_14(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_GetTranslationEnabled_15(HandleRef pThis);

		public virtual int GetTranslationEnabled()
		{
			return vtkBoxWidget.vtkBoxWidget_GetTranslationEnabled_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_HandlesOff_16(HandleRef pThis);

		public void HandlesOff()
		{
			vtkBoxWidget.vtkBoxWidget_HandlesOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_HandlesOn_17(HandleRef pThis);

		public void HandlesOn()
		{
			vtkBoxWidget.vtkBoxWidget_HandlesOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_InsideOutOff_18(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkBoxWidget.vtkBoxWidget_InsideOutOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_InsideOutOn_19(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkBoxWidget.vtkBoxWidget_InsideOutOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoxWidget.vtkBoxWidget_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoxWidget.vtkBoxWidget_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoxWidget NewInstance()
		{
			vtkBoxWidget result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_OutlineCursorWiresOff_24(HandleRef pThis);

		public void OutlineCursorWiresOff()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineCursorWiresOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_OutlineCursorWiresOn_25(HandleRef pThis);

		public void OutlineCursorWiresOn()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineCursorWiresOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_OutlineFaceWiresOff_26(HandleRef pThis);

		public void OutlineFaceWiresOff()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineFaceWiresOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_OutlineFaceWiresOn_27(HandleRef pThis);

		public void OutlineFaceWiresOn()
		{
			vtkBoxWidget.vtkBoxWidget_OutlineFaceWiresOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_PlaceWidget_28(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkBoxWidget.vtkBoxWidget_PlaceWidget_28(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_PlaceWidget_29(HandleRef pThis);

		public override void PlaceWidget()
		{
			vtkBoxWidget.vtkBoxWidget_PlaceWidget_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_PlaceWidget_30(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkBoxWidget.vtkBoxWidget_PlaceWidget_30(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_RotationEnabledOff_31(HandleRef pThis);

		public virtual void RotationEnabledOff()
		{
			vtkBoxWidget.vtkBoxWidget_RotationEnabledOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_RotationEnabledOn_32(HandleRef pThis);

		public virtual void RotationEnabledOn()
		{
			vtkBoxWidget.vtkBoxWidget_RotationEnabledOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxWidget SafeDownCast(vtkObjectBase o)
		{
			vtkBoxWidget vtkBoxWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget.vtkBoxWidget_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxWidget = (vtkBoxWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxWidget.Register(null);
				}
			}
			return vtkBoxWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_ScalingEnabledOff_34(HandleRef pThis);

		public virtual void ScalingEnabledOff()
		{
			vtkBoxWidget.vtkBoxWidget_ScalingEnabledOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_ScalingEnabledOn_35(HandleRef pThis);

		public virtual void ScalingEnabledOn()
		{
			vtkBoxWidget.vtkBoxWidget_ScalingEnabledOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetEnabled_36(HandleRef pThis, int arg0);

		public override void SetEnabled(int arg0)
		{
			vtkBoxWidget.vtkBoxWidget_SetEnabled_36(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetInsideOut_37(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetInsideOut_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetOutlineCursorWires_38(HandleRef pThis, int arg0);

		public void SetOutlineCursorWires(int arg0)
		{
			vtkBoxWidget.vtkBoxWidget_SetOutlineCursorWires_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetOutlineFaceWires_39(HandleRef pThis, int arg0);

		public void SetOutlineFaceWires(int arg0)
		{
			vtkBoxWidget.vtkBoxWidget_SetOutlineFaceWires_39(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetRotationEnabled_40(HandleRef pThis, int _arg);

		public virtual void SetRotationEnabled(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetRotationEnabled_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetScalingEnabled_41(HandleRef pThis, int _arg);

		public virtual void SetScalingEnabled(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetScalingEnabled_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetTransform_42(HandleRef pThis, HandleRef t);

		public virtual void SetTransform(vtkTransform t)
		{
			vtkBoxWidget.vtkBoxWidget_SetTransform_42(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_SetTranslationEnabled_43(HandleRef pThis, int _arg);

		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkBoxWidget.vtkBoxWidget_SetTranslationEnabled_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_TranslationEnabledOff_44(HandleRef pThis);

		public virtual void TranslationEnabledOff()
		{
			vtkBoxWidget.vtkBoxWidget_TranslationEnabledOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget_TranslationEnabledOn_45(HandleRef pThis);

		public virtual void TranslationEnabledOn()
		{
			vtkBoxWidget.vtkBoxWidget_TranslationEnabledOn_45(base.GetCppThis());
		}
	}
}
