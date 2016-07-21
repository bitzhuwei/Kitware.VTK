using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoxWidget2 : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxWidget2";

		public new static readonly string MRClassNameKey;

		static vtkBoxWidget2()
		{
			vtkBoxWidget2.MRClassNameKey = "class vtkBoxWidget2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxWidget2"));
		}

		public vtkBoxWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxWidget2 New()
		{
			vtkBoxWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget2.vtkBoxWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoxWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoxWidget2.vtkBoxWidget2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkBoxWidget2.vtkBoxWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget2_GetMoveFacesEnabled_02(HandleRef pThis);

		public virtual int GetMoveFacesEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetMoveFacesEnabled_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget2_GetRotationEnabled_03(HandleRef pThis);

		public virtual int GetRotationEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetRotationEnabled_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget2_GetScalingEnabled_04(HandleRef pThis);

		public virtual int GetScalingEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetScalingEnabled_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget2_GetTranslationEnabled_05(HandleRef pThis);

		public virtual int GetTranslationEnabled()
		{
			return vtkBoxWidget2.vtkBoxWidget2_GetTranslationEnabled_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget2_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoxWidget2.vtkBoxWidget2_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxWidget2_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoxWidget2.vtkBoxWidget2_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_MoveFacesEnabledOff_08(HandleRef pThis);

		public virtual void MoveFacesEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_MoveFacesEnabledOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_MoveFacesEnabledOn_09(HandleRef pThis);

		public virtual void MoveFacesEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_MoveFacesEnabledOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget2_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoxWidget2 NewInstance()
		{
			vtkBoxWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget2.vtkBoxWidget2_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_RotationEnabledOff_12(HandleRef pThis);

		public virtual void RotationEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_RotationEnabledOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_RotationEnabledOn_13(HandleRef pThis);

		public virtual void RotationEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_RotationEnabledOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxWidget2_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkBoxWidget2 vtkBoxWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxWidget2.vtkBoxWidget2_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxWidget = (vtkBoxWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxWidget.Register(null);
				}
			}
			return vtkBoxWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_ScalingEnabledOff_15(HandleRef pThis);

		public virtual void ScalingEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_ScalingEnabledOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_ScalingEnabledOn_16(HandleRef pThis);

		public virtual void ScalingEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_ScalingEnabledOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_SetMoveFacesEnabled_17(HandleRef pThis, int _arg);

		public virtual void SetMoveFacesEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetMoveFacesEnabled_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_SetRepresentation_18(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkBoxRepresentation r)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetRepresentation_18(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_SetRotationEnabled_19(HandleRef pThis, int _arg);

		public virtual void SetRotationEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetRotationEnabled_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_SetScalingEnabled_20(HandleRef pThis, int _arg);

		public virtual void SetScalingEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetScalingEnabled_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_SetTranslationEnabled_21(HandleRef pThis, int _arg);

		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkBoxWidget2.vtkBoxWidget2_SetTranslationEnabled_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_TranslationEnabledOff_22(HandleRef pThis);

		public virtual void TranslationEnabledOff()
		{
			vtkBoxWidget2.vtkBoxWidget2_TranslationEnabledOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxWidget2_TranslationEnabledOn_23(HandleRef pThis);

		public virtual void TranslationEnabledOn()
		{
			vtkBoxWidget2.vtkBoxWidget2_TranslationEnabledOn_23(base.GetCppThis());
		}
	}
}
