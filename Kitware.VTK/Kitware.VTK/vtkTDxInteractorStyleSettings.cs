using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTDxInteractorStyleSettings : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyleSettings";

		public new static readonly string MRClassNameKey;

		static vtkTDxInteractorStyleSettings()
		{
			vtkTDxInteractorStyleSettings.MRClassNameKey = "class vtkTDxInteractorStyleSettings";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyleSettings.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyleSettings"));
		}

		public vtkTDxInteractorStyleSettings(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleSettings_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyleSettings New()
		{
			vtkTDxInteractorStyleSettings result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTDxInteractorStyleSettings() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTDxInteractorStyleSettings_GetAngleSensitivity_01(HandleRef pThis);

		public virtual double GetAngleSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetAngleSensitivity_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTDxInteractorStyleSettings_GetTranslationXSensitivity_02(HandleRef pThis);

		public virtual double GetTranslationXSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetTranslationXSensitivity_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTDxInteractorStyleSettings_GetTranslationYSensitivity_03(HandleRef pThis);

		public virtual double GetTranslationYSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetTranslationYSensitivity_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTDxInteractorStyleSettings_GetTranslationZSensitivity_04(HandleRef pThis);

		public virtual double GetTranslationZSensitivity()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetTranslationZSensitivity_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationX_05(HandleRef pThis);

		public virtual bool GetUseRotationX()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetUseRotationX_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationY_06(HandleRef pThis);

		public virtual bool GetUseRotationY()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetUseRotationY_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTDxInteractorStyleSettings_GetUseRotationZ_07(HandleRef pThis);

		public virtual bool GetUseRotationZ()
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_GetUseRotationZ_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyleSettings_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTDxInteractorStyleSettings_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleSettings_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTDxInteractorStyleSettings NewInstance()
		{
			vtkTDxInteractorStyleSettings result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTDxInteractorStyleSettings_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTDxInteractorStyleSettings SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyleSettings vtkTDxInteractorStyleSettings = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleSettings = (vtkTDxInteractorStyleSettings)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleSettings.Register(null);
				}
			}
			return vtkTDxInteractorStyleSettings;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetAngleSensitivity_13(HandleRef pThis, double _arg);

		public virtual void SetAngleSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetAngleSensitivity_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetTranslationXSensitivity_14(HandleRef pThis, double _arg);

		public virtual void SetTranslationXSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetTranslationXSensitivity_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetTranslationYSensitivity_15(HandleRef pThis, double _arg);

		public virtual void SetTranslationYSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetTranslationYSensitivity_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetTranslationZSensitivity_16(HandleRef pThis, double _arg);

		public virtual void SetTranslationZSensitivity(double _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetTranslationZSensitivity_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationX_17(HandleRef pThis, byte _arg);

		public virtual void SetUseRotationX(bool _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetUseRotationX_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationY_18(HandleRef pThis, byte _arg);

		public virtual void SetUseRotationY(bool _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetUseRotationY_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTDxInteractorStyleSettings_SetUseRotationZ_19(HandleRef pThis, byte _arg);

		public virtual void SetUseRotationZ(bool _arg)
		{
			vtkTDxInteractorStyleSettings.vtkTDxInteractorStyleSettings_SetUseRotationZ_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
