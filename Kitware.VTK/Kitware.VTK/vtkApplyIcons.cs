using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkApplyIcons : vtkPassInputTypeAlgorithm
	{
		public enum ANNOTATION_ICON_WrapperEnum
		{
			ANNOTATION_ICON = 2,
			IGNORE_SELECTION,
			SELECTED_ICON = 0,
			SELECTED_OFFSET
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkApplyIcons";

		public new static readonly string MRClassNameKey;

		static vtkApplyIcons()
		{
			vtkApplyIcons.MRClassNameKey = "class vtkApplyIcons";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkApplyIcons.MRClassNameKey, Type.GetType("Kitware.VTK.vtkApplyIcons"));
		}

		public vtkApplyIcons(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyIcons_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkApplyIcons New()
		{
			vtkApplyIcons result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyIcons.vtkApplyIcons_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkApplyIcons() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkApplyIcons.vtkApplyIcons_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_ClearAllIconTypes_01(HandleRef pThis);

		public void ClearAllIconTypes()
		{
			vtkApplyIcons.vtkApplyIcons_ClearAllIconTypes_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyIcons_GetAttributeType_02(HandleRef pThis);

		public virtual int GetAttributeType()
		{
			return vtkApplyIcons.vtkApplyIcons_GetAttributeType_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyIcons_GetDefaultIcon_03(HandleRef pThis);

		public virtual int GetDefaultIcon()
		{
			return vtkApplyIcons.vtkApplyIcons_GetDefaultIcon_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyIcons_GetIconOutputArrayName_04(HandleRef pThis);

		public virtual string GetIconOutputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkApplyIcons.vtkApplyIcons_GetIconOutputArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyIcons_GetSelectedIcon_05(HandleRef pThis);

		public virtual int GetSelectedIcon()
		{
			return vtkApplyIcons.vtkApplyIcons_GetSelectedIcon_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyIcons_GetSelectionMode_06(HandleRef pThis);

		public virtual int GetSelectionMode()
		{
			return vtkApplyIcons.vtkApplyIcons_GetSelectionMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkApplyIcons_GetUseLookupTable_07(HandleRef pThis);

		public virtual bool GetUseLookupTable()
		{
			return vtkApplyIcons.vtkApplyIcons_GetUseLookupTable_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyIcons_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkApplyIcons.vtkApplyIcons_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkApplyIcons_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkApplyIcons.vtkApplyIcons_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyIcons_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkApplyIcons NewInstance()
		{
			vtkApplyIcons result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyIcons.vtkApplyIcons_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkApplyIcons_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkApplyIcons SafeDownCast(vtkObjectBase o)
		{
			vtkApplyIcons vtkApplyIcons = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkApplyIcons.vtkApplyIcons_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkApplyIcons = (vtkApplyIcons)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkApplyIcons.Register(null);
				}
			}
			return vtkApplyIcons;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetAttributeType_13(HandleRef pThis, int _arg);

		public virtual void SetAttributeType(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetAttributeType_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetDefaultIcon_14(HandleRef pThis, int _arg);

		public virtual void SetDefaultIcon(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetDefaultIcon_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetIconOutputArrayName_15(HandleRef pThis, string _arg);

		public virtual void SetIconOutputArrayName(string _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconOutputArrayName_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetIconType_16(HandleRef pThis, double v, int icon);

		public void SetIconType(double v, int icon)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconType_16(base.GetCppThis(), v, icon);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetIconType_17(HandleRef pThis, string v, int icon);

		public void SetIconType(string v, int icon)
		{
			vtkApplyIcons.vtkApplyIcons_SetIconType_17(base.GetCppThis(), v, icon);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetSelectedIcon_18(HandleRef pThis, int _arg);

		public virtual void SetSelectedIcon(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectedIcon_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetSelectionMode_19(HandleRef pThis, int _arg);

		public virtual void SetSelectionMode(int _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionMode_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetSelectionModeToAnnotationIcon_20(HandleRef pThis);

		public virtual void SetSelectionModeToAnnotationIcon()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToAnnotationIcon_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetSelectionModeToIgnoreSelection_21(HandleRef pThis);

		public virtual void SetSelectionModeToIgnoreSelection()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToIgnoreSelection_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetSelectionModeToSelectedIcon_22(HandleRef pThis);

		public virtual void SetSelectionModeToSelectedIcon()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToSelectedIcon_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetSelectionModeToSelectedOffset_23(HandleRef pThis);

		public virtual void SetSelectionModeToSelectedOffset()
		{
			vtkApplyIcons.vtkApplyIcons_SetSelectionModeToSelectedOffset_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_SetUseLookupTable_24(HandleRef pThis, byte _arg);

		public virtual void SetUseLookupTable(bool _arg)
		{
			vtkApplyIcons.vtkApplyIcons_SetUseLookupTable_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_UseLookupTableOff_25(HandleRef pThis);

		public virtual void UseLookupTableOff()
		{
			vtkApplyIcons.vtkApplyIcons_UseLookupTableOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkApplyIcons_UseLookupTableOn_26(HandleRef pThis);

		public virtual void UseLookupTableOn()
		{
			vtkApplyIcons.vtkApplyIcons_UseLookupTableOn_26(base.GetCppThis());
		}
	}
}
