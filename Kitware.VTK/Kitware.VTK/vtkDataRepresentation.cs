using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataRepresentation : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkDataRepresentation()
		{
			vtkDataRepresentation.MRClassNameKey = "class vtkDataRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataRepresentation"));
		}

		public vtkDataRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataRepresentation New()
		{
			vtkDataRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataRepresentation.vtkDataRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_Annotate_01(HandleRef pThis, HandleRef view, HandleRef annotations);

		public void Annotate(vtkView view, vtkAnnotationLayers annotations)
		{
			vtkDataRepresentation.vtkDataRepresentation_Annotate_01(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_Annotate_02(HandleRef pThis, HandleRef view, HandleRef annotations, byte extend);

		public void Annotate(vtkView view, vtkAnnotationLayers annotations, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_Annotate_02(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_ApplyViewTheme_03(HandleRef pThis, HandleRef arg0);

		public virtual void ApplyViewTheme(vtkViewTheme arg0)
		{
			vtkDataRepresentation.vtkDataRepresentation_ApplyViewTheme_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_ConvertSelection_04(HandleRef pThis, HandleRef view, HandleRef selection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSelection ConvertSelection(vtkView view, vtkSelection selection)
		{
			vtkSelection vtkSelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_ConvertSelection_04(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetAnnotationLink_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetAnnotationLink_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInputConnection_06(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAlgorithmOutput GetInputConnection(int port, int index)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInputConnection_06(base.GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalAnnotationOutputPort_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalAnnotationOutputPort_08(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_09(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalAnnotationOutputPort_09(base.GetCppThis(), port, conn, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalOutputPort_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalOutputPort_11(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_12(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalOutputPort_12(base.GetCppThis(), port, conn, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalSelectionOutputPort_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_14(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort(int port)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalSelectionOutputPort_14(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_15(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort(int port, int conn)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetInternalSelectionOutputPort_15(base.GetCppThis(), port, conn, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkDataRepresentation_GetSelectable_16(HandleRef pThis);

		public virtual bool GetSelectable()
		{
			return vtkDataRepresentation.vtkDataRepresentation_GetSelectable_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetSelectionArrayName_17(HandleRef pThis);

		public virtual string GetSelectionArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDataRepresentation.vtkDataRepresentation_GetSelectionArrayName_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_GetSelectionArrayNames_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetSelectionArrayNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_GetSelectionArrayNames_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkDataRepresentation_GetSelectionType_19(HandleRef pThis);

		public virtual int GetSelectionType()
		{
			return vtkDataRepresentation.vtkDataRepresentation_GetSelectionType_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkDataRepresentation_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataRepresentation.vtkDataRepresentation_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkDataRepresentation_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataRepresentation.vtkDataRepresentation_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataRepresentation NewInstance()
		{
			vtkDataRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkDataRepresentation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkDataRepresentation vtkDataRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataRepresentation.vtkDataRepresentation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataRepresentation = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataRepresentation.Register(null);
				}
			}
			return vtkDataRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_Select_25(HandleRef pThis, HandleRef view, HandleRef selection);

		public void Select(vtkView view, vtkSelection selection)
		{
			vtkDataRepresentation.vtkDataRepresentation_Select_25(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_Select_26(HandleRef pThis, HandleRef view, HandleRef selection, byte extend);

		public void Select(vtkView view, vtkSelection selection, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_Select_26(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SelectableOff_27(HandleRef pThis);

		public virtual void SelectableOff()
		{
			vtkDataRepresentation.vtkDataRepresentation_SelectableOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SelectableOn_28(HandleRef pThis);

		public virtual void SelectableOn()
		{
			vtkDataRepresentation.vtkDataRepresentation_SelectableOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SetAnnotationLink_29(HandleRef pThis, HandleRef link);

		public void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetAnnotationLink_29(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SetSelectable_30(HandleRef pThis, byte _arg);

		public virtual void SetSelectable(bool _arg)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectable_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SetSelectionArrayName_31(HandleRef pThis, string name);

		public virtual void SetSelectionArrayName(string name)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectionArrayName_31(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SetSelectionArrayNames_32(HandleRef pThis, HandleRef names);

		public virtual void SetSelectionArrayNames(vtkStringArray names)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectionArrayNames_32(base.GetCppThis(), (names == null) ? default(HandleRef) : names.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_SetSelectionType_33(HandleRef pThis, int _arg);

		public virtual void SetSelectionType(int _arg)
		{
			vtkDataRepresentation.vtkDataRepresentation_SetSelectionType_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_UpdateAnnotations_34(HandleRef pThis, HandleRef annotations);

		public void UpdateAnnotations(vtkAnnotationLayers annotations)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateAnnotations_34(base.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_UpdateAnnotations_35(HandleRef pThis, HandleRef annotations, byte extend);

		public void UpdateAnnotations(vtkAnnotationLayers annotations, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateAnnotations_35(base.GetCppThis(), (annotations == null) ? default(HandleRef) : annotations.GetCppThis(), extend ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_UpdateSelection_36(HandleRef pThis, HandleRef selection);

		public void UpdateSelection(vtkSelection selection)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateSelection_36(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkDataRepresentation_UpdateSelection_37(HandleRef pThis, HandleRef selection, byte extend);

		public void UpdateSelection(vtkSelection selection, bool extend)
		{
			vtkDataRepresentation.vtkDataRepresentation_UpdateSelection_37(base.GetCppThis(), (selection == null) ? default(HandleRef) : selection.GetCppThis(), extend ? (byte)1 : (byte)0);
		}
	}
}
