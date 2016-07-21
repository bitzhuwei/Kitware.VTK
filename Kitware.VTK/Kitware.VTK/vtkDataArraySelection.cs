using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataArraySelection : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArraySelection";

		public new static readonly string MRClassNameKey;

		static vtkDataArraySelection()
		{
			vtkDataArraySelection.MRClassNameKey = "class vtkDataArraySelection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArraySelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArraySelection"));
		}

		public vtkDataArraySelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArraySelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataArraySelection New()
		{
			vtkDataArraySelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArraySelection.vtkDataArraySelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataArraySelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataArraySelection.vtkDataArraySelection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_AddArray_01(HandleRef pThis, string name);

		public int AddArray(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_AddArray_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_ArrayExists_02(HandleRef pThis, string name);

		public int ArrayExists(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_ArrayExists_02(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_ArrayIsEnabled_03(HandleRef pThis, string name);

		public int ArrayIsEnabled(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_ArrayIsEnabled_03(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_CopySelections_04(HandleRef pThis, HandleRef selections);

		public void CopySelections(vtkDataArraySelection selections)
		{
			vtkDataArraySelection.vtkDataArraySelection_CopySelections_04(base.GetCppThis(), (selections == null) ? default(HandleRef) : selections.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_DisableAllArrays_05(HandleRef pThis);

		public void DisableAllArrays()
		{
			vtkDataArraySelection.vtkDataArraySelection_DisableAllArrays_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_DisableArray_06(HandleRef pThis, string name);

		public void DisableArray(string name)
		{
			vtkDataArraySelection.vtkDataArraySelection_DisableArray_06(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_EnableAllArrays_07(HandleRef pThis);

		public void EnableAllArrays()
		{
			vtkDataArraySelection.vtkDataArraySelection_EnableAllArrays_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_EnableArray_08(HandleRef pThis, string name);

		public void EnableArray(string name)
		{
			vtkDataArraySelection.vtkDataArraySelection_EnableArray_08(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_GetArrayIndex_09(HandleRef pThis, string name);

		public int GetArrayIndex(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetArrayIndex_09(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArraySelection_GetArrayName_10(HandleRef pThis, int index);

		public string GetArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkDataArraySelection.vtkDataArraySelection_GetArrayName_10(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_GetArraySetting_11(HandleRef pThis, string name);

		public int GetArraySetting(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetArraySetting_11(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_GetArraySetting_12(HandleRef pThis, int index);

		public int GetArraySetting(int index)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetArraySetting_12(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_GetEnabledArrayIndex_13(HandleRef pThis, string name);

		public int GetEnabledArrayIndex(string name)
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetEnabledArrayIndex_13(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_GetNumberOfArrays_14(HandleRef pThis);

		public int GetNumberOfArrays()
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetNumberOfArrays_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_GetNumberOfArraysEnabled_15(HandleRef pThis);

		public int GetNumberOfArraysEnabled()
		{
			return vtkDataArraySelection.vtkDataArraySelection_GetNumberOfArraysEnabled_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataArraySelection.vtkDataArraySelection_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDataArraySelection_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataArraySelection.vtkDataArraySelection_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArraySelection_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataArraySelection NewInstance()
		{
			vtkDataArraySelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArraySelection.vtkDataArraySelection_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_RemoveAllArrays_20(HandleRef pThis);

		public void RemoveAllArrays()
		{
			vtkDataArraySelection.vtkDataArraySelection_RemoveAllArrays_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_RemoveArrayByIndex_21(HandleRef pThis, int index);

		public void RemoveArrayByIndex(int index)
		{
			vtkDataArraySelection.vtkDataArraySelection_RemoveArrayByIndex_21(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDataArraySelection_RemoveArrayByName_22(HandleRef pThis, string name);

		public void RemoveArrayByName(string name)
		{
			vtkDataArraySelection.vtkDataArraySelection_RemoveArrayByName_22(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDataArraySelection_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataArraySelection SafeDownCast(vtkObjectBase o)
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataArraySelection.vtkDataArraySelection_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}
	}
}
