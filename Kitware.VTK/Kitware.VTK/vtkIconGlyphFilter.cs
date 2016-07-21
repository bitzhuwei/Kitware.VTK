using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIconGlyphFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIconGlyphFilter";

		public new static readonly string MRClassNameKey;

		static vtkIconGlyphFilter()
		{
			vtkIconGlyphFilter.MRClassNameKey = "class vtkIconGlyphFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIconGlyphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIconGlyphFilter"));
		}

		public vtkIconGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIconGlyphFilter New()
		{
			vtkIconGlyphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIconGlyphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIconGlyphFilter.vtkIconGlyphFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_GetDisplaySize_01(HandleRef pThis);

		public virtual int[] GetDisplaySize()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetDisplaySize_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_GetDisplaySize_02(HandleRef pThis, IntPtr data);

		public virtual void GetDisplaySize(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetDisplaySize_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIconGlyphFilter_GetGravity_03(HandleRef pThis);

		public virtual int GetGravity()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetGravity_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIconGlyphFilter_GetIconScaling_04(HandleRef pThis);

		public virtual int GetIconScaling()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconScaling_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_GetIconSheetSize_05(HandleRef pThis);

		public virtual int[] GetIconSheetSize()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSheetSize_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_GetIconSheetSize_06(HandleRef pThis, IntPtr data);

		public virtual void GetIconSheetSize(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSheetSize_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_GetIconSize_07(HandleRef pThis);

		public virtual int[] GetIconSize()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_GetIconSize_08(HandleRef pThis, IntPtr data);

		public virtual void GetIconSize(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetIconSize_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_GetOffset_09(HandleRef pThis);

		public virtual int[] GetOffset()
		{
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_GetOffset_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_GetOffset_10(HandleRef pThis, IntPtr data);

		public virtual void GetOffset(IntPtr data)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_GetOffset_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkIconGlyphFilter_GetPassScalars_11(HandleRef pThis);

		public virtual bool GetPassScalars()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetPassScalars_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkIconGlyphFilter_GetUseIconSize_12(HandleRef pThis);

		public virtual bool GetUseIconSize()
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_GetUseIconSize_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIconGlyphFilter_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkIconGlyphFilter_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIconGlyphFilter.vtkIconGlyphFilter_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIconGlyphFilter NewInstance()
		{
			vtkIconGlyphFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_PassScalarsOff_17(HandleRef pThis);

		public virtual void PassScalarsOff()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_PassScalarsOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_PassScalarsOn_18(HandleRef pThis);

		public virtual void PassScalarsOn()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_PassScalarsOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkIconGlyphFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIconGlyphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkIconGlyphFilter vtkIconGlyphFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIconGlyphFilter.vtkIconGlyphFilter_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIconGlyphFilter = (vtkIconGlyphFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIconGlyphFilter.Register(null);
				}
			}
			return vtkIconGlyphFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetDisplaySize_20(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetDisplaySize(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetDisplaySize_20(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetDisplaySize_21(HandleRef pThis, IntPtr _arg);

		public void SetDisplaySize(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetDisplaySize_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravity_22(HandleRef pThis, int _arg);

		public virtual void SetGravity(int _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravity_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToBottomCenter_23(HandleRef pThis);

		public void SetGravityToBottomCenter()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToBottomCenter_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToBottomLeft_24(HandleRef pThis);

		public void SetGravityToBottomLeft()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToBottomLeft_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToBottomRight_25(HandleRef pThis);

		public void SetGravityToBottomRight()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToBottomRight_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToCenterCenter_26(HandleRef pThis);

		public void SetGravityToCenterCenter()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToCenterCenter_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToCenterLeft_27(HandleRef pThis);

		public void SetGravityToCenterLeft()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToCenterLeft_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToCenterRight_28(HandleRef pThis);

		public void SetGravityToCenterRight()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToCenterRight_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToTopCenter_29(HandleRef pThis);

		public void SetGravityToTopCenter()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToTopCenter_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToTopLeft_30(HandleRef pThis);

		public void SetGravityToTopLeft()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToTopLeft_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetGravityToTopRight_31(HandleRef pThis);

		public void SetGravityToTopRight()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetGravityToTopRight_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconScaling_32(HandleRef pThis, int _arg);

		public virtual void SetIconScaling(int _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconScaling_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconScalingToScalingArray_33(HandleRef pThis);

		public void SetIconScalingToScalingArray()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconScalingToScalingArray_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconScalingToScalingOff_34(HandleRef pThis);

		public void SetIconScalingToScalingOff()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconScalingToScalingOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconSheetSize_35(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetIconSheetSize(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSheetSize_35(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconSheetSize_36(HandleRef pThis, IntPtr _arg);

		public void SetIconSheetSize(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSheetSize_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconSize_37(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetIconSize(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSize_37(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetIconSize_38(HandleRef pThis, IntPtr _arg);

		public void SetIconSize(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetIconSize_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetOffset_39(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetOffset(int _arg1, int _arg2)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetOffset_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetOffset_40(HandleRef pThis, IntPtr _arg);

		public void SetOffset(IntPtr _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetOffset_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetPassScalars_41(HandleRef pThis, byte _arg);

		public virtual void SetPassScalars(bool _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetPassScalars_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_SetUseIconSize_42(HandleRef pThis, byte _arg);

		public virtual void SetUseIconSize(bool _arg)
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_SetUseIconSize_42(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_UseIconSizeOff_43(HandleRef pThis);

		public virtual void UseIconSizeOff()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_UseIconSizeOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkIconGlyphFilter_UseIconSizeOn_44(HandleRef pThis);

		public virtual void UseIconSizeOn()
		{
			vtkIconGlyphFilter.vtkIconGlyphFilter_UseIconSizeOn_44(base.GetCppThis());
		}
	}
}
