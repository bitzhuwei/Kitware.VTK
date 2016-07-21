using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAppendSelection : vtkSelectionAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendSelection";

		public new static readonly string MRClassNameKey;

		static vtkAppendSelection()
		{
			vtkAppendSelection.MRClassNameKey = "class vtkAppendSelection";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendSelection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendSelection"));
		}

		public vtkAppendSelection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendSelection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendSelection New()
		{
			vtkAppendSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAppendSelection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAppendSelection.vtkAppendSelection_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkSelection arg0)
		{
			vtkAppendSelection.vtkAppendSelection_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_AppendByUnionOff_02(HandleRef pThis);

		public virtual void AppendByUnionOff()
		{
			vtkAppendSelection.vtkAppendSelection_AppendByUnionOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_AppendByUnionOn_03(HandleRef pThis);

		public virtual void AppendByUnionOn()
		{
			vtkAppendSelection.vtkAppendSelection_AppendByUnionOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendSelection_GetAppendByUnion_04(HandleRef pThis);

		public virtual int GetAppendByUnion()
		{
			return vtkAppendSelection.vtkAppendSelection_GetAppendByUnion_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendSelection_GetInput_05(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSelection GetInput(int idx)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_GetInput_05(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendSelection_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkSelection GetInput()
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelection = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelection.Register(null);
				}
			}
			return vtkSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendSelection_GetUserManagedInputs_07(HandleRef pThis);

		public virtual int GetUserManagedInputs()
		{
			return vtkAppendSelection.vtkAppendSelection_GetUserManagedInputs_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendSelection_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAppendSelection.vtkAppendSelection_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAppendSelection_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAppendSelection.vtkAppendSelection_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendSelection_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAppendSelection NewInstance()
		{
			vtkAppendSelection result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_RemoveInput_12(HandleRef pThis, HandleRef arg0);

		public void RemoveInput(vtkSelection arg0)
		{
			vtkAppendSelection.vtkAppendSelection_RemoveInput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAppendSelection_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAppendSelection SafeDownCast(vtkObjectBase o)
		{
			vtkAppendSelection vtkAppendSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAppendSelection.vtkAppendSelection_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendSelection = (vtkAppendSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendSelection.Register(null);
				}
			}
			return vtkAppendSelection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_SetAppendByUnion_14(HandleRef pThis, int _arg);

		public virtual void SetAppendByUnion(int _arg)
		{
			vtkAppendSelection.vtkAppendSelection_SetAppendByUnion_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_SetInputByNumber_15(HandleRef pThis, int num, HandleRef input);

		public void SetInputByNumber(int num, vtkSelection input)
		{
			vtkAppendSelection.vtkAppendSelection_SetInputByNumber_15(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_SetNumberOfInputs_16(HandleRef pThis, int num);

		public void SetNumberOfInputs(int num)
		{
			vtkAppendSelection.vtkAppendSelection_SetNumberOfInputs_16(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_SetUserManagedInputs_17(HandleRef pThis, int _arg);

		public virtual void SetUserManagedInputs(int _arg)
		{
			vtkAppendSelection.vtkAppendSelection_SetUserManagedInputs_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_UserManagedInputsOff_18(HandleRef pThis);

		public virtual void UserManagedInputsOff()
		{
			vtkAppendSelection.vtkAppendSelection_UserManagedInputsOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAppendSelection_UserManagedInputsOn_19(HandleRef pThis);

		public virtual void UserManagedInputsOn()
		{
			vtkAppendSelection.vtkAppendSelection_UserManagedInputsOn_19(base.GetCppThis());
		}
	}
}
