using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointSetToLabelHierarchy : vtkLabelHierarchyAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointSetToLabelHierarchy";

		public new static readonly string MRClassNameKey;

		static vtkPointSetToLabelHierarchy()
		{
			vtkPointSetToLabelHierarchy.MRClassNameKey = "class vtkPointSetToLabelHierarchy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointSetToLabelHierarchy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointSetToLabelHierarchy"));
		}

		public vtkPointSetToLabelHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointSetToLabelHierarchy New()
		{
			vtkPointSetToLabelHierarchy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointSetToLabelHierarchy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetBoundedSizeArrayName_01(HandleRef pThis);

		public virtual string GetBoundedSizeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetBoundedSizeArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetIconIndexArrayName_02(HandleRef pThis);

		public virtual string GetIconIndexArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetIconIndexArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetLabelArrayName_03(HandleRef pThis);

		public virtual string GetLabelArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetLabelArrayName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPointSetToLabelHierarchy_GetMaximumDepth_04(HandleRef pThis);

		public virtual int GetMaximumDepth()
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetMaximumDepth_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetOrientationArrayName_05(HandleRef pThis);

		public virtual string GetOrientationArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetOrientationArrayName_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetPriorityArrayName_06(HandleRef pThis);

		public virtual string GetPriorityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetPriorityArrayName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetSizeArrayName_07(HandleRef pThis);

		public virtual string GetSizeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetSizeArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPointSetToLabelHierarchy_GetTargetLabelCount_08(HandleRef pThis);

		public virtual int GetTargetLabelCount()
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetTargetLabelCount_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_GetTextProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetTextProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkPointSetToLabelHierarchy_GetUseUnicodeStrings_10(HandleRef pThis);

		public virtual bool GetUseUnicodeStrings()
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_GetUseUnicodeStrings_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPointSetToLabelHierarchy_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPointSetToLabelHierarchy_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointSetToLabelHierarchy NewInstance()
		{
			vtkPointSetToLabelHierarchy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointSetToLabelHierarchy_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointSetToLabelHierarchy SafeDownCast(vtkObjectBase o)
		{
			vtkPointSetToLabelHierarchy vtkPointSetToLabelHierarchy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointSetToLabelHierarchy = (vtkPointSetToLabelHierarchy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointSetToLabelHierarchy.Register(null);
				}
			}
			return vtkPointSetToLabelHierarchy;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetBoundedSizeArrayName_16(HandleRef pThis, string name);

		public virtual void SetBoundedSizeArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetBoundedSizeArrayName_16(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetIconIndexArrayName_17(HandleRef pThis, string name);

		public virtual void SetIconIndexArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetIconIndexArrayName_17(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetLabelArrayName_18(HandleRef pThis, string name);

		public virtual void SetLabelArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetLabelArrayName_18(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetMaximumDepth_19(HandleRef pThis, int _arg);

		public virtual void SetMaximumDepth(int _arg)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetMaximumDepth_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetOrientationArrayName_20(HandleRef pThis, string name);

		public virtual void SetOrientationArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetOrientationArrayName_20(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetPriorityArrayName_21(HandleRef pThis, string name);

		public virtual void SetPriorityArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetPriorityArrayName_21(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetSizeArrayName_22(HandleRef pThis, string name);

		public virtual void SetSizeArrayName(string name)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetSizeArrayName_22(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetTargetLabelCount_23(HandleRef pThis, int _arg);

		public virtual void SetTargetLabelCount(int _arg)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetTargetLabelCount_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetTextProperty_24(HandleRef pThis, HandleRef tprop);

		public virtual void SetTextProperty(vtkTextProperty tprop)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetTextProperty_24(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_SetUseUnicodeStrings_25(HandleRef pThis, byte _arg);

		public virtual void SetUseUnicodeStrings(bool _arg)
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_SetUseUnicodeStrings_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_UseUnicodeStringsOff_26(HandleRef pThis);

		public virtual void UseUnicodeStringsOff()
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_UseUnicodeStringsOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPointSetToLabelHierarchy_UseUnicodeStringsOn_27(HandleRef pThis);

		public virtual void UseUnicodeStringsOn()
		{
			vtkPointSetToLabelHierarchy.vtkPointSetToLabelHierarchy_UseUnicodeStringsOn_27(base.GetCppThis());
		}
	}
}
