using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSphereWidget2 : vtkAbstractWidget
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphereWidget2";

		public new static readonly string MRClassNameKey;

		static vtkSphereWidget2()
		{
			vtkSphereWidget2.MRClassNameKey = "class vtkSphereWidget2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphereWidget2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphereWidget2"));
		}

		public vtkSphereWidget2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereWidget2 New()
		{
			vtkSphereWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget2.vtkSphereWidget2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSphereWidget2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSphereWidget2.vtkSphereWidget2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_CreateDefaultRepresentation_01(HandleRef pThis);

		public override void CreateDefaultRepresentation()
		{
			vtkSphereWidget2.vtkSphereWidget2_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget2_GetScalingEnabled_02(HandleRef pThis);

		public virtual int GetScalingEnabled()
		{
			return vtkSphereWidget2.vtkSphereWidget2_GetScalingEnabled_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget2_GetTranslationEnabled_03(HandleRef pThis);

		public virtual int GetTranslationEnabled()
		{
			return vtkSphereWidget2.vtkSphereWidget2_GetTranslationEnabled_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget2_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSphereWidget2.vtkSphereWidget2_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSphereWidget2_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSphereWidget2.vtkSphereWidget2_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget2_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSphereWidget2 NewInstance()
		{
			vtkSphereWidget2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget2.vtkSphereWidget2_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSphereWidget2_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSphereWidget2 SafeDownCast(vtkObjectBase o)
		{
			vtkSphereWidget2 vtkSphereWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSphereWidget2.vtkSphereWidget2_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphereWidget = (vtkSphereWidget2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphereWidget.Register(null);
				}
			}
			return vtkSphereWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_ScalingEnabledOff_09(HandleRef pThis);

		public virtual void ScalingEnabledOff()
		{
			vtkSphereWidget2.vtkSphereWidget2_ScalingEnabledOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_ScalingEnabledOn_10(HandleRef pThis);

		public virtual void ScalingEnabledOn()
		{
			vtkSphereWidget2.vtkSphereWidget2_ScalingEnabledOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_SetRepresentation_11(HandleRef pThis, HandleRef r);

		public void SetRepresentation(vtkSphereRepresentation r)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetRepresentation_11(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_SetScalingEnabled_12(HandleRef pThis, int _arg);

		public virtual void SetScalingEnabled(int _arg)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetScalingEnabled_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_SetTranslationEnabled_13(HandleRef pThis, int _arg);

		public virtual void SetTranslationEnabled(int _arg)
		{
			vtkSphereWidget2.vtkSphereWidget2_SetTranslationEnabled_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_TranslationEnabledOff_14(HandleRef pThis);

		public virtual void TranslationEnabledOff()
		{
			vtkSphereWidget2.vtkSphereWidget2_TranslationEnabledOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSphereWidget2_TranslationEnabledOn_15(HandleRef pThis);

		public virtual void TranslationEnabledOn()
		{
			vtkSphereWidget2.vtkSphereWidget2_TranslationEnabledOn_15(base.GetCppThis());
		}
	}
}
