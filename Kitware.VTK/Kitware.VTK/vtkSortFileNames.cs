using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSortFileNames : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSortFileNames";

		public new static readonly string MRClassNameKey;

		static vtkSortFileNames()
		{
			vtkSortFileNames.MRClassNameKey = "class vtkSortFileNames";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSortFileNames.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSortFileNames"));
		}

		public vtkSortFileNames(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSortFileNames_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSortFileNames New()
		{
			vtkSortFileNames result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSortFileNames() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSortFileNames.vtkSortFileNames_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSortFileNames_GetFileNames_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_GetFileNames_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_GetGrouping_02(HandleRef pThis);

		public virtual int GetGrouping()
		{
			return vtkSortFileNames.vtkSortFileNames_GetGrouping_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_GetIgnoreCase_03(HandleRef pThis);

		public virtual int GetIgnoreCase()
		{
			return vtkSortFileNames.vtkSortFileNames_GetIgnoreCase_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSortFileNames_GetInputFileNames_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetInputFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_GetInputFileNames_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSortFileNames_GetNthGroup_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetNthGroup(int i)
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_GetNthGroup_05(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_GetNumberOfGroups_06(HandleRef pThis);

		public virtual int GetNumberOfGroups()
		{
			return vtkSortFileNames.vtkSortFileNames_GetNumberOfGroups_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_GetNumericSort_07(HandleRef pThis);

		public virtual int GetNumericSort()
		{
			return vtkSortFileNames.vtkSortFileNames_GetNumericSort_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_GetSkipDirectories_08(HandleRef pThis);

		public virtual int GetSkipDirectories()
		{
			return vtkSortFileNames.vtkSortFileNames_GetSkipDirectories_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_GroupingOff_09(HandleRef pThis);

		public virtual void GroupingOff()
		{
			vtkSortFileNames.vtkSortFileNames_GroupingOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_GroupingOn_10(HandleRef pThis);

		public virtual void GroupingOn()
		{
			vtkSortFileNames.vtkSortFileNames_GroupingOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_IgnoreCaseOff_11(HandleRef pThis);

		public virtual void IgnoreCaseOff()
		{
			vtkSortFileNames.vtkSortFileNames_IgnoreCaseOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_IgnoreCaseOn_12(HandleRef pThis);

		public virtual void IgnoreCaseOn()
		{
			vtkSortFileNames.vtkSortFileNames_IgnoreCaseOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSortFileNames.vtkSortFileNames_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSortFileNames_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSortFileNames.vtkSortFileNames_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSortFileNames_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSortFileNames NewInstance()
		{
			vtkSortFileNames result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_NumericSortOff_17(HandleRef pThis);

		public virtual void NumericSortOff()
		{
			vtkSortFileNames.vtkSortFileNames_NumericSortOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_NumericSortOn_18(HandleRef pThis);

		public virtual void NumericSortOn()
		{
			vtkSortFileNames.vtkSortFileNames_NumericSortOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSortFileNames_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSortFileNames SafeDownCast(vtkObjectBase o)
		{
			vtkSortFileNames vtkSortFileNames = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSortFileNames.vtkSortFileNames_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSortFileNames = (vtkSortFileNames)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSortFileNames.Register(null);
				}
			}
			return vtkSortFileNames;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SetGrouping_20(HandleRef pThis, int _arg);

		public virtual void SetGrouping(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetGrouping_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SetIgnoreCase_21(HandleRef pThis, int _arg);

		public virtual void SetIgnoreCase(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetIgnoreCase_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SetInputFileNames_22(HandleRef pThis, HandleRef input);

		public void SetInputFileNames(vtkStringArray input)
		{
			vtkSortFileNames.vtkSortFileNames_SetInputFileNames_22(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SetNumericSort_23(HandleRef pThis, int _arg);

		public virtual void SetNumericSort(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetNumericSort_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SetSkipDirectories_24(HandleRef pThis, int _arg);

		public virtual void SetSkipDirectories(int _arg)
		{
			vtkSortFileNames.vtkSortFileNames_SetSkipDirectories_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SkipDirectoriesOff_25(HandleRef pThis);

		public virtual void SkipDirectoriesOff()
		{
			vtkSortFileNames.vtkSortFileNames_SkipDirectoriesOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_SkipDirectoriesOn_26(HandleRef pThis);

		public virtual void SkipDirectoriesOn()
		{
			vtkSortFileNames.vtkSortFileNames_SkipDirectoriesOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSortFileNames_Update_27(HandleRef pThis);

		public virtual void Update()
		{
			vtkSortFileNames.vtkSortFileNames_Update_27(base.GetCppThis());
		}
	}
}
