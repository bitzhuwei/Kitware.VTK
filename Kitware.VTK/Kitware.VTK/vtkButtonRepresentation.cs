using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkButtonRepresentation : vtkWidgetRepresentation
	{
		public enum _HighlightState
		{
			HighlightHovering = 1,
			HighlightNormal = 0,
			HighlightSelecting = 2
		}

		public enum _InteractionState
		{
			Inside = 1,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkButtonRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkButtonRepresentation()
		{
			vtkButtonRepresentation.MRClassNameKey = "class vtkButtonRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButtonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonRepresentation"));
		}

		public vtkButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonRepresentation_GetHighlightState_01(HandleRef pThis);

		public virtual int GetHighlightState()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetHighlightState_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonRepresentation_GetNumberOfStatesMaxValue_02(HandleRef pThis);

		public virtual int GetNumberOfStatesMaxValue()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetNumberOfStatesMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonRepresentation_GetNumberOfStatesMinValue_03(HandleRef pThis);

		public virtual int GetNumberOfStatesMinValue()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetNumberOfStatesMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonRepresentation_GetState_04(HandleRef pThis);

		public virtual int GetState()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetState_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonRepresentation_Highlight_05(HandleRef pThis, int arg0);

		public override void Highlight(int arg0)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_Highlight_05(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonRepresentation_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkButtonRepresentation_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonRepresentation_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkButtonRepresentation NewInstance()
		{
			vtkButtonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonRepresentation.vtkButtonRepresentation_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonRepresentation_NextState_09(HandleRef pThis);

		public virtual void NextState()
		{
			vtkButtonRepresentation.vtkButtonRepresentation_NextState_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonRepresentation_PreviousState_10(HandleRef pThis);

		public virtual void PreviousState()
		{
			vtkButtonRepresentation.vtkButtonRepresentation_PreviousState_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkButtonRepresentation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkButtonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkButtonRepresentation vtkButtonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkButtonRepresentation.vtkButtonRepresentation_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonRepresentation = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonRepresentation.Register(null);
				}
			}
			return vtkButtonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonRepresentation_SetNumberOfStates_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfStates(int _arg)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_SetNumberOfStates_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonRepresentation_SetState_13(HandleRef pThis, int state);

		public virtual void SetState(int state)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_SetState_13(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkButtonRepresentation_ShallowCopy_14(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_ShallowCopy_14(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
