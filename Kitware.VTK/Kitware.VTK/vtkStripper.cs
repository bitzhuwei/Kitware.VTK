using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStripper : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStripper";

		public new static readonly string MRClassNameKey;

		static vtkStripper()
		{
			vtkStripper.MRClassNameKey = "class vtkStripper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStripper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStripper"));
		}

		public vtkStripper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStripper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStripper New()
		{
			vtkStripper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStripper.vtkStripper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStripper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStripper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStripper.vtkStripper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_GetMaximumLength_01(HandleRef pThis);

		public virtual int GetMaximumLength()
		{
			return vtkStripper.vtkStripper_GetMaximumLength_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_GetMaximumLengthMaxValue_02(HandleRef pThis);

		public virtual int GetMaximumLengthMaxValue()
		{
			return vtkStripper.vtkStripper_GetMaximumLengthMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_GetMaximumLengthMinValue_03(HandleRef pThis);

		public virtual int GetMaximumLengthMinValue()
		{
			return vtkStripper.vtkStripper_GetMaximumLengthMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_GetPassCellDataAsFieldData_04(HandleRef pThis);

		public virtual int GetPassCellDataAsFieldData()
		{
			return vtkStripper.vtkStripper_GetPassCellDataAsFieldData_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_GetPassThroughCellIds_05(HandleRef pThis);

		public virtual int GetPassThroughCellIds()
		{
			return vtkStripper.vtkStripper_GetPassThroughCellIds_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_GetPassThroughPointIds_06(HandleRef pThis);

		public virtual int GetPassThroughPointIds()
		{
			return vtkStripper.vtkStripper_GetPassThroughPointIds_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStripper.vtkStripper_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStripper_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStripper.vtkStripper_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStripper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStripper NewInstance()
		{
			vtkStripper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStripper.vtkStripper_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStripper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_PassCellDataAsFieldDataOff_11(HandleRef pThis);

		public virtual void PassCellDataAsFieldDataOff()
		{
			vtkStripper.vtkStripper_PassCellDataAsFieldDataOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_PassCellDataAsFieldDataOn_12(HandleRef pThis);

		public virtual void PassCellDataAsFieldDataOn()
		{
			vtkStripper.vtkStripper_PassCellDataAsFieldDataOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_PassThroughCellIdsOff_13(HandleRef pThis);

		public virtual void PassThroughCellIdsOff()
		{
			vtkStripper.vtkStripper_PassThroughCellIdsOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_PassThroughCellIdsOn_14(HandleRef pThis);

		public virtual void PassThroughCellIdsOn()
		{
			vtkStripper.vtkStripper_PassThroughCellIdsOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_PassThroughPointIdsOff_15(HandleRef pThis);

		public virtual void PassThroughPointIdsOff()
		{
			vtkStripper.vtkStripper_PassThroughPointIdsOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_PassThroughPointIdsOn_16(HandleRef pThis);

		public virtual void PassThroughPointIdsOn()
		{
			vtkStripper.vtkStripper_PassThroughPointIdsOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStripper_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStripper SafeDownCast(vtkObjectBase o)
		{
			vtkStripper vtkStripper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStripper.vtkStripper_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStripper = (vtkStripper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStripper.Register(null);
				}
			}
			return vtkStripper;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_SetMaximumLength_18(HandleRef pThis, int _arg);

		public virtual void SetMaximumLength(int _arg)
		{
			vtkStripper.vtkStripper_SetMaximumLength_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_SetPassCellDataAsFieldData_19(HandleRef pThis, int _arg);

		public virtual void SetPassCellDataAsFieldData(int _arg)
		{
			vtkStripper.vtkStripper_SetPassCellDataAsFieldData_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_SetPassThroughCellIds_20(HandleRef pThis, int _arg);

		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkStripper.vtkStripper_SetPassThroughCellIds_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStripper_SetPassThroughPointIds_21(HandleRef pThis, int _arg);

		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkStripper.vtkStripper_SetPassThroughPointIds_21(base.GetCppThis(), _arg);
		}
	}
}
